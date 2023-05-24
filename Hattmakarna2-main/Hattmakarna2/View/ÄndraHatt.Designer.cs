namespace View
{
    partial class ÄndraHatt
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
            tbxPris = new TextBox();
            label2 = new Label();
            tbxNamn = new TextBox();
            label1 = new Label();
            button2 = new Button();
            btnSpara = new Button();
            tbxMaterialkostnad = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(36, 34);
            label19.Name = "label19";
            label19.Size = new Size(263, 33);
            label19.TabIndex = 56;
            label19.Text = "Redigera lagerförd hatt";
            // 
            // tbxPris
            // 
            tbxPris.Location = new Point(169, 129);
            tbxPris.Name = "tbxPris";
            tbxPris.Size = new Size(294, 26);
            tbxPris.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 73;
            label2.Text = "Pris:";
            // 
            // tbxNamn
            // 
            tbxNamn.Location = new Point(169, 78);
            tbxNamn.Name = "tbxNamn";
            tbxNamn.Size = new Size(294, 26);
            tbxNamn.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 71;
            label1.Text = "Namn:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(40, 286);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 66;
            button2.Text = "Avbryt";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSpara
            // 
            btnSpara.BackColor = Color.FromArgb(44, 44, 44);
            btnSpara.FlatStyle = FlatStyle.Flat;
            btnSpara.ForeColor = Color.White;
            btnSpara.Location = new Point(320, 286);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(143, 38);
            btnSpara.TabIndex = 64;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = false;
            btnSpara.Click += btnSpara_Click;
            // 
            // tbxMaterialkostnad
            // 
            tbxMaterialkostnad.Location = new Point(169, 180);
            tbxMaterialkostnad.Name = "tbxMaterialkostnad";
            tbxMaterialkostnad.Size = new Size(294, 26);
            tbxMaterialkostnad.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 183);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 75;
            label3.Text = "Materialkostnad:";
            // 
            // ÄndraHatt
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(517, 377);
            Controls.Add(tbxMaterialkostnad);
            Controls.Add(label3);
            Controls.Add(tbxPris);
            Controls.Add(label2);
            Controls.Add(tbxNamn);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnSpara);
            Controls.Add(label19);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ÄndraHatt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ÄndraHatt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private TextBox tbxPris;
        private Label label2;
        private TextBox tbxNamn;
        private Label label1;
        private Button button2;
        private Button btnSpara;
        private TextBox tbxMaterialkostnad;
        private Label label3;
    }
}