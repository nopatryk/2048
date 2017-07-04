using System.Windows.Forms;

namespace _20
{
    public class MyButton : Button
    {
    }
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn33 = new _20.MyButton();
            this.btn32 = new _20.MyButton();
            this.btn31 = new _20.MyButton();
            this.btn30 = new _20.MyButton();
            this.btn23 = new _20.MyButton();
            this.btn22 = new _20.MyButton();
            this.btn21 = new _20.MyButton();
            this.btn20 = new _20.MyButton();
            this.btn13 = new _20.MyButton();
            this.btn12 = new _20.MyButton();
            this.btn11 = new _20.MyButton();
            this.btn10 = new _20.MyButton();
            this.btn03 = new _20.MyButton();
            this.btn02 = new _20.MyButton();
            this.btn01 = new _20.MyButton();
            this.btn00 = new _20.MyButton();
            this.label4 = new System.Windows.Forms.Label();
            this.top1 = new System.Windows.Forms.PictureBox();
            this.top1record = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.top1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(281, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "POINTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(275, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 57);
            this.label2.TabIndex = 17;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(87)))));
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(281, 83);
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
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(87)))));
            this.button2.CausesValidation = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(281, 171);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(117, 57);
            this.button2.TabIndex = 19;
            this.button2.Text = "COFNIJ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.panel1.Location = new System.Drawing.Point(9, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 263);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(118, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 22;
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn33.CausesValidation = false;
            this.btn33.Enabled = false;
            this.btn33.FlatAppearance.BorderSize = 0;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn33.Location = new System.Drawing.Point(198, 252);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(58, 59);
            this.btn33.TabIndex = 15;
            this.btn33.UseVisualStyleBackColor = false;
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn32.CausesValidation = false;
            this.btn32.Enabled = false;
            this.btn32.FlatAppearance.BorderSize = 0;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn32.Location = new System.Drawing.Point(136, 252);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(58, 59);
            this.btn32.TabIndex = 14;
            this.btn32.UseVisualStyleBackColor = false;
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn31.CausesValidation = false;
            this.btn31.Enabled = false;
            this.btn31.FlatAppearance.BorderSize = 0;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn31.Location = new System.Drawing.Point(74, 252);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(58, 59);
            this.btn31.TabIndex = 13;
            this.btn31.UseVisualStyleBackColor = false;
            // 
            // btn30
            // 
            this.btn30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn30.CausesValidation = false;
            this.btn30.Enabled = false;
            this.btn30.FlatAppearance.BorderSize = 0;
            this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn30.Location = new System.Drawing.Point(12, 252);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(58, 59);
            this.btn30.TabIndex = 12;
            this.btn30.UseVisualStyleBackColor = false;
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn23.CausesValidation = false;
            this.btn23.Enabled = false;
            this.btn23.FlatAppearance.BorderSize = 0;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn23.Location = new System.Drawing.Point(198, 189);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(58, 59);
            this.btn23.TabIndex = 11;
            this.btn23.UseVisualStyleBackColor = false;
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn22.CausesValidation = false;
            this.btn22.Enabled = false;
            this.btn22.FlatAppearance.BorderSize = 0;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn22.Location = new System.Drawing.Point(136, 189);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(58, 59);
            this.btn22.TabIndex = 10;
            this.btn22.Text = "2";
            this.btn22.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn21.CausesValidation = false;
            this.btn21.Enabled = false;
            this.btn21.FlatAppearance.BorderSize = 0;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn21.Location = new System.Drawing.Point(74, 189);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(58, 59);
            this.btn21.TabIndex = 9;
            this.btn21.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn20.CausesValidation = false;
            this.btn20.Enabled = false;
            this.btn20.FlatAppearance.BorderSize = 0;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn20.Location = new System.Drawing.Point(12, 189);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(58, 59);
            this.btn20.TabIndex = 8;
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn13.CausesValidation = false;
            this.btn13.Enabled = false;
            this.btn13.FlatAppearance.BorderSize = 0;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn13.Location = new System.Drawing.Point(198, 126);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(58, 59);
            this.btn13.TabIndex = 7;
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn12.CausesValidation = false;
            this.btn12.Enabled = false;
            this.btn12.FlatAppearance.BorderSize = 0;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn12.Location = new System.Drawing.Point(136, 126);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(58, 59);
            this.btn12.TabIndex = 6;
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn11.CausesValidation = false;
            this.btn11.Enabled = false;
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn11.Location = new System.Drawing.Point(74, 126);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(58, 59);
            this.btn11.TabIndex = 5;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn10.CausesValidation = false;
            this.btn10.Enabled = false;
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn10.Location = new System.Drawing.Point(12, 126);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(58, 59);
            this.btn10.TabIndex = 4;
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn03
            // 
            this.btn03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn03.CausesValidation = false;
            this.btn03.Enabled = false;
            this.btn03.FlatAppearance.BorderSize = 0;
            this.btn03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn03.Location = new System.Drawing.Point(198, 63);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(58, 59);
            this.btn03.TabIndex = 3;
            this.btn03.UseVisualStyleBackColor = false;
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn02.CausesValidation = false;
            this.btn02.Enabled = false;
            this.btn02.FlatAppearance.BorderSize = 0;
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn02.Location = new System.Drawing.Point(136, 63);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(58, 59);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = false;
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn01.CausesValidation = false;
            this.btn01.Enabled = false;
            this.btn01.FlatAppearance.BorderSize = 0;
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn01.Location = new System.Drawing.Point(74, 63);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(58, 59);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn00.CausesValidation = false;
            this.btn00.Enabled = false;
            this.btn00.FlatAppearance.BorderSize = 0;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn00.Location = new System.Drawing.Point(12, 63);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(58, 59);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Left to record:";
            // 
            // top1
            // 
            this.top1.Image = global::_20.Properties.Resources.top1;
            this.top1.Location = new System.Drawing.Point(316, 234);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(52, 54);
            this.top1.TabIndex = 24;
            this.top1.TabStop = false;
            // 
            // top1record
            // 
            this.top1record.Location = new System.Drawing.Point(275, 300);
            this.top1record.Name = "top1record";
            this.top1record.Size = new System.Drawing.Size(123, 22);
            this.top1record.TabIndex = 25;
            this.top1record.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(410, 331);
            this.Controls.Add(this.top1record);
            this.Controls.Add(this.top1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2047";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.top1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel1;
        private Label label3;
        private Label label4;
        private PictureBox top1;
        private Label top1record;
    }

}

