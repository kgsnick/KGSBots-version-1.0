namespace kgs_bots
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textOut = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTBConsole = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gamenotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.engine = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkDB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maxtreesize = new System.Windows.Forms.ComboBox();
            this.threads = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.periods = new System.Windows.Forms.NumericUpDown();
            this.rules = new System.Windows.Forms.ComboBox();
            this.byuomytime = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boardsize = new System.Windows.Forms.ComboBox();
            this.maintime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.psw = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.greenPic = new System.Windows.Forms.PictureBox();
            this.redPic = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.closeChBox = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byuomytime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPic)).BeginInit();
            this.SuspendLayout();
            // 
            // textOut
            // 
            this.textOut.BackColor = System.Drawing.Color.White;
            this.textOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textOut, "textOut");
            this.textOut.ForeColor = System.Drawing.Color.Lime;
            this.textOut.Name = "textOut";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.richTBConsole);
            this.panel2.Name = "panel2";
            // 
            // richTBConsole
            // 
            this.richTBConsole.BackColor = System.Drawing.Color.Black;
            this.richTBConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTBConsole, "richTBConsole");
            this.richTBConsole.ForeColor = System.Drawing.Color.Lime;
            this.richTBConsole.Name = "richTBConsole";
            this.richTBConsole.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.startBTN);
            this.panel1.Name = "panel1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.CausesValidation = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.StopClick);
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(199)))));
            this.startBTN.CausesValidation = false;
            this.startBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.startBTN, "startBTN");
            this.startBTN.FlatAppearance.BorderSize = 0;
            this.startBTN.ForeColor = System.Drawing.Color.White;
            this.startBTN.Name = "startBTN";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.StartClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.engine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.threads, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.maxtreesize, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkDB, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // gamenotes
            // 
            resources.ApplyResources(this.gamenotes, "gamenotes");
            this.gamenotes.Name = "gamenotes";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label11.Name = "label11";
            // 
            // engine
            // 
            this.engine.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.engine, "engine");
            this.engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engine.FormattingEnabled = true;
            this.engine.Items.AddRange(new object[] {
            resources.GetString("engine.Items"),
            resources.GetString("engine.Items1"),
            resources.GetString("engine.Items2")});
            this.engine.Name = "engine";
            this.engine.SelectedIndexChanged += new System.EventHandler(this.EngineSelectedIndexChanged);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label12.Name = "label12";
            // 
            // checkDB
            // 
            this.checkDB.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.checkDB, "checkDB");
            this.checkDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkDB.FormattingEnabled = true;
            this.checkDB.Items.AddRange(new object[] {
            resources.GetString("checkDB.Items"),
            resources.GetString("checkDB.Items1")});
            this.checkDB.Name = "checkDB";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label13.Name = "label13";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label15.Name = "label15";
            // 
            // maxtreesize
            // 
            resources.ApplyResources(this.maxtreesize, "maxtreesize");
            this.maxtreesize.FormattingEnabled = true;
            this.maxtreesize.Items.AddRange(new object[] {
            resources.GetString("maxtreesize.Items"),
            resources.GetString("maxtreesize.Items1"),
            resources.GetString("maxtreesize.Items2"),
            resources.GetString("maxtreesize.Items3"),
            resources.GetString("maxtreesize.Items4")});
            this.maxtreesize.Name = "maxtreesize";
            // 
            // threads
            // 
            resources.ApplyResources(this.threads, "threads");
            this.threads.FormattingEnabled = true;
            this.threads.Items.AddRange(new object[] {
            resources.GetString("threads.Items"),
            resources.GetString("threads.Items1"),
            resources.GetString("threads.Items2"),
            resources.GetString("threads.Items3"),
            resources.GetString("threads.Items4"),
            resources.GetString("threads.Items5"),
            resources.GetString("threads.Items6"),
            resources.GetString("threads.Items7")});
            this.threads.Name = "threads";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label14.Name = "label14";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.gamenotes, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.periods, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.rules, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.byuomytime, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.boardsize, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.maintime, 1, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label10.Name = "label10";
            // 
            // periods
            // 
            resources.ApplyResources(this.periods, "periods");
            this.periods.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.periods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.periods.Name = "periods";
            this.periods.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // rules
            // 
            this.rules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.rules, "rules");
            this.rules.FormattingEnabled = true;
            this.rules.Items.AddRange(new object[] {
            resources.GetString("rules.Items"),
            resources.GetString("rules.Items1")});
            this.rules.Name = "rules";
            // 
            // byuomytime
            // 
            resources.ApplyResources(this.byuomytime, "byuomytime");
            this.byuomytime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.byuomytime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.byuomytime.Name = "byuomytime";
            this.byuomytime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label9.Name = "label9";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label6.Name = "label6";
            // 
            // boardsize
            // 
            this.boardsize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.boardsize, "boardsize");
            this.boardsize.FormattingEnabled = true;
            this.boardsize.Items.AddRange(new object[] {
            resources.GetString("boardsize.Items"),
            resources.GetString("boardsize.Items1"),
            resources.GetString("boardsize.Items2"),
            resources.GetString("boardsize.Items3"),
            resources.GetString("boardsize.Items4"),
            resources.GetString("boardsize.Items5"),
            resources.GetString("boardsize.Items6")});
            this.boardsize.Name = "boardsize";
            // 
            // maintime
            // 
            resources.ApplyResources(this.maintime, "maintime");
            this.maintime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.maintime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maintime.Name = "maintime";
            this.maintime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.room, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.psw, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nickname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label4.Name = "label4";
            // 
            // room
            // 
            resources.ApplyResources(this.room, "room");
            this.room.Name = "room";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label3.Name = "label3";
            // 
            // psw
            // 
            resources.ApplyResources(this.psw, "psw");
            this.psw.Name = "psw";
            // 
            // nickname
            // 
            resources.ApplyResources(this.nickname, "nickname");
            this.nickname.Name = "nickname";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.label2.Name = "label2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Name = "label16";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::kgs_bots.Properties.Resources.min;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.MinimizedApp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // greenPic
            // 
            this.greenPic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.greenPic, "greenPic");
            this.greenPic.Image = global::kgs_bots.Properties.Resources.bulb_green;
            this.greenPic.Name = "greenPic";
            this.greenPic.TabStop = false;
            // 
            // redPic
            // 
            this.redPic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.redPic, "redPic");
            this.redPic.Image = global::kgs_bots.Properties.Resources.bulb_red;
            this.redPic.Name = "redPic";
            this.redPic.TabStop = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.SettingsBtn, "SettingsBtn");
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BackgroundImage = global::kgs_bots.Properties.Resources.set;
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.CheckedChanged += new System.EventHandler(this.Settings);
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.BackgroundImage = global::kgs_bots.Properties.Resources.info;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Info);
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImage = global::kgs_bots.Properties.Resources.console;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Console);
            // 
            // closeChBox
            // 
            resources.ApplyResources(this.closeChBox, "closeChBox");
            this.closeChBox.BackgroundImage = global::kgs_bots.Properties.Resources.close;
            this.closeChBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeChBox.FlatAppearance.BorderSize = 0;
            this.closeChBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.closeChBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeChBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeChBox.Name = "closeChBox";
            this.closeChBox.UseVisualStyleBackColor = true;
            this.closeChBox.CheckedChanged += new System.EventHandler(this.CloseApp);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.ControlBox = false;
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.closeChBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenPic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.redPic);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byuomytime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boardsize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.TextBox textOut;
        public System.Windows.Forms.ComboBox rules;
        private System.Windows.Forms.ComboBox threads;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox maxtreesize;
        private System.Windows.Forms.NumericUpDown periods;
        private System.Windows.Forms.NumericUpDown byuomytime;
        private System.Windows.Forms.NumericUpDown maintime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox redPic;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox engine;
        private System.Windows.Forms.PictureBox greenPic;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox SettingsBtn;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox closeChBox;
        public System.Windows.Forms.RichTextBox richTBConsole;
        public System.Windows.Forms.ComboBox checkDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox gamenotes;
    }
}

