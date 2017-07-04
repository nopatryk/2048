using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class InputBox : Form
    {
        
        private int points;
        public InputBox(int points)
        {
            
            InitializeComponent();
            this.inputNickBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.points = points;

        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                saveNick.PerformClick();
            }
        }

        private void saveNick_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.top1recordS = inputNickBox.Text +" "+ points;
            Properties.Settings.Default.nick = inputNickBox.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

            this.Close();
        }

    }
}
