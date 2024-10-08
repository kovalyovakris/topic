﻿using System;
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
    public partial class Topic6Test2 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Какой первый шаг следует предпринять при обнаружении проблем\n"+"с производительностью сотрудника?",
                "Как лучше всего подойти к обсуждению проблем\n"+"с поведением сотрудника?",
                "Как следует поступить, если сотрудник систематически\n"+"не выполняет свои обязанности?",
                "Какую роль играют регулярные обратные связи в управлении\n"+"проблемными сотрудниками?",
                "Как следует поступать, если сотрудник неадекватно реагирует\n"+"на конструктивную критику",
                "Как лучше всего реагировать на жалобы коллег о поведении\n"+"проблемного сотрудника?",
                "Какой подход наиболее эффективен для мотивации проблемного\n"+"сотрудника к улучшению его работы?",
                "Как следует действовать, если проблемы с сотрудником\n"+"не решаются после предоставления помощи и обратной связи?",
                "Какую роль играет создание позитивного рабочего климата\n"+"в управлении проблемными сотрудниками?",
                "Какой метод лучше всего использовать для контроля за\n"+"выполнением плана по улучшению работы проблемного сотрудника?"};
        private String[] answer1 = new string[10] {
            "Не предлагать бонусы, если проект является частью\n"+"регулярных обязанностей",
            "Использовать обвинительный тон и критиковать действия сотрудника",
            "Игнорировать проблему и надеяться, что сотрудник сам\n"+"начнет работать лучше",
            "Они не имеют большого значения, если есть официальные\n"+"отчеты о производительности",
            "Игнорировать его реакцию и продолжать давать критику",
            "Игнорировать жалобы, если они не подтверждаются\n"+"официальными отчетами",
            "Установить строгие штрафы за невыполнение задач",
            "Немедленно уволить сотрудника без дополнительных обсуждений",
            "Позитивный климат не имеет большого значения,\n"+"если сотрудник нарушает правила",
            "Довериться сотруднику и не вмешиваться в процесс,\n"+"если он пообещал улучшение",
        };
        private String[] answer2 = new string[10] {
            "Немедленно принять меры дисциплинарного характера",
            "Обсуждать проблему только в частном порядке, не учитывая\n" +"мнение самого сотрудника",
            "Вынести предупреждение и в случае повторения проблемы,\n"+"уволить сотрудника",
            "Обратные связи имеют значение только в случае\n"+"серьезных нарушений",
            "Прекратить давать критику и не принимать никаких мер",
            "Сразу принимать меры дисциплинарного характера\n"+"на основе жалоб",
            "Снизить рабочие нагрузки, чтобы избежать проблем в будущем",
            "Обсудить с сотрудником возможные варианты решения проблемы\n"+"и предложить более строгие меры",
            "Позитивный климат важен только для сотрудников\n"+"с хорошими показателями",
            "Проводить оценки только по окончании установленного\n"+"срока без регулярного контроля",
        };
        private String[] answer3 = new string[10] {
            "Провести беседу с сотрудником, чтобы выяснить\n"+"возможные причины проблем",
            "Обсуждать проблемы в конструктивном тоне, сосредоточив внимание\n"+"на конкретных фактах и поведении",
            "Провести анализ причин невыполнения обязанностей и предложить\n"+"помощь или обучение для улучшения результатов",
            "Регулярные обратные связи помогают своевременно выявлять\n"+"проблемы и корректировать поведение",
            "Попытаться понять причины его реакции и предложить поддержку\n"+"для улучшения восприятия критики",
            "Исследовать жалобы, проводя беседы с коллегами и выясняя\n"+"детали ситуации",
            "Предложить поддержку, обучение и возможности для карьерного\n"+"роста при выполнении задач",
            "Продолжить работу с сотрудником, рассматривая возможность\n"+"изменения его роли или задач",
            "Позитивный рабочий климат способствует более открытой\n"+"коммуникации и снижает конфликты",
            "Проводить регулярные проверки и встречи для обсуждения прогресса\n"+"и предоставления обратной связи",
        };
        public Topic6Test2()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
            button3.Hide();
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
            groupBox1.Hide();
            button2.Hide();
            if (points <= 10)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вам нужно больше внимания уделить конструктивному\n"+
                "подходу к управлению проблемными сотрудниками\n"+
                "и улучшению коммуникации.";
            }
            else if (points >= 11 && points <= 20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "У вас есть некоторые хорошие практики,\n"+
                "но стоит улучшить подходы к предоставлению\n"+
                "обратной связи и решению проблем.";
            }
            else if (points >= 21 && points <= 30)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вы уже применяете эффективные методы управления\n"+
                "проблемными сотрудниками, но есть возможности\n"+
                "для дальнейшего улучшения.";
            }
            else if (points >= 31 && points <= 40)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Ваш подход к управлению проблемными сотрудниками\n"+
                "очень хорошо проработан, и вы эффективно используете\n"+
                "стратегии для их поддержки и мотивации.";
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
            Topic6Test3 test3 = new Topic6Test3();
            test3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
