namespace ZH3_WKIUQF_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlCimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foglalasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendegBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernevDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.szamlCimDataGridViewTextBoxColumn,
            this.szulDatDataGridViewTextBoxColumn,
            this.foglalasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendegBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(126, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(660, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // usernevDataGridViewTextBoxColumn
            // 
            this.usernevDataGridViewTextBoxColumn.DataPropertyName = "Usernev";
            this.usernevDataGridViewTextBoxColumn.HeaderText = "Usernev";
            this.usernevDataGridViewTextBoxColumn.Name = "usernevDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // szamlCimDataGridViewTextBoxColumn
            // 
            this.szamlCimDataGridViewTextBoxColumn.DataPropertyName = "SzamlCim";
            this.szamlCimDataGridViewTextBoxColumn.HeaderText = "SzamlCim";
            this.szamlCimDataGridViewTextBoxColumn.Name = "szamlCimDataGridViewTextBoxColumn";
            // 
            // szulDatDataGridViewTextBoxColumn
            // 
            this.szulDatDataGridViewTextBoxColumn.DataPropertyName = "SzulDat";
            this.szulDatDataGridViewTextBoxColumn.HeaderText = "SzulDat";
            this.szulDatDataGridViewTextBoxColumn.Name = "szulDatDataGridViewTextBoxColumn";
            // 
            // foglalasDataGridViewTextBoxColumn
            // 
            this.foglalasDataGridViewTextBoxColumn.DataPropertyName = "Foglalas";
            this.foglalasDataGridViewTextBoxColumn.HeaderText = "Foglalas";
            this.foglalasDataGridViewTextBoxColumn.Name = "foglalasDataGridViewTextBoxColumn";
            this.foglalasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendegBindingSource
            // 
            this.vendegBindingSource.DataSource = typeof(ZH3_WKIUQF_2.Models2.Vendeg);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Írd be a felhasználónevet a szűréséhez";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(958, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendegBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn usernevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szamlCimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szulDatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foglalasDataGridViewTextBoxColumn;
        private BindingSource vendegBindingSource;
        private Label label1;
    }
}
