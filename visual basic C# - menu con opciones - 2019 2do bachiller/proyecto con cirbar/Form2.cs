using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_con_cirbar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gracias  por visitar el programa");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Cambio = new Form3();
            Cambio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Cambio = new Form4();
            Cambio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Cambio = new Form5();
            Cambio.Show();
            this.Hide();
        }
    }
}
