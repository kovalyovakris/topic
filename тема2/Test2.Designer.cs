using static тема_1.Form1;
using static тема2.MainWindow;

namespace тема_1
{
    partial class Test2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test2));
			label1 = new Label();
			Button1 = new Button();
			label3 = new Label();
			groupBox1 = new RoundedGroupBox();
			radioButton4 = new RadioButton();
			button2 = new RoundButton();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			button3 = new Button();
			pictureBox1 = new PictureBox();
			roundedPanel9 = new RoundedPanel();
			roundedPanel8 = new RoundedPanel();
			roundedPanel7 = new RoundedPanel();
			roundedPanel6 = new RoundedPanel();
			roundedPanel5 = new RoundedPanel();
			roundedPanel4 = new RoundedPanel();
			roundedPanel3 = new RoundedPanel();
			roundedPanel2 = new RoundedPanel();
			roundedPanel1 = new RoundedPanel();
			roundedPanel10 = new RoundedPanel();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 12F);
			label1.Location = new Point(475, 52);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(809, 36);
			label1.TabIndex = 1;
			label1.Text = "Тест №2: делегирование полномочий и принятие решений";
			// 
			// Button1
			// 
			Button1.Location = new Point(726, 290);
			Button1.Margin = new Padding(5);
			Button1.Name = "Button1";
			Button1.Size = new Size(314, 74);
			Button1.TabIndex = 3;
			Button1.Text = "Начать тест 2";
			Button1.UseVisualStyleBackColor = true;
			Button1.Click += Button1_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Times New Roman", 13.875F);
			label3.ForeColor = Color.FromArgb(64, 64, 64);
			label3.Location = new Point(47, 112);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(973, 42);
			label3.TabIndex = 4;
			label3.Text = "Продолжаете ли Вы работать после окончания рабочего дня?";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(roundedPanel9);
			groupBox1.Controls.Add(roundedPanel8);
			groupBox1.Controls.Add(roundedPanel7);
			groupBox1.Controls.Add(roundedPanel6);
			groupBox1.Controls.Add(roundedPanel5);
			groupBox1.Controls.Add(roundedPanel4);
			groupBox1.Controls.Add(roundedPanel3);
			groupBox1.Controls.Add(roundedPanel2);
			groupBox1.Controls.Add(roundedPanel1);
			groupBox1.Controls.Add(roundedPanel10);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(radioButton4);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.CornerRadius = 60;
			groupBox1.Location = new Point(300, 163);
			groupBox1.Margin = new Padding(5);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(5);
			groupBox1.Size = new Size(1160, 647);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.BackColor = Color.Transparent;
			radioButton4.Font = new Font("Times New Roman", 16.125F);
			radioButton4.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton4.Location = new Point(47, 392);
			radioButton4.Margin = new Padding(5);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(121, 53);
			radioButton4.TabIndex = 3;
			radioButton4.TabStop = true;
			radioButton4.Text = "Нет";
			radioButton4.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.YellowGreen;
			button2.Font = new Font("Times New Roman", 13.875F);
			button2.ForeColor = Color.FromArgb(64, 64, 64);
			button2.Location = new Point(758, 493);
			button2.Margin = new Padding(5);
			button2.Name = "button2";
			button2.Size = new Size(336, 98);
			button2.TabIndex = 6;
			button2.Text = "Вперед";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.BackColor = Color.Transparent;
			radioButton3.Font = new Font("Times New Roman", 16.125F);
			radioButton3.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton3.Location = new Point(47, 331);
			radioButton3.Margin = new Padding(5);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(121, 53);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "Нет";
			radioButton3.UseVisualStyleBackColor = false;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.BackColor = Color.Transparent;
			radioButton2.Font = new Font("Times New Roman", 16.125F);
			radioButton2.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton2.Location = new Point(47, 270);
			radioButton2.Margin = new Padding(5);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(121, 53);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "Нет";
			radioButton2.UseVisualStyleBackColor = false;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.BackColor = Color.Transparent;
			radioButton1.Font = new Font("Times New Roman", 16.125F);
			radioButton1.ForeColor = Color.FromArgb(64, 64, 64);
			radioButton1.Location = new Point(47, 210);
			radioButton1.Margin = new Padding(5);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(101, 53);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "Да";
			radioButton1.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			button3.Location = new Point(730, 851);
			button3.Margin = new Padding(5);
			button3.Name = "button3";
			button3.Size = new Size(322, 74);
			button3.TabIndex = 7;
			button3.Text = "Перейти к тесту 3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
			pictureBox1.Location = new Point(21, 24);
			pictureBox1.Margin = new Padding(5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(63, 64);
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// roundedPanel9
			// 
			roundedPanel9.BackColor = Color.Silver;
			roundedPanel9.CornerRadius = 20;
			roundedPanel9.ForeColor = SystemColors.AppWorkspace;
			roundedPanel9.Location = new Point(913, 67);
			roundedPanel9.Name = "roundedPanel9";
			roundedPanel9.Size = new Size(80, 20);
			roundedPanel9.TabIndex = 25;
			// 
			// roundedPanel8
			// 
			roundedPanel8.BackColor = Color.Silver;
			roundedPanel8.CornerRadius = 20;
			roundedPanel8.ForeColor = SystemColors.AppWorkspace;
			roundedPanel8.Location = new Point(818, 67);
			roundedPanel8.Name = "roundedPanel8";
			roundedPanel8.Size = new Size(80, 20);
			roundedPanel8.TabIndex = 24;
			// 
			// roundedPanel7
			// 
			roundedPanel7.BackColor = Color.Silver;
			roundedPanel7.CornerRadius = 20;
			roundedPanel7.ForeColor = SystemColors.AppWorkspace;
			roundedPanel7.Location = new Point(723, 67);
			roundedPanel7.Name = "roundedPanel7";
			roundedPanel7.Size = new Size(80, 20);
			roundedPanel7.TabIndex = 23;
			// 
			// roundedPanel6
			// 
			roundedPanel6.BackColor = Color.Silver;
			roundedPanel6.CornerRadius = 20;
			roundedPanel6.ForeColor = SystemColors.AppWorkspace;
			roundedPanel6.Location = new Point(628, 67);
			roundedPanel6.Name = "roundedPanel6";
			roundedPanel6.Size = new Size(80, 20);
			roundedPanel6.TabIndex = 22;
			// 
			// roundedPanel5
			// 
			roundedPanel5.BackColor = Color.Silver;
			roundedPanel5.CornerRadius = 20;
			roundedPanel5.ForeColor = SystemColors.AppWorkspace;
			roundedPanel5.Location = new Point(533, 67);
			roundedPanel5.Name = "roundedPanel5";
			roundedPanel5.Size = new Size(80, 20);
			roundedPanel5.TabIndex = 21;
			// 
			// roundedPanel4
			// 
			roundedPanel4.BackColor = Color.Silver;
			roundedPanel4.CornerRadius = 20;
			roundedPanel4.ForeColor = SystemColors.AppWorkspace;
			roundedPanel4.Location = new Point(438, 67);
			roundedPanel4.Name = "roundedPanel4";
			roundedPanel4.Size = new Size(80, 20);
			roundedPanel4.TabIndex = 20;
			// 
			// roundedPanel3
			// 
			roundedPanel3.BackColor = Color.Silver;
			roundedPanel3.CornerRadius = 20;
			roundedPanel3.ForeColor = SystemColors.AppWorkspace;
			roundedPanel3.Location = new Point(343, 67);
			roundedPanel3.Name = "roundedPanel3";
			roundedPanel3.Size = new Size(80, 20);
			roundedPanel3.TabIndex = 19;
			// 
			// roundedPanel2
			// 
			roundedPanel2.BackColor = Color.Silver;
			roundedPanel2.CornerRadius = 20;
			roundedPanel2.ForeColor = SystemColors.AppWorkspace;
			roundedPanel2.Location = new Point(248, 67);
			roundedPanel2.Name = "roundedPanel2";
			roundedPanel2.Size = new Size(80, 20);
			roundedPanel2.TabIndex = 18;
			// 
			// roundedPanel1
			// 
			roundedPanel1.BackColor = Color.Silver;
			roundedPanel1.CornerRadius = 20;
			roundedPanel1.ForeColor = SystemColors.AppWorkspace;
			roundedPanel1.Location = new Point(153, 67);
			roundedPanel1.Name = "roundedPanel1";
			roundedPanel1.Size = new Size(80, 20);
			roundedPanel1.TabIndex = 17;
			// 
			// roundedPanel10
			// 
			roundedPanel10.BackColor = Color.Silver;
			roundedPanel10.CornerRadius = 20;
			roundedPanel10.ForeColor = SystemColors.AppWorkspace;
			roundedPanel10.Location = new Point(58, 67);
			roundedPanel10.Name = "roundedPanel10";
			roundedPanel10.Size = new Size(80, 20);
			roundedPanel10.TabIndex = 16;
			// 
			// Test2
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1734, 1072);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(groupBox1);
			Controls.Add(Button1);
			Controls.Add(label1);
			DoubleBuffered = true;
			Margin = new Padding(5);
			Name = "Test2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Test2";
			Load += Test2_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Button Button1;
        private Label label3;
        private RoundedGroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RoundButton button2;
        private Button button3;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private PictureBox pictureBox1;
		private RoundedPanel roundedPanel9;
		private RoundedPanel roundedPanel8;
		private RoundedPanel roundedPanel7;
		private RoundedPanel roundedPanel6;
		private RoundedPanel roundedPanel5;
		private RoundedPanel roundedPanel4;
		private RoundedPanel roundedPanel3;
		private RoundedPanel roundedPanel2;
		private RoundedPanel roundedPanel1;
		private RoundedPanel roundedPanel10;
	}
}