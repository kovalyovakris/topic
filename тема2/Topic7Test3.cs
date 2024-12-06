﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static тема_1.Form1;

namespace тема2
{
    public partial class Topic7Test3 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Какой метод наиболее эффективен для создания команды\n"+"с высокой продуктивностью?",
                "Как лучше всего управлять разногласиями между\n"+"членами команды?",
                "Какой подход помогает обеспечить четкое понимание\n"+"целей проекта всей командой?",
                "Какой способ лучше всего использовать для выявления\n"+"и развития сильных сторон сотрудников в команде?",
                "Как лучше всего поддерживать мотивацию команды\n"+"в длительных проектах?",
                "Какой метод лучше всего использовать для эффективного\n"+"распределения задач в команде?",
                "Какой подход наиболее эффективен для развития командных\n"+"отношений и укрепления доверия?",
                "Как следует подходить к оценке результатов работы команды?",
                "Как лучше всего поддерживать баланс между рабочей\n"+"нагрузкой и личной жизнью членов команды?",
                "Какой метод лучше всего использовать для оценки эффективности\n"+"команды в долгосрочной перспективе?"
        };
        private String[] answer1 = new string[10] {
            "Собрать команду случайным образом и надеяться на лучшее",
            "Оставить разногласия нерешенными и надеяться, что они\n" +
            "решатся сами собой",
            "Оставить цели открытыми и полагаться на индивидуа-\n" +
            "льные интерпретации",
            "Игнорировать индивидуальные навыки и сосредоточиться\n"+"только на общей работе",
            "Предоставить минимальную обратную связь и поддерживать\n"+"работу на автомате",
            "Назначить задачи исходя из случайного выбора",
            "Игнорировать личные отношения и сосредоточиться только\n"+"на рабочих процессах",
            "Оценивать результаты только по завершению проекта",
            "Игнорировать личную жизнь сотрудников и сосредоточиться\n"+"на выполнении задач",
            "Оценивать только завершенные проекты без учета\n"+"долгосрочных результатов",
        };
        private String[] answer2 = new string[10] {
            "Набрать сотрудников по одному критерию, например,\n"+"по степени их популярности",
            "Периодически обсуждать проблемы на общих встречах,\n"+"чтобы выявить и решить их",
            "Периодически напоминать команде о целях проекта\n"+"через электронную почту",
            "Проводить периодические оценки и обсуждения для выявления\n"+"сильных сторон и возможных областей для развития",
            "Проводить регулярные встречи для обсуждения прогресса\n"+"и отмечать достижения команды",
            "Распределять задачи в зависимости от текущей загрузки\n"+"сотрудников, без учета их специализации",
            "Проводить командные мероприятия, которые способствуют\n"+"улучшению взаимодействия",
            "Проводить промежуточные оценки и обсуждения результатов\n"+"для корректировки курса работы",
            "Предлагать гибкие графики и возможности для управления\n"+"рабочим временем",
            "Использовать данные по завершенным проектам и удовлетво-\n" +
            "ренности клиентов для оценки эффективности",
        };
        private String[] answer3 = new string[10] {
            "Сформировать команду, учитывая сильные стороны и слабости\n"+"каждого участника, чтобы сбалансировать навыки",
            "Провести переговоры между сторонами конфликта и искать\n"+"совместное решение",
            "Провести подробное обсуждение целей и ожидаемых результатов\n"+"на старте проекта и регулярно обновлять информацию",
            "Обсуждать и развивать сильные стороны сотрудников в рамках\n"+"регулярных личных встреч и предоставлять возможности для роста",
            "Создавать систему регулярного признания и вознаграждения\n"+"за достигнутые результаты и усилия",
            "Учитывать профессиональные навыки и интересы сотрудников\n"+"при распределении задач, чтобы повысить\n" +
            "эффективность выполнения",
            "Создавать возможности для неформального общения для развития\n"+"доверительных отношений",
            "Регулярно проводить оценки работы команды и предоставлять\n"+"обратную связь для улучшения результатов в процессе работы",
            "Поощрять использование гибких графиков, удаленной работы\n"+"и других мер для баланса между работой и личной жизнью",
            "Регулярно анализировать долгосрочные результаты работы\n"+"команды и учитывать все аспекты работы "
        };

		private RoundedPanel[] progressPanels;
		public Topic7Test3()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
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
            label2.Text = (n + 1).ToString() + "/10";
            Button1.Hide();
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
			radioButton1.Hide();
			radioButton2.Hide();
			radioButton3.Hide();
			for (int i = 0; i < progressPanels.Length; i++)
			{
				progressPanels[i].Hide();
			}
			button2.Hide();
			if (points <= 6)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Вам следует  пересмотреть методы  управления  проблемными\n" +
                "требовать значительных улучшений. Рассмотрите возможности\n" +
                "для  развития эффективных методов  взаимодействия  и управ-" +
                "ления";
            }
            else if (points >= 7 && points <= 12)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Вы применяете некоторые правильные методы, но есть еще\n" +
                "области для улучшения в создании и управлении командой";
            }
            else if (points >= 13 && points <= 16)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Ваши подходы к созданию эффективной команды достаточно\n" +
                "хорошие, но стоит обратить внимание на  дополнительные\n"+
                "аспекты для дальнейшего улучшения";
            }
            else if (points >= 17 && points <= 20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Вы хорошо справляетесь с созданием и управлением\n" +
                "эффективной командой, применяя продуманные стра-\n" +
                "тегии и методы";
            }
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
