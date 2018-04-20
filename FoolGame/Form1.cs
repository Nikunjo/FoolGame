using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int Togmove;
        int MVX;
        int MVY;

      

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {

            Random r = new Random();
            int x = r.Next(680);
            int y = r.Next(350);

            button2.Location = new Point(x, y);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Congratulation You Are Fool.. :D\n\nWant To Play Again?","Game Over", MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
            {

               MessageBox.Show("Welcome To Fool Game");
               
            }


           else
            {          
             
                this.Close();
            }
           
            
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Congratulation You Win The Game.. :D\n\nWant To Play Again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                MessageBox.Show("Welcome To Fool Game");

            }


            else
            {

                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (this.WindowState != FormWindowState.Minimized)
            {

                this.WindowState = FormWindowState.Minimized;
            
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            Togmove = 1;
            MVX = e.X;
            MVY = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            Togmove = 0;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Togmove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MVX, MousePosition.Y - MVY);
            }

        }

       
        
    }
}
