using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using тема2;
using static тема_1.Form1;

namespace тема_1
{
	public partial class Test2 : Form
	{
		private int n = 0;
		private int points = 0;
		private String[] questions = new string[10] {
				"Как Вы обычно реагируете на задачи, требующие делегирования?",
				"Как Вы принимаете решения в вашей работе?",
				"Как Вы относитесь к идеи, что ваши подчинённые могут\n"+"важные задачи?",
				"Как Вы реагируете, если ваши решения вызывают критику?",
				"Как Вы отзываете свои делегированные задачи?",
				"Как Вы выбираете, кому делегировать задание?",
				"Как Вы воспринимаете свою роль как руководителя в вопросах\n"+"делегирования?",
				"Как часто Вы анализируете результаты принятых решений?",
				"Как Вы относитесь к предложениям команды в процессе\n"+"принятия решений?",
				"Как Вы реагируете на ошибки, допущенные подчинёнными?"};
		private String[] answer1 = new string[10] {
			"Я предпочитаю делать все сам ",
			"Опираюсь только на собственный опыт ",
			"Я сомневаюсь в их способности",
			"Игнорирую критику",
			"Проверяю только в конце",
			"Опираюсь на личные симпатии",
			"Я единственный, кто несет ответственность",
			"Не делаю этого",
			"Считаю, что такое не нужно",
			"Вижу это как повод для критики",
		};
		private String[] answer2 = new string[10] {
			"Делаю, но чувствую себя неуверенно",
			"Учитываю мнения нескольких коллег",
			"Иногда позволяю, но контролирую каждое действие",
			"Анализирую, но не принимаю во внимание мнения других ",
			"Проверяю иногда",
			"Выбираю только тех, кто меньше загружен",
			"Я контролирую, но иногда позволяю другим участвовать",
			"Редко, только если что-то пошло не так",
			"Прислушиваюсь, но редко пользуюсь их мнением",
			"Приложу усилия, чтобы исправить их",
		};
		private String[] answer3 = new string[10] {
			"Делаю, если доверяю кому-то",
			"Применяю систематический подход и анализ данных",
			"Доверяю, но остаюсь на связи",
			"Слушаю критику и готов обсудить  ",
			"Проверяю регулярно, но без излишнего контроля ",
			"Оцениваю навыки и опыт ",
			"Я делегирую и обучаю своих сотрудников",
			"Обычно делаю это, чтобы учиться на опыте",
			"Учитываю, если они мне нравятся ",
			"Обсуждаю ошибки и вывожу уроки",
		};
		private String[] answer4 = new string[10] {
			"Открыт к делегированию и чувствую себя комфортно",
			"Обсуждаю с командой и принимаю решение вместе ",
			"Полностью доверяю и поддерживаю их инициативу",
			"Использую критику как возможность для улучшения",
			"Поддерживаю открытость и общение в процессе выполнения",
			"Учитываю сильные стороны команды и их интересы",
			"Я считаю, что роль руководителя - это поддержка и развитие команды",// переформулировать до норм длины
			"Всегда, чтобы постоянно улучшать процесс",
			"Всегда обсуждаю и включаю в процесс",
			"Воспринимаю ошибки как часть обучения",
		};

		private RoundedPanel[] progressPanels;
		public Test2()
		{
			InitializeComponent();
			label2.Hide();
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

		private void Button1_Click(object sender, EventArgs e)
		{

			Button1.Hide();
			label2.Visible = true;
			label2.Text = questions[n];
			radioButton5.Text = answer1[n];
			radioButton6.Text = answer2[n];
			radioButton7.Text = answer3[n];
			radioButton8.Text = answer4[n];
			groupBox1.Visible = true;
			button2.Visible = true;
			n++;
		}
		private void ShowAnswer(int p)
		{
            radioButton5.Hide();
            radioButton6.Hide();
			radioButton7.Hide();
			radioButton8.Hide();
            roundButton2.Hide();
            for (int i = 0; i < progressPanels.Length; i++)
            {
                progressPanels[i].Hide();
            }
            if (points <= 10)
			{
				label2.Text = $"Ваш результат: {points} баллов\n" +
				"Рекомендации: Вам стоит рассмотреть\n" +
				"возможность улучшения ваших навыков\n" +
				"делегирования и принятия решений. Попробуйте\n" +
				"начать с небольших задач, которые вы можете\n" + "делегировать, и обращайте внимание на то, как\n" +
				"другие справляются с ними. Изучите литературу на\n" + "тему эффективных методов делегирования \n" + "и управления.";
			}
			else if (points >= 11 && points <= 20)
			{
				label2.Text = $"Ваш результат: {points} баллов\n" +
				"Рекомендации: У вас есть определенные знания \n" +
				"и навыки, но есть еще над чем работать. Начните\n" +
				"открыто обсуждать с командой важные решения,\n" +
				"экспериментируйте с делегированием и учитесь на\n" + "своих ошибках. Открытость к критике и вовлечение\n" +
				"команды поможет вам развиваться в данной области.\n";
			}
			else if (points >= 21 && points <= 30)
			{
				label2.Text = $"Ваш результат: {points} баллов\n" +
				"Рекомендации: Вы на правильном пути! У вас\n" +
				"достаточно уверенности в делегировании и\n" +
				"принятии решений. Продолжайте развивать свои\n" +
				"навыки, обучая других и создавая более\n" + "эффективные рабочие процессы. Рассмотрите\n" +
				"возможность участия в тренингах по управлению и\n" + "лидерству для дальнейшего роста.";
			}
			else if (points >= 31 && points <= 40)
			{
				label2.Text = $"Ваш результат: {points} баллов\n" +
				"Рекомендации: Вы обладаете высокими навыками\n" +
				"делегирования и принятия решений. Продолжайте\n" +
				"действовать в этом направлении и развивайте свою\n" +
				"команду. Рассмотрите возможность наставничества и\n" + "делегирования еще более значительных задач,\n" +
				"чтобы помочь вашему коллективу расти и развиваться.\n";
			}
			button3.Visible = true;
		}
		private void NextQuestion(int num)
		{
			if (num < 10)
			{

				label2.Text = questions[n];
				radioButton5.Text = answer1[n];
				radioButton6.Text = answer2[n];
				radioButton7.Text = answer3[n];
				radioButton8.Text = answer4[n];
				UpdatePanelColors();
			}
			if (num == 10)
				ShowAnswer(points);
			radioButton5.Checked = false;
			radioButton6.Checked = false;
			radioButton7.Checked = false;
			radioButton8.Checked = false;
			n++;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!radioButton5.Checked && !radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked)
			{
				MessageBox.Show("Выберите один из вариантов ответа");
				return;
			}
			if (radioButton5.Checked)
			{
				NextQuestion(n);
			}
			else if (radioButton6.Checked)
			{
				points++;
				NextQuestion(n);
			}
			else if (radioButton7.Checked)
			{
				points = points + 2;
				NextQuestion(n);
			}
			else if (radioButton8.Checked)
			{
				points = points + 3;
				NextQuestion(n);
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Test3 test3 = new Test3();
			test3.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainWindow main = new MainWindow();
			main.Show();
		}

		private void Test2_Load(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
