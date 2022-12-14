using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_WKIUQF_2.Models2;

namespace ZH3_WKIUQF_2
{
    public partial class UserControl3 : UserControl
    {
        new SzallashelyContext context = new SzallashelyContext();
        

        public UserControl3()
        {
            InitializeComponent();
            Szobakeres();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szobakeres();
        }

        private void Szobakeres()
        {
            var szoba = from x in context.Szobas
                        where x.SzobaSzama.Contains(textBox1.Text)
                        select x;
            dataGridView1.DataSource = szoba.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foglala foglalas = new Foglala();
            foglalas.SzobaFk = int.Parse(textBox1.Text);
            foglalas.Mettol = dateTimePicker1.Value;
            foglalas.Meddig = dateTimePicker2.Value;
            foglalas.FelnottSzam = int.Parse(textBox2.Text);
            foglalas.GyermekSzam = int.Parse(textBox3.Text);

            MessageBox.Show("A foglalásod sikeres");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Adjon meg egy értéket");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, string.Empty);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Adjon meg egy értéket");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, string.Empty);
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Adjon meg egy értéket");
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, string.Empty);
        }
    }
}
