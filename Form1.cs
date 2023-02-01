using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SnakeGame
{
    public partial class Form1 : Form
    {
        bool red = false;
        
        int flag=0;
        //int x = 40;
        //int y = 540;
        //int x = 2;
        //int y = 573;
        //int x = 23;
        //int y = 566;
        int x = 2;
        int y = 577;
        int diceNum;
        //int x = 99;
        //int y = 567;

        //int x = 105;
        //int y = 382;


        int p=0;

        bool blue = false;
        int xblue = 2;
        int yblue = 577;
        int pblue = 0;
      
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //labelVisible();
            //if (flag==0)
            //{
            //    button2.Enabled=false;

            //}
            //hidden you are win
            //***********************************hidden label and stone and textbox ******************************************
            textBox1.Visible = false;
            textBox2.Visible = false;
            //not used because there is broblem with instance from Label
            label9.Visible = false;
            label11.Visible = false;

            pictureBox4.Visible = false; 
            pictureBox6.Visible = false;
            //  pictureBox5.Load("./Images/dice.png");$"Images/{dice}.png"
            //***********************************load image ******************************************
            pictureBox5.BackgroundImage = Image.FromFile("Images/dice.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox2.BackgroundImage = Image.FromFile("Images/r1.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox3.BackgroundImage = Image.FromFile("Images/b2.jpg");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;

            
            pictureBox4.BackgroundImage = Image.FromFile("Images/r11.jpg");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox6.BackgroundImage = Image.FromFile("Images/b22.jpg");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;

            
           
        }
        //***********************************player 1 red******************************************
        private void button1_Click(object sender, EventArgs e)
        {

            //Logics.labelVisible(label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13);
            diceNum = Logics.rollDice(pictureBox5);
                label2.Text = diceNum.ToString();
               
           
            if (red == true)
            {
               p= Logics.Move(ref p, pictureBox4, ref x, ref y, textBox1, diceNum);
                label7.Text = p.ToString();
               // x += 80;
                //pictureBox4.Location = new Point(x, y);
                label4.Text = pictureBox5. Location.X.ToString();
                label6.Text = pictureBox5. Location.Y.ToString();

            }
            //label2.Text == "6" &&
            if ( red==false)
            {
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                red = true;
                pictureBox4.Location = new Point(x, y);
                label4.Text = x.ToString();
                label6.Text = y.ToString();

                
                label7.Text = p.ToString();
                p++;
            }

           
           
            p= Logics.ladder(ref x, ref y,ref p, pictureBox4);
            //label7.Text = p.ToString();
            p = Logics.snake(ref x, ref y,ref p, pictureBox4);
            label7.Text = p.ToString();

            //diceNum == 6
            if (red == false)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                button1.Enabled = false;
                button2.Enabled = true;
            }

            if (p == 100)
            {
                MessageBox.Show("Red win");
              
                button1.Enabled = false;
                button2.Enabled = false;
                //apper you are win
                textBox1.Visible = true;
                textBox1.Text = "Player 1 win";
                textBox1.ForeColor = System.Drawing.Color.White;


            }

        }//the end button1 click
         //***********************************plater 2 blue ******************************************
        private void button2_Click(object sender, EventArgs e)
        {

            diceNum = Logics.rollDice(pictureBox5);
            label2.Text = diceNum.ToString();


            if (blue == true)
            {
                pblue = Logics.Move(ref pblue, pictureBox6, ref xblue, ref yblue, textBox2, diceNum);
                label10.Text = pblue.ToString();
                // x += 80;
                //pictureBox4.Location = new Point(x, y);
                label12.Text = pictureBox6.Location.X.ToString();
                label13.Text = pictureBox6.Location.Y.ToString();

            }


            //label2.Text == "6" &&
                if ( blue == false)
                {
                    pictureBox3.Visible = false;
                    pictureBox6.Visible = true;
                   blue = true;
                    pictureBox6.Location = new Point(xblue, yblue);
                    label12.Text = xblue.ToString();
                    label13.Text = yblue.ToString();

                   
                    label10.Text = pblue.ToString();
                    pblue++;
                }

                
            
                pblue = Logics.ladder(ref xblue, ref yblue, ref pblue, pictureBox6);
                //label7.Text = p.ToString();
                 pblue = Logics.snake(ref xblue, ref yblue, ref pblue, pictureBox6);
                label10.Text = pblue.ToString();

            // diceNum == 6
            if (blue == false)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
                button2.Enabled = false;
                button1.Enabled = true;
            }
            if (pblue == 100)
            {
                MessageBox.Show("blue win");

                button2.Enabled = false;
                button1.Enabled = false;
               
                textBox2.Visible = true;
                textBox2.Text = "Player 2 win";
                textBox2.ForeColor = System.Drawing.Color.White;

            }

        }//the end button2 click

        //public void labelVisible()
        //{
        //    //l1.visible=false;
        //    //label2.Visible = false;
        //    //l3.visible = false;
        //    label4.Visible = false;
        //    // l5.visible = false;
        //    label6.Visible = false;
        //    label7.Visible = false;
        //    //l8.visible = false;
        //    label9.Visible = false;
        //    label10.Visible = false;
        //    label11.Visible = false;
        //    label12.Visible = false;
        //    label13.Visible = false;
        //}

         
    }//the end class form
}//the end namespace
