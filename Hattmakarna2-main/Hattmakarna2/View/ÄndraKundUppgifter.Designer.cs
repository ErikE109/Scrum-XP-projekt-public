namespace View
{
    partial class ÄndraKundUppgifter
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
            btnSpara = new Button();
            btnGåTillbaka = new Button();
            label1 = new Label();
            tbxLand = new TextBox();
            lblLand = new Label();
            tbxPostnummer = new TextBox();
            lblPostnummer = new Label();
            tbxOrt = new TextBox();
            lblOrt = new Label();
            tbxTelefonnummer = new TextBox();
            label4 = new Label();
            tbxEpost = new TextBox();
            label3 = new Label();
            tbxAdress = new TextBox();
            label2 = new Label();
            tbxNamn = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSpara
            // 
            btnSpara.BackColor = Color.FromArgb(44, 44, 44);
            btnSpara.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpara.ForeColor = Color.White;
            btnSpara.Location = new Point(294, 397);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(136, 42);
            btnSpara.TabIndex = 0;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = false;
            btnSpara.Click += btnSpara_Click;
            // 
            // btnGåTillbaka
            // 
            btnGåTillbaka.BackColor = Color.White;
            btnGåTillbaka.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGåTillbaka.ForeColor = Color.DimGray;
            btnGåTillbaka.Location = new Point(53, 397);
            btnGåTillbaka.Name = "btnGåTillbaka";
            btnGåTillbaka.Size = new Size(133, 42);
            btnGåTillbaka.TabIndex = 9;
            btnGåTillbaka.Text = "Avbryt";
            btnGåTillbaka.UseVisualStyleBackColor = false;
            btnGåTillbaka.Click += btnGåTillbaka_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 48);
            label1.TabIndex = 10;
            label1.Text = "Redigera kund";
            // 
            // tbxLand
            // 
            tbxLand.Location = new Point(177, 235);
            tbxLand.Name = "tbxLand";
            tbxLand.Size = new Size(253, 27);
            tbxLand.TabIndex = 58;
            // 
            // lblLand
            // 
            lblLand.AutoSize = true;
            lblLand.Location = new Point(53, 235);
            lblLand.Name = "lblLand";
            lblLand.Size = new Size(44, 20);
            lblLand.TabIndex = 57;
            lblLand.Text = "Land:";
            // 
            // tbxPostnummer
            // 
            tbxPostnummer.Location = new Point(177, 155);
            tbxPostnummer.Name = "tbxPostnummer";
            tbxPostnummer.Size = new Size(253, 27);
            tbxPostnummer.TabIndex = 56;
            // 
            // lblPostnummer
            // 
            lblPostnummer.AutoSize = true;
            lblPostnummer.Location = new Point(53, 158);
            lblPostnummer.Name = "lblPostnummer";
            lblPostnummer.Size = new Size(94, 20);
            lblPostnummer.TabIndex = 55;
            lblPostnummer.Text = "Postnummer:";
            // 
            // tbxOrt
            // 
            tbxOrt.Location = new Point(177, 198);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(253, 27);
            tbxOrt.TabIndex = 54;
            // 
            // lblOrt
            // 
            lblOrt.AutoSize = true;
            lblOrt.Location = new Point(53, 198);
            lblOrt.Name = "lblOrt";
            lblOrt.Size = new Size(33, 20);
            lblOrt.TabIndex = 53;
            lblOrt.Text = "Ort:";
            // 
            // tbxTelefonnummer
            // 
            tbxTelefonnummer.Location = new Point(177, 312);
            tbxTelefonnummer.Name = "tbxTelefonnummer";
            tbxTelefonnummer.Size = new Size(253, 27);
            tbxTelefonnummer.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 315);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 51;
            label4.Text = "Telefonnummer:";
            // 
            // tbxEpost
            // 
            tbxEpost.Location = new Point(177, 275);
            tbxEpost.Name = "tbxEpost";
            tbxEpost.Size = new Size(253, 27);
            tbxEpost.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 278);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 49;
            label3.Text = "Epost:";
            // 
            // tbxAdress
            // 
            tbxAdress.Location = new Point(177, 117);
            tbxAdress.Name = "tbxAdress";
            tbxAdress.Size = new Size(253, 27);
            tbxAdress.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 120);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 47;
            label2.Text = "Adress:";
            // 
            // tbxNamn
            // 
            tbxNamn.Location = new Point(177, 80);
            tbxNamn.Name = "tbxNamn";
            tbxNamn.Size = new Size(253, 27);
            tbxNamn.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 83);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 45;
            label5.Text = "Namn:";
            // 
            // ÄndraKundUppgifter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 499);
            Controls.Add(tbxLand);
            Controls.Add(lblLand);
            Controls.Add(tbxPostnummer);
            Controls.Add(lblPostnummer);
            Controls.Add(tbxOrt);
            Controls.Add(lblOrt);
            Controls.Add(tbxTelefonnummer);
            Controls.Add(label4);
            Controls.Add(tbxEpost);
            Controls.Add(label3);
            Controls.Add(tbxAdress);
            Controls.Add(label2);
            Controls.Add(tbxNamn);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnGåTillbaka);
            Controls.Add(btnSpara);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ÄndraKundUppgifter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ÄndraKundUppgifter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpara;
        private Button btnGåTillbaka;
        private Label label1;
        private TextBox tbxLand;
        private Label lblLand;
        private TextBox tbxPostnummer;
        private Label lblPostnummer;
        private TextBox tbxOrt;
        private Label lblOrt;
        private TextBox tbxTelefonnummer;
        private Label label4;
        private TextBox tbxEpost;
        private Label label3;
        private TextBox tbxAdress;
        private Label label2;
        private TextBox tbxNamn;
        private Label label5;
    }
}