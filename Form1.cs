using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        Image[] Blocks = new Image[8];
        Random rand=new Random();
        int[,] cordonate1 = new int[4, 2];
        int[,] cordonate2 = new int[4, 2];
        int[,] cordonate3 = new int[4, 2];
        int[,] frame1=new int[15,9];
        PictureBox[,] principal = new PictureBox[14, 9];
        PictureBox[,] secundar = new PictureBox[4, 4];
        int game = 0,i,j,level=0,score=0,a,b,gameover=1,position=1,P=1,nextpiece=0,ok,glitch=1;
        int l, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameTime.Interval = 1000;
            Start.Enabled = false;
            Restart.Enabled = true;
            Pause.Enabled = true;
            score = 0;
            level = 1;
            glitch = 1;
            nextpiece = 0;
            position = 1;
            gameover = 0;
            ScoreBox.Text = "Score" + '\n' + score;
            LevelBox.Text = "Level" + '\n' + level;
            game++;
            for (i = 0; i < 15; i++)
            {
                for (j = 1; j < 9; j++)
                {
                    frame1[i,j] = 0;
                }
            }
            if (game == 1)
            {
                Blocks[0] = Properties.Resources.Black_block;
                Blocks[1] = Properties.Resources.Red_block;
                Blocks[2] = Properties.Resources.Green_block;
                Blocks[3] = Properties.Resources.Blue_block;
                Blocks[4] = Properties.Resources.Orange_block;
                Blocks[5] = Properties.Resources.Yallow_block;
                Blocks[6] = Properties.Resources.Blue_Dark_block;
                Blocks[7] = Properties.Resources.Purple_block;
                principal[2, 1] = Block1;
                principal[2, 2] = Block2;
                principal[2, 3] = Block3;
                principal[2, 4] = Block4;
                principal[2, 5] = Block5;
                principal[2, 6] = Block6;
                principal[2, 7] = Block7;
                principal[2, 8] = Block8;
                principal[3, 1] = Block9;
                principal[3, 2] = Block10;
                principal[3, 3] = Block11;
                principal[3, 4] = Block12;
                principal[3, 5] = Block13;
                principal[3, 6] = Block14;
                principal[3, 7] = Block15;
                principal[3, 8] = Block16;
                principal[4, 1] = Block17;
                principal[4, 2] = Block18;
                principal[4, 3] = Block19;
                principal[4, 4] = Block20;
                principal[4, 5] = Block21;
                principal[4, 6] = Block22;
                principal[4, 7] = Block23;
                principal[4, 8] = Block24;
                principal[5, 1] = Block25;
                principal[5, 2] = Block26;
                principal[5, 3] = Block27;
                principal[5, 4] = Block28;
                principal[5, 5] = Block29;
                principal[5, 6] = Block30;
                principal[5, 7] = Block31;
                principal[5, 8] = Block32;
                principal[6, 1] = Block33;
                principal[6, 2] = Block34;
                principal[6, 3] = Block35;
                principal[6, 4] = Block36;
                principal[6, 5] = Block37;
                principal[6, 6] = Block38;
                principal[6, 7] = Block39;
                principal[6, 8] = Block40;
                principal[7, 1] = Block41;
                principal[7, 2] = Block42;
                principal[7, 3] = Block43;
                principal[7, 4] = Block44;
                principal[7, 5] = Block45;
                principal[7, 6] = Block46;
                principal[7, 7] = Block47;
                principal[7, 8] = Block48;
                principal[8, 1] = Block49;
                principal[8, 2] = Block50;
                principal[8, 3] = Block51;
                principal[8, 4] = Block52;
                principal[8, 5] = Block53;
                principal[8, 6] = Block54;
                principal[8, 7] = Block55;
                principal[8, 8] = Block56;
                principal[9, 1] = Block57;
                principal[9, 2] = Block58;
                principal[9, 3] = Block59;
                principal[9, 4] = Block60;
                principal[9, 5] = Block61;
                principal[9, 6] = Block62;
                principal[9, 7] = Block63;
                principal[9, 8] = Block64;
                principal[10, 1] = Block65;
                principal[10, 2] = Block66;
                principal[10, 3] = Block67;
                principal[10, 4] = Block68;
                principal[10, 5] = Block69;
                principal[10, 6] = Block70;
                principal[10, 7] = Block71;
                principal[10, 8] = Block72;
                principal[11, 1] = Block73;
                principal[11, 2] = Block74;
                principal[11, 3] = Block75;
                principal[11, 4] = Block76;
                principal[11, 5] = Block77;
                principal[11, 6] = Block78;
                principal[11, 7] = Block79;
                principal[11, 8] = Block80;
                principal[12, 1] = Block81;
                principal[12, 2] = Block82;
                principal[12, 3] = Block83;
                principal[12, 4] = Block84;
                principal[12, 5] = Block85;
                principal[12, 6] = Block86;
                principal[12, 7] = Block87;
                principal[12, 8] = Block88;
                principal[13, 1] = Block89;
                principal[13, 2] = Block90;
                principal[13, 3] = Block91;
                principal[13, 4] = Block92;
                principal[13, 5] = Block93;
                principal[13, 6] = Block94;
                principal[13, 7] = Block95;
                principal[13, 8] = Block96;
                secundar[0, 0] = B1;
                secundar[0, 1] = B2;
                secundar[0, 2] = B3;
                secundar[0, 3] = B4;
                secundar[1, 0] = B5;
                secundar[1, 1] = B6;
                secundar[1, 2] = B7;
                secundar[1, 3] = B8;
                secundar[2, 0] = B9;
                secundar[2, 1] = B10;
                secundar[2, 2] = B11;
                secundar[2, 3] = B12;
                secundar[3, 0] = B13;
                secundar[3, 1] = B14;
                secundar[3, 2] = B15;
                secundar[3, 3] = B16;
            }
            if (position == 1)
            {
                a = rand.Next(1, 8);
                if (a == 1)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 4] = frame1[1, 5] = 1;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 4;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 5;

                }
                if (a == 2)
                {
                    frame1[1, 3] = frame1[1, 4] = frame1[1, 5] = frame1[1, 6] = 2;
                    cordonate1[0, 0] = 1; cordonate1[0, 1] = 3;
                    cordonate1[1, 0] = 1; cordonate1[1, 1] = 4;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 5;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 6;
                }
                if (a == 3)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 5] = frame1[1, 6] = 3;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 5;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 6;
                }
                if (a == 4)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 3] = frame1[1, 4] = 4;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 3;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 4;
                }
                if (a == 5)
                {
                    frame1[0, 4] = frame1[1, 3] = frame1[1, 4] = frame1[1, 5] = 5;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 1; cordonate1[1, 1] = 3;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 4;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 5;
                }
                if (a == 6)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 5] = frame1[2, 5] = 6;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 5;
                    cordonate1[3, 0] = 2; cordonate1[3, 1] = 5;
                }
                if (a == 7)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 4] = frame1[2, 4] = 7;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 4;
                    cordonate1[3, 0] = 2; cordonate1[3, 1] = 4;
                }
                cordonate2[0, 0] = cordonate1[0, 0];
                cordonate2[0, 1] = cordonate1[0, 1];
                cordonate2[1, 0] = cordonate1[1, 0];
                cordonate2[1, 1] = cordonate1[1, 1];
                cordonate2[2, 0] = cordonate1[2, 0];
                cordonate2[2, 1] = cordonate1[2, 1];
                cordonate2[3, 0] = cordonate1[3, 0];
                cordonate2[3, 1] = cordonate1[3, 1];
                b = rand.Next(1, 8);
                for (i = 1; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        secundar[i, j].Image = Blocks[0];
                    }

                }
                if (b == 1)
                {
                    secundar[1, 1].Image = secundar[1, 2].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[1];
                }
                if (b == 2)
                {
                    secundar[3, 0].Image = secundar[3, 1].Image = secundar[3, 2].Image = secundar[3, 3].Image = Blocks[2];
                }
                if (b == 3)
                {
                    secundar[1, 0].Image = secundar[1, 1].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[3];
                }
                if (b == 4)
                {
                    secundar[1, 3].Image = secundar[1, 2].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[4];
                }
                if (b == 5)
                {
                    secundar[1, 1].Image = secundar[2, 0].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[5];
                }
                if (b == 6)
                {
                    secundar[1, 1].Image = secundar[1, 2].Image = secundar[2, 2].Image = secundar[3, 2].Image = Blocks[6];
                }
                if (b == 7)
                {
                    secundar[1, 3].Image = secundar[1, 2].Image = secundar[2, 2].Image = secundar[3, 2].Image = Blocks[7];
                }
                GameTime.Enabled = true;
            }

        }


        private void GameTime_Tick(object sender, EventArgs e)
        {
            if (gameover == 0)
            {
                if (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14)
                {
                    if (a == 1)
                    {

                        if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                        {
                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                            frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 1; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 1;
                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 1; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 1;
                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                        }
                        else
                        {
                            GameTime.Enabled = false;
                            ChangePiece.Enabled = true;
                            nextpiece = 1;
                        }

                    }
                    if (a == 2)
                    {
                        if (position % 2 == 1)
                        {
                            if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;
                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                            else
                            {
                                GameTime.Enabled = false;
                                ChangePiece.Enabled = true;
                                nextpiece = 1;
                            }
                        }
                        else
                        {
                            if (position % 2 == 0)
                            {
                                if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                                else
                                {
                                    GameTime.Enabled = false;
                                    ChangePiece.Enabled = true;
                                    nextpiece = 1;
                                }
                            }
                        }
                    }
                    if (a == 3)
                    {
                        if (position % 2 == 1)
                        {
                            if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                            else
                            {
                                GameTime.Enabled = false;
                                ChangePiece.Enabled = true;
                                nextpiece = 1;
                            }
                        }
                        else
                        {
                            if (position % 2 == 0)
                            {
                                if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                                else
                                {
                                    GameTime.Enabled = false;
                                    ChangePiece.Enabled = true;
                                    nextpiece = 1;
                                }
                            }
                        }
                    }
                    if (a == 4)
                    {
                        if (position % 2 == 1)
                        {
                            if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                            else
                            {
                                GameTime.Enabled = false;
                                ChangePiece.Enabled = true;
                                nextpiece = 1;
                            }
                        }
                        else
                        {
                            if (position % 2 == 0)
                            {
                                if (frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                                else
                                {
                                    GameTime.Enabled = false;
                                    ChangePiece.Enabled = true;
                                    nextpiece = 1;
                                }
                            }
                        }
                    }
                    if (a == 5)
                    {
                        if (position % 4 == 1)
                        {
                            if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                            else
                            {
                                GameTime.Enabled = false;
                                ChangePiece.Enabled = true;
                                nextpiece = 1;
                            }
                        }
                        else
                        {
                            if (position % 4 == 2)
                            {
                                if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                                else
                                {
                                    GameTime.Enabled = false;
                                    ChangePiece.Enabled = true;
                                    nextpiece = 1;
                                }
                            }
                            else
                            {
                                if (position % 4 == 3)
                                {
                                    if (frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0)
                                    {
                                        cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                        frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    }
                                    else
                                    {
                                        GameTime.Enabled = false;
                                        ChangePiece.Enabled = true;
                                        nextpiece = 1;
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 0)
                                    {
                                        if (frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                        {
                                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        }
                                        else
                                        {
                                            GameTime.Enabled = false;
                                            ChangePiece.Enabled = true;
                                            nextpiece = 1;
                                        }
                                    }

                                }

                            }
                        }
                    }
                    if (a == 6)
                    {
                        if (position % 4 == 1)
                        {
                            if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                            else
                            {
                                GameTime.Enabled = false;
                                ChangePiece.Enabled = true;
                                nextpiece = 1;
                            }
                        }
                        else
                        {
                            if (position % 4 == 2)
                            {
                                if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                                else
                                {
                                    GameTime.Enabled = false;
                                    ChangePiece.Enabled = true;
                                    nextpiece = 1;
                                }
                            }
                            else
                            {
                                if (position % 4 == 3)
                                {
                                    if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                    {
                                        cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                        frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    }
                                    else
                                    {
                                        GameTime.Enabled = false;
                                        ChangePiece.Enabled = true;
                                        nextpiece = 1;
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 0)
                                    {
                                        if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                        {
                                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        }
                                        else
                                        {
                                            GameTime.Enabled = false;
                                            ChangePiece.Enabled = true;
                                            nextpiece = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (a == 7)
                    {
                        if (position % 4 == 1)
                        {
                            if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                            else
                            {
                                GameTime.Enabled = false;
                                ChangePiece.Enabled = true;
                                nextpiece = 1;
                            }
                        }
                        else
                        {
                            if (position % 4 == 2)
                            {
                                if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                                else
                                {
                                    GameTime.Enabled = false;
                                    ChangePiece.Enabled = true;
                                    nextpiece = 1;
                                }
                            }
                            else
                            {
                                if (position % 4 == 3)
                                {
                                    if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                    {
                                        cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                        frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    }
                                    else
                                    {
                                        GameTime.Enabled = false;
                                        ChangePiece.Enabled = true;
                                        nextpiece = 1;
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 0)
                                    {
                                        if (frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0)
                                        {
                                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        }
                                        else
                                        {
                                            GameTime.Enabled = false;
                                            ChangePiece.Enabled = true;
                                            nextpiece = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    GameTime.Enabled = false;
                    ChangePiece.Enabled = true;
                    nextpiece = 1;
                }
                for (i = 2; i < 14; i++)
                {
                    for (j = 1; j < 9; j++)
                    {
                        principal[i, j].Image = Blocks[frame1[i, j]];
                    }
                }
                
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            GameTime.Enabled = false;
            GameOver.Visible = false;
            PauseOn.Visible = false;
            score = 0;
            level = 1;
            ScoreBox.Text = "Score" + '\n' + score;
            LevelBox.Text = "Level" + '\n' + level;
            for (i = 0; i < 15; i++)
            {
                for (j = 1; j < 9; j++)
                {
                    frame1[i, j] = 0;
                }
            }
            for (i = 2; i < 14; i++)
            {
                for (j = 1; j < 9; j++)
                {
                    principal[i, j].Image = Blocks[0];
                }
            }
            for (i = 1; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    secundar[i, j].Image = Blocks[0];
                }

            }
            Start.Enabled = true;
            Pause.Enabled = false;
            Restart.Enabled = false;
        }

        private void ChangePiece_Tick(object sender, EventArgs e)
        {
            if (gameover == 0)
            {
                for (i = 0; i < 2; i++)
                {
                    for (j = 1; j < 9; j++)
                    {
                        if (frame1[i, j] != 0)
                        {
                            GameOver.Visible = true;
                            gameover = 1;
                        }
                    }
                }
                ChangePiece.Enabled = false;
                for(i = 2; i < 14;i++)
                {
                    ok = 0;
                    for (j = 1; j < 9; j++)
                    {
                        if (frame1[i, j] == 0)
                        {
                            ok = 1;
                        }
                    }
                    if (ok == 0)
                    {
                        score=score+10;
                        if ((score + 100) / 100 > 9)
                        {
                            level = 10;
                        }
                        else
                        {
                            level = (score + 100) / 100;
                        }
                        GameTime.Interval = 1100 - (level * 100);
                        for (l = i; l > 0; l--)
                        {
                            for (c = 1; c < 9; c++)
                            {
                                frame1[l, c] = frame1[l - 1, c];
                            }
                        }
                    }
                }
                ScoreBox.Text = "Score" + '\n' + score;
                LevelBox.Text = "Level" + '\n' + level;
                a = b;
                if (a == 1)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 4] = frame1[1, 5] = 1;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 4;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 5;

                }
                if (a == 2)
                {
                    frame1[1, 3] = frame1[1, 4] = frame1[1, 5] = frame1[1, 6] = 2;
                    cordonate1[0, 0] = 1; cordonate1[0, 1] = 3;
                    cordonate1[1, 0] = 1; cordonate1[1, 1] = 4;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 5;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 6;
                }
                if (a == 3)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 5] = frame1[1, 6] = 3;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 5;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 6;
                }
                if (a == 4)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 3] = frame1[1, 4] = 4;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 3;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 4;
                }
                if (a == 5)
                {
                    frame1[0, 4] = frame1[1, 3] = frame1[1, 4] = frame1[1, 5] = 5;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 1; cordonate1[1, 1] = 3;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 4;
                    cordonate1[3, 0] = 1; cordonate1[3, 1] = 5;
                }
                if (a == 6)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 5] = frame1[2, 5] = 6;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 5;
                    cordonate1[3, 0] = 2; cordonate1[3, 1] = 5;
                }
                if (a == 7)
                {
                    frame1[0, 4] = frame1[0, 5] = frame1[1, 4] = frame1[2, 4] = 7;
                    cordonate1[0, 0] = 0; cordonate1[0, 1] = 4;
                    cordonate1[1, 0] = 0; cordonate1[1, 1] = 5;
                    cordonate1[2, 0] = 1; cordonate1[2, 1] = 4;
                    cordonate1[3, 0] = 2; cordonate1[3, 1] = 4;
                }
                cordonate2[0, 0] = cordonate1[0, 0];
                cordonate2[0, 1] = cordonate1[0, 1];
                cordonate2[1, 0] = cordonate1[1, 0];
                cordonate2[1, 1] = cordonate1[1, 1];
                cordonate2[2, 0] = cordonate1[2, 0];
                cordonate2[2, 1] = cordonate1[2, 1];
                cordonate2[3, 0] = cordonate1[3, 0];
                cordonate2[3, 1] = cordonate1[3, 1];
                b = rand.Next(1, 8);
                for (i = 1; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        secundar[i, j].Image = Blocks[0];
                    }

                }
                if (b == 1)
                {
                    secundar[1, 1].Image = secundar[1, 2].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[1];
                }
                if (b == 2)
                {
                    secundar[3, 0].Image = secundar[3, 1].Image = secundar[3, 2].Image = secundar[3, 3].Image = Blocks[2];
                }
                if (b == 3)
                {
                    secundar[1, 0].Image = secundar[1, 1].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[3];
                }
                if (b == 4)
                {
                    secundar[1, 3].Image = secundar[1, 2].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[4];
                }
                if (b == 5)
                {
                    secundar[1, 1].Image = secundar[2, 0].Image = secundar[2, 1].Image = secundar[2, 2].Image = Blocks[5];
                }
                if (b == 6)
                {
                    secundar[1, 1].Image = secundar[1, 2].Image = secundar[2, 2].Image = secundar[3, 2].Image = Blocks[6];
                }
                if (b == 7)
                {
                    secundar[1, 3].Image = secundar[1, 2].Image = secundar[2, 2].Image = secundar[3, 2].Image = Blocks[7];
                }
                GameTime.Enabled = true;
                nextpiece = 0;
                position = 1;
            }

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            P++;
            if (P % 2 == 1)
            {
                PauseOn.Visible = false;
                GameTime.Enabled = true;
            }
            else
            {
                PauseOn.Visible=true;
                GameTime.Enabled = false;
            }
        }

       

        private void Right_Click(object sender, EventArgs e)
        {
            if (nextpiece == 0)
            {
                if (P % 2 == 1)
                {
                    if (gameover == 0)
                    {
                        if (cordonate1[0, 1] + 1 < 9 && cordonate1[1, 1] + 1 < 9 && cordonate1[2, 1] + 1 < 9 && cordonate1[3, 1] + 1 < 9)
                        {
                            if (a == 1)
                            {
                                if (frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                {
                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                    cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 1;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 1;
                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 1;

                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                }
                            }
                            if (a == 2)
                            {
                                if (position % 2 == 1)
                                {
                                    if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 3)
                            {
                                if (position % 2 == 1)
                                {
                                    if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 2 == 0)
                                    {
                                        if (frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 4)
                            {
                                if (position % 2 == 1)
                                {
                                    if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 2 == 0)
                                    {
                                        if (frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 5)
                            {
                                if (position % 4 == 1)
                                {
                                    if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 2)
                                    {
                                        if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (position % 4 == 3)
                                        {
                                            if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0)
                                            {
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                for (i = 2; i < 14; i++)
                                                {
                                                    for (j = 1; j < 9; j++)
                                                    {
                                                        principal[i, j].Image = Blocks[frame1[i, j]];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (position % 4 == 0)
                                            {
                                                if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0)
                                                {
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                    cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                    for (i = 2; i < 14; i++)
                                                    {
                                                        for (j = 1; j < 9; j++)
                                                        {
                                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                            if (a == 6)
                            {
                                if (position % 4 == 1)
                                {
                                    if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 2)
                                    {
                                        if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (position % 4 == 3)
                                        {
                                            if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0)
                                            {
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                for (i = 2; i < 14; i++)
                                                {
                                                    for (j = 1; j < 9; j++)
                                                    {
                                                        principal[i, j].Image = Blocks[frame1[i, j]];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (position % 4 == 0)
                                            {
                                                if (frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0)
                                                {
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                    cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                    for (i = 2; i < 14; i++)
                                                    {
                                                        for (j = 1; j < 9; j++)
                                                        {
                                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 7)
                            {
                                if (position % 4 == 1)
                                {
                                    if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 2)
                                    {
                                        if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (position % 4 == 3)
                                        {
                                            if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0)
                                            {
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                for (i = 2; i < 14; i++)
                                                {
                                                    for (j = 1; j < 9; j++)
                                                    {
                                                        principal[i, j].Image = Blocks[frame1[i, j]];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (position % 4 == 0)
                                            {
                                                if (frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0)
                                                {
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                    cordonate1[0, 1]++; cordonate1[1, 1]++; cordonate1[2, 1]++; cordonate1[3, 1]++;
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                    for (i = 2; i < 14; i++)
                                                    {
                                                        for (j = 1; j < 9; j++)
                                                        {
                                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (nextpiece == 0)
            {
                if (P % 2 == 1)
                {
                    if (gameover == 0)
                    {
                        if (cordonate1[0, 1] - 1 > 0 && cordonate1[1, 1] - 1 > 0 && cordonate1[2, 1] - 1 > 0 && cordonate1[3, 1] - 1 > 0)
                        {
                            if (a == 1)
                            {
                                if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0)
                                {
                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                    cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 1;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 1;
                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 1;

                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                }
                            }
                            if (a == 2)
                            {
                                if (position % 2 == 1)
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 3)
                            {
                                if (position % 2 == 1)
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 2 == 0)
                                    {
                                        if (frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 4)
                            {
                                if (position % 2 == 1)
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 2 == 0)
                                    {
                                        if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 5)
                            {
                                if (position % 4 == 1)
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 2)
                                    {
                                        if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (position % 4 == 3)
                                        {
                                            if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                            {
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                for (i = 2; i < 14; i++)
                                                {
                                                    for (j = 1; j < 9; j++)
                                                    {
                                                        principal[i, j].Image = Blocks[frame1[i, j]];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (position % 4 == 0)
                                            {
                                                if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                                {
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                    cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;

                                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                    for (i = 2; i < 14; i++)
                                                    {
                                                        for (j = 1; j < 9; j++)
                                                        {
                                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 6)
                            {
                                if (position % 4 == 1)
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 2)
                                    {
                                        if (frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (position % 4 == 3)
                                        {
                                            if (frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0 && frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0)
                                            {
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                for (i = 2; i < 14; i++)
                                                {
                                                    for (j = 1; j < 9; j++)
                                                    {
                                                        principal[i, j].Image = Blocks[frame1[i, j]];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (position % 4 == 0)
                                            {
                                                if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                                {
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                    cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;

                                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                    for (i = 2; i < 14; i++)
                                                    {
                                                        for (j = 1; j < 9; j++)
                                                        {
                                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (a == 7)
                            {
                                if (position % 4 == 1)
                                {
                                    if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                    {
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                        cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                        frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                        frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                        frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        for (i = 2; i < 14; i++)
                                        {
                                            for (j = 1; j < 9; j++)
                                            {
                                                principal[i, j].Image = Blocks[frame1[i, j]];
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 2)
                                    {
                                        if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0)
                                        {
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                            cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                            frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                            frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                            for (i = 2; i < 14; i++)
                                            {
                                                for (j = 1; j < 9; j++)
                                                {
                                                    principal[i, j].Image = Blocks[frame1[i, j]];
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (position % 4 == 3)
                                        {
                                            if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0)
                                            {
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                                frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                                frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                                frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                for (i = 2; i < 14; i++)
                                                {
                                                    for (j = 1; j < 9; j++)
                                                    {
                                                        principal[i, j].Image = Blocks[frame1[i, j]];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (position % 4 == 0)
                                            {
                                                if (frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                                {
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 0;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 0;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 0;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 0;
                                                    cordonate1[0, 1]--; cordonate1[1, 1]--; cordonate1[2, 1]--; cordonate1[3, 1]--;
                                                    frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7;
                                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7;
                                                    frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;

                                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                                    for (i = 2; i < 14; i++)
                                                    {
                                                        for (j = 1; j < 9; j++)
                                                        {
                                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        private void Down_Click(object sender, EventArgs e)
        {
            if(P % 2 == 1)
            {
                if (gameover == 0)
                {
                    if (a == 1)
                    {
                        while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                        {
                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                            frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 1; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 1;
                            frame1[cordonate1[0, 0], cordonate1[0, 1]] = 1; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 1;
                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                        }
                    }
                    if (a == 2)
                    {
                        if (position % 2 == 1)
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                        else
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                    }
                    if (a == 3)
                    {
                        if (position % 2 == 1)
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                        else
                        {
                            if (position % 2 == 0)
                            {
                                while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                            }
                        }
                        
                    }
                    if (a == 4)
                    {
                        if (position % 2 == 1)
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                        else
                        {
                            if (position % 2 == 0)
                            {
                                while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                            }
                        }
                    }
                    if (a == 5)
                    {
                        if (position % 4 == 1)
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                        else
                        {
                            if (position % 4 == 2)
                            {
                                while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                            }
                            else
                            {
                                if (position % 4 == 3)
                                {
                                    while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0)
                                    {
                                        cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                        frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 0)
                                    {
                                        while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0)
                                        {
                                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        }
                                    }

                                }
                            }
                        }

                    }
                    if (a == 6)
                    {
                        if (position % 4 == 1)
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                        else
                        {
                            if(position%4 == 2)
                            {
                                while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                            }
                            else
                            {
                                if (position % 4 == 3)
                                {
                                    while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                    {
                                        cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                        frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 0)
                                    {
                                        while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                        {
                                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (a == 7)
                    {
                        if (position % 4 == 1)
                        {
                            while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                            {
                                cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                            }
                        }
                        else
                        {
                            if (position % 4 == 2)
                            {
                                while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                {
                                    cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                }
                            }
                            else
                            {
                                if (position % 4 == 3)
                                {
                                    while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[2, 0] + 1, cordonate1[2, 1]] == 0)
                                    {
                                        cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                        frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                        frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                        cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                        cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                        cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                        cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    }
                                }
                                else
                                {
                                    if (position % 4 == 0)
                                    {
                                        while (cordonate1[0, 0] + 1 < 14 && cordonate1[1, 0] + 1 < 14 && cordonate1[2, 0] + 1 < 14 && cordonate1[3, 0] + 1 < 14 && frame1[cordonate1[3, 0] + 1, cordonate1[3, 1]] == 0 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                                        {
                                            cordonate1[0, 0]++; cordonate1[1, 0]++; cordonate1[2, 0]++; cordonate1[3, 0]++;
                                            frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0; frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                            frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7; frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                            cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                            cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                            cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                            cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            if (gameover == 0)
            {
                if (P % 2 == 1)
                {
                    if (nextpiece == 0)
                    {
                        if (a == 2)
                        {
                            glitch = 1;
                            if (position % 2 == 1 && glitch == 1)
                            {
                                if (cordonate1[0, 0] - 2 > -1 && cordonate1[1, 0] + 1 < 14 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[1, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[1, 0] - 2, cordonate1[1, 1]] == 0)
                                {

                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 2;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] - 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] - 1;
                                    cordonate1[3, 0] = cordonate1[3, 0] + 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] - 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }


                            if (position % 2 == 0 && glitch == 1)
                            {

                                if (cordonate1[0, 1] - 1 > 0 && cordonate1[0, 1] + 2 < 9 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 2] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 2;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] + 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] + 1;
                                    cordonate1[3, 0] = cordonate1[3, 0] - 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 2; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 2;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 2; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 2;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }

                        }
                        if (a == 3)
                        {
                            glitch = 1;
                            if (position % 2 == 1 && glitch == 1)
                            {
                                if (cordonate1[0, 0] - 1 > -1 && frame1[cordonate1[0, 0], cordonate1[1, 1] + 1] == 0 && frame1[cordonate1[0, 0] - 1, cordonate1[1, 1] + 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] - 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] + 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 2;
                                    cordonate1[3, 1] = cordonate1[3, 1] - 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }

                            if (position % 2 == 0 && glitch == 1)
                            {
                                if (cordonate1[0, 1] - 2 > 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] + 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] - 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 3; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 3;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 3; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 3;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }

                        }
                        if (a == 4)
                        {
                            glitch = 1;
                            if (position % 2 == 1 && glitch == 1)
                            {
                                if (cordonate1[0, 0] - 1 > -1 && frame1[cordonate1[0, 0], cordonate1[0, 1] - 1] == 0 && frame1[cordonate1[0, 0] - 1, cordonate1[0, 1] - 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] - 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] + 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] - 2;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 2 == 0 && glitch == 1)
                            {
                                if (cordonate1[0, 1] + 2 < 9 && frame1[cordonate1[0, 0] + 1, cordonate1[0, 1] - 2] == 0 && frame1[cordonate1[0, 0] + 2, cordonate1[0, 1]] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] + 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] - 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] + 2;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 4; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 4;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 4; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 4;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                        }
                        if (a == 5)
                        {
                            glitch = 1;
                            if (position % 4 == 1 && glitch == 1)
                            {
                                if (cordonate1[1, 0] + 1 < 14 && frame1[cordonate1[1, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[1, 0] + 1, cordonate1[1, 1]] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 1;
                                    cordonate1[3, 0] = cordonate1[3, 0] + 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] - 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 2 && glitch == 1)
                            {
                                if (cordonate1[2, 1] + 1 < 9 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] + 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] + 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 3 && glitch == 1)
                            {
                                if (cordonate1[2, 0] - 1 > -1 && frame1[cordonate1[2, 0] - 1, cordonate1[2, 1]] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 2;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 0 && glitch == 1)
                            {
                                if (cordonate1[1, 1] - 1 > 0 && frame1[cordonate1[1, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 2] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] + 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] - 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] + 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] - 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 5; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 5;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 5; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 5;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                        }
                        if (a == 6)
                        {
                            glitch = 1;
                            if (position % 4 == 1 && glitch == 1)
                            {
                                if (cordonate1[2, 1] + 1 < 9 && frame1[cordonate1[2, 0], cordonate1[2, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] + 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] - 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] + 2;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 2 && glitch == 1)
                            {
                                if (cordonate1[1, 0] - 2 > -1 && frame1[cordonate1[1, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[1, 0] - 2, cordonate1[1, 1]] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] - 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] - 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] - 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 3 && glitch == 1)
                            {
                                if (cordonate1[1, 1] + 2 < 9 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 1] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] + 2] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] + 2;
                                    cordonate1[2, 0] = cordonate1[2, 0] - 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] - 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] + 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 0 && glitch == 1)
                            {
                                if (cordonate1[1, 0] - 1 > -1 && frame1[cordonate1[1, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[0, 0] - 1, cordonate1[0, 1]] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] - 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] - 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 6; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 6;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 6; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 6;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                        }
                        if (a == 7)
                        {
                            glitch = 1;
                            if (position % 4 == 1 && glitch == 1)
                            {
                                if (cordonate1[2, 1] - 1 > 0 && frame1[cordonate1[2, 0], cordonate1[2, 1] - 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] + 1] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] + 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] + 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] + 2;
                                    cordonate1[1, 1] = cordonate1[1, 1] - 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 2 && glitch == 1)
                            {
                                if (cordonate1[0, 0] - 1 > -1 && frame1[cordonate1[0, 0], cordonate1[0, 1] + 2] == 0 && frame1[cordonate1[3, 0] - 2, cordonate1[3, 1]] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 2;
                                    cordonate1[1, 0] = cordonate1[1, 0] - 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] + 2;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 3 && glitch == 1)
                            {
                                if (cordonate1[1, 1] - 2 > 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 2] == 0 && frame1[cordonate1[1, 0], cordonate1[1, 1] - 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] + 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] - 2;
                                    cordonate1[1, 1] = cordonate1[1, 1] - 1;
                                    cordonate1[2, 0] = cordonate1[2, 0] - 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] + 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;
                                }
                            }
                            if (position % 4 == 0 && glitch == 1)
                            {
                                if (cordonate1[1, 0] - 1 > -1 && frame1[cordonate1[1, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[2, 0] - 1, cordonate1[1, 1]] == 0 && frame1[cordonate1[3, 0], cordonate1[3, 1] - 1] == 0)
                                {
                                    frame1[cordonate2[0, 0], cordonate2[0, 1]] = 0; frame1[cordonate2[1, 0], cordonate2[1, 1]] = 0;
                                    frame1[cordonate2[2, 0], cordonate2[2, 1]] = 0; frame1[cordonate2[3, 0], cordonate2[3, 1]] = 0;
                                    cordonate1[0, 0] = cordonate1[0, 0] - 1;
                                    cordonate1[0, 1] = cordonate1[0, 1] + 1;
                                    cordonate1[1, 0] = cordonate1[1, 0] - 1;
                                    cordonate1[1, 1] = cordonate1[1, 1] + 1;
                                    cordonate1[2, 1] = cordonate1[2, 1] - 1;
                                    cordonate1[3, 1] = cordonate1[3, 1] - 1;
                                    frame1[cordonate1[2, 0], cordonate1[2, 1]] = 7; frame1[cordonate1[3, 0], cordonate1[3, 1]] = 7;
                                    frame1[cordonate1[1, 0], cordonate1[1, 1]] = 7; frame1[cordonate1[0, 0], cordonate1[0, 1]] = 7;
                                    cordonate2[1, 0] = cordonate1[1, 0]; cordonate2[2, 0] = cordonate1[2, 0];
                                    cordonate2[0, 0] = cordonate1[0, 0]; cordonate2[3, 0] = cordonate1[3, 0];
                                    cordonate2[1, 1] = cordonate1[1, 1]; cordonate2[2, 1] = cordonate1[2, 1];
                                    cordonate2[0, 1] = cordonate1[0, 1]; cordonate2[3, 1] = cordonate1[3, 1];
                                    for (i = 2; i < 14; i++)
                                    {
                                        for (j = 1; j < 9; j++)
                                        {
                                            principal[i, j].Image = Blocks[frame1[i, j]];
                                        }
                                    }
                                    glitch = 0;
                                    position++;

                                }
                            }
                        }

                    }
                }
            }




        }
    }
}

