using System;
using FontAwesome.Sharp;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursuch
{
    public partial class guestsToAdd : Form
    {
        //1 - OK, 2 - Cancel + Next
        private List<Guest> guests_to_add = null;
        private int mode;
        public guestsToAdd(int mode, List<Guest> gta = null)
        {
            this.mode = mode;
            InitializeComponent();
            if (mode == CheckDialogMode.OK)
            {
                btnSave.Visible = true;
            }
            if(mode == CheckDialogMode.CancelNext)
            {
                btnBack.Visible = true;
                btnNext.Visible = true;
            }
            this.guests_to_add = mode != 0 ? Form1.guests_to_add : gta;
            render();
        }
        private void render()
        {
            List<string> ns = new List<string>();
            var reg = new Regex(@"label(Name|Patro|Fam|aaa)(\d)");
            foreach (var lab in this.Controls.OfType<Label>())
            {
                lab.Visible = false;
                var v = reg.Match(lab.Name);
                if (!v.Success)
                    continue;
                string regexresult = v.Groups[2].Value;
                int index = int.Parse(regexresult)-1;
                for (int j = 0; j < this.guests_to_add.Count(); j++)
                {
                    if (index == j)
                    {
                        lab.Visible = true;
                        if (lab.Name.Contains("Name")) lab.Text = this.guests_to_add[j].name;
                        if (lab.Name.Contains("Fam")) lab.Text = this.guests_to_add[j].surname;
                        if (lab.Name.Contains("Patro")) lab.Text = this.guests_to_add[j].patronymic;

                        if (!ns.Contains(regexresult))
                            ns.Add(regexresult);

                        break;
                    }
                }
            }
            if (mode == CheckDialogMode.OK)
            {
                foreach (var btn in this.Controls.OfType<IconButton>())
                {
                    if (btn.Name.Contains("Del"))
                    {
                        btn.Visible = false;
                        foreach (string v in ns)
                        {
                            if (btn.Name.Contains(v))
                                btn.Visible = true;
                        }
                    }
                }
            }
        }

        private void AnyBtnDel_Click(object sender, EventArgs e)
        {
            var _ = (FontAwesome.Sharp.IconButton)sender;
            //name = btnDel1
            int btnNum = int.Parse(_.Name.Substring(6));
            this.guests_to_add.Remove(this.guests_to_add[btnNum - 1]);
            if(this.guests_to_add.Count() > 0)
                render();
            else
            {
                DialogResult result = MessageBox.Show("Вы удалили из списка последнего жильца.\nСохранить изменения и закрыть окно редактирования?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Form1.guests_to_add = this.guests_to_add;
                    this.Close();
                }
                else
                    render();
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form1.guests_to_add = this.guests_to_add;
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var db = new dbprovider();
            var room_id = db.SqlExec($"SELECT uid FROM rooms WHERE room_number = {guests_to_add[0].roomN}")[0][0];
            for(int i =0; i < guests_to_add.Count(); i++)
                db.SqlExec($"INSERT INTO guests(name, surname, patronymic, used_room_id, date_of_arrival, date_of_leaving) VALUES('{guests_to_add[i].name}', '{guests_to_add[i].surname}', '{guests_to_add[i].patronymic}', {room_id}, GETDATE(), GETDATE())");
           
            var res = MessageBox.Show("Заддные успешно занесены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
                this.Close();
        }
    }
}
