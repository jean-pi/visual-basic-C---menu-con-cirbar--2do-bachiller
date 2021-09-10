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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            string usuario;
            int  contraseña;
            usuario = Convert.ToString(iTalk_TextBox_Small1.Text);
            contraseña = int.Parse(textBox1.Text);
            if(usuario=="jeanpierre" && contraseña == 16)
            {
                this.timer1.Start(); ;
            }
            else
            {
                MessageBox.Show("clave incorrecta");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.iTalk_ProgressBar1.Increment(1);
            if(iTalk_ProgressBar1.Value==iTalk_ProgressBar1.Maximum)
            {
                this.timer1.Stop();
                Form2 Cambio = new Form2();
                Cambio.Show();
                this.Hide();
            }
        }

        private void iTalk_TextBox_Small2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
