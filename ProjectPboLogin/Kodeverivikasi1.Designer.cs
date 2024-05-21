namespace ProjectPboLogin
{
    partial class Kodeverivikasi1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mask_group__1_;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 266);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 443);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 1;
            label1.Text = "Kode Verifikasi";
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Font = new Font("Nunito", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox1.ForeColor = Color.DimGray;
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(142, 493);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(302, 48);
            bigTextBox1.TabIndex = 2;
            bigTextBox1.Text = "Type the above word...";
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            bigTextBox1.TextChanged += bigTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Nunito", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(220, 662);
            button1.Name = "button1";
            button1.Size = new Size(143, 53);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Group;
            pictureBox2.Location = new Point(1137, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 210);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat ExtraBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(1204, 541);
            label2.Name = "label2";
            label2.Size = new Size(196, 46);
            label2.TabIndex = 5;
            label2.Text = "EZBRARY ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(1165, 587);
            label3.Name = "label3";
            label3.Size = new Size(264, 39);
            label3.TabIndex = 6;
            label3.Text = "PERPUSTAKAAN";
            // 
            // Kodeverivikasi1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(bigTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kodeverivikasi1";
            Text = "Kodeverivikasi1";
            Load += Kodeverivikasi1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}