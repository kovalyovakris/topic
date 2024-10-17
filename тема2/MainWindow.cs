using System.Windows.Forms.Design;
using тема_1;

namespace тема2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic2Test1 topic2 = new Topic2Test1();
            topic2.Show();
        }

        private void buttTest3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic3Test1 topic3 = new Topic3Test1();
            topic3.Show();
        }

        private void buttTest4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic4Test1 topic4 = new Topic4Test1();
            topic4.Show();
        }

        private void buttText5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic5Test1 topic5 = new Topic5Test1();
            topic5.Show();
        }

        private void buttTest6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic6Test3 topic6 = new Topic6Test3();
            topic6.Show();
        }

        private void buttTest7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic7Test1 topic7 = new Topic7Test1();
            topic7.Show();

        }
    }
}
