namespace View
{
    partial class ÄndraLösen
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
            lblÄndLös = new Label();
            lblNyLös = new Label();
            lblUppLös = new Label();
            tbxNyLös = new TextBox();
            tbxUppLös = new TextBox();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // btnSpara
            // 
            btnSpara.BackColor = Color.FromArgb(44, 44, 44);
            btnSpara.FlatStyle = FlatStyle.Flat;
            btnSpara.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpara.ForeColor = Color.White;
            btnSpara.Location = new Point(215, 347);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(94, 29);
            btnSpara.TabIndex = 0;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = false;
            btnSpara.Click += btnSpara_Click;
            // 
            // lblÄndLös
            // 
            lblÄndLös.AutoSize = true;
            lblÄndLös.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblÄndLös.Location = new Point(36, 40);
            lblÄndLös.Name = "lblÄndLös";
            lblÄndLös.Size = new Size(210, 34);
            lblÄndLös.TabIndex = 1;
            lblÄndLös.Text = "Ändra lösenord";
            // 
            // lblNyLös
            // 
            lblNyLös.AutoSize = true;
            lblNyLös.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNyLös.Location = new Point(36, 175);
            lblNyLös.Name = "lblNyLös";
            lblNyLös.Size = new Size(101, 18);
            lblNyLös.TabIndex = 2;
            lblNyLös.Text = "Nytt lösenord:";
            // 
            // lblUppLös
            // 
            lblUppLös.AutoSize = true;
            lblUppLös.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUppLös.Location = new Point(36, 231);
            lblUppLös.Name = "lblUppLös";
            lblUppLös.Size = new Size(142, 18);
            lblUppLös.TabIndex = 3;
            lblUppLös.Text = "Upprepa lösenordet:";
            // 
            // tbxNyLös
            // 
            tbxNyLös.Location = new Point(184, 175);
            tbxNyLös.Name = "tbxNyLös";
            tbxNyLös.PasswordChar = '*';
            tbxNyLös.Size = new Size(125, 27);
            tbxNyLös.TabIndex = 4;
            // 
            // tbxUppLös
            // 
            tbxUppLös.Location = new Point(184, 231);
            tbxUppLös.Name = "tbxUppLös";
            tbxUppLös.PasswordChar = '*';
            tbxUppLös.Size = new Size(125, 27);
            tbxUppLös.TabIndex = 5;
            // 
            // btnAvbryt
            // 
            btnAvbryt.BackColor = Color.White;
            btnAvbryt.FlatStyle = FlatStyle.Flat;
            btnAvbryt.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAvbryt.ForeColor = Color.DimGray;
            btnAvbryt.Location = new Point(36, 347);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(94, 29);
            btnAvbryt.TabIndex = 6;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = false;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // ÄndraLösen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 439);
            Controls.Add(btnAvbryt);
            Controls.Add(tbxUppLös);
            Controls.Add(tbxNyLös);
            Controls.Add(lblUppLös);
            Controls.Add(lblNyLös);
            Controls.Add(lblÄndLös);
            Controls.Add(btnSpara);
            Name = "ÄndraLösen";
            Text = "ÄndraLösen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpara;
        private Label lblÄndLös;
        private Label lblNyLös;
        private Label lblUppLös;
        private TextBox tbxNyLös;
        private TextBox tbxUppLös;
        private Button btnAvbryt;
    }
}