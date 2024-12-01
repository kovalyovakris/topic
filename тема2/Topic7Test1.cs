using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тема2
{
    public partial class Topic7Test1 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Какой подход наиболее эффективен для формирования команды\n"+"с разнообразными навыками?",
                "Какой метод лучше всего использовать для повышения командного духа?",
                "Как следует управлять распределением задач внутри команды\n"+"для достижения максимальной эффективности?",
                "Как лучше всего обеспечивать, чтобы члены команды понимали\n"+"общие цели и задачи проекта?",
                "Как лучше всего справляться с конфликтами между членами команды?",
                "Какой способ наиболее эффективен для обеспечения выполнения\n"+"сроков проекта?",
                "Какую роль играет обратная связь в процессе создания\n"+"эффективной команды?",
                "Как лучше всего подходить к созданию и поддержанию позитивной\n"+"рабочей атмосферы?",
                "Какой метод лучше всего использовать для развития и повышения\n"+"квалификации членов команды?",
                "Как следует реагировать на предложения по улучшению\n"+"работы от членов команды?"
        };
        private String[] answer1 = new string[10] {
            "Игнорировать проблему и надеяться, что ситуация\n"+"улучшится сама собой",
            "Использовать обвинительный тон и критиковать действия\n"+"сотрудника",
            "Игнорировать проблему и надеяться, что сотрудник сам начнет\n"+"работать лучше",
            "Они не имеют большого значения, если есть официальные отчеты\n"+"о производительности",
            "Игнорировать его реакцию и продолжать давать критику",
            "Игнорировать жалобы, если они не подтверждаются\n"+"официальными отчетами",
            "Установить строгие штрафы за невыполнение задач",
            "Немедленно уволить сотрудника без дополнительных обсуждений",
            "Позитивный климат не имеет большого значения,\n"+"если сотрудник нарушает правила",
            "Довериться сотруднику и не вмешиваться в процесс,\n"+"если он пообещал улучшение",
        };
        private String[] answer2 = new string[10] {
            "Немедленно принять меры дисциплинарного характера",
            "Обсуждать проблему только в частном порядке, не учитывая\nz"+"мнение самого сотрудника",
            "Вынести предупреждение и в случае повторения проблемы,\n"+"уволить сотрудника",
            "Обратные связи имеют значение только в случае\n"+"серьезных нарушений",
            "Прекратить давать критику и не принимать никаких мер",
            "Сразу принимать меры дисциплинарного характера\n"+"на основе жалоб",
            "Снизить рабочие нагрузки, чтобы избежать проблем в будущем",
            "Обсудить с сотрудником возможные варианты решения проблемы\n"+"и предложить более строгие меры",
            "Позитивный климат важен только для сотрудников\n"+"с хорошими показателями",
            "Проводить оценки только по окончании установленного срока\n"+"без регулярного контроля",
        };
        private String[] answer3 = new string[10] {
            "Провести беседу с сотрудником, чтобы выяснить возможные\n"+"причины проблем",
            "Обсуждать проблемы в конструктивном тоне, сосредоточив внимание\n"+"на конкретных фактах и поведении",
            "Провести анализ причин невыполнения обязанностей и предложить\n"+"помощь или обучение для улучшения результатов",
            "Регулярные обратные связи помогают своевременно выявлять\n"+"проблемы и корректировать поведение",
            "Попытаться понять причины его реакции и предложить поддержку\n"+"для улучшения восприятия критики",
            "Исследовать жалобы, проводя беседы с коллегами и выясняя\n"+"детали ситуации",
            "Предложить поддержку, обучение и возможности для карьерного\n"+"роста при выполнении задач",
            "Продолжить работу с сотрудником, рассматривая возможность\n"+"изменения его роли или задач",
            "Позитивный рабочий климат способствует более открытой\n"+"коммуникации и снижает конфликты",
            "Проводить регулярные проверки и встречи для обсуждения\n"+"прогресса и предоставления обратной связи",
        };
		private RoundedPanel[] progressPanels;
		public Topic7Test1()
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
            radioButton1.Text = answer1[n];
            radioButton2.Text = answer2[n];
            radioButton3.Text = answer3[n];
            groupBox1.Visible = true;
            button2.Visible = true;
            n++;
        }
        private void ShowAnswer(int p)
        {
            label2.Hide();
            groupBox1.Hide();
            button2.Hide();
            if (points <= 5)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вам следует улучшить подходы к созданию и управлению\n" +
                "командой. Сосредоточьте внимание на эффективной коммуникации и\n"+
                "развитии команды";
            }
            else if (points >= 6 && points <= 12)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вы применяете некоторые хорошие методы, но есть\n" +
                "возможности для улучшения в управлении и взаимодействии\n"+
                "внутри команды";
            }
            else if (points >= 13 && points <= 16)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Ваши подходы к созданию эффективной команды весьма\n" +
                "эффективны, но всегда можно найти способы для\n" +
                "дополнительного улучшения";
            }
            else if (17 <= points && points <= 20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                    "Вы отлично справляетесь с созданием и управлением\n" +
                    "эффективной командой, применяя продуманные стратегии и подходы";
            }
            button3.Visible = true;
        }
        private void NextQuestion(int num)
        {
            if (num < 10)
            {
                label2.Text = (n + 1).ToString() + "/10";
                label3.Text = questions[n];
                radioButton1.Text = answer1[n];
                radioButton2.Text = answer2[n];
                radioButton3.Text = answer3[n];
				UpdatePanelColors();
			}
			if (num == 10)
                ShowAnswer(points);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            n++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Выберите один из вариантов ответа");
                return;
            }
            if (radioButton1.Checked)
            {
                NextQuestion(n);
            }
            else if (radioButton2.Checked)
            {
                points++;
                NextQuestion(n);
            }
            else if (radioButton3.Checked)
            {
                points = points + 2;
                NextQuestion(n);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic7Test2 test2 = new Topic7Test2();
            test2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
