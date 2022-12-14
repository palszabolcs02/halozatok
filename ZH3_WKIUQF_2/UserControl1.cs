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
    public partial class UserControl1 : UserControl
    {
        Models2.SzallashelyContext context = new Models2.SzallashelyContext();
        public UserControl1()
        {
            InitializeComponent();
            Szallaskeres();
            Szobakeres();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szallaskeres();
            
        }

        private void Szallaskeres()
        {
            var szallas = from x in context.Szallashelies
                          where x.SzallasNev.Contains(textBox1.Text)
                          select x;
            listBox1.DataSource = szallas.ToList();
            listBox1.DisplayMember = "SzallasNev";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Szobakeres();
        }

        private void Szobakeres()
        {
            var szoba = from x in context.Szallashelies
                        where x.Cim.Contains(textBox2.Text)
                        select x;
            listBox2.DataSource = szoba.ToList();
            listBox2.DisplayMember = "Cim";
        }
    }
}
