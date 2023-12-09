namespace proba_projekt
{
    partial class UserControl3
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
            this.txtTermékek = new System.Windows.Forms.TextBox();
            this.listTermékek = new System.Windows.Forms.ListBox();
            this.txtVevők = new System.Windows.Forms.TextBox();
            this.listVevők = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vevőSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelésekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vevőkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vevőkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermékek
            // 
            this.txtTermékek.Location = new System.Drawing.Point(18, 22);
            this.txtTermékek.Name = "txtTermékek";
            this.txtTermékek.Size = new System.Drawing.Size(134, 23);
            this.txtTermékek.TabIndex = 0;
            this.txtTermékek.TextChanged += new System.EventHandler(this.txtTermékek_TextChanged);
            // 
            // listTermékek
            // 
            this.listTermékek.FormattingEnabled = true;
            this.listTermékek.ItemHeight = 15;
            this.listTermékek.Location = new System.Drawing.Point(18, 73);
            this.listTermékek.Name = "listTermékek";
            this.listTermékek.Size = new System.Drawing.Size(134, 124);
            this.listTermékek.TabIndex = 1;
            // 
            // txtVevők
            // 
            this.txtVevők.Location = new System.Drawing.Point(174, 22);
            this.txtVevők.Name = "txtVevők";
            this.txtVevők.Size = new System.Drawing.Size(126, 23);
            this.txtVevők.TabIndex = 2;
            this.txtVevők.TextChanged += new System.EventHandler(this.txtVevők_TextChanged);
            // 
            // listVevők
            // 
            this.listVevők.FormattingEnabled = true;
            this.listVevők.ItemHeight = 15;
            this.listVevők.Location = new System.Drawing.Point(174, 73);
            this.listVevők.Name = "listVevők";
            this.listVevők.Size = new System.Drawing.Size(126, 124);
            this.listVevők.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Új vevő hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vevőSkDataGridViewTextBoxColumn,
            this.névDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.rendelésekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vevőkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(320, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(485, 102);
            this.dataGridView1.TabIndex = 5;
            // 
            // vevőSkDataGridViewTextBoxColumn
            // 
            this.vevőSkDataGridViewTextBoxColumn.DataPropertyName = "VevőSk";
            this.vevőSkDataGridViewTextBoxColumn.HeaderText = "VevőSk";
            this.vevőSkDataGridViewTextBoxColumn.Name = "vevőSkDataGridViewTextBoxColumn";
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // rendelésekDataGridViewTextBoxColumn
            // 
            this.rendelésekDataGridViewTextBoxColumn.DataPropertyName = "Rendelések";
            this.rendelésekDataGridViewTextBoxColumn.HeaderText = "Rendelések";
            this.rendelésekDataGridViewTextBoxColumn.Name = "rendelésekDataGridViewTextBoxColumn";
            // 
            // vevőkBindingSource
            // 
            this.vevőkBindingSource.DataSource = typeof(proba_projekt.Models.Vevők);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Vevő törlése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVevők);
            this.Controls.Add(this.txtVevők);
            this.Controls.Add(this.listTermékek);
            this.Controls.Add(this.txtTermékek);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(830, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vevőkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTermékek;
        private ListBox listTermékek;
        private TextBox txtVevők;
        private ListBox listVevők;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vevőSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelésekDataGridViewTextBoxColumn;
        private BindingSource vevőkBindingSource;
        private Button button2;
    }
}
