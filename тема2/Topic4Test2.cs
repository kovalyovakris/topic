using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace тема2
{
    public partial class Topic4Test2 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Какую стратегию лучше всего использовать для повышения\n"+"вовлеченности сотрудников?",
                "Какую роль играет гибкость рабочего графика\n"+"в мотивации сотрудников?",
                "Что наиболее важно для долгосрочного удержания\n"+"IT-специалистов?",
                "Как лучше всего демонстрировать признание сотрудникам\n"+"за их достижения?",
                "Что может негативно повлиять на мотивацию IT-сотрудников?",
                "Как поддерживать высокую мотивацию сотрудников\n"+"во время длительных проектов?",
                "Какую роль играют социальные мероприятия\n"+"в мотивации команды?",
                "Какой фактор чаще всего повышает лояльность\n"+"IT-сотрудников к компании?",
                "Как мотивировать сотрудников в условиях быстрого\n"+"роста компании?",
                "Какую стратегию стоит использовать для улучшения мотивации сотрудников,\n"+"которые работают в стрессовой среде?"};
        private String[] answer1 = new string[10] {
            "Четко прописанные обязанности без возможности изменений",
            "Гибкий график не оказывает значительного влияния на мотивацию",
            "Привлечение новых сотрудников для разгрузки текущих",
            "Признание не обязательно, если сотрудник получает\n"+"достойную зарплату",
            "Долгосрочные проекты без быстрых результатов",
            "Не вмешиваться и позволить сотрудникам самостоятельно\n"+"организовать работу",
            "Социальные мероприятия отвлекают от работы\n"+"и снижают концентрацию",
            "Увеличение количества выходных дней",
            "Поддерживать прежние условия работы без изменений",
            "Повысить требования, чтобы сотрудники справлялись\n"+"с трудностями быстрее",
        };
        private String[] answer2 = new string[10] {
            "Увеличение рабочего времени для достижения\n"+"максимальной продуктивности",
            "Гибкость не критична, если работа оплачивается выше среднего",
            "Постоянное повышение зарплаты",
            "Редкие премии за особые достижения",
            "Высокие требования к качеству работы",
            "Постоянно напоминать о финальной цели проекта",
            "Это приятно, но не оказывает большого влияния\n"+"на продуктивность и мотивацию",
            "Ежегодные премии",
            "Привлекать внешних специалистов для распределения\n"+"нагрузки",
            "Уменьшить количество рабочих часов, но не решать\n"+"коренных причин стресса",
        };
        private String[] answer3 = new string[10] {
            "Постоянные обсуждения с сотрудниками их карьерных целей\n"+"и их участие в принятии решений",
            "Это основной фактор, повышающий удовлетворенность и мотивацию",
            "Возможности карьерного роста, профессиональное развитие\n"+"и поддержка руководства",
            "Регулярные публичные признания успехов сотрудника\n"+"на общих собраниях",
            "Микроменеджмент и отсутствие доверия со стороны\n"+"руководства",
            "Делить проекты на этапы и праздновать успехи\n"+"по мере их завершения",
            "Они помогают сплотить команду и улучшить внутренние\n"+"коммуникации",
            "Возможности обучения и участия в профессиональных конференциях",
            "Создавать новые возможности для лидерства и повышения",
            "Предоставить сотрудникам доступ к ресурсам для управления стрессом,\n"+"таким как коучинг или медитация",
        };
        public Topic4Test2()
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
                "Ваши методы мотивации требуют значительных улучшений.\n"+"Важно больше фокусироваться на признании,\n"+"карьерных возможностях и балансе между работой\n"+"и личной жизнью";
            }
            else if (points >= 11 && points <= 20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "У вас есть базовые идеи по мотивации, но нужно\n"+"уделить больше внимания индивидуальным потребностям\n"+"сотрудников и созданию более поддерживающей среды.";
            }
            else if (points >= 21 && points <= 30)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Хорошие методы мотивации, но есть возможность\n"+"развить подходы к долгосрочной мотивации и созданию\n"+"благоприятных условий для профессионального роста";
            }
            else if (points >= 31 && points <= 40)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вы эффективно управляете мотивацией сотрудников,\n"+"создавая оптимальные условия для их развития и вовлеченности";
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
            Topic4Test3 test3 = new Topic4Test3();
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
