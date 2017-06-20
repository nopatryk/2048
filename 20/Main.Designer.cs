using System.Windows.Forms;

namespace _20
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn33 = new MyButton();
            this.btn32 = new MyButton();
            this.btn31 = new MyButton();
            this.btn30 = new MyButton();
            this.btn23 = new MyButton();
            this.btn22 = new MyButton();
            this.btn21 = new MyButton();
            this.btn20 = new MyButton();
            this.btn13 = new MyButton();
            this.btn12 = new MyButton();
            this.btn11 = new MyButton();
            this.btn10 = new MyButton();
            this.btn03 = new MyButton();
            this.btn02 = new MyButton();
            this.btn01 = new MyButton();
            this.btn00 = new MyButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(277, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "POINTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(271, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 57);
            this.label2.TabIndex = 17;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(277, 75);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(117, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "RESETUJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.CausesValidation = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(277, 138);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(117, 57);
            this.button2.TabIndex = 19;
            this.button2.Text = "COFNIJ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.CausesValidation = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(277, 201);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(117, 57);
            this.button3.TabIndex = 20;
            this.button3.Text = "REKORDY";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn33
            // 
            this.btn33.CausesValidation = false;
            this.btn33.Enabled = false;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn33.Location = new System.Drawing.Point(198, 201);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(56, 57);
            this.btn33.TabIndex = 15;
            this.btn33.UseVisualStyleBackColor = true;
            // 
            // btn32
            // 
            this.btn32.CausesValidation = false;
            this.btn32.Enabled = false;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn32.Location = new System.Drawing.Point(136, 201);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(56, 57);
            this.btn32.TabIndex = 14;
            this.btn32.UseVisualStyleBackColor = true;
            // 
            // btn31
            // 
            this.btn31.CausesValidation = false;
            this.btn31.Enabled = false;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn31.Location = new System.Drawing.Point(74, 201);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(56, 57);
            this.btn31.TabIndex = 13;
            this.btn31.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.CausesValidation = false;
            this.btn30.Enabled = false;
            this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn30.Location = new System.Drawing.Point(12, 201);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(56, 57);
            this.btn30.TabIndex = 12;
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // btn23
            // 
            this.btn23.CausesValidation = false;
            this.btn23.Enabled = false;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn23.Location = new System.Drawing.Point(198, 138);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(56, 57);
            this.btn23.TabIndex = 11;
            this.btn23.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.CausesValidation = false;
            this.btn22.Enabled = false;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn22.Location = new System.Drawing.Point(136, 138);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(56, 57);
            this.btn22.TabIndex = 10;
            this.btn22.Text = "2";
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.CausesValidation = false;
            this.btn21.Enabled = false;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn21.Location = new System.Drawing.Point(74, 138);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(56, 57);
            this.btn21.TabIndex = 9;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.CausesValidation = false;
            this.btn20.Enabled = false;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn20.Location = new System.Drawing.Point(12, 138);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(56, 57);
            this.btn20.TabIndex = 8;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.CausesValidation = false;
            this.btn13.Enabled = false;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn13.Location = new System.Drawing.Point(198, 75);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(56, 57);
            this.btn13.TabIndex = 7;
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.CausesValidation = false;
            this.btn12.Enabled = false;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn12.Location = new System.Drawing.Point(136, 75);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(56, 57);
            this.btn12.TabIndex = 6;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.CausesValidation = false;
            this.btn11.Enabled = false;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11.Location = new System.Drawing.Point(74, 75);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(56, 57);
            this.btn11.TabIndex = 5;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.CausesValidation = false;
            this.btn10.Enabled = false;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10.Location = new System.Drawing.Point(12, 75);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(56, 57);
            this.btn10.TabIndex = 4;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn03
            // 
            this.btn03.CausesValidation = false;
            this.btn03.Enabled = false;
            this.btn03.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn03.Location = new System.Drawing.Point(198, 12);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(56, 57);
            this.btn03.TabIndex = 3;
            this.btn03.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.CausesValidation = false;
            this.btn02.Enabled = false;
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn02.Location = new System.Drawing.Point(136, 12);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(56, 57);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.CausesValidation = false;
            this.btn01.Enabled = false;
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn01.Location = new System.Drawing.Point(74, 12);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(56, 57);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.CausesValidation = false;
            this.btn00.Enabled = false;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn00.Location = new System.Drawing.Point(12, 12);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(56, 57);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 266);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2047";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private MyButton btn01;
        private MyButton btn02;
        private MyButton btn03;
        private MyButton btn10;
        private MyButton btn11;
        private MyButton btn12;
        private MyButton btn13;
        private MyButton btn20;
        private MyButton btn21;
        private MyButton btn22;
        private MyButton btn23;
        private MyButton btn00;
        private MyButton btn30;
        private MyButton btn31;
        private MyButton btn32;
        private MyButton btn33;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }

}

