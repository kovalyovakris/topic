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
    public partial class Topic3Test3 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Как лучше всего помочь новому сотруднику понять\n"+"задачи и цели компании?",
                "Какую роль играет HR в процессе адаптации\n"+"нового сотрудника?",
                "Какой из методов наиболее эффективен для снижения стресса\n"+"у нового сотрудника в первые дни работы?",
                "Как можно сделать первые недели работы нового сотрудника\n"+"максимально комфортными?",
                "Что наиболее важно при адаптации сотрудник\n"+" в мультикультурной команде?",
                "Какую роль играют регулярные встречи с руководителем\n"+"в процессе адаптации?",
                "Как лучше всего интегрировать нового сотрудника в команду?",
                "Как важна адаптация на уровне технологий\n"+"для нового IT-сотрудника?",
                "Как лучше всего помочь сотруднику,\n"+"если он испытывает трудности в адаптации?",
                "Какой из факторов наиболее важен для успешной адаптации\n"+"нового сотрудника?"};
        private String[] answer1 = new string[10] {
            "Попросить изучить информацию на сайте компании",
            "HR поддерживает нового сотрудника только\n"+"в вопросах оформления документов",
            "Ожидать, что сотрудник самостоятельно адаптируется\n"+"к новому окружению",
            "Дать сотруднику полный контроль над задачами\n"+"без вмешательства",
            "Не обращать внимания на культурные различия,\n"+"ожидая, что сотрудник сам адаптируется",
            "Встречи нужны только для подведения итогов\n"+"в конце испытательного срока",
            "Ожидать, что новый сотрудник сам наладит контакты с коллегами",
            "Сотрудник должен сам разобраться с инструментами\n"+"в процессе работы",
            "Подождать, пока он сам справится с проблемами",
            "Предоставление всех необходимых документов\n"+"и инструкций в первый день работы",
        };
        private String[] answer2 = new string[10] {
            "Раздать печатные материалы о миссии\n"+"и видении компании для самостоятельного изучения",
            "HR консультирует нового сотрудника\n"+"только на этапе подписания контракта",
            "Оставить сотруднику время для освоения\n"+"в собственном темпе, без давления",
            "Попросить команду уделять внимание новому сотруднику\n"+"при необходимости",
            "Дать доступ к курсам по межкультурному взаимодействию\n"+"для изучения в свободное время",
            "Встречи должны проходить раз в месяц для оценки работы",
            "Дать новому сотруднику время для самостоятельного\n"+"знакомства с командой",
            "Важно только предоставить доступ к основным системам,\n"+"остальное не критично",
            "Снизить количество задач, чтобы дать больше времени на адаптацию",
            "Наличие четкого плана задач и регулярной отчетности",
        };
        private String[] answer3 = new string[10] {
            "Провести вводную встречу с руководством,\n"+"где объясняются миссия и ценности компании",
            "HR помогает решать возникающие вопросы, организовывает\n"+"вводное обучение и следит за адаптацией",
            "Назначить ментора, который будет помогать с техническими\n"+"и организационными вопросами",
            "Составить четкий план задач на первые недели\n"+"и организовать регулярные встречи с командой",
            "Ознакомить нового сотрудника с различиями в культурных\n"+"особенностях и нормами общения",
            "Эти встречи помогают отслеживать прогресс и выявлять\n"+"трудности на ранних этапах",
            "Организовать командные мероприятия и пригласить нового сотрудника\n"+"активно участвовать",
            "Важно провести обучение по использованию всех внутренних систем\n"+"и инструментов компании",
            "Оказать индивидуальную поддержку, выявить конкретные проблемы\n"+"и предложить решения",
            "Создание благоприятной рабочей атмосферы и открытого общения\n"+"с коллегами и руководством",
        };
        public Topic3Test3()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
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
            if (points <= 6)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: Вы имеете начальное представление о\n" +
                "делегировании и принятии решений. Рекомендуется изучить\n" +
                "основные концепты и подходы к делегированию. Прочитайте\n" +
                "книги или пройдите курсы по управлению, чтобы углубить \n" + "свои знания.";
            }
            else if (points >= 7 && points <= 12)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: У вас достаточно понимания тематики, однако\n" +
                "есть области, требующие улучшения. Сфокусируйтесь на\n" +
                "практике делегирования и принимайте участие в обсуждениях\n" +
                "по принятию решений в команде. Попробуйте применять\n" +
                "полученные знания в реальных ситуациях.\n";
            }
            else if (points >= 13 && points <= 18)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: Вы обладаете хорошими знаниями о\n" +
                "делегировании и процессе принятия решений. Чтобы еще\n" +
                "больше улучшить свои навыки, начните применять их на\n" +
                "практике и работайте над созданием более эффективных\n" + "команд.";
            }
            else if (points >= 19 && points <= 24)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: Вы эксперт в области делегирования и \n" +
                "принятия решений! Продолжайте развивать свои навыки и\n" +
                "делитесь знаниями с другими. Рассмотрите возможность\n" +
                "наставничества новых сотрудников или участия в тренингах для\n" + "развития управленческих навыков.\n";
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
