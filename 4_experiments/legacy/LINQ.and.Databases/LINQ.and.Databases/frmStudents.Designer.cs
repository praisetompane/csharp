namespace LINQ.and.Databases
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTULNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUGPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiny_CollegeDataSet = new LINQ.and.Databases.Tiny_CollegeDataSet();
            this.sTUDENTTableAdapter = new LINQ.and.Databases.Tiny_CollegeDataSetTableAdapters.STUDENTTableAdapter();
            this.sTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiny_CollegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTULNAMEDataGridViewTextBoxColumn,
            this.sTUFNAMEDataGridViewTextBoxColumn,
            this.sTUGPADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(25, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // sTULNAMEDataGridViewTextBoxColumn
            // 
            this.sTULNAMEDataGridViewTextBoxColumn.DataPropertyName = "STU_LNAME";
            this.sTULNAMEDataGridViewTextBoxColumn.HeaderText = "STU_LNAME";
            this.sTULNAMEDataGridViewTextBoxColumn.Name = "sTULNAMEDataGridViewTextBoxColumn";
            // 
            // sTUFNAMEDataGridViewTextBoxColumn
            // 
            this.sTUFNAMEDataGridViewTextBoxColumn.DataPropertyName = "STU_FNAME";
            this.sTUFNAMEDataGridViewTextBoxColumn.HeaderText = "STU_FNAME";
            this.sTUFNAMEDataGridViewTextBoxColumn.Name = "sTUFNAMEDataGridViewTextBoxColumn";
            // 
            // sTUGPADataGridViewTextBoxColumn
            // 
            this.sTUGPADataGridViewTextBoxColumn.DataPropertyName = "STU_GPA";
            this.sTUGPADataGridViewTextBoxColumn.HeaderText = "STU_GPA";
            this.sTUGPADataGridViewTextBoxColumn.Name = "sTUGPADataGridViewTextBoxColumn";
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.tiny_CollegeDataSet;
            // 
            // tiny_CollegeDataSet
            // 
            this.tiny_CollegeDataSet.DataSetName = "Tiny_CollegeDataSet";
            this.tiny_CollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource1
            // 
            this.sTUDENTBindingSource1.DataMember = "STUDENT";
            this.sTUDENTBindingSource1.DataSource = this.tiny_CollegeDataSet1;
            // 
            // sTUDENTBindingSource2
            // 
            this.sTUDENTBindingSource2.DataMember = "STUDENT";
            this.sTUDENTBindingSource2.DataSource = this.tiny_CollegeDataSet2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiny_CollegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      
    }
}

