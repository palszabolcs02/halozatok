using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_WKIUQF_2
{
    public partial class UserControl2 : UserControl
    {
        Models2.SzallashelyContext context = new Models2.SzallashelyContext();
        public UserControl2()
        {
            InitializeComponent();
            Vendegszur();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Vendegszur();
        }

        private void Vendegszur()
        {
            var nevek = from x in context.Vendegs
                        where x.Usernev.Contains(textBox1.Text)
                        select x;
            dataGridView1.DataSource = nevek.ToList();
        }
    }
}
