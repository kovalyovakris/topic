using static тема_1.Form1;
using static тема2.MainWindow;

namespace тема2
{
    partial class Topic5Test2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topic5Test2));
			pictureBox1 = new PictureBox();
			button3 = new RoundButton();
			button2 = new RoundButton();
			groupBox1 = new RoundedGroupBox();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			label3 = new Label();
			Button1 = new RoundButton();
			label2 = new Label();
			label1 = new Label();
			roundedPanel1 = new RoundedPanel();
			roundedPanel9 = new RoundedPanel();
			roundedPanel8 = new RoundedPanel();
			roundedPanel7 = new RoundedPanel();
			roundedPanel6 = new RoundedPanel();
			roundedPanel5 = new RoundedPanel();
			roundedPanel10 = new RoundedPanel();
			roundedPanel3 = new RoundedPanel();
			roundedPanel4 = new RoundedPanel();
			roundedPanel2 = new RoundedPanel();
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
			pictureBox1.Margin = new Padding(5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(63, 64);
			pictureBox1.TabIndex = 36;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.YellowGreen;
			button3.Font = new Font("Times New Roman", 13.875F);
			button3.ForeColor = Color.FromArgb(64, 64, 64);
			button3.Location = new Point(733, 848);
			button3.Margin = new Padding(5);
			button3.Name = "button3";
			button3.Size = new Size(385, 98);
			button3.TabIndex = 35;
			button3.Text = "Перейти к тесту №3";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.YellowGreen;
			button2.Font = new Font("Times New Roman", 13.875F);
			button2.ForeColor = Color.FromArgb(64, 64, 64);
			button2.Location = new Point(783, 498);
			button2.Margin = new Padding(5);
			button2.Name = "button2";
			button2.Size = new Size(362, 116);
			button2.TabIndex = 34;
			button2.Text = "Вперед";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(roundedPanel1);
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(roundedPanel9);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(roundedPanel8);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(roundedPanel7);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Controls.Add(roundedPanel6);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(roundedPanel5);
			groupBox1.Controls.Add(roundedPanel10);
			groupBox1.Controls.Add(roundedPanel2);
			groupBox1.Controls.Add(roundedPanel3);
			groupBox1.Controls.Add(roundedPanel4);
			groupBox1.CornerRadius = 60;
			groupBox1.Location = new Point(301, 163);
			groupBox1.Margin = new Padding(5);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(5);
			groupBox1.Size = new Size(1186, 646);
			groupBox1.TabIndex = 33;
			groupBox1.TabStop = false;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.BackColor = Color.Transparent;
			radioButton3.Font = new Font("Times New Roman", 13.875F);
			radioButton3.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton3.Location = new Point(58, 409);
			radioButton3.Margin = new Padding(5);
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
			radioButton2.Margin = new Padding(5);
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
			radioButton1.Margin = new Padding(5);
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
			label3.TabIndex = 32;
			label3.Text = "Продолжаете ли Вы работать после окончания рабочего дня?";
			// 
			// Button1
			// 
			Button1.BackColor = Color.YellowGreen;
			Button1.Font = new Font("Times New Roman", 13.875F);
			Button1.ForeColor = Color.FromArgb(64, 64, 64);
			Button1.Location = new Point(733, 317);
			Button1.Margin = new Padding(5);
			Button1.Name = "Button1";
			Button1.Size = new Size(385, 98);
			Button1.TabIndex = 31;
			Button1.Text = "Начать тест №2";
			Button1.UseVisualStyleBackColor = false;
			Button1.Click += Button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(796, 187);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(0, 36);
			label2.TabIndex = 30;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 16.125F);
			label1.ForeColor = Color.FromArgb(64, 64, 64);
			label1.Location = new Point(318, 46);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(1123, 49);
			label1.TabIndex = 29;
			label1.Text = "Тест№2: cистемы компенсации и стимулирования персонала";
			// 
			// roundedPanel1
			// 
			roundedPanel1.BackColor = Color.Silver;
			roundedPanel1.CornerRadius = 20;
			roundedPanel1.ForeColor = SystemColors.AppWorkspace;
			roundedPanel1.Location = new Point(153, 67);
			roundedPanel1.Name = "roundedPanel1";
			roundedPanel1.Size = new Size(80, 19);
			roundedPanel1.TabIndex = 57;
			// 
			// roundedPanel9
			// 
			roundedPanel9.BackColor = Color.Silver;
			roundedPanel9.CornerRadius = 20;
			roundedPanel9.ForeColor = SystemColors.AppWorkspace;
			roundedPanel9.Location = new Point(913, 67);
			roundedPanel9.Name = "roundedPanel9";
			roundedPanel9.Size = new Size(80, 19);
			roundedPanel9.TabIndex = 65;
			// 
			// roundedPanel8
			// 
			roundedPanel8.BackColor = Color.Silver;
			roundedPanel8.CornerRadius = 20;
			roundedPanel8.ForeColor = SystemColors.AppWorkspace;
			roundedPanel8.Location = new Point(817, 67);
			roundedPanel8.Name = "roundedPanel8";
			roundedPanel8.Size = new Size(80, 19);
			roundedPanel8.TabIndex = 64;
			// 
			// roundedPanel7
			// 
			roundedPanel7.BackColor = Color.Silver;
			roundedPanel7.CornerRadius = 20;
			roundedPanel7.ForeColor = SystemColors.AppWorkspace;
			roundedPanel7.Location = new Point(723, 67);
			roundedPanel7.Name = "roundedPanel7";
			roundedPanel7.Size = new Size(80, 19);
			roundedPanel7.TabIndex = 63;
			// 
			// roundedPanel6
			// 
			roundedPanel6.BackColor = Color.Silver;
			roundedPanel6.CornerRadius = 20;
			roundedPanel6.ForeColor = SystemColors.AppWorkspace;
			roundedPanel6.Location = new Point(627, 67);
			roundedPanel6.Name = "roundedPanel6";
			roundedPanel6.Size = new Size(80, 19);
			roundedPanel6.TabIndex = 62;
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
			roundedPanel5.TabIndex = 61;
			// 
			// roundedPanel10
			// 
			roundedPanel10.BackColor = Color.Silver;
			roundedPanel10.CornerRadius = 20;
			roundedPanel10.ForeColor = SystemColors.AppWorkspace;
			roundedPanel10.Location = new Point(58, 67);
			roundedPanel10.Name = "roundedPanel10";
			roundedPanel10.Size = new Size(80, 19);
			roundedPanel10.TabIndex = 56;
			// 
			// roundedPanel3
			// 
			roundedPanel3.BackColor = Color.Silver;
			roundedPanel3.CornerRadius = 20;
			roundedPanel3.ForeColor = SystemColors.AppWorkspace;
			roundedPanel3.Location = new Point(343, 67);
			roundedPanel3.Name = "roundedPanel3";
			roundedPanel3.Size = new Size(80, 19);
			roundedPanel3.TabIndex = 59;
			// 
			// roundedPanel4
			// 
			roundedPanel4.BackColor = Color.Silver;
			roundedPanel4.CornerRadius = 20;
			roundedPanel4.ForeColor = SystemColors.AppWorkspace;
			roundedPanel4.Location = new Point(439, 67);
			roundedPanel4.Name = "roundedPanel4";
			roundedPanel4.Size = new Size(80, 19);
			roundedPanel4.TabIndex = 60;
			// 
			// roundedPanel2
			// 
			roundedPanel2.BackColor = Color.Silver;
			roundedPanel2.CornerRadius = 20;
			roundedPanel2.ForeColor = SystemColors.AppWorkspace;
			roundedPanel2.Location = new Point(249, 67);
			roundedPanel2.Name = "roundedPanel2";
			roundedPanel2.Size = new Size(80, 19);
			roundedPanel2.TabIndex = 58;
			// 
			// Topic5Test2
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1734, 1072);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(groupBox1);
			Controls.Add(Button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(5);
			Name = "Topic5Test2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Системы компенсации и стимулирования персонала";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox1;
        private RoundButton button3;
        private RoundButton button2;
        private RoundedGroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private RoundButton Button1;
        private Label label2;
        private Label label1;
		private RoundedPanel roundedPanel1;
		private RoundedPanel roundedPanel9;
		private RoundedPanel roundedPanel8;
		private RoundedPanel roundedPanel7;
		private RoundedPanel roundedPanel6;
		private RoundedPanel roundedPanel5;
		private RoundedPanel roundedPanel10;
		private RoundedPanel roundedPanel2;
		private RoundedPanel roundedPanel3;
		private RoundedPanel roundedPanel4;
	}
}