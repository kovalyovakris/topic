using тема2;

namespace тема_1
{
	public partial class Form1 : Form
	{
		private int n = 0;
		private int points = 0;
		private String[] questions = new string[10] {
				"Продолжаете ли Вы работать после окончания рабочего дня?",
				"Трудитесь ли Вы дольше своих сотрудников?",
				"Часто ли Вы выполняете работу, с которой вполне могли бы\n" +
				"справиться и без Вашего участия?",
				"Продолжаете ли Вы занимаетесь проблемами из той сферы\n" +
				"деятельности, которую уже делегировали подчиненным?\n",
				"Расходуете ли Вы время на рутинную работу, которую могут\n" +
				"сделать другие?",
				"Часто ли к Вам обращаются по поводу задач, не выполненных\n" +
				"Вашими подчиненными?",
				"Стремитесь ли Вы к тому, чтобы быть в курсе всех дел и иметь\n" +
				"информацию обо всем?",
				"Стоит ли Вам больших усилий придерживаться списка \n" +
				"последовательности выполнения приоритетных работ?",
				"Удается ли Вам найти, в случае необходимости, подчиненного,\n" +
				"который помог бы Вам?",
				"Хватает ли Вам времени на планирование?"
		};

		private RoundedPanel[] progressPanels;

		public Form1()
		{
			InitializeComponent();
			label3.Hide();
			groupBox1.Hide();
			button2.Hide();
			button3.Hide();
			progressPanels = new RoundedPanel[]
			{
				roundedPanel10, roundedPanel1, roundedPanel2, roundedPanel3, roundedPanel4,
				roundedPanel5, roundedPanel6, roundedPanel7, roundedPanel8,
				roundedPanel9
			};

			UpdatePanelColors();
		}

		private void UpdatePanelColors()
		{
			for (int i = 0; i < progressPanels.Length; i++)
			{
				if (i < n)
				{
					progressPanels[i].BackColor = Color.DimGray;
				}
				else
				{
					progressPanels[i].BackColor = Color.Silver;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label2.Text = (n + 1).ToString() + "/10";
			button1.Hide();
			label3.Visible = true;
			label3.Text = questions[n];
			groupBox1.Visible = true;
			button2.Visible = true;
			n++;
		}
		private void ShowAnswer(int p)
		{
			label2.Hide();
			groupBox1.Hide();
			button2.Hide();
			if (points < 6)
			{
				label3.Text = $"Ваш результат: {points} баллов\n" +
				"Похоже, что делегирование полномочий и ответственности\n" +
				"представляет для Вас серьезную проблему.\n" +
				"Пересмотрите задания, которые вы поручаете своим подчиненным\n" +
				"Присмотритесь внимательнее к своим подчиненным,\n" + "изучите получше их способности и опыт.\n" +
				"Задумайтесь о своем отношении к делегированию полномочий.\n" + "Вполне может быть, что Вы еще сомневаетесь в том,\n" + "что Ваши работники могут справиться\n" + "с порученной работой не хуже Вас, или даже лучше";
			}
			else if (points > 5)
			{
				label3.Text = $"Ваш результат: {points} баллов\n" +
				"Поздравляем! Вы не имеете проблем с делегированием\n" + "полномочий и ответственности.";
			}
			button3.Visible = true;
		}

		private void NextQuestion(int num)
		{
			if (num < 10)
			{
				label2.Text = (n + 1).ToString() + "/10";
				label3.Text = questions[n];
				UpdatePanelColors();
			}
			if (num == 10)
				ShowAnswer(points);
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			n++;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!radioButton1.Checked && !radioButton2.Checked)
			{
				MessageBox.Show("Выберите вариант 'да' или 'нет'");
				return;
			}
			if (radioButton1.Checked)
			{
				if (label3.Text == questions[8] || label3.Text == questions[9])
				{
					points++;
				}
				NextQuestion(n);
			}
			else if (radioButton2.Checked)
			{
				if (label3.Text != questions[8] && label3.Text != questions[9])
				{
					points++;
				}
				NextQuestion(n);
			}
		}


		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Test2 test2 = new Test2();
			test2.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainWindow main = new MainWindow();
			main.Show();
		}




		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

	}
}