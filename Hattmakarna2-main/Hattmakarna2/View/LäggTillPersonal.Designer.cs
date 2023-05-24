namespace View
{
    partial class LäggTillPersonal
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
            lblAnvnamn = new Label();
            tbxAnvNam = new TextBox();
            tbxLös = new TextBox();
            tbxUppLös = new TextBox();
            lblLösenord = new Label();
            lblLösenordIgen = new Label();
            btnSpaNyPer = new Button();
            lblNyPersonal = new Label();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // lblAnvnamn
            // 
            lblAnvnamn.AutoSize = true;
            lblAnvnamn.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnvnamn.ForeColor = Color.Black;
            lblAnvnamn.Location = new Point(70, 126);
            lblAnvnamn.Name = "lblAnvnamn";
            lblAnvnamn.Size = new Size(112, 18);
            lblAnvnamn.TabIndex = 0;
            lblAnvnamn.Text = "Användarnamn:";
            // 
            // tbxAnvNam
            // 
            tbxAnvNam.Location = new Point(204, 122);
            tbxAnvNam.Name = "tbxAnvNam";
            tbxAnvNam.Size = new Size(166, 27);
            tbxAnvNam.TabIndex = 1;
            // 
            // tbxLös
            // 
            tbxLös.Location = new Point(204, 193);
            tbxLös.Name = "tbxLös";
            tbxLös.PasswordChar = '*';
            tbxLös.Size = new Size(166, 27);
            tbxLös.TabIndex = 2;
            // 
            // tbxUppLös
            // 
            tbxUppLös.Location = new Point(204, 254);
            tbxUppLös.Name = "tbxUppLös";
            tbxUppLös.PasswordChar = '*';
            tbxUppLös.Size = new Size(166, 27);
            tbxUppLös.TabIndex = 3;
            // 
            // lblLösenord
            // 
            lblLösenord.AutoSize = true;
            lblLösenord.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLösenord.Location = new Point(70, 197);
            lblLösenord.Name = "lblLösenord";
            lblLösenord.Size = new Size(74, 18);
            lblLösenord.TabIndex = 4;
            lblLösenord.Text = "Lösenord:";
            lblLösenord.UseMnemonic = false;
            // 
            // lblLösenordIgen
            // 
            lblLösenordIgen.AutoSize = true;
            lblLösenordIgen.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLösenordIgen.Location = new Point(70, 263);
            lblLösenordIgen.Name = "lblLösenordIgen";
            lblLösenordIgen.Size = new Size(129, 18);
            lblLösenordIgen.TabIndex = 5;
            lblLösenordIgen.Text = "Upprepa lösenord:";
            lblLösenordIgen.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSpaNyPer
            // 
            btnSpaNyPer.BackColor = Color.FromArgb(44, 44, 44);
            btnSpaNyPer.FlatStyle = FlatStyle.Flat;
            btnSpaNyPer.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpaNyPer.ForeColor = Color.White;
            btnSpaNyPer.Location = new Point(270, 355);
            btnSpaNyPer.Name = "btnSpaNyPer";
            btnSpaNyPer.Size = new Size(100, 38);
            btnSpaNyPer.TabIndex = 6;
            btnSpaNyPer.Text = "Spara";
            btnSpaNyPer.UseVisualStyleBackColor = false;
            btnSpaNyPer.Click += btnSpaNyPer_Click;
            // 
            // lblNyPersonal
            // 
            lblNyPersonal.AutoSize = true;
            lblNyPersonal.Font = new Font("Bahnschrift Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNyPersonal.ForeColor = Color.Black;
            lblNyPersonal.Location = new Point(70, 48);
            lblNyPersonal.Name = "lblNyPersonal";
            lblNyPersonal.Size = new Size(249, 28);
            lblNyPersonal.TabIndex = 7;
            lblNyPersonal.Text = "Registrera ny personal";
            lblNyPersonal.Click += label4_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.BackColor = Color.White;
            btnAvbryt.FlatStyle = FlatStyle.Flat;
            btnAvbryt.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAvbryt.ForeColor = Color.DimGray;
            btnAvbryt.Location = new Point(70, 356);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(94, 37);
            btnAvbryt.TabIndex = 8;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = false;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // LäggTillPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 454);
            Controls.Add(btnAvbryt);
            Controls.Add(lblNyPersonal);
            Controls.Add(btnSpaNyPer);
            Controls.Add(lblLösenordIgen);
            Controls.Add(lblLösenord);
            Controls.Add(tbxUppLös);
            Controls.Add(tbxLös);
            Controls.Add(tbxAnvNam);
            Controls.Add(lblAnvnamn);
            MaximumSize = new Size(449, 501);
            Name = "LäggTillPersonal";
            Text = "LäggTillPersonal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnvnamn;
        private TextBox tbxAnvNam;
        private TextBox tbxLös;
        private TextBox tbxUppLös;
        private Label lblLösenord;
        private Label lblLösenordIgen;
        private Button btnSpaNyPer;
        private Label lblNyPersonal;
        private Button btnAvbryt;
    }
}