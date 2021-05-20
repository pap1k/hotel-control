namespace coursuch
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAuthName = new System.Windows.Forms.Label();
            this.panelAuth = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpassword = new PlaceHolderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblogin = new PlaceHolderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.iconButtonReload = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.phtbSearch = new PlaceHolderTextBox();
            this.labelRoomsStat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Жилец = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHive = new System.Windows.Forms.Panel();
            this.labelFreeRooms = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditList = new FontAwesome.Sharp.IconButton();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.labelroomn = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAddGuestToList = new FontAwesome.Sharp.IconButton();
            this.btnHiveGuests = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.phtbPatro = new PlaceHolderTextBox();
            this.phtbName = new PlaceHolderTextBox();
            this.phtbSurname = new PlaceHolderTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelpatr = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelroomc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelsurname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panelAuth.SuspendLayout();
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.panelHive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.button2);
            this.panelMain.Location = new System.Drawing.Point(12, 105);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(803, 428);
            this.panelMain.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(59, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(669, 189);
            this.button3.TabIndex = 1;
            this.button3.Text = "Заселить жильцов";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(59, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(669, 189);
            this.button2.TabIndex = 0;
            this.button2.Text = "Список номеров";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация:";
            // 
            // labelAuthName
            // 
            this.labelAuthName.AutoSize = true;
            this.labelAuthName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthName.Location = new System.Drawing.Point(132, 9);
            this.labelAuthName.Name = "labelAuthName";
            this.labelAuthName.Size = new System.Drawing.Size(16, 23);
            this.labelAuthName.TabIndex = 2;
            this.labelAuthName.Text = "-";
            this.labelAuthName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelAuth
            // 
            this.panelAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAuth.BackColor = System.Drawing.Color.White;
            this.panelAuth.Controls.Add(this.iconButton1);
            this.panelAuth.Controls.Add(this.label5);
            this.panelAuth.Controls.Add(this.label4);
            this.panelAuth.Controls.Add(this.tbpassword);
            this.panelAuth.Controls.Add(this.label3);
            this.panelAuth.Controls.Add(this.tblogin);
            this.panelAuth.Controls.Add(this.label2);
            this.panelAuth.Location = new System.Drawing.Point(278, 90);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(298, 454);
            this.panelAuth.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 342);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(292, 52);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Авторизоваться";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(3, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 2);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 2);
            this.label4.TabIndex = 8;
            // 
            // tbpassword
            // 
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic);
            this.tbpassword.ForeColor = System.Drawing.Color.Gray;
            this.tbpassword.Location = new System.Drawing.Point(3, 246);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.PlaceHolderText = "Введите пароль";
            this.tbpassword.Size = new System.Drawing.Size(292, 33);
            this.tbpassword.TabIndex = 6;
            this.tbpassword.Text = "Введите пароль";
            this.tbpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // tblogin
            // 
            this.tblogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblogin.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic);
            this.tblogin.ForeColor = System.Drawing.Color.Gray;
            this.tblogin.Location = new System.Drawing.Point(3, 86);
            this.tblogin.Name = "tblogin";
            this.tblogin.PlaceHolderText = "Введите логин";
            this.tblogin.Size = new System.Drawing.Size(292, 33);
            this.tblogin.TabIndex = 4;
            this.tblogin.Text = "Введите логин";
            this.tblogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tblogin_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // panelRooms
            // 
            this.panelRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRooms.Controls.Add(this.iconButtonReload);
            this.panelRooms.Controls.Add(this.iconPictureBox1);
            this.panelRooms.Controls.Add(this.phtbSearch);
            this.panelRooms.Controls.Add(this.labelRoomsStat);
            this.panelRooms.Controls.Add(this.label6);
            this.panelRooms.Controls.Add(this.dgvRooms);
            this.panelRooms.Location = new System.Drawing.Point(12, 71);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(803, 478);
            this.panelRooms.TabIndex = 3;
            // 
            // iconButtonReload
            // 
            this.iconButtonReload.FlatAppearance.BorderSize = 0;
            this.iconButtonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonReload.IconColor = System.Drawing.Color.Black;
            this.iconButtonReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonReload.Location = new System.Drawing.Point(734, 0);
            this.iconButtonReload.Name = "iconButtonReload";
            this.iconButtonReload.Size = new System.Drawing.Size(64, 61);
            this.iconButtonReload.TabIndex = 16;
            this.iconButtonReload.UseVisualStyleBackColor = true;
            this.iconButtonReload.Click += new System.EventHandler(this.iconButtonReload_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Turquoise;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 38);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // phtbSearch
            // 
            this.phtbSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic);
            this.phtbSearch.ForeColor = System.Drawing.Color.Gray;
            this.phtbSearch.Location = new System.Drawing.Point(46, 38);
            this.phtbSearch.Name = "phtbSearch";
            this.phtbSearch.PlaceHolderText = null;
            this.phtbSearch.Size = new System.Drawing.Size(194, 31);
            this.phtbSearch.TabIndex = 3;
            this.phtbSearch.TextChanged += new System.EventHandler(this.placeHolderTextBoxSearch_TextChanged);
            // 
            // labelRoomsStat
            // 
            this.labelRoomsStat.AutoSize = true;
            this.labelRoomsStat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoomsStat.Location = new System.Drawing.Point(742, 62);
            this.labelRoomsStat.Name = "labelRoomsStat";
            this.labelRoomsStat.Size = new System.Drawing.Size(56, 23);
            this.labelRoomsStat.TabIndex = 2;
            this.labelRoomsStat.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(528, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Всего свободно / занято:";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Floor,
            this.Жилец,
            this.RoomNumber,
            this.Class,
            this.Status});
            this.dgvRooms.Location = new System.Drawing.Point(3, 96);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.Size = new System.Drawing.Size(795, 374);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            // 
            // Floor
            // 
            this.Floor.Frozen = true;
            this.Floor.HeaderText = "Этаж";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // Жилец
            // 
            this.Жилец.Frozen = true;
            this.Жилец.HeaderText = "Жилец";
            this.Жилец.Name = "Жилец";
            this.Жилец.ReadOnly = true;
            this.Жилец.Width = 195;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Frozen = true;
            this.RoomNumber.HeaderText = "Номер комнаты";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.Width = 200;
            // 
            // Class
            // 
            this.Class.Frozen = true;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 170;
            // 
            // Status
            // 
            this.Status.Frozen = true;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // panelHive
            // 
            this.panelHive.Controls.Add(this.labelFreeRooms);
            this.panelHive.Controls.Add(this.label8);
            this.panelHive.Controls.Add(this.label7);
            this.panelHive.Controls.Add(this.btnEditList);
            this.panelHive.Controls.Add(this.comboBoxRooms);
            this.panelHive.Controls.Add(this.labelroomn);
            this.panelHive.Controls.Add(this.label22);
            this.panelHive.Controls.Add(this.label19);
            this.panelHive.Controls.Add(this.label20);
            this.panelHive.Controls.Add(this.btnAddGuestToList);
            this.panelHive.Controls.Add(this.btnHiveGuests);
            this.panelHive.Controls.Add(this.label13);
            this.panelHive.Controls.Add(this.comboBoxClasses);
            this.panelHive.Controls.Add(this.phtbPatro);
            this.panelHive.Controls.Add(this.phtbName);
            this.panelHive.Controls.Add(this.phtbSurname);
            this.panelHive.Controls.Add(this.label17);
            this.panelHive.Controls.Add(this.labelpatr);
            this.panelHive.Controls.Add(this.label16);
            this.panelHive.Controls.Add(this.labelroomc);
            this.panelHive.Controls.Add(this.label12);
            this.panelHive.Controls.Add(this.labelname);
            this.panelHive.Controls.Add(this.label10);
            this.panelHive.Controls.Add(this.labelsurname);
            this.panelHive.Controls.Add(this.label9);
            this.panelHive.Location = new System.Drawing.Point(12, 102);
            this.panelHive.Name = "panelHive";
            this.panelHive.Size = new System.Drawing.Size(803, 450);
            this.panelHive.TabIndex = 4;
            // 
            // labelFreeRooms
            // 
            this.labelFreeRooms.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.labelFreeRooms.ForeColor = System.Drawing.Color.Black;
            this.labelFreeRooms.Location = new System.Drawing.Point(635, 315);
            this.labelFreeRooms.Name = "labelFreeRooms";
            this.labelFreeRooms.Size = new System.Drawing.Size(116, 33);
            this.labelFreeRooms.TabIndex = 46;
            this.labelFreeRooms.Text = "-";
            this.labelFreeRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(570, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 33);
            this.label8.TabIndex = 45;
            this.label8.Text = "Свободно мест";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(291, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 2);
            this.label7.TabIndex = 44;
            // 
            // btnEditList
            // 
            this.btnEditList.BackColor = System.Drawing.Color.White;
            this.btnEditList.FlatAppearance.BorderSize = 0;
            this.btnEditList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditList.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditList.ForeColor = System.Drawing.Color.Thistle;
            this.btnEditList.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditList.IconColor = System.Drawing.Color.Turquoise;
            this.btnEditList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditList.Location = new System.Drawing.Point(291, 397);
            this.btnEditList.Name = "btnEditList";
            this.btnEditList.Size = new System.Drawing.Size(62, 45);
            this.btnEditList.TabIndex = 43;
            this.btnEditList.UseVisualStyleBackColor = false;
            this.btnEditList.Click += new System.EventHandler(this.btnEditList_Click);
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRooms.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(602, 184);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(150, 31);
            this.comboBoxRooms.TabIndex = 42;
            this.comboBoxRooms.Text = "  № комнаты";
            this.comboBoxRooms.SelectedIndexChanged += new System.EventHandler(this.comboBoxRooms_SelectedIndexChanged);
            this.comboBoxRooms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxRooms_MouseClick);
            // 
            // labelroomn
            // 
            this.labelroomn.BackColor = System.Drawing.Color.Red;
            this.labelroomn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelroomn.Location = new System.Drawing.Point(477, 217);
            this.labelroomn.Name = "labelroomn";
            this.labelroomn.Size = new System.Drawing.Size(275, 2);
            this.labelroomn.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(640, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 33);
            this.label22.TabIndex = 40;
            this.label22.Text = "Комната";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(367, 440);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 2);
            this.label19.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(444, 440);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 2);
            this.label20.TabIndex = 38;
            // 
            // btnAddGuestToList
            // 
            this.btnAddGuestToList.BackColor = System.Drawing.Color.White;
            this.btnAddGuestToList.FlatAppearance.BorderSize = 0;
            this.btnAddGuestToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuestToList.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddGuestToList.ForeColor = System.Drawing.Color.Thistle;
            this.btnAddGuestToList.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddGuestToList.IconColor = System.Drawing.Color.Gold;
            this.btnAddGuestToList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddGuestToList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddGuestToList.Location = new System.Drawing.Point(365, 397);
            this.btnAddGuestToList.Name = "btnAddGuestToList";
            this.btnAddGuestToList.Size = new System.Drawing.Size(62, 45);
            this.btnAddGuestToList.TabIndex = 36;
            this.btnAddGuestToList.UseVisualStyleBackColor = false;
            this.btnAddGuestToList.Click += new System.EventHandler(this.btnAddGuestToList_Click);
            // 
            // btnHiveGuests
            // 
            this.btnHiveGuests.BackColor = System.Drawing.Color.White;
            this.btnHiveGuests.FlatAppearance.BorderSize = 0;
            this.btnHiveGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiveGuests.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHiveGuests.ForeColor = System.Drawing.Color.Thistle;
            this.btnHiveGuests.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnHiveGuests.IconColor = System.Drawing.Color.SpringGreen;
            this.btnHiveGuests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHiveGuests.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHiveGuests.Location = new System.Drawing.Point(442, 397);
            this.btnHiveGuests.Name = "btnHiveGuests";
            this.btnHiveGuests.Size = new System.Drawing.Size(62, 45);
            this.btnHiveGuests.TabIndex = 12;
            this.btnHiveGuests.UseVisualStyleBackColor = false;
            this.btnHiveGuests.Click += new System.EventHandler(this.btnHiveGuests_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(477, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 2);
            this.label13.TabIndex = 32;
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClasses.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Items.AddRange(new object[] {
            "Бизнес",
            "Люкс",
            "Обычный",
            "Эконом"});
            this.comboBoxClasses.Location = new System.Drawing.Point(573, 54);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxClasses.Size = new System.Drawing.Size(179, 31);
            this.comboBoxClasses.TabIndex = 30;
            this.comboBoxClasses.Text = "Выберите класс";
            this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasses_SelectedIndexChanged);
            this.comboBoxClasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxClasses_KeyPress);
            this.comboBoxClasses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxClasses_MouseClick);
            // 
            // phtbPatro
            // 
            this.phtbPatro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phtbPatro.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic);
            this.phtbPatro.ForeColor = System.Drawing.Color.Gray;
            this.phtbPatro.Location = new System.Drawing.Point(14, 318);
            this.phtbPatro.Name = "phtbPatro";
            this.phtbPatro.PlaceHolderText = "Отчество жильца";
            this.phtbPatro.Size = new System.Drawing.Size(275, 33);
            this.phtbPatro.TabIndex = 27;
            this.phtbPatro.Text = "Отчество жильца";
            this.phtbPatro.Enter += new System.EventHandler(this.phtbPatro_Enter);
            // 
            // phtbName
            // 
            this.phtbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phtbName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic);
            this.phtbName.ForeColor = System.Drawing.Color.Gray;
            this.phtbName.Location = new System.Drawing.Point(14, 184);
            this.phtbName.Name = "phtbName";
            this.phtbName.PlaceHolderText = "Имя жильца";
            this.phtbName.Size = new System.Drawing.Size(275, 33);
            this.phtbName.TabIndex = 26;
            this.phtbName.Text = "Имя жильца";
            this.phtbName.Enter += new System.EventHandler(this.phtbName_Enter);
            // 
            // phtbSurname
            // 
            this.phtbSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phtbSurname.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic);
            this.phtbSurname.ForeColor = System.Drawing.Color.Gray;
            this.phtbSurname.Location = new System.Drawing.Point(14, 57);
            this.phtbSurname.Name = "phtbSurname";
            this.phtbSurname.PlaceHolderText = "Фамилия жильца";
            this.phtbSurname.Size = new System.Drawing.Size(275, 33);
            this.phtbSurname.TabIndex = 25;
            this.phtbSurname.Text = "Фамилия жильца";
            this.phtbSurname.Enter += new System.EventHandler(this.phtbSurname_Enter);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(396, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2, 350);
            this.label17.TabIndex = 24;
            // 
            // labelpatr
            // 
            this.labelpatr.BackColor = System.Drawing.Color.Red;
            this.labelpatr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelpatr.Location = new System.Drawing.Point(14, 354);
            this.labelpatr.Name = "labelpatr";
            this.labelpatr.Size = new System.Drawing.Size(275, 2);
            this.labelpatr.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(14, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 33);
            this.label16.TabIndex = 21;
            this.label16.Text = "Отчество";
            // 
            // labelroomc
            // 
            this.labelroomc.BackColor = System.Drawing.Color.Red;
            this.labelroomc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelroomc.Location = new System.Drawing.Point(477, 87);
            this.labelroomc.Name = "labelroomc";
            this.labelroomc.Size = new System.Drawing.Size(275, 2);
            this.labelroomc.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(567, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 33);
            this.label12.TabIndex = 15;
            this.label12.Text = "Класс комнаты";
            // 
            // labelname
            // 
            this.labelname.BackColor = System.Drawing.Color.Red;
            this.labelname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelname.Location = new System.Drawing.Point(14, 220);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(275, 2);
            this.labelname.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 33);
            this.label10.TabIndex = 12;
            this.label10.Text = "Имя";
            // 
            // labelsurname
            // 
            this.labelsurname.BackColor = System.Drawing.Color.Red;
            this.labelsurname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelsurname.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelsurname.Location = new System.Drawing.Point(14, 93);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(275, 2);
            this.labelsurname.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 33);
            this.label9.TabIndex = 9;
            this.label9.Text = "Фамилия";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Thistle;
            this.buttonBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.buttonBack.IconColor = System.Drawing.Color.Tomato;
            this.buttonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(12, 35);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 52);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(598, 9);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(168, 56);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Управление персоналом";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Tomato;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(766, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 591);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAuthName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAuth);
            this.Controls.Add(this.panelHive);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelMain.ResumeLayout(false);
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.panelHive.ResumeLayout(false);
            this.panelHive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAuthName;
        private System.Windows.Forms.Panel panelAuth;
        private PlaceHolderTextBox tbpassword;
        private System.Windows.Forms.Label label3;
        private PlaceHolderTextBox tblogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label labelRoomsStat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelHive;
        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelpatr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelroomc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private PlaceHolderTextBox phtbPatro;
        private PlaceHolderTextBox phtbName;
        private PlaceHolderTextBox phtbSurname;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconButton btnAddGuestToList;
        private FontAwesome.Sharp.IconButton btnHiveGuests;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.Label labelroomn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEditList;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label labelFreeRooms;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private PlaceHolderTextBox phtbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Жилец;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private FontAwesome.Sharp.IconButton iconButtonReload;
    }
}

