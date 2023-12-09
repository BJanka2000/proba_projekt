namespace proba_projekt
{
    partial class UserControl2
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
            this.txtTermék = new System.Windows.Forms.TextBox();
            this.listTermék = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.szállításIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szállítóFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.szállítóAdatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termékFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.termékekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mennyiségSzállítóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megrendelésIdőpontjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teljesítésIdőpontjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egységárSzállítóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szállítókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listSzállító = new System.Windows.Forms.ListBox();
            this.txtSzállító = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listIdőpontok = new System.Windows.Forms.ListBox();
            this.txtFizetés = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szállítóAdatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szállítókBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermék
            // 
            this.txtTermék.Location = new System.Drawing.Point(25, 28);
            this.txtTermék.Name = "txtTermék";
            this.txtTermék.Size = new System.Drawing.Size(144, 23);
            this.txtTermék.TabIndex = 0;
            this.txtTermék.TextChanged += new System.EventHandler(this.txtTermék_TextChanged);
            // 
            // listTermék
            // 
            this.listTermék.FormattingEnabled = true;
            this.listTermék.ItemHeight = 15;
            this.listTermék.Location = new System.Drawing.Point(25, 69);
            this.listTermék.Name = "listTermék";
            this.listTermék.Size = new System.Drawing.Size(144, 139);
            this.listTermék.TabIndex = 1;
            this.listTermék.SelectedIndexChanged += new System.EventHandler(this.listTermék_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szállításIdDataGridViewTextBoxColumn,
            this.szállítóFkDataGridViewTextBoxColumn,
            this.termékFkDataGridViewTextBoxColumn,
            this.mennyiségSzállítóDataGridViewTextBoxColumn,
            this.megrendelésIdőpontjaDataGridViewTextBoxColumn,
            this.teljesítésIdőpontjaDataGridViewTextBoxColumn,
            this.egységárSzállítóDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.szállítókBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(777, 92);
            this.dataGridView1.TabIndex = 2;
            // 
            // szállításIdDataGridViewTextBoxColumn
            // 
            this.szállításIdDataGridViewTextBoxColumn.DataPropertyName = "SzállításId";
            this.szállításIdDataGridViewTextBoxColumn.HeaderText = "SzállításId";
            this.szállításIdDataGridViewTextBoxColumn.Name = "szállításIdDataGridViewTextBoxColumn";
            // 
            // szállítóFkDataGridViewTextBoxColumn
            // 
            this.szállítóFkDataGridViewTextBoxColumn.DataPropertyName = "SzállítóFk";
            this.szállítóFkDataGridViewTextBoxColumn.DataSource = this.szállítóAdatokBindingSource;
            this.szállítóFkDataGridViewTextBoxColumn.DisplayMember = "Cégnév";
            this.szállítóFkDataGridViewTextBoxColumn.HeaderText = "SzállítóFk";
            this.szállítóFkDataGridViewTextBoxColumn.Name = "szállítóFkDataGridViewTextBoxColumn";
            this.szállítóFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.szállítóFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.szállítóFkDataGridViewTextBoxColumn.ValueMember = "SzállítóSk";
            // 
            // szállítóAdatokBindingSource
            // 
            this.szállítóAdatokBindingSource.DataSource = typeof(proba_projekt.Models.SzállítóAdatok);
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
            // termékekBindingSource
            // 
            this.termékekBindingSource.DataSource = typeof(proba_projekt.Models.Termékek);
            // 
            // mennyiségSzállítóDataGridViewTextBoxColumn
            // 
            this.mennyiségSzállítóDataGridViewTextBoxColumn.DataPropertyName = "MennyiségSzállító";
            this.mennyiségSzállítóDataGridViewTextBoxColumn.HeaderText = "MennyiségSzállító";
            this.mennyiségSzállítóDataGridViewTextBoxColumn.Name = "mennyiségSzállítóDataGridViewTextBoxColumn";
            // 
            // megrendelésIdőpontjaDataGridViewTextBoxColumn
            // 
            this.megrendelésIdőpontjaDataGridViewTextBoxColumn.DataPropertyName = "MegrendelésIdőpontja";
            this.megrendelésIdőpontjaDataGridViewTextBoxColumn.HeaderText = "MegrendelésIdőpontja";
            this.megrendelésIdőpontjaDataGridViewTextBoxColumn.Name = "megrendelésIdőpontjaDataGridViewTextBoxColumn";
            // 
            // teljesítésIdőpontjaDataGridViewTextBoxColumn
            // 
            this.teljesítésIdőpontjaDataGridViewTextBoxColumn.DataPropertyName = "TeljesítésIdőpontja";
            this.teljesítésIdőpontjaDataGridViewTextBoxColumn.HeaderText = "TeljesítésIdőpontja";
            this.teljesítésIdőpontjaDataGridViewTextBoxColumn.Name = "teljesítésIdőpontjaDataGridViewTextBoxColumn";
            // 
            // egységárSzállítóDataGridViewTextBoxColumn
            // 
            this.egységárSzállítóDataGridViewTextBoxColumn.DataPropertyName = "EgységárSzállító";
            this.egységárSzállítóDataGridViewTextBoxColumn.HeaderText = "EgységárSzállító";
            this.egységárSzállítóDataGridViewTextBoxColumn.Name = "egységárSzállítóDataGridViewTextBoxColumn";
            // 
            // szállítókBindingSource
            // 
            this.szállítókBindingSource.DataSource = typeof(proba_projekt.Models.Szállítók);
            // 
            // listSzállító
            // 
            this.listSzállító.FormattingEnabled = true;
            this.listSzállító.ItemHeight = 15;
            this.listSzállító.Location = new System.Drawing.Point(203, 69);
            this.listSzállító.Name = "listSzállító";
            this.listSzállító.Size = new System.Drawing.Size(144, 139);
            this.listSzállító.TabIndex = 4;
            this.listSzállító.SelectedIndexChanged += new System.EventHandler(this.listSzállító_SelectedIndexChanged);
            // 
            // txtSzállító
            // 
            this.txtSzállító.Location = new System.Drawing.Point(203, 28);
            this.txtSzállító.Name = "txtSzállító";
            this.txtSzállító.Size = new System.Drawing.Size(144, 23);
            this.txtSzállító.TabIndex = 3;
            this.txtSzállító.TextChanged += new System.EventHandler(this.txtSzállító_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 414);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(777, 60);
            this.dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Megrendelés időpontjai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mennyiség * Egységár:";
            // 
            // listIdőpontok
            // 
            this.listIdőpontok.FormattingEnabled = true;
            this.listIdőpontok.ItemHeight = 15;
            this.listIdőpontok.Location = new System.Drawing.Point(390, 69);
            this.listIdőpontok.Name = "listIdőpontok";
            this.listIdőpontok.Size = new System.Drawing.Size(135, 139);
            this.listIdőpontok.TabIndex = 8;
            this.listIdőpontok.SelectedIndexChanged += new System.EventHandler(this.listIdőpontok_SelectedIndexChanged);
            // 
            // txtFizetés
            // 
            this.txtFizetés.Location = new System.Drawing.Point(552, 69);
            this.txtFizetés.Name = "txtFizetés";
            this.txtFizetés.Size = new System.Drawing.Size(126, 23);
            this.txtFizetés.TabIndex = 9;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFizetés);
            this.Controls.Add(this.listIdőpontok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listSzállító);
            this.Controls.Add(this.txtSzállító);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listTermék);
            this.Controls.Add(this.txtTermék);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(805, 537);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szállítóAdatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szállítókBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTermék;
        private ListBox listTermék;
        private DataGridView dataGridView1;
        private ListBox listSzállító;
        private TextBox txtSzállító;
        private DataGridViewTextBoxColumn szállításIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn szállítóFkDataGridViewTextBoxColumn;
        private BindingSource szállítóAdatokBindingSource;
        private DataGridViewComboBoxColumn termékFkDataGridViewTextBoxColumn;
        private BindingSource termékekBindingSource;
        private DataGridViewTextBoxColumn mennyiségSzállítóDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn megrendelésIdőpontjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teljesítésIdőpontjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egységárSzállítóDataGridViewTextBoxColumn;
        private BindingSource szállítókBindingSource;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private ListBox listIdőpontok;
        private TextBox txtFizetés;
    }
}
