﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    public partial class flappybird : Form
    {
        int speed = 10;
        int gravity = 5;
        int score = 0;
        int upDownVerticalSpeed = 5;
        bool moveUpDown = false;
        int maxVerticalMovement = 100; // Maximum vertical movement for the obstacles
        int downInitialTop, upInitialTop; // To store initial positions of obstacles

        public event Action<int> GameEnded;

        public flappybird()
        {
            InitializeComponent();
            downInitialTop = down.Top;
            upInitialTop = up.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void gametimerevent(object sender, EventArgs e)
        {
            bird.Top += gravity;

            down.Left -= speed;
            up.Left -= speed;

            if (moveUpDown)
            {
                // Move up and down obstacles vertically
                down.Top += upDownVerticalSpeed;
                up.Top += upDownVerticalSpeed;

                // Check if obstacles reached the max vertical bounds
                if (down.Top >= downInitialTop + maxVerticalMovement || down.Top <= downInitialTop - maxVerticalMovement)
                {
                    upDownVerticalSpeed = -upDownVerticalSpeed;
                }

                if (up.Top >= upInitialTop + maxVerticalMovement || up.Top <= upInitialTop - maxVerticalMovement)
                {
                    upDownVerticalSpeed = -upDownVerticalSpeed;
                }
            }

            gamescore.Text = score.ToString();

            if (down.Left < -150)
            {
                down.Left = 700;
                down.Top = downInitialTop; // Reset to initial position
                score++;
                CheckScore();
            }
            if (up.Left < -180)
            {
                up.Left = 650;
                up.Top = upInitialTop; // Reset to initial position
                score++;
                CheckScore();
            }
            if (bird.Bounds.IntersectsWith(down.Bounds) ||
                bird.Bounds.IntersectsWith(up.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (score > 5)
            {
                speed = 14;
            }
            if (score > 25)
            {
                speed = 17;
            }
            if (score > 35)
            {
                speed = 24;
                gravity = 8;
            }
            if (score > 45)
            {
                speed = 42;
                gravity = 12;
            }
        }

        private void CheckScore()
        {
            if (score % 10 == 0)
            {
                moveUpDown = true;
            }
            else
            {
                moveUpDown = false;
                // Reset positions to avoid visual artifacts
                down.Top = downInitialTop;
                up.Top = upInitialTop;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -13;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 13;
            }
        }

        private void endGame()
        {
            gametimer.Stop();
            gamescore.Text += " koniec gry ;c";
            GameEnded?.Invoke(score);
        }
    }
}
