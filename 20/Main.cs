using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace _20
{
    public partial class Main : Form
    {
        int sum = 0;
        bool done = false;
        MyButton[,] mybtns;
        string[,] mybtnsBackup;
        public Main()
        {
            InitializeComponent();

            mybtns = new MyButton[,]{
                { btn00,btn01,btn02,btn03 },
                { btn10,btn11,btn12,btn13 },
                { btn20,btn21,btn22,btn23 },
                { btn30,btn31,btn32,btn33 },

            };
            mybtnsBackup = new string[4, 4];
            paintColor();


        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    mybtnsBackup[i, j] = mybtns[i, j].Text;

            paintColor();
            string key = e.KeyChar.ToString().ToUpper();

            if (key.Equals("A"))
            {
                moveToFreeSpace(false, false, false, true); moveToFreeSpace(false, false, false, true);
                AddLeft();
                moveToFreeSpace(false, false, false, true); moveToFreeSpace(false, false, false, true);

                if (done)
                    addNumber();
                done = false;
            }
            if (key.Equals("S"))
            {

                AddDown();

                if (done)
                    addNumber();
                done = false;
            }
            if (key.Equals("W"))
            {
                AddUp();

                if (done)
                    addNumber();
                done = false;

            }
            if (key.Equals("D"))
            {
                AddRight();

                if (done)
                    addNumber();
                done = false;
            }
            paintColor();
            label2.Text = sum + "";

        }
        public void AddLeft()
        {
            for (int y = 0; y <= 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (mybtns[y, x].Text == "" && mybtns[y, x].Text.Length > 0)
                    {
                        mybtns[y, x].Text = mybtns[y, x + 1].Text;
                        mybtns[y, x + 1].Text = "";
                        done = true;

                    }
                    else
                    {

                        if (mybtns[y, x].Text.Equals(mybtns[y, x + 1].Text) && mybtns[y, x + 1].Text.Length > 0)
                        {
                            sum += int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x + 1].Text);
                            mybtns[y, x].Text = int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x + 1].Text) + "";
                            mybtns[y, x + 1].Text = "";
                            done = true;


                        }
                    }
                }
            }

        }
        public void AddUp()
        {

            for (int y = 0; y < 3; y++)
            {
                moveToFreeSpace(false, false, true); moveToFreeSpace(false, false, true);

                for (int x = 0; x <= 3; x++)
                {

                    if (mybtns[y, x].Text == "" && mybtns[y + 1, x].Text.Length > 0)
                    {

                        mybtns[y, x].Text = mybtns[y + 1, x].Text;
                        mybtns[y + 1, x].Text = "";
                        done = true;
                    }
                    else
                    {
                        if (mybtns[y, x].Text.Equals(mybtns[y + 1, x].Text) && mybtns[y + 1, x].Text.Length > 0)
                        {
                            sum += int.Parse(mybtns[y + 1, x].Text) + int.Parse(mybtns[y, x].Text);
                            mybtns[y, x].Text = int.Parse(mybtns[y + 1, x].Text) + int.Parse(mybtns[y, x].Text) + "";
                            mybtns[y + 1, x].Text = "";
                            done = true;

                        }
                    }

                }
            }

        }
        public void AddDown()
        {

            for (int y = 3; y > 0; y--)
            {
                moveToFreeSpace(false, true); moveToFreeSpace(false, true);
                for (int x = 0; x <= 3; x++)
                {

                    if (mybtns[y, x].Text == "" && mybtns[y - 1, x].Text.Length > 0)
                    {

                        mybtns[y, x].Text = mybtns[y - 1, x].Text;
                        mybtns[y - 1, x].Text = "";
                        done = true;

                    }

                    if (mybtns[y, x].Text.Equals(mybtns[y - 1, x].Text) && mybtns[y - 1, x].Text.Length > 0)
                    {
                        sum += int.Parse(mybtns[y - 1, x].Text) + int.Parse(mybtns[y, x].Text);
                        mybtns[y, x].Text = int.Parse(mybtns[y - 1, x].Text) + int.Parse(mybtns[y, x].Text) + "";
                        mybtns[y - 1, x].Text = "";
                        done = true;

                    }


                }
            }
        }
        public void AddRight()
        {
            for (int y = 0; y <= 3; y++)
            {

                for (int x = 3; x > 0; x--)
                {
                    moveToFreeSpace(true); moveToFreeSpace(true);
                    if (mybtns[y, x].Text == "" && mybtns[y, x - 1].Text.Length > 0)
                    {
                        mybtns[y, x].Text = mybtns[y, x - 1].Text;
                        mybtns[y, x - 1].Text = "";
                        done = true;
                    }
                    else
                    {
                        if (mybtns[y, x].Text.Equals(mybtns[y, x - 1].Text) && mybtns[y, x - 1].Text.Length > 0)
                        {
                            sum += (int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x - 1].Text));
                            mybtns[y, x].Text = int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x - 1].Text) + "";
                            mybtns[y, x - 1].Text = "";
                            done = true;

                        }
                    }

                }

            }

        }
        public void moveToFreeSpace(bool right = false, bool down = false, bool up = false, bool left = false)
        {
            if (right)
                //right
                for (int y = 0; y <= 3; y++)
                {
                    for (int x = 3; x > 0; x--)
                    {
                        if (mybtns[y, x].Text == "" && mybtns[y, x - 1].Text.Length > 0)
                        {
                            mybtns[y, x].Text = mybtns[y, x - 1].Text;
                            mybtns[y, x - 1].Text = "";
                            done = true;
                        }
                    }
                }
            if (down)
                //down
                for (int y = 3; y > 0; y--)
                {

                    for (int x = 0; x <= 3; x++)
                    {

                        if (mybtns[y, x].Text == "" && mybtns[y - 1, x].Text.Length > 0)
                        {

                            mybtns[y, x].Text = mybtns[y - 1, x].Text;
                            mybtns[y - 1, x].Text = "";
                            done = true;
                        }
                    }
                }
            if (up)
                //up
                for (int y = 0; y < 3; y++)
                {

                    for (int x = 0; x <= 3; x++)
                    {

                        if (mybtns[y, x].Text == "" && mybtns[y + 1, x].Text.Length > 0)
                        {

                            mybtns[y, x].Text = mybtns[y + 1, x].Text;
                            mybtns[y + 1, x].Text = "";
                            done = true;
                        }
                    }
                }
            if (left)
                for (int y = 0; y <= 3; y++)
                {
                    for (int x = 3; x > 0; x--)
                    {
                        if (mybtns[y, x - 1].Text == "" && mybtns[y, x].Text.Length > 0)
                        {

                            mybtns[y, x - 1].Text = mybtns[y, x].Text;
                            mybtns[y, x].Text = "";
                            done = true;
                        }
                    }
                }
        }
        public void addNumber()
        {
            List<MyButton> emptybuttons = new List<MyButton>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mybtns[i, j].Text.Equals(""))
                    {
                        emptybuttons.Add(mybtns[i, j]);
                    }
                }
            }
            Random r = new Random();
            int k = r.Next(emptybuttons.Count);
            if (emptybuttons.Count == 0)
            {
                MessageBox.Show("GAME OVER", " GAME OVER", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                emptybuttons[k].Text = "2";
            }


        }
        public void paintColor()
        {
            foreach (MyButton mb in Controls.OfType<MyButton>())
            {
                mb.BackColor = Color.FromArgb(175, 175, 175);
                mb.BackgroundImage = null;

                if (mb.Text == "2")
                    mb.BackgroundImage = Properties.Resources._2;
                if (mb.Text == "4")
                    mb.BackgroundImage = Properties.Resources._4;
                if (mb.Text == "8")
                    mb.BackgroundImage = Properties.Resources._8;
                if (mb.Text == "16")
                    mb.BackgroundImage = Properties.Resources._16;
                if (mb.Text == "32")
                    mb.BackgroundImage = Properties.Resources._32;
                if (mb.Text == "64")
                    mb.BackgroundImage = Properties.Resources._64;
                if (mb.Text == "128")
                    mb.BackgroundImage = Properties.Resources._128;
                if (mb.Text == "256")
                    mb.BackgroundImage = Properties.Resources._254;
                if (mb.Text == "512")
                    mb.BackgroundImage = Properties.Resources._512;
                if (mb.Text == "1024")
                    mb.BackgroundImage = Properties.Resources._1024;
                if (mb.Text == "2048")
                    mb.BackgroundImage = Properties.Resources._2048;
                if (mb.Text == "4096")
                    mb.BackgroundImage = Properties.Resources._4096;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (MyButton mbtns in Controls.OfType<MyButton>())
            {
                mbtns.Text = "";
            }
            btn21.Text = "2";
            sum = 0;
            label2.Text = "0";
            paintColor();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    mybtns[i, j].Text = mybtnsBackup[i, j];
            }
            paintColor();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int points = int.Parse(label2.Text);
            Records r = new Records(points);
            r.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:
                    SendKeys.Send("s");
                    break;
                case Keys.Right:
                    SendKeys.Send("d");
                    break;
                case Keys.Up:
                    SendKeys.Send("w");
                    break;
                case Keys.Left:
                    SendKeys.Send("a");
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
