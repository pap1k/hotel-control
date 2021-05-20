using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursuch
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Form activeForm = null;
        private Panel prevPanel = null;
        private Panel activePanel = null;

        public static bool isAdminFormActive = false;

        public static List<Guest> guests_to_add = new List<Guest>();
        dbprovider db = new dbprovider();
        User user;
        public Form1()
        {
            InitializeComponent();
            foreach (var pb in this.Controls.OfType<Panel>())
                pb.Visible = false;
            panelAuth.Visible = true;
        }
        #region Функции
        private void loadNewForm(Form newFrom)
        {
            activeForm = newFrom;
            newFrom.TopLevel = false;
            newFrom.FormBorderStyle = FormBorderStyle.None;
            newFrom.Dock = DockStyle.Fill;
            panelMain.Controls.Add(newFrom);
            panelMain.Tag = newFrom;
            newFrom.BringToFront();
            newFrom.Show();
        }
        private void togglePanels(Panel p1, Panel p2, bool useback = true)
        {
            if (useback)
            {
                activePanel = p2;
                prevPanel = p1;
                buttonBack.Visible = true;   
            }
            p1.Visible = false;
            p2.Visible = true;
        }
        private bool checkAddGuestForm()
        {
            bool v = true;
            if (string.IsNullOrEmpty(phtbSurname.Text)) { v = false; labelsurname.Height = 4; }
            if (string.IsNullOrEmpty(phtbName.Text)) { v = false; labelname.Height = 4; }
            if (string.IsNullOrEmpty(phtbPatro.Text)) { v = false; labelpatr.Height = 4; }
            if (comboBoxClasses.SelectedIndex == -1) { v = false; labelroomc.Height = 4; }
            if (comboBoxRooms.SelectedIndex == -1) { v = false; labelroomn.Height = 4; }
                
            return v;
        }
        private void tryAuth()
        {
            if (!string.IsNullOrEmpty(tblogin.Text))
            {
                if (!string.IsNullOrEmpty(tbpassword.Text))
                {
                    var sqlresult = db.SqlExec($"SELECT uid FROM emp_accounts WHERE username = '{tblogin.Text}'");
                    if (sqlresult.Count() == 1)
                    {
                        sqlresult = db.SqlExec($"SELECT info_id FROM emp_accounts WHERE username = '{tblogin.Text}' AND password = '{tbpassword.Text}'");
                        if (sqlresult.Count() == 1)
                        {
                            sqlresult = db.SqlExec($"SELECT i.surname, i.name, i.patronymic, r.rank_name, rank_access_level FROM emp_info i JOIN emp_accounts a ON i.uid = {sqlresult[0][0]} JOIN ranks r ON r.uid = a.rank_id");
                            labelAuthName.Text = $"{sqlresult[0][0]} {sqlresult[0][1]} {sqlresult[0][2]} [{sqlresult[0][3]}]";

                            user = new User(sqlresult[0][0], sqlresult[0][1], int.Parse(sqlresult[0][4]));

                            if (user.getLvl() == 4) btnAdmin.Visible = true;

                            togglePanels(panelAuth, panelMain, false);
                        }
                        else
                            showError("Введен неверный пароль.");
                    }
                    else
                        showError("Не найден такой пользователь.");
                }
                else
                    showError("Введите пароль");
            }
            else
                showError("Введите логин");
        }
        private void showError(string s)
        {
            MessageBox.Show(s, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void filldgv(DataGridView dgv, List<List<string>> data)
        {
            for (int i = 0; i < data.Count(); i++)
            {
                bool v = string.IsNullOrEmpty(data[i][3]);
                dgvRooms.Rows.Add(data[i][0], data[i][1], data[i][2], v ? "Свободно" : "Занято");
            }
        }
        #endregion
        #region Ивенты для работы
        private void button1_Click(object sender, EventArgs e)
        {
            tryAuth();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            togglePanels(panelMain, panelRooms);
            var res = db.SqlExec("SELECT r.floor, g.surname, r.room_number, c.class_name, g.uid FROM rooms r LEFT JOIN guests g ON g.used_room_id = r.uid JOIN classes c ON r.class_id = c.uid");
            int[] stat = { 0, 0};
            for (int i = 0; i < res.Count(); i++)
            {
                bool v = string.IsNullOrEmpty(res[i][4]);
                dgvRooms.Rows.Add(int.Parse(res[i][0]), res[i][1], int.Parse(res[i][2]), res[i][3], v ? "Свободно" : "Занято");
                dgvRooms.Rows[i].Cells[4].Style.BackColor = v ? Color.Green : Color.Red;
                if (v) stat[0]++; else stat[1]++; 
            }
            labelRoomsStat.Text = $"{stat[0]} / {stat[1]}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            togglePanels(panelMain, panelHive);
            guests_to_add = new List<Guest>();
            var res = db.SqlExec("SELECT room_number FROM rooms WHERE rooms.uid NOT IN (SELECT used_room_id FROM guests)");
            for (int i = 0; i < res.Count(); i++)
                comboBoxRooms.Items.Add(res[i][0]);

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(prevPanel != null)
            {
                togglePanels(activePanel, prevPanel, false);
                buttonBack.Visible = false;
            }
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelroomc.Height = 2;
            ActiveControl = null;
            comboBoxRooms.Items.Clear();
            comboBoxRooms.Text = "№ комнаты";
            labelFreeRooms.Text = "-";
            var res = db.SqlExec($"SELECT room_number FROM rooms WHERE rooms.uid NOT IN (SELECT used_room_id FROM guests) AND class_id = (SELECT classes.uid FROM classes WHERE classes.class_name='{comboBoxClasses.SelectedItem}')");
            for (int i = 0; i < res.Count(); i++)
                comboBoxRooms.Items.Add(res[i][0]);
        }

        private void btnAddGuestToList_Click(object sender, EventArgs e)
        {
            if (checkAddGuestForm())
            {
                if (int.Parse(labelFreeRooms.Text) >= 0)
                {
                    guests_to_add.Add(new Guest(phtbName.Text, phtbSurname.Text, phtbPatro.Text, int.Parse(comboBoxRooms.SelectedItem.ToString())));
                    comboBoxClasses.Enabled = false;
                    comboBoxRooms.Enabled = false;
                    phtbName.ClearText();
                    phtbSurname.ClearText();
                    phtbPatro.ClearText();
                    labelFreeRooms.Text = (int.Parse(labelFreeRooms.Text) - 1).ToString();
                }
                else
                    showError("Все места в номере заняты");
            }
            else
                showError("Проверьте правильнось введенных данных.");
        }
        private void btnHiveGuests_Click(object sender, EventArgs e)
        {
            checkAddGuestForm();
            if (guests_to_add.Count() > 0)
                new guestsToAdd(CheckDialogMode.CancelNext).ShowDialog();
            else
                showError("Список жильцов для заселения пуст");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (!isAdminFormActive)
            {
                //var _ = (FontAwesome.Sharp.IconButton)sender;
                //_.Enabled = false;
                new Admin();
            }
        }

        private void btnEditList_Click(object sender, EventArgs e)
        {
            if (guests_to_add.Count() > 0)
                new guestsToAdd(CheckDialogMode.OK).ShowDialog();
            else
                showError("Список жильцов для заселения пуст");
        }
        #endregion
        #region Всякое говно
        private void phtbSurname_Enter(object sender, EventArgs e)
        {
            labelsurname.Height = 2;
        }

        private void phtbName_Enter(object sender, EventArgs e)
        {
            labelname.Height = 2;
        }

        private void phtbPatro_Enter(object sender, EventArgs e)
        {
            labelpatr.Height = 2;
        }

        private void comboBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelroomn.Height = 2;
            ActiveControl = null;
            var res = db.SqlExec($"SELECT couchette FROM rooms WHERE room_number = {comboBoxRooms.SelectedItem}");
            labelFreeRooms.Text = res[0][0];
        }

        private void comboBoxClasses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tblogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryAuth();
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryAuth();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

       

        private void comboBoxRooms_MouseClick(object sender, MouseEventArgs e)
        {
            var combo = (ComboBox)sender;
            combo.DroppedDown = !combo.DroppedDown;
        }

        private void comboBoxClasses_MouseClick(object sender, MouseEventArgs e)
        {
            var combo = (ComboBox)sender;
            combo.DroppedDown = !combo.DroppedDown;
        }
        #endregion

        private void placeHolderTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            phtbSearch.BackColor = Color.White;
            bool mode = false;
            List<DataGridViewRow> save = new List<DataGridViewRow>();
            if (phtbSearch.TextLength != 0)
            {
                if(int.TryParse(phtbSearch.Text, out int _))
                {
                    mode = true;
                }
                
                for(int i =0; i < dgvRooms.Rows.Count; i++)
                {
                    if(mode && dgvRooms.Rows[i].Cells[2].Value.ToString().StartsWith(phtbSearch.Text))
                    {
                        save.Add(dgvRooms.Rows[i]);
                    }
                    if(!mode && dgvRooms.Rows[i].Cells[1].Value.ToString().ToLower().Contains(phtbSearch.Text.ToLower()))
                    {
                        save.Add(dgvRooms.Rows[i]);
                    }
                }
                if(save.Count() == 0)
                {
                    phtbSearch.BackColor = Color.Red;
                }
                else
                {
                    dgvRooms.Rows.Clear();
                    for (int j = 0; j < save.Count(); j++)
                        dgvRooms.Rows.Add(
                                save[j].Cells[0].Value,
                                save[j].Cells[1].Value,
                                save[j].Cells[2].Value,
                                save[j].Cells[3].Value,
                                save[j].Cells[4].Value
                            );
                }

            }
            else
            {
                dgvRooms.Rows.Clear();
                var res = db.SqlExec("SELECT r.floor,  g.surname, r.room_number, c.class_name, g.uid FROM rooms r LEFT JOIN guests g ON g.used_room_id = r.uid JOIN classes c ON r.class_id = c.uid");
                for (int i = 0; i < res.Count(); i++)
                {
                    bool v = string.IsNullOrEmpty(res[i][4]);
                    dgvRooms.Rows.Add(int.Parse(res[i][0]), res[i][1], int.Parse(res[i][2]), res[i][3], v ? "Свободно" : "Занято");
                    dgvRooms.Rows[i].Cells[4].Style.BackColor = v ? Color.Green : Color.Red;
                }
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int roomn = (int)dgvRooms.Rows[e.RowIndex].Cells[2].Value;
                var res = db.SqlExec($"SELECT guests.uid, name, surname, patronymic, date_of_arrival, date_of_leaving FROM guests WHERE surname = '{dgvRooms.Rows[e.RowIndex].Cells[1].Value.ToString()}' AND used_room_id = (SELECT rooms.uid FROM rooms WHERE room_number = {roomn})")[0];

                new RoomInfo(int.Parse(res[0]), new Guest(res[1], res[2], res[3], roomn), res[4], res[5]).ShowDialog();
            }
        }

        private void iconButtonReload_Click(object sender, EventArgs e)
        {
            dgvRooms.Rows.Clear();
            var res = db.SqlExec("SELECT r.floor, g.surname, r.room_number, c.class_name, g.uid FROM rooms r LEFT JOIN guests g ON g.used_room_id = r.uid JOIN classes c ON r.class_id = c.uid");
            int[] stat = { 0, 0 };
            for (int i = 0; i < res.Count(); i++)
            {
                bool v = string.IsNullOrEmpty(res[i][4]);
                dgvRooms.Rows.Add(int.Parse(res[i][0]), res[i][1], int.Parse(res[i][2]), res[i][3], v ? "Свободно" : "Занято");
                dgvRooms.Rows[i].Cells[4].Style.BackColor = v ? Color.Green : Color.Red;
                if (v) stat[0]++; else stat[1]++;
            }
            labelRoomsStat.Text = $"{stat[0]} / {stat[1]}";
        }
    }
    public static class CheckDialogMode
    {
        public const int View = 0;
        public const int OK = 1;
        public const int CancelNext = 2;
    }
}
