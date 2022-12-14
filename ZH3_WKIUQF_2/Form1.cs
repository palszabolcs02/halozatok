namespace ZH3_WKIUQF_2
{
    public partial class Form1 : Form
    {
        UserControl u1;
        UserControl u2;
        UserControl u3;

        public Form1()
        {
            u1 = new UserControl1();
            u2 = new UserControl2();
            u3 = new UserControl3();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u2.Hide();
            u3.Hide();
            u1.Show();
            u1.Dock = DockStyle.Fill;
            this.Controls.Add(u1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Show();
            u3.Hide();

            u2.Dock = DockStyle.Fill;
            this.Controls.Add(u2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Hide();
            u3.Show();


            u3.Dock = DockStyle.Fill;
            this.Controls.Add(u3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult valami = MessageBox.Show("Biztos elhagyod az appot, te halandó?", "Kilépés", MessageBoxButtons.YesNo);
            if (valami == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}