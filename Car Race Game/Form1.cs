using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race_Game
{
   
    public partial class Form1 : Form
       
        
    {
        int CurrentSpeed = 5;
        int PlayerSpeed = 0;
        public Form1()
        {
            InitializeComponent();
            gameover.Visible = false;
            label1.Visible = false;  //for invisible the gameover replay and close text
            exit.Visible = false;
            


        }
        //for visible the Gameover replay and close text
        
        private void Gameover()
        {
            if (player.Bounds.IntersectsWith(enemy_1.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible=true;
                label1.Visible=true;
                exit.Visible=true;
                speed_txt.Text = "Speed .0 MPH";

            }

            if (player.Bounds.IntersectsWith(enemy_2.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
                label1.Visible = true;
                exit.Visible=true;
                speed_txt.Text = "Speed .0 MPH";
               


            }
        }
        //for road mover
        private void track_line(int speed)
        {
            if (track1.Top >= 612)
            {
                track1.Top = 0;
            }
            else
            {
                track1.Top += speed;
            }

            if (track2.Top >= 612)
            {
                track2.Top = 0;
            }
            else
            {
                track2.Top += speed;
            }

            if (track3.Top >= 612)
            {
                track3.Top = 0;
            }
            else
            {
                track3.Top += speed;
            }

            Random rnd = new Random();
            int x, y;
            if (enemy_1.Top >= 612)
            {
                x=rnd.Next(0,300);

                enemy_1.Location= new Point(x, 0);
            }
            else
            {
                enemy_1.Top += speed;
            }

            if (enemy_2.Top >= 612)
            {
                y = rnd.Next(0, 500);

                enemy_2.Location = new Point(y, 0);
            }
            else
            {
                enemy_2.Top += speed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void track1_Click(object sender, EventArgs e)
        {
            
        }
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            track_line(PlayerSpeed);
            Gameover();
            if (enemy_1.Top > 580)
            {
                enemy_1.Top = 0;
                score += 10;
                score_text.Text = "score :" + score;
            }
           else if (enemy_1.Top > 580)
            {
                enemy_2.Top = 0;
                score += 10;
                score_text.Text = "score :" + score;
            }
        }
        //for shift the car from left to right and right to left
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left >= 50)
                {
                    player.Left += -30;
                }
            }else if(e.KeyCode == Keys.Right)
            {
                if(player.Right < 500)
                {
                    player.Left += 30;
                }
            }
            else if(e.KeyCode == Keys.Up)
            {
                if (PlayerSpeed < 50)
                    PlayerSpeed++;
                speed_txt.Text = "Speed: " + CurrentSpeed +"MPH ".ToString();
                CurrentSpeed++;
            }

            else if (e.KeyCode == Keys.Down)
            {
                if (PlayerSpeed < 50)
                    PlayerSpeed--;
                speed_txt.Text = "Speed: " + CurrentSpeed + "MPH ".ToString();
                CurrentSpeed--;
            }
        }

        //for replay the game
        private void label1_Click(object sender, EventArgs e)
        {
            
            Form1 dlg = new Form1();
            dlg.Show();
            this.Hide();

        }
        //for close the game
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
