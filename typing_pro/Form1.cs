using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typing_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        Random random1 = new Random();
        int x = 0,y = 5,ball=0,qate=0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible=false;
            timer1.Start();
            x = random.Next(0,600);
            label1.Location=new Point(x,5);
        }
        private void jaylastiriw()
        {
            x = random.Next(0, 600);
            label1.Location = new Point(x, 5);
            char q = (char)random2.Next(97, 123);
            label1.Text = q.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 5;
            label1.Location = new Point(x, y);
           
            if (y>500)
            {
               jaylastiriw();
                qate++;
                guna2HtmlLabel4.Text = qate.ToString();
                y = 5;
            }
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            y = 0;
            if (e.KeyChar.ToString() == label1.Text)
            {
                jaylastiriw();
                ball++;
                guna2HtmlLabel3.Text = ball.ToString();
            }
          
            else
            {
                qate++;
                guna2HtmlLabel4.Text = qate.ToString();
            }
        }

        //a_z=97;122
        //A_Z=65;90
        Random random2 =new Random();
       
    }
}
