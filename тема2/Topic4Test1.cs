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
    public partial class Topic4Test1 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Какой фактор является наиболее важным для\n" +"мотивации IT-сотрудников?",
                "Как эффективнее всего мотивировать сотрудника\n"+"на удаленной работе?",
                "Что важнее всего для повышения мотивации сотрудников\n"+"в IT-компании?",
                "Какую роль играет признание и обратная связь\n"+"в мотивации сотрудников?",
                "Какую мотивационную программу стоит внедрить для повышения\n"+"вовлеченности сотрудников?",
                "Что может быть демотивирующим фактором для IT-сотрудников?",
                "Какую роль играют возможности обучения и развития\n"+"в мотивации сотрудников?",
                "Как влияет корпоративная культура на мотивацию сотрудников?",
                "Как лучше всего поддерживать мотивацию сотрудников\n"+"в долгосрочной перспективе?",
                "Что является наиболее эффективным для мотивации команды\n"+"в условиях напряженных сроков?"};
        private String[] answer1 = new string[10] {
            "Высокая зарплата без дополнительных бонусов\n"+"и гибкости",
            "Дать ему полный контроль над своим графиком\n"+"без ожиданий со стороны компании",
            "Контролировать выполнение задач и строго \n"+"аказывать за ошибки",
            "Признание и обратная связь не критичны,\n"+"если сотрудники получают свои зарплаты вовремя",
            "Введение штрафов за невыполнение планов",
            "Сложные задачи и проекты, требующие глубокого вовлечения",
            "Обучение и развитие не оказывают сильного влияния\n"+"на мотивацию сотрудников",
            "Корпоративная культура не оказывает значительного\n" +"влияния на мотивацию сотрудников",
            "Постоянный контроль за выполнением задач и требований",
            "Увеличение рабочей нагрузки для быстрого"+"выполнения проекта",
        };
        private String[] answer2 = new string[10] {
            "Бесплатные обеды и корпоративы",
            "Устанавливать строгие дедлайны и следить\n"+"за выполнением задач",
            "Увеличить зарплату и предоставить больше выходных",
            "Обратная связь важна, но признание не оказывает\n"+"сильного влияния",
            "Премии за выполнение квартальных задач",
            "Недостаток удобных рабочих мест",
            "Возможности обучения полезны, но не так важны, как бонусы",
            "Поддержка руководства важна, но культура в целом не так значима",
            "Регулярные повышения зарплаты и премии",
            "Обещание бонусов за выполнение проекта вовремя",
        };
        private String[] answer3 = new string[10] {
            "Конкурентная зарплата в сочетании с возможностями\n"+"роста и развития. ",
            "Поддерживать постоянную связь, предоставляя гибкий график\n"+"и доверяя результатам работы",
            "Предоставить новые профессиональные вызовы и проекты",
            "Это один из ключевых факторов мотивации, который\n" +"показывает сотруднику, что его вклад ценят",
            "Программу с наградами за успехи, карьерное\n"+"развитие и обучение",
            "Отсутствие карьерного роста и профессионального развития",
            "Это один из главных стимулов для долгосрочной\n" +"мотивации сотрудников",
            "Открытая и поддерживающая культура сильно повышает\n"+"мотивацию и вовлеченность",
            "Постоянное развитие навыков, новые вызовы\n" +"и возможности для роста",
            "Признание их усилий и предоставление ресурсов\n"+"для успешного выполнения задачи",
        };
        public Topic4Test1()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
            button3.Hide();
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
                "Подходы к мотивации требуют пересмотра.\n" +"Нужно обратить внимание на признание,\n"+"возможности для развития и гибкость условий.";
            }
            else if (points >= 6 && points <= 12)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вы используете некоторые эффективные методы мотивации,\n"+"но есть пространство для роста, особенно\n"+"в части поддержки развития и вовлеченности сотрудников";
            }
            else if (points >= 13 && points <= 16)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "У вас хорошие методы мотивации, но можно усилить\n"+"акцент на обучении, поддержке и создании\n"+"благоприятной корпоративной культуры";
            }
            else if (17 <= points && points <= 20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                    "Отличный уровень организации мотивации персонала.\n"+"Ваш подход стимулирует как профессиональное развитие,\n"+"так и личную удовлетворенность сотрудников";
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
            Topic4Test2 test2 = new Topic4Test2();
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
