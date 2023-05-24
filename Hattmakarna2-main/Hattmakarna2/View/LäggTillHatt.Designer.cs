namespace View
{
    partial class LäggTillHatt
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
            btnAvbryt = new Button();
            btnLäggTillHatt = new Button();
            label1 = new Label();
            tbxNamn = new TextBox();
            tbxPris = new TextBox();
            label2 = new Label();
            label19 = new Label();
            tbxMaterialkostnad = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAvbryt
            // 
            btnAvbryt.BackColor = Color.White;
            btnAvbryt.FlatStyle = FlatStyle.Flat;
            btnAvbryt.ForeColor = Color.DimGray;
            btnAvbryt.Location = new Point(39, 294);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(136, 33);
            btnAvbryt.TabIndex = 42;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = false;
            // 
            // btnLäggTillHatt
            // 
            btnLäggTillHatt.BackColor = Color.FromArgb(44, 44, 44);
            btnLäggTillHatt.FlatStyle = FlatStyle.Flat;
            btnLäggTillHatt.ForeColor = Color.White;
            btnLäggTillHatt.Location = new Point(327, 294);
            btnLäggTillHatt.Name = "btnLäggTillHatt";
            btnLäggTillHatt.Size = new Size(136, 33);
            btnLäggTillHatt.TabIndex = 40;
            btnLäggTillHatt.Text = "Lägg till hatt";
            btnLäggTillHatt.UseVisualStyleBackColor = false;
            btnLäggTillHatt.Click += btnLäggTillHatt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 51;
            label1.Text = "Namn:";
            // 
            // tbxNamn
            // 
            tbxNamn.Location = new Point(169, 81);
            tbxNamn.Name = "tbxNamn";
            tbxNamn.Size = new Size(294, 26);
            tbxNamn.TabIndex = 52;
            // 
            // tbxPris
            // 
            tbxPris.Location = new Point(169, 147);
            tbxPris.Name = "tbxPris";
            tbxPris.Size = new Size(294, 26);
            tbxPris.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 150);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 53;
            label2.Text = "Pris:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(36, 34);
            label19.Name = "label19";
            label19.Size = new Size(265, 33);
            label19.TabIndex = 55;
            label19.Text = "Skapa ny lagerförd hatt";
            // 
            // tbxMaterialkostnad
            // 
            tbxMaterialkostnad.Location = new Point(169, 210);
            tbxMaterialkostnad.Name = "tbxMaterialkostnad";
            tbxMaterialkostnad.Size = new Size(294, 26);
            tbxMaterialkostnad.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 213);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 56;
            label3.Text = "Materialkostnad:";
            // 
            // LäggTillHatt
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(517, 377);
            Controls.Add(tbxMaterialkostnad);
            Controls.Add(label3);
            Controls.Add(label19);
            Controls.Add(tbxPris);
            Controls.Add(label2);
            Controls.Add(tbxNamn);
            Controls.Add(label1);
            Controls.Add(btnAvbryt);
            Controls.Add(btnLäggTillHatt);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LäggTillHatt";
            Text = "LäggTillHatt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvbryt;
        private Button btnLäggTillHatt;
        private Label label1;
        private TextBox tbxNamn;
        private TextBox tbxPris;
        private Label label2;
        private Label label19;
        private TextBox tbxMaterialkostnad;
        private Label label3;
    }
}