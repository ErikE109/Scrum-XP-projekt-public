namespace View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label2 = new Label();
            label1 = new Label();
            btnLoggaIn = new Button();
            tbxLösenord = new TextBox();
            lblLösenord = new Label();
            tbxAnvändarnamn = new TextBox();
            lblAnvändarnamn = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 194);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(289, 24);
            label2.TabIndex = 9;
            label2.Text = "Ange dina inloggningsuppgifter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 8;
            label1.Text = "Hejhej! 👋";
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.FlatAppearance.BorderSize = 0;
            btnLoggaIn.Location = new Point(143, 489);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(394, 37);
            btnLoggaIn.TabIndex = 20;
            btnLoggaIn.Text = " Logga in";
            btnLoggaIn.UseVisualStyleBackColor = false;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // tbxLösenord
            // 
            tbxLösenord.Font = new Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxLösenord.Location = new Point(143, 391);
            tbxLösenord.Name = "tbxLösenord";
            tbxLösenord.PasswordChar = '*';
            tbxLösenord.Size = new Size(394, 39);
            tbxLösenord.TabIndex = 19;
            // 
            // lblLösenord
            // 
            lblLösenord.AutoSize = true;
            lblLösenord.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLösenord.Location = new Point(143, 365);
            lblLösenord.Name = "lblLösenord";
            lblLösenord.Size = new Size(100, 24);
            lblLösenord.TabIndex = 18;
            lblLösenord.Text = "Lösenord:";
            // 
            // tbxAnvändarnamn
            // 
            tbxAnvändarnamn.Font = new Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAnvändarnamn.Location = new Point(143, 304);
            tbxAnvändarnamn.Name = "tbxAnvändarnamn";
            tbxAnvändarnamn.Size = new Size(394, 39);
            tbxAnvändarnamn.TabIndex = 17;
            // 
            // lblAnvändarnamn
            // 
            lblAnvändarnamn.AutoSize = true;
            lblAnvändarnamn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnvändarnamn.Location = new Point(143, 278);
            lblAnvändarnamn.Name = "lblAnvändarnamn";
            lblAnvändarnamn.Size = new Size(152, 24);
            lblAnvändarnamn.TabIndex = 16;
            lblAnvändarnamn.Text = "Användarnamn:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(771, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 729);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoggaIn);
            Controls.Add(tbxLösenord);
            Controls.Add(lblLösenord);
            Controls.Add(tbxAnvändarnamn);
            Controls.Add(lblAnvändarnamn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hattmakarna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnLoggaIn;
        private TextBox tbxLösenord;
        private Label lblLösenord;
        private TextBox tbxAnvändarnamn;
        private Label lblAnvändarnamn;
        private PictureBox pictureBox1;
    }
}