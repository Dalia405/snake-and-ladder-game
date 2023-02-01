using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection.Emit;


namespace SnakeGame
{
    internal class Logics
    {
       
        public static int rollDice(PictureBox p)
        {
            
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);

            p.BackgroundImage = Image.FromFile($"Images/{dice}.png");
            p.BackgroundImageLayout = ImageLayout.Stretch;

            return dice;
        }//the end rollDice

        //******************************************************Move*****************************************************************
        public static int Move(ref int p, PictureBox box, ref int x, ref int y, TextBox text, int diceNum)
        {
            if (diceNum + p > 100)
            {
                text.Visible = true;
                text.Text = "you can not move";
                text.ForeColor = System.Drawing.Color.Red;
                // return;
            }
            else
            {



                for (int i = 0; i < diceNum; i++)
                {



                    if (p == 10)
                    {
                        //x = 21;
                        //y = 507;
                        //  p++;
                        x = 737;
                        y = 507;
                        
                    }

                    else
                    {
                        if (p == 20)
                        {
                            x = 21;
                            y = 446;
                            //  p++;
                        }
                        else
                        {
                            if (p == 30)
                            {
                               
                                //x = 21;
                                //y = 384;

                                //  p++;
                                x = 737;
                                y = 384;
                            }
                            else
                            {
                                if (p == 40)
                                {
                                    x = 21;
                                    y = 321;
                                    //   p++;
                                }
                                else
                                {
                                    if (p == 50)
                                    {
                                        //x = 21;
                                        //y = 260;
                                        //  p++;
                                        x = 737;
                                        y = 260;
                                       
                                    }
                                    else
                                    {
                                        if (p == 60)
                                        {
                                            x = 21;
                                            y = 195;
                                            //  p++;
                                        }
                                        else
                                        {
                                            if (p == 70)
                                            {
                                                //x = 21;
                                                //y = 140;
                                                //   p++;
                                                x = 737;
                                                y = 140;
                                                
                                            }
                                            else
                                            {
                                                if (p == 80)
                                                {
                                                    x = 21;
                                                    y = 77;
                                                    //   p++;
                                                }
                                                else
                                                {
                                                    if (p == 90)
                                                    {
                                                        //x = 21;
                                                        //y = 12;
                                                        //   p++;
                                                        x = 739;
                                                        y = 12;
                                                       
                                                    }
                                                    else
                                                    {
                                                        
                                                        if (p > 10 && p<20 || p > 30 && p < 40 || p > 50 && p < 60 || p > 70 && p < 80 || p > 90)
                                                        {
                                                            x -= 80;
                                                        }
                                                        else
                                                        {
                                                           
                                                                x += 80;
                                                        }
                                                       
                                                        // p++

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }


                            }

                        }

                    }//the end else
                     // l.Text = p.ToString();
                   
                    box.Location = new Point(x, y);
                    p++;
                }//the end loop
            }
            return p;
        }//the end move
        //******************************************************ladder*****************************************************************
        public static int ladder(ref int x,ref int y,ref int p,PictureBox boxLadder)
        {
            if (p == 3)
            {

                x = 12;
                y = 446;
                p =21;
                // p = 17;

            }
            else
            {
                if (p == 8)
                {
                   
                    x = 740;
                    y = 446;
                    p = 30;
                }
                else
                {
                   
                    if (p == 28)
                    {

                        x = 259;
                        y = 75;
                        p = 84;
                    }
                    else
                    {
                        if (p == 58)
                        {
                           
                            x = 262;
                            y = 139;
                            p = 77;
                        }
                        else
                        {
                            if (p == 75)
                            {
                                x = 420;
                                y = 82;
                                p = 86;
                            }
                            else
                            {
                                if (p == 80)
                                {
                                   


                                    x = 22;
                                    y = 12;
                                    p = 100;
                                }
                                else
                                {
                                    if (p == 90)
                                    {
                                        x = 737;
                                        y = 12;
                                        p = 91;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            boxLadder.Location = new Point(x, y);
            return p;
        }//the end ladder
        //******************************************************snake*****************************************************************
        public static int snake(ref int x, ref int y,ref int p, PictureBox boxSnake)
        {
            if (p == 17)
            {
                x = 580;
                y = 507;
                p = 13;
                // p = 17;
            }
            else
            {
                if (p == 52)
                {
                   
                    x = 654;
                    y = 440;
                    p = 29;
                }
                else
                {

                    if (p == 57)
                    {
                        
                        x = 12;
                        y = 385;
                        p = 40;
                    }
                    else
                    {
                      
                        if (p == 62)
                        {
                            x = 100;
                            y = 448;
                            p = 22;
                        }
                        else
                        {
                            if (p == 88)
                            {
                                
                                x = 182;
                                y = 509;
                                p = 18;
                            }
                            else
                            {
                                if (p == 95)
                                {
                                   
                                   x = 740;
                                    y = 260;
                                    p = 51;
                                }
                                else
                                {
                                   
                                    if (p == 97)
                                    {
                                        x = 100;
                                        y = 139;
                                        p = 79;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            boxSnake.Location = new Point(x, y);
            return p;
        }//the end snake

       


    }//end class logics
}

