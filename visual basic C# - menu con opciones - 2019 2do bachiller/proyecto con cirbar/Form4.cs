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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Cambio = new Form2();
            Cambio.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("WWW.google.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
