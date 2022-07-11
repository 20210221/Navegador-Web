using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_Web
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                return;

            }

            webBrowser1.Navigate(textBox1.Text);

           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            webBrowser1.GoBack();

                textBox1.Text = webBrowser1.Url.AbsoluteUri;

           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

                webBrowser1.GoForward();

                textBox1.Text = webBrowser1.Url.AbsoluteUri;

                panel3.Visible = false;

            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            textBox1.Text = "";

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.AbsoluteUri;

            panel3.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color colorSelect = colorDialog1.Color;

                panel1.BackColor = colorSelect;

                panel2.BackColor = colorSelect;

                panel3.BackColor = colorSelect;

                pictureBox1.BackColor = colorSelect;

                pictureBox2.BackColor = colorSelect;

                pictureBox3.BackColor = colorSelect;

                pictureBox9.BackColor = colorSelect;

                pictureBox4.BackColor = colorSelect;

                pictureBox5.BackColor = colorSelect;

                pictureBox6.BackColor = colorSelect;

                pictureBox7.BackColor = colorSelect;

                pictureBox8.BackColor = colorSelect;

                pictureBox10.BackColor = colorSelect;

                bunifuFlatButton1.BackColor = colorSelect;

                bunifuFlatButton1.Activecolor = colorSelect;

                bunifuFlatButton1.Normalcolor = colorSelect;

                bunifuFlatButton1.OnHovercolor = colorSelect;

                bunifuFlatButton2.BackColor = colorSelect;

                bunifuFlatButton2.Activecolor = colorSelect;

                bunifuFlatButton2.Normalcolor = colorSelect;

                bunifuFlatButton2.OnHovercolor = colorSelect;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                Font fontSelect = fontDialog1.Font;

                label1.Font = fontSelect;

                bunifuCustomLabel1.Font = fontSelect;

                bunifuCustomLabel2.Font = fontSelect;

               textBox1.Font = fontSelect;

                bunifuFlatButton1.Font = fontSelect;

                bunifuFlatButton2.Font = fontSelect;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (bunifuFlatButton1.Visible == false) {

                bunifuFlatButton1.Visible = true;

                bunifuFlatButton2.Visible = true;

               

               
            }

            else
            {
                bunifuFlatButton1.Visible = false;

                bunifuFlatButton2.Visible = false;
            }

           
        }
    }
}
