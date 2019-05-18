using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vdir = +1;
        int speed = 1; 
        bool game_over = false;
        private void vert_Tick(object sender, EventArgs e)
        {
            if (ball.Top < 0)
            {
                vdir = +1;
            }
            else if (ball.Top > (this.Height - ball.Height - slide.Height))
            {
                if (ball.Left < slide.Left || ((ball.Left + ball.Width) > (slide.Left + slide.Width)))
                {
                    vert.Enabled = horz.Enabled = false;
                    game_over = true;

                    label1.BackColor = Color.DarkRed;
                    pblpaused.Visible = true;
                    label1.Text = "Game Over!";
                   

                }
                else
                {
                    speed++;
                }

                vdir = -1;

            }
            ball.Top += (vdir * speed);


        }
        int hdir = +1;
        private void horz_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
            {
                hdir = +1;
            }
            else if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;
            }

            ball.Left += (hdir * speed);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        bool _left = false, _right = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                _right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                _left = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                vert.Enabled = horz.Enabled = paused = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (!game_over)
                {
                    vert.Enabled = horz.Enabled = paused = true;
                }
            }
        }
        bool paused
        {
            get
            {
                return !pblpaused.Visible;
            }
            set
            {
                pblpaused.Visible = !value;
            }
        }

        private void key_watch_Tick(object sender, EventArgs e)
        {
            if (_right && slide.Left < (this.Width - slide.Width))
            {
                slide.Left = slide.Left + 30;
            }
            else if (_left && slide.Left > 0)
            {
                slide.Left = slide.Left - 30;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false;
            }
        }
    }
}
