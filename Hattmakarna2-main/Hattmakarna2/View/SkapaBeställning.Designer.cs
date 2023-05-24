using System.Net.Http.Headers;

namespace View
{
    partial class SkapaBeställning
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
            label1 = new Label();
            cbxSpecialHatt = new CheckBox();
            cbxLagerfördHatt = new CheckBox();
            label2 = new Label();
            cbbLagerfördHatt = new ComboBox();
            label3 = new Label();
            cbbKund = new ComboBox();
            cbbSkapadAv = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            tbxBeskrivning = new TextBox();
            label15 = new Label();
            tbxAdress = new TextBox();
            btnSkapa = new Button();
            btnAvbryt = new Button();
            label16 = new Label();
            label18 = new Label();
            comboBox1 = new ComboBox();
            label19 = new Label();
            panel1 = new Panel();
            label17 = new Label();
            tbxLand = new TextBox();
            label21 = new Label();
            tbxOrt = new TextBox();
            label20 = new Label();
            pnlHattInfo = new Panel();
            lvTyg = new ListView();
            namn = new ColumnHeader();
            AntalMeter = new ColumnHeader();
            lvDekoration = new ListView();
            namnn = new ColumnHeader();
            antal = new ColumnHeader();
            label5 = new Label();
            cbbTyg = new ComboBox();
            btnDAdd = new Button();
            btnTAdd = new Button();
            label7 = new Label();
            tbxTygLängd = new TextBox();
            label8 = new Label();
            label11 = new Label();
            cbbDekoration = new ComboBox();
            label10 = new Label();
            tbxDekoration = new TextBox();
            label9 = new Label();
            label12 = new Label();
            tbxUA = new TextBox();
            label13 = new Label();
            tbxPostNummer = new TextBox();
            label14 = new Label();
            panel1.SuspendLayout();
            pnlHattInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 223);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 0;
            label1.Text = "Specialhatt";
            // 
            // cbxSpecialHatt
            // 
            cbxSpecialHatt.AutoSize = true;
            cbxSpecialHatt.Location = new Point(126, 224);
            cbxSpecialHatt.Name = "cbxSpecialHatt";
            cbxSpecialHatt.Size = new Size(18, 17);
            cbxSpecialHatt.TabIndex = 4;
            cbxSpecialHatt.UseVisualStyleBackColor = true;
            cbxSpecialHatt.CheckedChanged += cbxSpecialHatt_CheckedChanged;
            // 
            // cbxLagerfördHatt
            // 
            cbxLagerfördHatt.AutoSize = true;
            cbxLagerfördHatt.Location = new Point(126, 254);
            cbxLagerfördHatt.Name = "cbxLagerfördHatt";
            cbxLagerfördHatt.Size = new Size(18, 17);
            cbxLagerfördHatt.TabIndex = 5;
            cbxLagerfördHatt.UseVisualStyleBackColor = true;
            cbxLagerfördHatt.CheckedChanged += cbxLagerfördHatt_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 253);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 2;
            label2.Text = "Lagerförd hatt";
            // 
            // cbbLagerfördHatt
            // 
            cbbLagerfördHatt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLagerfördHatt.FormattingEnabled = true;
            cbbLagerfördHatt.Location = new Point(168, 250);
            cbbLagerfördHatt.Name = "cbbLagerfördHatt";
            cbbLagerfördHatt.Size = new Size(283, 26);
            cbbLagerfördHatt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 12);
            label3.Name = "label3";
            label3.Size = new Size(45, 18);
            label3.TabIndex = 6;
            label3.Text = "Kund:";
            // 
            // cbbKund
            // 
            cbbKund.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKund.FormattingEnabled = true;
            cbbKund.Location = new Point(124, 9);
            cbbKund.Name = "cbbKund";
            cbbKund.Size = new Size(325, 26);
            cbbKund.TabIndex = 1;
            cbbKund.SelectedIndexChanged += cbbKund_SelectedIndexChanged;
            // 
            // cbbSkapadAv
            // 
            cbbSkapadAv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSkapadAv.FormattingEnabled = true;
            cbbSkapadAv.Location = new Point(124, 156);
            cbbSkapadAv.Name = "cbbSkapadAv";
            cbbSkapadAv.Size = new Size(325, 26);
            cbbSkapadAv.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 160);
            label4.Name = "label4";
            label4.Size = new Size(79, 18);
            label4.TabIndex = 8;
            label4.Text = "Skapad av:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 338);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 13;
            label6.Text = "Beskrivning";
            // 
            // tbxBeskrivning
            // 
            tbxBeskrivning.Location = new Point(23, 359);
            tbxBeskrivning.Multiline = true;
            tbxBeskrivning.Name = "tbxBeskrivning";
            tbxBeskrivning.Size = new Size(435, 71);
            tbxBeskrivning.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 44);
            label15.Name = "label15";
            label15.Size = new Size(59, 18);
            label15.TabIndex = 30;
            label15.Text = "Adress:";
            // 
            // tbxAdress
            // 
            tbxAdress.Location = new Point(124, 41);
            tbxAdress.Name = "tbxAdress";
            tbxAdress.Size = new Size(325, 26);
            tbxAdress.TabIndex = 2;
            // 
            // btnSkapa
            // 
            btnSkapa.BackColor = Color.FromArgb(44, 44, 44);
            btnSkapa.FlatStyle = FlatStyle.Flat;
            btnSkapa.ForeColor = Color.White;
            btnSkapa.Location = new Point(392, 525);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(148, 37);
            btnSkapa.TabIndex = 15;
            btnSkapa.Text = "Skapa beställning";
            btnSkapa.UseVisualStyleBackColor = false;
            btnSkapa.Click += btnSkapa_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.BackColor = Color.White;
            btnAvbryt.FlatStyle = FlatStyle.Flat;
            btnAvbryt.ForeColor = Color.DimGray;
            btnAvbryt.Location = new Point(32, 525);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(143, 37);
            btnAvbryt.TabIndex = 16;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = false;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DarkGray;
            label16.Location = new Point(4, 181);
            label16.Name = "label16";
            label16.Size = new Size(505, 18);
            label16.TabIndex = 31;
            label16.Text = "_______________________________________________________________________";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 287);
            label18.Name = "label18";
            label18.Size = new Size(84, 18);
            label18.TabIndex = 33;
            label18.Text = "Huvudmått:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "S", "M", "L" });
            comboBox1.Location = new Point(168, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 26);
            comboBox1.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(30, 22);
            label19.Name = "label19";
            label19.Size = new Size(235, 33);
            label19.TabIndex = 37;
            label19.Text = "Skapa ny beställning";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(tbxLand);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(tbxOrt);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(pnlHattInfo);
            panel1.Controls.Add(tbxPostNummer);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbxBeskrivning);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(cbbSkapadAv);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbxSpecialHatt);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(cbxLagerfördHatt);
            panel1.Controls.Add(cbbLagerfördHatt);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbbKund);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxAdress);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(30, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 424);
            panel1.TabIndex = 39;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.DarkGray;
            label17.Location = new Point(4, 315);
            label17.Name = "label17";
            label17.Size = new Size(505, 18);
            label17.TabIndex = 45;
            label17.Text = "_______________________________________________________________________";
            // 
            // tbxLand
            // 
            tbxLand.Location = new Point(318, 124);
            tbxLand.Name = "tbxLand";
            tbxLand.Size = new Size(131, 26);
            tbxLand.TabIndex = 44;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(273, 127);
            label21.Name = "label21";
            label21.Size = new Size(48, 18);
            label21.TabIndex = 43;
            label21.Text = "Land :";
            // 
            // tbxOrt
            // 
            tbxOrt.Location = new Point(124, 124);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(139, 26);
            tbxOrt.TabIndex = 42;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(19, 127);
            label20.Name = "label20";
            label20.Size = new Size(36, 18);
            label20.TabIndex = 41;
            label20.Text = "Ort :";
            // 
            // pnlHattInfo
            // 
            pnlHattInfo.Controls.Add(lvTyg);
            pnlHattInfo.Controls.Add(lvDekoration);
            pnlHattInfo.Controls.Add(label5);
            pnlHattInfo.Controls.Add(cbbTyg);
            pnlHattInfo.Controls.Add(btnDAdd);
            pnlHattInfo.Controls.Add(btnTAdd);
            pnlHattInfo.Controls.Add(label7);
            pnlHattInfo.Controls.Add(tbxTygLängd);
            pnlHattInfo.Controls.Add(label8);
            pnlHattInfo.Controls.Add(label11);
            pnlHattInfo.Controls.Add(cbbDekoration);
            pnlHattInfo.Controls.Add(label10);
            pnlHattInfo.Controls.Add(tbxDekoration);
            pnlHattInfo.Controls.Add(label9);
            pnlHattInfo.Controls.Add(label12);
            pnlHattInfo.Controls.Add(tbxUA);
            pnlHattInfo.Controls.Add(label13);
            pnlHattInfo.Location = new Point(19, 450);
            pnlHattInfo.Name = "pnlHattInfo";
            pnlHattInfo.Size = new Size(439, 364);
            pnlHattInfo.TabIndex = 38;
            // 
            // lvTyg
            // 
            lvTyg.Columns.AddRange(new ColumnHeader[] { namn, AntalMeter });
            lvTyg.Location = new Point(4, 42);
            lvTyg.Name = "lvTyg";
            lvTyg.Size = new Size(430, 86);
            lvTyg.TabIndex = 79;
            lvTyg.UseCompatibleStateImageBehavior = false;
            lvTyg.View = System.Windows.Forms.View.Details;
            // 
            // namn
            // 
            namn.Text = "Namn";
            namn.Width = 200;
            // 
            // AntalMeter
            // 
            AntalMeter.Text = "Antal meter";
            AntalMeter.Width = 120;
            // 
            // lvDekoration
            // 
            lvDekoration.Columns.AddRange(new ColumnHeader[] { namnn, antal });
            lvDekoration.Location = new Point(3, 198);
            lvDekoration.Name = "lvDekoration";
            lvDekoration.Size = new Size(431, 86);
            lvDekoration.TabIndex = 78;
            lvDekoration.UseCompatibleStateImageBehavior = false;
            lvDekoration.View = System.Windows.Forms.View.Details;
            // 
            // namnn
            // 
            namnn.Text = "Namn";
            namnn.Width = 200;
            // 
            // antal
            // 
            antal.Text = "Antal";
            antal.Width = 120;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(32, 18);
            label5.TabIndex = 11;
            label5.Text = "Tyg:";
            // 
            // cbbTyg
            // 
            cbbTyg.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTyg.FormattingEnabled = true;
            cbbTyg.Location = new Point(90, 11);
            cbbTyg.Name = "cbbTyg";
            cbbTyg.Size = new Size(179, 26);
            cbbTyg.TabIndex = 7;
            cbbTyg.SelectedIndexChanged += cbbTyg_SelectedIndexChanged;
            // 
            // btnDAdd
            // 
            btnDAdd.BackColor = Color.FromArgb(44, 44, 44);
            btnDAdd.FlatStyle = FlatStyle.Flat;
            btnDAdd.ForeColor = Color.White;
            btnDAdd.Location = new Point(364, 162);
            btnDAdd.Name = "btnDAdd";
            btnDAdd.Size = new Size(70, 30);
            btnDAdd.TabIndex = 36;
            btnDAdd.Text = "Lägg till";
            btnDAdd.UseVisualStyleBackColor = false;
            btnDAdd.Click += btnDAdd_Click;
            // 
            // btnTAdd
            // 
            btnTAdd.BackColor = Color.FromArgb(44, 44, 44);
            btnTAdd.FlatStyle = FlatStyle.Flat;
            btnTAdd.ForeColor = Color.White;
            btnTAdd.Location = new Point(364, 6);
            btnTAdd.Name = "btnTAdd";
            btnTAdd.Size = new Size(70, 30);
            btnTAdd.TabIndex = 35;
            btnTAdd.Text = "Lägg till";
            btnTAdd.UseVisualStyleBackColor = false;
            btnTAdd.Click += btnTAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 14);
            label7.Name = "label7";
            label7.Size = new Size(16, 18);
            label7.TabIndex = 16;
            label7.Text = "x";
            // 
            // tbxTygLängd
            // 
            tbxTygLängd.Location = new Point(294, 11);
            tbxTygLängd.Name = "tbxTygLängd";
            tbxTygLängd.Size = new Size(41, 26);
            tbxTygLängd.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 14);
            label8.Name = "label8";
            label8.Size = new Size(21, 18);
            label8.TabIndex = 18;
            label8.Text = "m";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 170);
            label11.Name = "label11";
            label11.Size = new Size(84, 18);
            label11.TabIndex = 19;
            label11.Text = "Dekoration:";
            // 
            // cbbDekoration
            // 
            cbbDekoration.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDekoration.FormattingEnabled = true;
            cbbDekoration.Location = new Point(90, 167);
            cbbDekoration.Name = "cbbDekoration";
            cbbDekoration.Size = new Size(179, 26);
            cbbDekoration.TabIndex = 10;
            cbbDekoration.SelectedIndexChanged += cbbDekoration_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 170);
            label10.Name = "label10";
            label10.Size = new Size(16, 18);
            label10.TabIndex = 22;
            label10.Text = "x";
            // 
            // tbxDekoration
            // 
            tbxDekoration.Location = new Point(294, 167);
            tbxDekoration.Name = "tbxDekoration";
            tbxDekoration.Size = new Size(41, 26);
            tbxDekoration.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 170);
            label9.Name = "label9";
            label9.Size = new Size(21, 18);
            label9.TabIndex = 24;
            label9.Text = "st";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 317);
            label12.Name = "label12";
            label12.Size = new Size(151, 18);
            label12.TabIndex = 25;
            label12.Text = "Uppskattad arbetstid:";
            // 
            // tbxUA
            // 
            tbxUA.Location = new Point(150, 314);
            tbxUA.Name = "tbxUA";
            tbxUA.Size = new Size(66, 26);
            tbxUA.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(222, 317);
            label13.Name = "label13";
            label13.Size = new Size(57, 18);
            label13.TabIndex = 27;
            label13.Text = "timmar";
            // 
            // tbxPostNummer
            // 
            tbxPostNummer.Location = new Point(124, 96);
            tbxPostNummer.Name = "tbxPostNummer";
            tbxPostNummer.Size = new Size(90, 26);
            tbxPostNummer.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 76);
            label14.Name = "label14";
            label14.Size = new Size(95, 18);
            label14.TabIndex = 39;
            label14.Text = "Postnummer:";
            // 
            // SkapaBeställning
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 596);
            Controls.Add(panel1);
            Controls.Add(label19);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSkapa);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SkapaBeställning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skapa ny beställning";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHattInfo.ResumeLayout(false);
            pnlHattInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox cbxSpecialHatt;
        private CheckBox cbxLagerfördHatt;
        private Label label2;
        private ComboBox cbbLagerfördHatt;
        private Label label3;
        private ComboBox cbbKund;
        private ComboBox cbbSkapadAv;
        private Label label4;
        private Label label6;
        private TextBox tbxBeskrivning;
        private Label label15;
        private TextBox tbxAdress;
        private Button btnSkapa;
        private Button btnAvbryt;
        private Label label16;
        private Label label18;
        private ComboBox comboBox1;
        private Label label19;
        private Panel panel1;
        private Label label21;
        private TextBox tbxOrt;
        private Label label20;
        private TextBox tbxPostNummer;
        private Label label14;
        private TextBox tbxLand;
        private Label label17;
        private Panel pnlHattInfo;
        private ListView lvTyg;
        private ColumnHeader namn;
        private ColumnHeader AntalMeter;
        private ListView lvDekoration;
        private ColumnHeader namnn;
        private ColumnHeader antal;
        private Label label5;
        private ComboBox cbbTyg;
        private Button btnDAdd;
        private Button btnTAdd;
        private Label label7;
        private TextBox tbxTygLängd;
        private Label label8;
        private Label label11;
        private ComboBox cbbDekoration;
        private Label label10;
        private TextBox tbxDekoration;
        private Label label9;
        private Label label12;
        private TextBox tbxUA;
        private Label label13;
    }
}