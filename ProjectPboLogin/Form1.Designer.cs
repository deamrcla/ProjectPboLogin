namespace ProjectPboLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            bigTextBox2 = new ReaLTaiizor.Controls.BigTextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mask_group;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 266);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Font = new Font("Nunito", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox1.ForeColor = Color.DimGray;
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(120, 368);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(405, 46);
            bigTextBox1.TabIndex = 1;
            bigTextBox1.Text = "Username/Email/No.Telepon";
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            // 
            // bigTextBox2
            // 
            bigTextBox2.BackColor = Color.Transparent;
            bigTextBox2.Font = new Font("Nunito", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox2.ForeColor = Color.DimGray;
            bigTextBox2.Image = null;
            bigTextBox2.Location = new Point(120, 454);
            bigTextBox2.MaxLength = 32767;
            bigTextBox2.Multiline = false;
            bigTextBox2.Name = "bigTextBox2";
            bigTextBox2.ReadOnly = false;
            bigTextBox2.Size = new Size(405, 46);
            bigTextBox2.TabIndex = 2;
            bigTextBox2.Text = "Password";
            bigTextBox2.TextAlignment = HorizontalAlignment.Left;
            bigTextBox2.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(148, 569);
            button1.Name = "button1";
            button1.Size = new Size(336, 57);
            button1.TabIndex = 3;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(147, 647);
            button2.Name = "button2";
            button2.Size = new Size(337, 57);
            button2.TabIndex = 4;
            button2.Text = "Masuk Sebagai Admin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 827);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 5;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(0, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(0, 57);
            bigLabel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(242, 902);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 7;
            label1.Text = "Belum Punya Akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(287, 922);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(51, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daftar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Group_237532;
            pictureBox2.Location = new Point(509, 902);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 40);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Group;
            pictureBox3.Location = new Point(1137, 328);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(320, 210);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat ExtraBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(1209, 541);
            label2.Name = "label2";
            label2.Size = new Size(186, 46);
            label2.TabIndex = 11;
            label2.Text = "EZBRARY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(1163, 587);
            label3.Name = "label3";
            label3.Size = new Size(264, 39);
            label3.TabIndex = 12;
            label3.Text = "PERPUSTAKAAN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(bigLabel1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bigTextBox2);
            Controls.Add(bigTextBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
    }
}
