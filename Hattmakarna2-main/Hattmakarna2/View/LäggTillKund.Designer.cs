namespace View
{
    partial class LäggTillKund
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
            tbxNamn = new TextBox();
            tbxAdress = new TextBox();
            label2 = new Label();
            tbxEpost = new TextBox();
            label3 = new Label();
            tbxTelefonnummer = new TextBox();
            label4 = new Label();
            btnLäggTill = new Button();
            btnAvbryt = new Button();
            label19 = new Label();
            tbxOrt = new TextBox();
            lblOrt = new Label();
            tbxPostnummer = new TextBox();
            lblPostnummer = new Label();
            tbxLand = new TextBox();
            lblLand = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 102);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 0;
            label1.Text = "Namn:";
            // 
            // tbxNamn
            // 
            tbxNamn.Location = new Point(161, 99);
            tbxNamn.Name = "tbxNamn";
            tbxNamn.Size = new Size(182, 26);
            tbxNamn.TabIndex = 1;
            // 
            // tbxAdress
            // 
            tbxAdress.Location = new Point(161, 136);
            tbxAdress.Name = "tbxAdress";
            tbxAdress.Size = new Size(182, 26);
            tbxAdress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 139);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 2;
            label2.Text = "Adress:";
            // 
            // tbxEpost
            // 
            tbxEpost.Location = new Point(161, 294);
            tbxEpost.Name = "tbxEpost";
            tbxEpost.Size = new Size(182, 26);
            tbxEpost.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 297);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 4;
            label3.Text = "Epost:";
            // 
            // tbxTelefonnummer
            // 
            tbxTelefonnummer.Location = new Point(161, 331);
            tbxTelefonnummer.Name = "tbxTelefonnummer";
            tbxTelefonnummer.Size = new Size(182, 26);
            tbxTelefonnummer.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 334);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 6;
            label4.Text = "Telefonnummer:";
            // 
            // btnLäggTill
            // 
            btnLäggTill.BackColor = Color.FromArgb(44, 44, 44);
            btnLäggTill.FlatStyle = FlatStyle.Flat;
            btnLäggTill.ForeColor = Color.White;
            btnLäggTill.Location = new Point(207, 405);
            btnLäggTill.Name = "btnLäggTill";
            btnLäggTill.Size = new Size(136, 33);
            btnLäggTill.TabIndex = 8;
            btnLäggTill.Text = "Lägg till";
            btnLäggTill.UseVisualStyleBackColor = false;
            btnLäggTill.Click += btnLäggTill_Click_1;
            // 
            // btnAvbryt
            // 
            btnAvbryt.BackColor = Color.White;
            btnAvbryt.FlatStyle = FlatStyle.Flat;
            btnAvbryt.ForeColor = Color.DimGray;
            btnAvbryt.Location = new Point(37, 405);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(136, 33);
            btnAvbryt.TabIndex = 9;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(37, 39);
            label19.Name = "label19";
            label19.Size = new Size(190, 33);
            label19.TabIndex = 38;
            label19.Text = "Lägg till ny kund";
            // 
            // tbxOrt
            // 
            tbxOrt.Location = new Point(161, 217);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(182, 26);
            tbxOrt.TabIndex = 40;
            // 
            // lblOrt
            // 
            lblOrt.AutoSize = true;
            lblOrt.Location = new Point(37, 217);
            lblOrt.Name = "lblOrt";
            lblOrt.Size = new Size(32, 18);
            lblOrt.TabIndex = 39;
            lblOrt.Text = "Ort:";
            // 
            // tbxPostnummer
            // 
            tbxPostnummer.Location = new Point(161, 174);
            tbxPostnummer.Name = "tbxPostnummer";
            tbxPostnummer.Size = new Size(182, 26);
            tbxPostnummer.TabIndex = 42;
            // 
            // lblPostnummer
            // 
            lblPostnummer.AutoSize = true;
            lblPostnummer.Location = new Point(37, 177);
            lblPostnummer.Name = "lblPostnummer";
            lblPostnummer.Size = new Size(95, 18);
            lblPostnummer.TabIndex = 41;
            lblPostnummer.Text = "Postnummer:";
            // 
            // tbxLand
            // 
            tbxLand.Location = new Point(161, 254);
            tbxLand.Name = "tbxLand";
            tbxLand.Size = new Size(182, 26);
            tbxLand.TabIndex = 44;
            // 
            // lblLand
            // 
            lblLand.AutoSize = true;
            lblLand.Location = new Point(37, 254);
            lblLand.Name = "lblLand";
            lblLand.Size = new Size(44, 18);
            lblLand.TabIndex = 43;
            lblLand.Text = "Land:";
            // 
            // LäggTillKund
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 481);
            Controls.Add(tbxLand);
            Controls.Add(lblLand);
            Controls.Add(tbxPostnummer);
            Controls.Add(lblPostnummer);
            Controls.Add(tbxOrt);
            Controls.Add(lblOrt);
            Controls.Add(label19);
            Controls.Add(btnAvbryt);
            Controls.Add(btnLäggTill);
            Controls.Add(tbxTelefonnummer);
            Controls.Add(label4);
            Controls.Add(tbxEpost);
            Controls.Add(label3);
            Controls.Add(tbxAdress);
            Controls.Add(label2);
            Controls.Add(tbxNamn);
            Controls.Add(label1);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LäggTillKund";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lägg Till Kund";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNamn;
        private TextBox tbxAdress;
        private Label label2;
        private TextBox tbxEpost;
        private Label label3;
        private TextBox tbxTelefonnummer;
        private Label label4;
        private Button btnLäggTill;
        private Button btnAvbryt;
        private Label label19;
        private TextBox tbxOrt;
        private Label lblOrt;
        private TextBox tbxPostnummer;
        private Label lblPostnummer;
        private TextBox tbxLand;
        private Label lblLand;
    }
}