using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Settings = _20.Properties.Settings;


namespace _20
{

    public partial class Main : Form
    {

        private int sumOfPoints = 0, currentRecord = 0; // sum of curernt points && current top1 record
        private bool moveDone = false; // check if move of tiles is done
        private MyButton[,] mybtns; // array of 'tiles' with points
        private string[,] mybtnsBackup; // array to save last move
     
        public Main()
        {
            InitializeComponent();
            Settings.Default.nick = "";

            mybtns = new MyButton[,]{
                { btn00,btn01,btn02,btn03 },
                { btn10,btn11,btn12,btn13 },
                { btn20,btn21,btn22,btn23 },
                { btn30,btn31,btn32,btn33 },

            };
            mybtnsBackup = new string[4, 4];
            paintColor();

            top1record.Text = Settings.Default.top1recordS;
            currentRecord = int.Parse(Settings.Default.top1recordS.Substring(Settings.Default.top1recordS.LastIndexOf(' ')));

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

                if (moveDone)
                    addNumber();
                moveDone = false;
            }
            if (key.Equals("S"))
            {

                AddDown();

                if (moveDone)
                    addNumber();
                moveDone = false;
            }
            if (key.Equals("W"))
            {
                AddUp();

                if (moveDone)
                    addNumber();
                moveDone = false;

            }
            if (key.Equals("D"))
            {
                AddRight();

                if (moveDone)
                    addNumber();
                moveDone = false;
            }
            paintColor();
            label2.Text = sumOfPoints + "";
            int left = currentRecord - sumOfPoints;
            if(left > 0)
            {
                label3.Text = left + "";
            }
            else if(left <= 0)
            {
                label3.Text = "New Record!";
                if (Settings.Default.nick.Equals(""))
                {
                    InputBox ib = new InputBox(sumOfPoints);
                    ib.Show();
                }
                else
                {
                    Settings.Default.top1recordS = Settings.Default.nick + " " + sumOfPoints;
                    Settings.Default.Save();
                    Settings.Default.Upgrade();
                }

            }



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
                        moveDone = true;

                    }
                    else
                    {

                        if (mybtns[y, x].Text.Equals(mybtns[y, x + 1].Text) && mybtns[y, x + 1].Text.Length > 0)
                        {
                            sumOfPoints += int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x + 1].Text);
                            mybtns[y, x].Text = int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x + 1].Text) + "";
                            mybtns[y, x + 1].Text = "";
                            moveDone = true;

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
                        moveDone = true;
                    }
                    else
                    {
                        if (mybtns[y, x].Text.Equals(mybtns[y + 1, x].Text) && mybtns[y + 1, x].Text.Length > 0)
                        {
                            sumOfPoints += int.Parse(mybtns[y + 1, x].Text) + int.Parse(mybtns[y, x].Text);
                            mybtns[y, x].Text = int.Parse(mybtns[y + 1, x].Text) + int.Parse(mybtns[y, x].Text) + "";
                            mybtns[y + 1, x].Text = "";
                            moveDone = true;

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
                        moveDone = true;

                    }

                    if (mybtns[y, x].Text.Equals(mybtns[y - 1, x].Text) && mybtns[y - 1, x].Text.Length > 0)
                    {
                        sumOfPoints += int.Parse(mybtns[y - 1, x].Text) + int.Parse(mybtns[y, x].Text);
                        mybtns[y, x].Text = int.Parse(mybtns[y - 1, x].Text) + int.Parse(mybtns[y, x].Text) + "";
                        mybtns[y - 1, x].Text = "";
                        moveDone = true;

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
                        moveDone = true;
                    }
                    else
                    {
                        if (mybtns[y, x].Text.Equals(mybtns[y, x - 1].Text) && mybtns[y, x - 1].Text.Length > 0)
                        {
                            sumOfPoints += (int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x - 1].Text));
                            mybtns[y, x].Text = int.Parse(mybtns[y, x].Text) + int.Parse(mybtns[y, x - 1].Text) + "";
                            mybtns[y, x - 1].Text = "";
                            moveDone = true;

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
                            moveDone = true;
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
                            moveDone = true;
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
                            moveDone = true;
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
                            moveDone = true;
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

            if (emptybuttons.Count != 0)
            {
                Random r = new Random();
                int k = r.Next(emptybuttons.Count);
                emptybuttons[k].Text = "2";
            }
            else
            {
                MessageBox.Show("GAME OVER", " GAME OVER", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
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
            sumOfPoints = 0;
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
