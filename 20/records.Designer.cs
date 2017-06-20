namespace _20
{
    partial class Records
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
            this.components = new System.ComponentModel.Container();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsDataSet = new _20.recordsDataSet();
            this.recordTableAdapter = new _20.recordsDataSetTableAdapters.recordTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoursRecordsLabel = new System.Windows.Forms.Label();
            this.yoursRecord = new System.Windows.Forms.Label();
            this.saveYoursRecord = new System.Windows.Forms.Button();
            this.NickBox = new System.Windows.Forms.TextBox();
            this.NickLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "record";
            this.recordBindingSource.DataSource = this.recordsDataSet;
            // 
            // recordsDataSet
            // 
            this.recordsDataSet.DataSetName = "recordsDataSet";
            this.recordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordTableAdapter
            // 
            this.recordTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pointsDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(241, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yoursRecordsLabel
            // 
            this.yoursRecordsLabel.BackColor = System.Drawing.Color.Transparent;
            this.yoursRecordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yoursRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yoursRecordsLabel.Location = new System.Drawing.Point(256, 8);
            this.yoursRecordsLabel.Name = "yoursRecordsLabel";
            this.yoursRecordsLabel.Size = new System.Drawing.Size(182, 65);
            this.yoursRecordsLabel.TabIndex = 1;
            this.yoursRecordsLabel.Text = "Score";
            this.yoursRecordsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yoursRecord
            // 
            this.yoursRecord.BackColor = System.Drawing.Color.Transparent;
            this.yoursRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yoursRecord.Location = new System.Drawing.Point(271, 41);
            this.yoursRecord.Name = "yoursRecord";
            this.yoursRecord.Size = new System.Drawing.Size(153, 23);
            this.yoursRecord.TabIndex = 2;
            this.yoursRecord.Text = "123";
            this.yoursRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveYoursRecord
            // 
            this.saveYoursRecord.Location = new System.Drawing.Point(256, 132);
            this.saveYoursRecord.Name = "saveYoursRecord";
            this.saveYoursRecord.Size = new System.Drawing.Size(182, 38);
            this.saveYoursRecord.TabIndex = 3;
            this.saveYoursRecord.Text = "Zapisz swój rekord";
            this.saveYoursRecord.UseVisualStyleBackColor = true;
            this.saveYoursRecord.Click += new System.EventHandler(this.saveYoursRecord_Click);
            // 
            // NickBox
            // 
            this.NickBox.Location = new System.Drawing.Point(304, 92);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(134, 20);
            this.NickBox.TabIndex = 4;
            // 
            // NickLabel
            // 
            this.NickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NickLabel.Location = new System.Drawing.Point(256, 92);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(42, 20);
            this.NickLabel.TabIndex = 5;
            this.NickLabel.Text = "Nick:";
            this.NickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 404);
            this.Controls.Add(this.NickLabel);
            this.Controls.Add(this.NickBox);
            this.Controls.Add(this.saveYoursRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yoursRecord);
            this.Controls.Add(this.yoursRecordsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Records";
            this.Text = "Records";
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private recordsDataSet recordsDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private recordsDataSetTableAdapters.recordTableAdapter recordTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label yoursRecordsLabel;
        private System.Windows.Forms.Label yoursRecord;
        private System.Windows.Forms.Button saveYoursRecord;
        private System.Windows.Forms.TextBox NickBox;
        private System.Windows.Forms.Label NickLabel;
    }
}