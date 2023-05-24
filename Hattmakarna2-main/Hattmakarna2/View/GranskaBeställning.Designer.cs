namespace View
{
    partial class GranskaBeställning
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
            label19 = new Label();
            cbbHuvudmmått = new ComboBox();
            label18 = new Label();
            label16 = new Label();
            btnAvbryt = new Button();
            btnSpara = new Button();
            tbxAdress = new TextBox();
            label15 = new Label();
            lblPris = new Label();
            label14 = new Label();
            label13 = new Label();
            tbxTid = new TextBox();
            label12 = new Label();
            tbxBeskrivning = new TextBox();
            label6 = new Label();
            cbbSkapadAv = new ComboBox();
            label4 = new Label();
            cbbKund = new ComboBox();
            label3 = new Label();
            btnSkapaFraktsedel = new Button();
            btnSkapaFaktura = new Button();
            label1 = new Label();
            cbbOrderStatus = new ComboBox();
            btnBeställningTabort = new Button();
            panel1 = new Panel();
            panTygDek = new Panel();
            lvTyg = new ListView();
            namn = new ColumnHeader();
            AntalMeter = new ColumnHeader();
            label5 = new Label();
            cbbTyg = new ComboBox();
            label7 = new Label();
            tbxTygLängd = new TextBox();
            label8 = new Label();
            btnTAdd = new Button();
            label11 = new Label();
            lvDekoration = new ListView();
            namnn = new ColumnHeader();
            antal = new ColumnHeader();
            cbbDekoration = new ComboBox();
            label10 = new Label();
            tbxDekoration = new TextBox();
            label9 = new Label();
            btnDAdd = new Button();
            tbxLand = new TextBox();
            label21 = new Label();
            tbxOrt = new TextBox();
            label20 = new Label();
            tbxPostNummer = new TextBox();
            label2 = new Label();
            btnSkickaEpost = new Button();
            tbxVikt = new TextBox();
            lblTotalvikt = new Label();
            cbxGåva = new CheckBox();
            lblGåva = new Label();
            label22 = new Label();
            lblNyttPris = new Label();
            panel1.SuspendLayout();
            panTygDek.SuspendLayout();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(18, 30);
            label19.Name = "label19";
            label19.Size = new Size(226, 33);
            label19.TabIndex = 74;
            label19.Text = "Granska beställning";
            // 
            // cbbHuvudmmått
            // 
            cbbHuvudmmått.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHuvudmmått.FormattingEnabled = true;
            cbbHuvudmmått.Items.AddRange(new object[] { "S", "M", "L" });
            cbbHuvudmmått.Location = new Point(140, 224);
            cbbHuvudmmått.Name = "cbbHuvudmmått";
            cbbHuvudmmått.Size = new Size(325, 26);
            cbbHuvudmmått.TabIndex = 71;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(13, 217);
            label18.Name = "label18";
            label18.Size = new Size(84, 18);
            label18.TabIndex = 70;
            label18.Text = "Huvudmått:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DarkGray;
            label16.Location = new Point(13, 181);
            label16.Name = "label16";
            label16.Size = new Size(498, 18);
            label16.TabIndex = 68;
            label16.Text = "______________________________________________________________________";
            // 
            // btnAvbryt
            // 
            btnAvbryt.BackColor = Color.Transparent;
            btnAvbryt.FlatStyle = FlatStyle.Flat;
            btnAvbryt.ForeColor = Color.DimGray;
            btnAvbryt.Location = new Point(18, 640);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(162, 39);
            btnAvbryt.TabIndex = 57;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = false;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // btnSpara
            // 
            btnSpara.BackColor = Color.FromArgb(44, 44, 44);
            btnSpara.FlatStyle = FlatStyle.Flat;
            btnSpara.ForeColor = Color.White;
            btnSpara.Location = new Point(358, 640);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(162, 40);
            btnSpara.TabIndex = 56;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = false;
            btnSpara.Click += btnSpara_Click;
            // 
            // tbxAdress
            // 
            tbxAdress.Location = new Point(140, 50);
            tbxAdress.Name = "tbxAdress";
            tbxAdress.Size = new Size(325, 26);
            tbxAdress.TabIndex = 41;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 53);
            label15.Name = "label15";
            label15.Size = new Size(120, 18);
            label15.TabIndex = 67;
            label15.Text = "Leveransadress:";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPris.Location = new Point(158, 496);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(43, 24);
            lblPris.TabIndex = 66;
            lblPris.Text = "000";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 499);
            label14.Name = "label14";
            label14.Size = new Size(38, 18);
            label14.TabIndex = 65;
            label14.Text = "Pris:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(247, 291);
            label13.Name = "label13";
            label13.Size = new Size(57, 18);
            label13.TabIndex = 64;
            label13.Text = "timmar";
            // 
            // tbxTid
            // 
            tbxTid.Location = new Point(175, 287);
            tbxTid.Name = "tbxTid";
            tbxTid.Size = new Size(66, 26);
            tbxTid.TabIndex = 54;
            tbxTid.TextChanged += PresenteraNyttPris;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 291);
            label12.Name = "label12";
            label12.Size = new Size(151, 18);
            label12.TabIndex = 63;
            label12.Text = "Uppskattad arbetstid:";
            // 
            // tbxBeskrivning
            // 
            tbxBeskrivning.Location = new Point(13, 287);
            tbxBeskrivning.Multiline = true;
            tbxBeskrivning.Name = "tbxBeskrivning";
            tbxBeskrivning.Size = new Size(449, 71);
            tbxBeskrivning.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 266);
            label6.Name = "label6";
            label6.Size = new Size(95, 18);
            label6.TabIndex = 53;
            label6.Text = "Beskrivning :";
            // 
            // cbbSkapadAv
            // 
            cbbSkapadAv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSkapadAv.FormattingEnabled = true;
            cbbSkapadAv.Location = new Point(139, 144);
            cbbSkapadAv.Name = "cbbSkapadAv";
            cbbSkapadAv.Size = new Size(325, 26);
            cbbSkapadAv.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(79, 18);
            label4.TabIndex = 49;
            label4.Text = "Skapad av:";
            // 
            // cbbKund
            // 
            cbbKund.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKund.FormattingEnabled = true;
            cbbKund.Location = new Point(140, 18);
            cbbKund.Name = "cbbKund";
            cbbKund.Size = new Size(325, 26);
            cbbKund.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(45, 18);
            label3.TabIndex = 46;
            label3.Text = "Kund:";
            // 
            // btnSkapaFraktsedel
            // 
            btnSkapaFraktsedel.BackColor = Color.FromArgb(44, 44, 44);
            btnSkapaFraktsedel.FlatStyle = FlatStyle.Flat;
            btnSkapaFraktsedel.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkapaFraktsedel.ForeColor = Color.White;
            btnSkapaFraktsedel.Location = new Point(186, 584);
            btnSkapaFraktsedel.Name = "btnSkapaFraktsedel";
            btnSkapaFraktsedel.Size = new Size(162, 35);
            btnSkapaFraktsedel.TabIndex = 75;
            btnSkapaFraktsedel.Text = "Skapa Fraktsedel";
            btnSkapaFraktsedel.UseVisualStyleBackColor = false;
            btnSkapaFraktsedel.Click += btnSkapaFraktsedel_Click;
            // 
            // btnSkapaFaktura
            // 
            btnSkapaFaktura.BackColor = Color.FromArgb(44, 44, 44);
            btnSkapaFaktura.FlatStyle = FlatStyle.Flat;
            btnSkapaFaktura.ForeColor = Color.White;
            btnSkapaFaktura.Location = new Point(18, 584);
            btnSkapaFaktura.Name = "btnSkapaFaktura";
            btnSkapaFaktura.Size = new Size(162, 35);
            btnSkapaFaktura.TabIndex = 76;
            btnSkapaFaktura.Text = "Skapa Faktura";
            btnSkapaFaktura.UseVisualStyleBackColor = false;
            btnSkapaFaktura.Click += btnSkapaFaktura_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 533);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 77;
            label1.Text = "Orderstatus:";
            // 
            // cbbOrderStatus
            // 
            cbbOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbOrderStatus.FormattingEnabled = true;
            cbbOrderStatus.Items.AddRange(new object[] { "Ny beställning", "Förfrågan skickad", "Bekräftad", "Under tillverkning", "Skickad", "Betald" });
            cbbOrderStatus.Location = new Point(158, 533);
            cbbOrderStatus.Name = "cbbOrderStatus";
            cbbOrderStatus.Size = new Size(147, 26);
            cbbOrderStatus.TabIndex = 78;
            cbbOrderStatus.SelectedIndexChanged += cbbOrderStatus_SelectedIndexChanged;
            // 
            // btnBeställningTabort
            // 
            btnBeställningTabort.BackColor = Color.IndianRed;
            btnBeställningTabort.FlatStyle = FlatStyle.Flat;
            btnBeställningTabort.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeställningTabort.ForeColor = Color.White;
            btnBeställningTabort.Location = new Point(186, 640);
            btnBeställningTabort.Name = "btnBeställningTabort";
            btnBeställningTabort.Size = new Size(162, 39);
            btnBeställningTabort.TabIndex = 79;
            btnBeställningTabort.Text = "Radera Order";
            btnBeställningTabort.UseVisualStyleBackColor = false;
            btnBeställningTabort.Click += btnBeställningTabort_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panTygDek);
            panel1.Controls.Add(tbxLand);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(tbxOrt);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(tbxPostNummer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbbSkapadAv);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbbKund);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(tbxAdress);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(cbbHuvudmmått);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbxBeskrivning);
            panel1.Location = new Point(18, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 414);
            panel1.TabIndex = 80;
            // 
            // panTygDek
            // 
            panTygDek.Controls.Add(lvTyg);
            panTygDek.Controls.Add(label5);
            panTygDek.Controls.Add(cbbTyg);
            panTygDek.Controls.Add(label7);
            panTygDek.Controls.Add(tbxTygLängd);
            panTygDek.Controls.Add(label8);
            panTygDek.Controls.Add(btnTAdd);
            panTygDek.Controls.Add(label11);
            panTygDek.Controls.Add(lvDekoration);
            panTygDek.Controls.Add(cbbDekoration);
            panTygDek.Controls.Add(label10);
            panTygDek.Controls.Add(tbxDekoration);
            panTygDek.Controls.Add(label9);
            panTygDek.Controls.Add(btnDAdd);
            panTygDek.Controls.Add(label13);
            panTygDek.Controls.Add(tbxTid);
            panTygDek.Controls.Add(label12);
            panTygDek.Location = new Point(13, 377);
            panTygDek.Name = "panTygDek";
            panTygDek.Size = new Size(473, 360);
            panTygDek.TabIndex = 86;
            // 
            // lvTyg
            // 
            lvTyg.Columns.AddRange(new ColumnHeader[] { namn, AntalMeter });
            lvTyg.Location = new Point(18, 51);
            lvTyg.Name = "lvTyg";
            lvTyg.Size = new Size(452, 86);
            lvTyg.TabIndex = 76;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 16);
            label5.Name = "label5";
            label5.Size = new Size(32, 18);
            label5.TabIndex = 52;
            label5.Text = "Tyg:";
            // 
            // cbbTyg
            // 
            cbbTyg.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTyg.FormattingEnabled = true;
            cbbTyg.Location = new Point(102, 12);
            cbbTyg.Name = "cbbTyg";
            cbbTyg.Size = new Size(147, 26);
            cbbTyg.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 16);
            label7.Name = "label7";
            label7.Size = new Size(16, 18);
            label7.TabIndex = 58;
            label7.Text = "x";
            // 
            // tbxTygLängd
            // 
            tbxTygLängd.Location = new Point(278, 12);
            tbxTygLängd.Name = "tbxTygLängd";
            tbxTygLängd.Size = new Size(41, 26);
            tbxTygLängd.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 20);
            label8.Name = "label8";
            label8.Size = new Size(21, 18);
            label8.TabIndex = 59;
            label8.Text = "m";
            // 
            // btnTAdd
            // 
            btnTAdd.BackColor = Color.FromArgb(44, 44, 44);
            btnTAdd.FlatStyle = FlatStyle.Flat;
            btnTAdd.ForeColor = Color.White;
            btnTAdd.Location = new Point(376, 14);
            btnTAdd.Name = "btnTAdd";
            btnTAdd.Size = new Size(83, 31);
            btnTAdd.TabIndex = 72;
            btnTAdd.Text = "Lägg till";
            btnTAdd.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 151);
            label11.Name = "label11";
            label11.Size = new Size(84, 18);
            label11.TabIndex = 60;
            label11.Text = "Dekoration:";
            // 
            // lvDekoration
            // 
            lvDekoration.Columns.AddRange(new ColumnHeader[] { namnn, antal });
            lvDekoration.Location = new Point(18, 183);
            lvDekoration.Name = "lvDekoration";
            lvDekoration.Size = new Size(452, 86);
            lvDekoration.TabIndex = 77;
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
            // cbbDekoration
            // 
            cbbDekoration.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDekoration.FormattingEnabled = true;
            cbbDekoration.Location = new Point(102, 147);
            cbbDekoration.Name = "cbbDekoration";
            cbbDekoration.Size = new Size(147, 26);
            cbbDekoration.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(256, 151);
            label10.Name = "label10";
            label10.Size = new Size(16, 18);
            label10.TabIndex = 61;
            label10.Text = "x";
            // 
            // tbxDekoration
            // 
            tbxDekoration.Location = new Point(278, 147);
            tbxDekoration.Name = "tbxDekoration";
            tbxDekoration.Size = new Size(41, 26);
            tbxDekoration.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(325, 151);
            label9.Name = "label9";
            label9.Size = new Size(21, 18);
            label9.TabIndex = 62;
            label9.Text = "st";
            // 
            // btnDAdd
            // 
            btnDAdd.BackColor = Color.FromArgb(44, 44, 44);
            btnDAdd.FlatStyle = FlatStyle.Flat;
            btnDAdd.ForeColor = Color.White;
            btnDAdd.Location = new Point(376, 145);
            btnDAdd.Name = "btnDAdd";
            btnDAdd.Size = new Size(83, 31);
            btnDAdd.TabIndex = 73;
            btnDAdd.Text = "Lägg till";
            btnDAdd.UseVisualStyleBackColor = false;
            // 
            // tbxLand
            // 
            tbxLand.Location = new Point(325, 106);
            tbxLand.Name = "tbxLand";
            tbxLand.Size = new Size(140, 26);
            tbxLand.TabIndex = 83;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(280, 109);
            label21.Name = "label21";
            label21.Size = new Size(48, 18);
            label21.TabIndex = 82;
            label21.Text = "Land :";
            // 
            // tbxOrt
            // 
            tbxOrt.Location = new Point(140, 106);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(130, 26);
            tbxOrt.TabIndex = 81;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(13, 109);
            label20.Name = "label20";
            label20.Size = new Size(36, 18);
            label20.TabIndex = 80;
            label20.Text = "Ort :";
            // 
            // tbxPostNummer
            // 
            tbxPostNummer.Location = new Point(140, 78);
            tbxPostNummer.Name = "tbxPostNummer";
            tbxPostNummer.Size = new Size(130, 26);
            tbxPostNummer.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 78;
            label2.Text = "Postnummer:";
            // 
            // btnSkickaEpost
            // 
            btnSkickaEpost.BackColor = Color.FromArgb(44, 44, 44);
            btnSkickaEpost.FlatStyle = FlatStyle.Flat;
            btnSkickaEpost.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkickaEpost.ForeColor = Color.White;
            btnSkickaEpost.Location = new Point(358, 584);
            btnSkickaEpost.Name = "btnSkickaEpost";
            btnSkickaEpost.Size = new Size(162, 35);
            btnSkickaEpost.TabIndex = 81;
            btnSkickaEpost.Text = "Skicka Epost";
            btnSkickaEpost.UseVisualStyleBackColor = false;
            btnSkickaEpost.Click += btnSkickaEpost_Click;
            // 
            // tbxVikt
            // 
            tbxVikt.Location = new Point(422, 504);
            tbxVikt.Name = "tbxVikt";
            tbxVikt.Size = new Size(32, 26);
            tbxVikt.TabIndex = 82;
            tbxVikt.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTotalvikt
            // 
            lblTotalvikt.AutoSize = true;
            lblTotalvikt.Location = new Point(331, 509);
            lblTotalvikt.Name = "lblTotalvikt";
            lblTotalvikt.Size = new Size(71, 18);
            lblTotalvikt.TabIndex = 83;
            lblTotalvikt.Text = "Totalvikt: ";
            // 
            // cbxGåva
            // 
            cbxGåva.AutoSize = true;
            cbxGåva.Location = new Point(422, 541);
            cbxGåva.Name = "cbxGåva";
            cbxGåva.Size = new Size(18, 17);
            cbxGåva.TabIndex = 84;
            cbxGåva.UseVisualStyleBackColor = true;
            // 
            // lblGåva
            // 
            lblGåva.AutoSize = true;
            lblGåva.Location = new Point(331, 541);
            lblGåva.Name = "lblGåva";
            lblGåva.Size = new Size(45, 18);
            lblGåva.TabIndex = 85;
            lblGåva.Text = "Gåva:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(460, 507);
            label22.Name = "label22";
            label22.Size = new Size(24, 18);
            label22.TabIndex = 86;
            label22.Text = "kg";
            // 
            // lblNyttPris
            // 
            lblNyttPris.AutoSize = true;
            lblNyttPris.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNyttPris.Location = new Point(246, 496);
            lblNyttPris.Name = "lblNyttPris";
            lblNyttPris.Size = new Size(0, 24);
            lblNyttPris.TabIndex = 87;
            // 
            // GranskaBeställning
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(598, 697);
            Controls.Add(lblNyttPris);
            Controls.Add(label22);
            Controls.Add(lblGåva);
            Controls.Add(cbxGåva);
            Controls.Add(lblTotalvikt);
            Controls.Add(tbxVikt);
            Controls.Add(btnSkickaEpost);
            Controls.Add(panel1);
            Controls.Add(btnBeställningTabort);
            Controls.Add(cbbOrderStatus);
            Controls.Add(label1);
            Controls.Add(btnSkapaFaktura);
            Controls.Add(btnSkapaFraktsedel);
            Controls.Add(label19);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSpara);
            Controls.Add(lblPris);
            Controls.Add(label14);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GranskaBeställning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GranskaBeställning";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panTygDek.ResumeLayout(false);
            panTygDek.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private ComboBox cbbHuvudmmått;
        private Label label18;
        private Label label16;
        private Button btnAvbryt;
        private Button btnSpara;
        private TextBox tbxAdress;
        private Label label15;
        private Label lblPris;
        private Label label14;
        private Label label13;
        private TextBox tbxTid;
        private Label label12;
        private TextBox tbxBeskrivning;
        private Label label6;
        private ComboBox cbbSkapadAv;
        private Label label4;
        private ComboBox cbbKund;
        private Label label3;
        private Button btnSkapaFraktsedel;
        private Button btnSkapaFaktura;
        private Label label1;
        private ComboBox cbbOrderStatus;
        private Button btnBeställningTabort;
        private Panel panel1;
        private TextBox tbxLand;
        private Label label21;
        private TextBox tbxOrt;
        private Label label20;
        private TextBox tbxPostNummer;
        private Label label2;
        private Button btnSkickaEpost;
        private TextBox tbxVikt;
        private Label lblTotalvikt;
        private CheckBox cbxGåva;
        private Label lblGåva;
        private Label label22;
        private Label lblNyttPris;
        private Panel panTygDek;
        private ListView lvTyg;
        private ColumnHeader namn;
        private ColumnHeader AntalMeter;
        private Label label5;
        private ComboBox cbbTyg;
        private Label label7;
        private TextBox tbxTygLängd;
        private Label label8;
        private Button btnTAdd;
        private Label label11;
        private ListView lvDekoration;
        private ColumnHeader namnn;
        private ColumnHeader antal;
        private ComboBox cbbDekoration;
        private Label label10;
        private TextBox tbxDekoration;
        private Label label9;
        private Button btnDAdd;
    }
}