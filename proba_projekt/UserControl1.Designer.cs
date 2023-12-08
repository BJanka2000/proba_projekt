namespace proba_projekt
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rendelésekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termékekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vevőkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.időpontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termékFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mennyiségDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vevőFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vevőkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendIdDataGridViewTextBoxColumn,
            this.időpontDataGridViewTextBoxColumn,
            this.termékFkDataGridViewTextBoxColumn,
            this.mennyiségDataGridViewTextBoxColumn,
            this.vevőFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelésekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(806, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // rendelésekBindingSource
            // 
            this.rendelésekBindingSource.DataSource = typeof(proba_projekt.Models.Rendelések);
            // 
            // termékekBindingSource
            // 
            this.termékekBindingSource.DataSource = typeof(proba_projekt.Models.Termékek);
            // 
            // vevőkBindingSource
            // 
            this.vevőkBindingSource.DataSource = typeof(proba_projekt.Models.Vevők);
            // 
            // rendIdDataGridViewTextBoxColumn
            // 
            this.rendIdDataGridViewTextBoxColumn.DataPropertyName = "RendId";
            this.rendIdDataGridViewTextBoxColumn.HeaderText = "RendId";
            this.rendIdDataGridViewTextBoxColumn.Name = "rendIdDataGridViewTextBoxColumn";
            // 
            // időpontDataGridViewTextBoxColumn
            // 
            this.időpontDataGridViewTextBoxColumn.DataPropertyName = "Időpont";
            this.időpontDataGridViewTextBoxColumn.HeaderText = "Időpont";
            this.időpontDataGridViewTextBoxColumn.Name = "időpontDataGridViewTextBoxColumn";
            // 
            // termékFkDataGridViewTextBoxColumn
            // 
            this.termékFkDataGridViewTextBoxColumn.DataPropertyName = "TermékFk";
            this.termékFkDataGridViewTextBoxColumn.DataSource = this.termékekBindingSource;
            this.termékFkDataGridViewTextBoxColumn.DisplayMember = "Terméknév";
            this.termékFkDataGridViewTextBoxColumn.HeaderText = "TermékFk";
            this.termékFkDataGridViewTextBoxColumn.Name = "termékFkDataGridViewTextBoxColumn";
            this.termékFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.termékFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.termékFkDataGridViewTextBoxColumn.ValueMember = "TermékSk";
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            this.mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            // 
            // vevőFkDataGridViewTextBoxColumn
            // 
            this.vevőFkDataGridViewTextBoxColumn.DataPropertyName = "VevőFk";
            this.vevőFkDataGridViewTextBoxColumn.DataSource = this.vevőkBindingSource;
            this.vevőFkDataGridViewTextBoxColumn.DisplayMember = "Név";
            this.vevőFkDataGridViewTextBoxColumn.HeaderText = "VevőFk";
            this.vevőFkDataGridViewTextBoxColumn.Name = "vevőFkDataGridViewTextBoxColumn";
            this.vevőFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vevőFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vevőFkDataGridViewTextBoxColumn.ValueMember = "VevőSk";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(812, 522);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vevőkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn rendIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn időpontDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn termékFkDataGridViewTextBoxColumn;
        private BindingSource termékekBindingSource;
        private DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn vevőFkDataGridViewTextBoxColumn;
        private BindingSource vevőkBindingSource;
        private BindingSource rendelésekBindingSource;
    }
}
