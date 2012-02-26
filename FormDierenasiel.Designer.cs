namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// Formulier om dierenasiel te kunnen testen
    /// </summary>
    partial class FormDierenasiel
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
            this.rdBtnHond = new System.Windows.Forms.RadioButton();
            this.rdBtnKat = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbCapaciteit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvGereserveerd = new System.Windows.Forms.ListView();
            this.lvNietGereserveerd = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbChipnrVoegToe = new System.Windows.Forms.TextBox();
            this.tbGeboortejaar = new System.Windows.Forms.TextBox();
            this.tbRoepnaam = new System.Windows.Forms.TextBox();
            this.cbStatusVoegToe = new System.Windows.Forms.ComboBox();
            this.btVoegToe = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbChipnrReserveer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btWijzig = new System.Windows.Forms.Button();
            this.cbStatusReserveer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btVerwijder = new System.Windows.Forms.Button();
            this.tbChipnrVerwijder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbFoto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btSelecteerFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btToonGroteFoto = new System.Windows.Forms.Button();
            this.btAfsluiten = new System.Windows.Forms.Button();
            this.tbExtraInformatie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btKloonHuisdier = new System.Windows.Forms.Button();
            this.chChipnummer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoepnaam1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGeboortejaar1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChipnummer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoepnaam2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGeboortejaar2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBtnHond
            // 
            this.rdBtnHond.AutoSize = true;
            this.rdBtnHond.Checked = true;
            this.rdBtnHond.Location = new System.Drawing.Point(111, 26);
            this.rdBtnHond.Name = "rdBtnHond";
            this.rdBtnHond.Size = new System.Drawing.Size(57, 17);
            this.rdBtnHond.TabIndex = 0;
            this.rdBtnHond.TabStop = true;
            this.rdBtnHond.Text = "HOND";
            this.rdBtnHond.UseVisualStyleBackColor = true;
            // 
            // rdBtnKat
            // 
            this.rdBtnKat.AutoSize = true;
            this.rdBtnKat.Location = new System.Drawing.Point(111, 49);
            this.rdBtnKat.Name = "rdBtnKat";
            this.rdBtnKat.Size = new System.Drawing.Size(46, 17);
            this.rdBtnKat.TabIndex = 1;
            this.rdBtnKat.Text = "KAT";
            this.rdBtnKat.UseVisualStyleBackColor = true;
            this.rdBtnKat.CheckedChanged += new System.EventHandler(this.rdBtnKat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbCapaciteit);
            this.groupBox1.Controls.Add(this.tbNaam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 608);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dierenasiel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capaciteit:";
            // 
            // tbNaam
            // 
            this.tbNaam.BackColor = System.Drawing.SystemColors.Window;
            this.tbNaam.Location = new System.Drawing.Point(131, 24);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.ReadOnly = true;
            this.tbNaam.Size = new System.Drawing.Size(111, 20);
            this.tbNaam.TabIndex = 2;
            // 
            // tbCapaciteit
            // 
            this.tbCapaciteit.BackColor = System.Drawing.SystemColors.Window;
            this.tbCapaciteit.Location = new System.Drawing.Point(131, 55);
            this.tbCapaciteit.Name = "tbCapaciteit";
            this.tbCapaciteit.ReadOnly = true;
            this.tbCapaciteit.Size = new System.Drawing.Size(111, 20);
            this.tbCapaciteit.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btKloonHuisdier);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lvNietGereserveerd);
            this.groupBox2.Controls.Add(this.lvGereserveerd);
            this.groupBox2.Location = new System.Drawing.Point(357, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 579);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overzicht";
            // 
            // lvGereserveerd
            // 
            this.lvGereserveerd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChipnummer1,
            this.chRoepnaam1,
            this.chGeboortejaar1});
            this.lvGereserveerd.Location = new System.Drawing.Point(19, 46);
            this.lvGereserveerd.MultiSelect = false;
            this.lvGereserveerd.Name = "lvGereserveerd";
            this.lvGereserveerd.Size = new System.Drawing.Size(283, 156);
            this.lvGereserveerd.TabIndex = 0;
            this.lvGereserveerd.UseCompatibleStateImageBehavior = false;
            this.lvGereserveerd.View = System.Windows.Forms.View.Details;
            this.lvGereserveerd.SelectedIndexChanged += new System.EventHandler(this.lvGereserveerd_SelectedIndexChanged);
            // 
            // lvNietGereserveerd
            // 
            this.lvNietGereserveerd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChipnummer2,
            this.chRoepnaam2,
            this.chGeboortejaar2});
            this.lvNietGereserveerd.Location = new System.Drawing.Point(19, 242);
            this.lvNietGereserveerd.MultiSelect = false;
            this.lvNietGereserveerd.Name = "lvNietGereserveerd";
            this.lvNietGereserveerd.Size = new System.Drawing.Size(283, 156);
            this.lvNietGereserveerd.TabIndex = 1;
            this.lvNietGereserveerd.UseCompatibleStateImageBehavior = false;
            this.lvNietGereserveerd.View = System.Windows.Forms.View.Details;
            this.lvNietGereserveerd.SelectedIndexChanged += new System.EventHandler(this.lvNietGereserveerd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gereserveerd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niet gereserveerd";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbExtraInformatie);
            this.groupBox3.Controls.Add(this.btSelecteerFoto);
            this.groupBox3.Controls.Add(this.tbFoto);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btVoegToe);
            this.groupBox3.Controls.Add(this.cbStatusVoegToe);
            this.groupBox3.Controls.Add(this.tbRoepnaam);
            this.groupBox3.Controls.Add(this.tbGeboortejaar);
            this.groupBox3.Controls.Add(this.tbChipnrVoegToe);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rdBtnHond);
            this.groupBox3.Controls.Add(this.rdBtnKat);
            this.groupBox3.Location = new System.Drawing.Point(20, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toevoegen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Roepnaam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Soort:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chipnummer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Geboortejaar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gereserveerd:";
            // 
            // tbChipnrVoegToe
            // 
            this.tbChipnrVoegToe.Location = new System.Drawing.Point(111, 75);
            this.tbChipnrVoegToe.Name = "tbChipnrVoegToe";
            this.tbChipnrVoegToe.Size = new System.Drawing.Size(111, 20);
            this.tbChipnrVoegToe.TabIndex = 6;
            // 
            // tbGeboortejaar
            // 
            this.tbGeboortejaar.Location = new System.Drawing.Point(111, 101);
            this.tbGeboortejaar.Name = "tbGeboortejaar";
            this.tbGeboortejaar.Size = new System.Drawing.Size(111, 20);
            this.tbGeboortejaar.TabIndex = 7;
            // 
            // tbRoepnaam
            // 
            this.tbRoepnaam.Location = new System.Drawing.Point(111, 127);
            this.tbRoepnaam.Name = "tbRoepnaam";
            this.tbRoepnaam.Size = new System.Drawing.Size(111, 20);
            this.tbRoepnaam.TabIndex = 8;
            // 
            // cbStatusVoegToe
            // 
            this.cbStatusVoegToe.FormattingEnabled = true;
            this.cbStatusVoegToe.Location = new System.Drawing.Point(111, 180);
            this.cbStatusVoegToe.Name = "cbStatusVoegToe";
            this.cbStatusVoegToe.Size = new System.Drawing.Size(111, 21);
            this.cbStatusVoegToe.TabIndex = 9;
            // 
            // btVoegToe
            // 
            this.btVoegToe.Location = new System.Drawing.Point(242, 309);
            this.btVoegToe.Name = "btVoegToe";
            this.btVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btVoegToe.TabIndex = 10;
            this.btVoegToe.Text = "Toevoegen";
            this.btVoegToe.UseVisualStyleBackColor = true;
            this.btVoegToe.Click += new System.EventHandler(this.btVoegToe_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbStatusReserveer);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btWijzig);
            this.groupBox4.Controls.Add(this.tbChipnrReserveer);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(20, 442);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 81);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reserveer/vrijgave";
            // 
            // tbChipnrReserveer
            // 
            this.tbChipnrReserveer.Location = new System.Drawing.Point(111, 22);
            this.tbChipnrReserveer.Name = "tbChipnrReserveer";
            this.tbChipnrReserveer.Size = new System.Drawing.Size(111, 20);
            this.tbChipnrReserveer.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Chipnummer:";
            // 
            // btWijzig
            // 
            this.btWijzig.Location = new System.Drawing.Point(242, 20);
            this.btWijzig.Name = "btWijzig";
            this.btWijzig.Size = new System.Drawing.Size(75, 23);
            this.btWijzig.TabIndex = 11;
            this.btWijzig.Text = "Wijzig";
            this.btWijzig.UseVisualStyleBackColor = true;
            this.btWijzig.Click += new System.EventHandler(this.btWijzig_Click);
            // 
            // cbStatusReserveer
            // 
            this.cbStatusReserveer.FormattingEnabled = true;
            this.cbStatusReserveer.Location = new System.Drawing.Point(111, 50);
            this.cbStatusReserveer.Name = "cbStatusReserveer";
            this.cbStatusReserveer.Size = new System.Drawing.Size(111, 21);
            this.cbStatusReserveer.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Gereserveerd:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btVerwijder);
            this.groupBox5.Controls.Add(this.tbChipnrVerwijder);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(20, 540);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(331, 58);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Verwijder";
            // 
            // btVerwijder
            // 
            this.btVerwijder.Location = new System.Drawing.Point(242, 23);
            this.btVerwijder.Name = "btVerwijder";
            this.btVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btVerwijder.TabIndex = 14;
            this.btVerwijder.Text = "Verwijder";
            this.btVerwijder.UseVisualStyleBackColor = true;
            this.btVerwijder.Click += new System.EventHandler(this.btVerwijder_Click);
            // 
            // tbChipnrVerwijder
            // 
            this.tbChipnrVerwijder.Location = new System.Drawing.Point(111, 25);
            this.tbChipnrVerwijder.Name = "tbChipnrVerwijder";
            this.tbChipnrVerwijder.Size = new System.Drawing.Size(111, 20);
            this.tbChipnrVerwijder.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Chipnummer:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btToonGroteFoto);
            this.groupBox6.Controls.Add(this.pbFoto);
            this.groupBox6.Location = new System.Drawing.Point(19, 404);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(158, 165);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Foto";
            // 
            // tbFoto
            // 
            this.tbFoto.Location = new System.Drawing.Point(111, 153);
            this.tbFoto.Name = "tbFoto";
            this.tbFoto.Size = new System.Drawing.Size(111, 20);
            this.tbFoto.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Foto:";
            // 
            // btSelecteerFoto
            // 
            this.btSelecteerFoto.Location = new System.Drawing.Point(228, 151);
            this.btSelecteerFoto.Name = "btSelecteerFoto";
            this.btSelecteerFoto.Size = new System.Drawing.Size(27, 23);
            this.btSelecteerFoto.TabIndex = 13;
            this.btSelecteerFoto.Text = "...";
            this.btSelecteerFoto.UseVisualStyleBackColor = true;
            this.btSelecteerFoto.Click += new System.EventHandler(this.btSelecteerFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(6, 19);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(141, 108);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btToonGroteFoto
            // 
            this.btToonGroteFoto.Location = new System.Drawing.Point(33, 133);
            this.btToonGroteFoto.Name = "btToonGroteFoto";
            this.btToonGroteFoto.Size = new System.Drawing.Size(93, 23);
            this.btToonGroteFoto.TabIndex = 1;
            this.btToonGroteFoto.Text = "Toon grote foto";
            this.btToonGroteFoto.UseVisualStyleBackColor = true;
            this.btToonGroteFoto.Click += new System.EventHandler(this.btToonGroteFoto_Click);
            // 
            // btAfsluiten
            // 
            this.btAfsluiten.Location = new System.Drawing.Point(596, 626);
            this.btAfsluiten.Name = "btAfsluiten";
            this.btAfsluiten.Size = new System.Drawing.Size(75, 23);
            this.btAfsluiten.TabIndex = 6;
            this.btAfsluiten.Text = "Afsluiten";
            this.btAfsluiten.UseVisualStyleBackColor = true;
            this.btAfsluiten.Click += new System.EventHandler(this.btAfsluiten_Click);
            // 
            // tbExtraInformatie
            // 
            this.tbExtraInformatie.Location = new System.Drawing.Point(10, 230);
            this.tbExtraInformatie.Multiline = true;
            this.tbExtraInformatie.Name = "tbExtraInformatie";
            this.tbExtraInformatie.Size = new System.Drawing.Size(307, 73);
            this.tbExtraInformatie.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Extra informatie:";
            // 
            // btKloonHuisdier
            // 
            this.btKloonHuisdier.Location = new System.Drawing.Point(214, 423);
            this.btKloonHuisdier.Name = "btKloonHuisdier";
            this.btKloonHuisdier.Size = new System.Drawing.Size(88, 23);
            this.btKloonHuisdier.TabIndex = 9;
            this.btKloonHuisdier.Text = "Kloon huisdier";
            this.btKloonHuisdier.UseVisualStyleBackColor = true;
            this.btKloonHuisdier.Click += new System.EventHandler(this.btKloonHuisdier_Click);
            // 
            // chChipnummer1
            // 
            this.chChipnummer1.Text = "Chipnummer";
            this.chChipnummer1.Width = 100;
            // 
            // chRoepnaam1
            // 
            this.chRoepnaam1.Text = "Roepnaam";
            this.chRoepnaam1.Width = 100;
            // 
            // chGeboortejaar1
            // 
            this.chGeboortejaar1.Text = "Geboortejaar";
            this.chGeboortejaar1.Width = 80;
            // 
            // chChipnummer2
            // 
            this.chChipnummer2.Text = "Chipnummer";
            this.chChipnummer2.Width = 100;
            // 
            // chRoepnaam2
            // 
            this.chRoepnaam2.Text = "Roepnaam";
            this.chRoepnaam2.Width = 100;
            // 
            // chGeboortejaar2
            // 
            this.chGeboortejaar2.Text = "Geboortejaar";
            this.chGeboortejaar2.Width = 80;
            // 
            // FormDierenasiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 656);
            this.Controls.Add(this.btAfsluiten);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDierenasiel";
            this.Text = "Dierenasiel";
            this.Load += new System.EventHandler(this.FormDierenasiel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnHond;
        private System.Windows.Forms.RadioButton rdBtnKat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btVoegToe;
        private System.Windows.Forms.ComboBox cbStatusVoegToe;
        private System.Windows.Forms.TextBox tbRoepnaam;
        private System.Windows.Forms.TextBox tbGeboortejaar;
        private System.Windows.Forms.TextBox tbChipnrVoegToe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvNietGereserveerd;
        private System.Windows.Forms.ListView lvGereserveerd;
        private System.Windows.Forms.TextBox tbCapaciteit;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btVerwijder;
        private System.Windows.Forms.TextBox tbChipnrVerwijder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbStatusReserveer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btWijzig;
        private System.Windows.Forms.TextBox tbChipnrReserveer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSelecteerFoto;
        private System.Windows.Forms.TextBox tbFoto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btToonGroteFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btAfsluiten;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbExtraInformatie;
        private System.Windows.Forms.Button btKloonHuisdier;
        private System.Windows.Forms.ColumnHeader chChipnummer2;
        private System.Windows.Forms.ColumnHeader chRoepnaam2;
        private System.Windows.Forms.ColumnHeader chGeboortejaar2;
        private System.Windows.Forms.ColumnHeader chChipnummer1;
        private System.Windows.Forms.ColumnHeader chRoepnaam1;
        private System.Windows.Forms.ColumnHeader chGeboortejaar1;
    }
}

