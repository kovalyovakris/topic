using static тема_1.Form1;
using static тема2.MainWindow;

namespace тема2
{
    partial class Topic6Test3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topic6Test3));
			pictureBox1 = new PictureBox();
			button2 = new RoundButton();
			groupBox1 = new RoundedGroupBox();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			label3 = new Label();
			Button1 = new RoundButton();
			label2 = new Label();
			label1 = new Label();
			roundedPanel1 = new тема_1.Form1.RoundedPanel();
			roundedPanel9 = new тема_1.Form1.RoundedPanel();
			roundedPanel8 = new тема_1.Form1.RoundedPanel();
			roundedPanel7 = new тема_1.Form1.RoundedPanel();
			roundedPanel6 = new тема_1.Form1.RoundedPanel();
			roundedPanel5 = new тема_1.Form1.RoundedPanel();
			roundedPanel10 = new тема_1.Form1.RoundedPanel();
			roundedPanel2 = new тема_1.Form1.RoundedPanel();
			roundedPanel3 = new тема_1.Form1.RoundedPanel();
			roundedPanel4 = new тема_1.Form1.RoundedPanel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(20, 19);
			pictureBox1.Margin = new Padding(5, 5, 5, 5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(63, 64);
			pictureBox1.TabIndex = 54;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.YellowGreen;
			button2.Font = new Font("Times New Roman", 13.875F);
			button2.ForeColor = Color.FromArgb(64, 64, 64);
			button2.Location = new Point(783, 528);
			button2.Margin = new Padding(5, 5, 5, 5);
			button2.Name = "button2";
			button2.Size = new Size(363, 98);
			button2.TabIndex = 53;
			button2.Text = "Вперед";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(roundedPanel1);
			groupBox1.Controls.Add(roundedPanel9);
			groupBox1.Controls.Add(roundedPanel8);
			groupBox1.Controls.Add(roundedPanel7);
			groupBox1.Controls.Add(roundedPanel6);
			groupBox1.Controls.Add(roundedPanel5);
			groupBox1.Controls.Add(roundedPanel10);
			groupBox1.Controls.Add(roundedPanel2);
			groupBox1.Controls.Add(roundedPanel3);
			groupBox1.Controls.Add(roundedPanel4);
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Location = new Point(301, 163);
			groupBox1.Margin = new Padding(5, 5, 5, 5);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(5, 5, 5, 5);
			groupBox1.Size = new Size(1186, 646);
			groupBox1.TabIndex = 52;
			groupBox1.TabStop = false;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.BackColor = Color.Transparent;
			radioButton3.Font = new Font("Times New Roman", 13.875F);
			radioButton3.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton3.Location = new Point(58, 409);
			radioButton3.Margin = new Padding(5, 5, 5, 5);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(108, 46);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "Нет";
			radioButton3.UseVisualStyleBackColor = false;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.BackColor = Color.Transparent;
			radioButton2.Font = new Font("Times New Roman", 13.875F);
			radioButton2.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton2.Location = new Point(58, 320);
			radioButton2.Margin = new Padding(5, 5, 5, 5);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(108, 46);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "Нет";
			radioButton2.UseVisualStyleBackColor = false;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.BackColor = Color.Transparent;
			radioButton1.Font = new Font("Times New Roman", 13.875F);
			radioButton1.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton1.Location = new Point(58, 231);
			radioButton1.Margin = new Padding(5, 5, 5, 5);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(90, 46);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "Да";
			radioButton1.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Times New Roman", 13.875F);
			label3.ForeColor = Color.FromArgb(64, 64, 64);
			label3.Location = new Point(47, 112);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(973, 42);
			label3.TabIndex = 51;
			label3.Text = "Продолжаете ли Вы работать после окончания рабочего дня?";
			// 
			// Button1
			// 
			Button1.BackColor = Color.YellowGreen;
			Button1.Font = new Font("Times New Roman", 13.875F);
			Button1.ForeColor = Color.FromArgb(64, 64, 64);
			Button1.Location = new Point(733, 317);
			Button1.Margin = new Padding(5, 5, 5, 5);
			Button1.Name = "Button1";
			Button1.Size = new Size(363, 98);
			Button1.TabIndex = 50;
			Button1.Text = "Начать тест 3";
			Button1.UseVisualStyleBackColor = false;
			Button1.Click += Button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(804, 203);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(0, 36);
			label2.TabIndex = 49;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 16.125F);
			label1.ForeColor = Color.FromArgb(64, 64, 64);
			label1.Location = new Point(419, 46);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(922, 49);
			label1.TabIndex = 48;
			label1.Text = "Тест№3: управление проблемными сотрудниками";
			// 
			// roundedPanel1
			// 
			roundedPanel1.BackColor = Color.Silver;
			roundedPanel1.CornerRadius = 20;
			roundedPanel1.ForeColor = SystemColors.AppWorkspace;
			roundedPanel1.Location = new Point(153, 67);
			roundedPanel1.Name = "roundedPanel1";
			roundedPanel1.Size = new Size(80, 19);
			roundedPanel1.TabIndex = 67;
			// 
			// roundedPanel9
			// 
			roundedPanel9.BackColor = Color.Silver;
			roundedPanel9.CornerRadius = 20;
			roundedPanel9.ForeColor = SystemColors.AppWorkspace;
			roundedPanel9.Location = new Point(913, 67);
			roundedPanel9.Name = "roundedPanel9";
			roundedPanel9.Size = new Size(80, 19);
			roundedPanel9.TabIndex = 75;
			// 
			// roundedPanel8
			// 
			roundedPanel8.BackColor = Color.Silver;
			roundedPanel8.CornerRadius = 20;
			roundedPanel8.ForeColor = SystemColors.AppWorkspace;
			roundedPanel8.Location = new Point(817, 67);
			roundedPanel8.Name = "roundedPanel8";
			roundedPanel8.Size = new Size(80, 19);
			roundedPanel8.TabIndex = 74;
			// 
			// roundedPanel7
			// 
			roundedPanel7.BackColor = Color.Silver;
			roundedPanel7.CornerRadius = 20;
			roundedPanel7.ForeColor = SystemColors.AppWorkspace;
			roundedPanel7.Location = new Point(723, 67);
			roundedPanel7.Name = "roundedPanel7";
			roundedPanel7.Size = new Size(80, 19);
			roundedPanel7.TabIndex = 73;
			// 
			// roundedPanel6
			// 
			roundedPanel6.BackColor = Color.Silver;
			roundedPanel6.CornerRadius = 20;
			roundedPanel6.ForeColor = SystemColors.AppWorkspace;
			roundedPanel6.Location = new Point(627, 67);
			roundedPanel6.Name = "roundedPanel6";
			roundedPanel6.Size = new Size(80, 19);
			roundedPanel6.TabIndex = 72;
			// 
			// roundedPanel5
			// 
			roundedPanel5.BackColor = Color.Silver;
			roundedPanel5.CornerRadius = 20;
			roundedPanel5.ForeColor = SystemColors.AppWorkspace;
			roundedPanel5.ImeMode = ImeMode.NoControl;
			roundedPanel5.Location = new Point(533, 67);
			roundedPanel5.Name = "roundedPanel5";
			roundedPanel5.Size = new Size(80, 19);
			roundedPanel5.TabIndex = 71;
			// 
			// roundedPanel10
			// 
			roundedPanel10.BackColor = Color.Silver;
			roundedPanel10.CornerRadius = 20;
			roundedPanel10.ForeColor = SystemColors.AppWorkspace;
			roundedPanel10.Location = new Point(58, 67);
			roundedPanel10.Name = "roundedPanel10";
			roundedPanel10.Size = new Size(80, 19);
			roundedPanel10.TabIndex = 66;
			// 
			// roundedPanel2
			// 
			roundedPanel2.BackColor = Color.Silver;
			roundedPanel2.CornerRadius = 20;
			roundedPanel2.ForeColor = SystemColors.AppWorkspace;
			roundedPanel2.Location = new Point(249, 67);
			roundedPanel2.Name = "roundedPanel2";
			roundedPanel2.Size = new Size(80, 19);
			roundedPanel2.TabIndex = 68;
			// 
			// roundedPanel3
			// 
			roundedPanel3.BackColor = Color.Silver;
			roundedPanel3.CornerRadius = 20;
			roundedPanel3.ForeColor = SystemColors.AppWorkspace;
			roundedPanel3.Location = new Point(343, 67);
			roundedPanel3.Name = "roundedPanel3";
			roundedPanel3.Size = new Size(80, 19);
			roundedPanel3.TabIndex = 69;
			// 
			// roundedPanel4
			// 
			roundedPanel4.BackColor = Color.Silver;
			roundedPanel4.CornerRadius = 20;
			roundedPanel4.ForeColor = SystemColors.AppWorkspace;
			roundedPanel4.Location = new Point(439, 67);
			roundedPanel4.Name = "roundedPanel4";
			roundedPanel4.Size = new Size(80, 19);
			roundedPanel4.TabIndex = 70;
			// 
			// Topic6Test3
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1734, 1054);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox1);
			Controls.Add(Button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(5, 5, 5, 5);
			Name = "Topic6Test3";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Управление проблемными сотрудниками";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox1;
        private RoundButton button2;
        private RoundedGroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private RoundButton Button1;
        private Label label2;
        private Label label1;
		private тема_1.Form1.RoundedPanel roundedPanel1;
		private тема_1.Form1.RoundedPanel roundedPanel9;
		private тема_1.Form1.RoundedPanel roundedPanel8;
		private тема_1.Form1.RoundedPanel roundedPanel7;
		private тема_1.Form1.RoundedPanel roundedPanel6;
		private тема_1.Form1.RoundedPanel roundedPanel5;
		private тема_1.Form1.RoundedPanel roundedPanel10;
		private тема_1.Form1.RoundedPanel roundedPanel2;
		private тема_1.Form1.RoundedPanel roundedPanel3;
		private тема_1.Form1.RoundedPanel roundedPanel4;
	}
}