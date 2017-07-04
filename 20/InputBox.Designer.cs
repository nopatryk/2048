namespace _20
{
    partial class InputBox
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
            this.saveNick = new System.Windows.Forms.Button();
            this.InputNickLabel = new System.Windows.Forms.Label();
            this.inputNickBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveNick
            // 
            this.saveNick.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveNick.Location = new System.Drawing.Point(221, 0);
            this.saveNick.Name = "saveNick";
            this.saveNick.Size = new System.Drawing.Size(75, 33);
            this.saveNick.TabIndex = 0;
            this.saveNick.Text = "OK";
            this.saveNick.UseVisualStyleBackColor = true;
            this.saveNick.Click += new System.EventHandler(this.saveNick_Click);
            // 
            // InputNickLabel
            // 
            this.InputNickLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputNickLabel.AutoSize = true;
            this.InputNickLabel.Location = new System.Drawing.Point(13, 8);
            this.InputNickLabel.Name = "InputNickLabel";
            this.InputNickLabel.Size = new System.Drawing.Size(32, 13);
            this.InputNickLabel.TabIndex = 1;
            this.InputNickLabel.Text = "Nick:";
            // 
            // inputNickBox
            // 
            this.inputNickBox.AllowDrop = true;
            this.inputNickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputNickBox.Location = new System.Drawing.Point(51, 2);
            this.inputNickBox.Name = "inputNickBox";
            this.inputNickBox.Size = new System.Drawing.Size(170, 27);
            this.inputNickBox.TabIndex = 1;
            this.inputNickBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 33);
            this.Controls.Add(this.inputNickBox);
            this.Controls.Add(this.InputNickLabel);
            this.Controls.Add(this.saveNick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveNick;
        private System.Windows.Forms.Label InputNickLabel;
        private System.Windows.Forms.TextBox inputNickBox;
    }
}