namespace ZH3_WKIUQF_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.szobaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szobaSzamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ferohelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potagyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallasFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foglalasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallasFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            this.textBox2.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            this.textBox3.Validated += new System.EventHandler(this.textBox3_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 325);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(80, 382);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szoba szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Felnőtt db";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gyerek db";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Foglalás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szobaIdDataGridViewTextBoxColumn,
            this.szobaSzamaDataGridViewTextBoxColumn,
            this.ferohelyDataGridViewTextBoxColumn,
            this.potagyDataGridViewTextBoxColumn,
            this.klimasDataGridViewTextBoxColumn,
            this.szallasFkDataGridViewTextBoxColumn,
            this.foglalasDataGridViewTextBoxColumn,
            this.szallasFkNavigationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.szobaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(200, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // szobaIdDataGridViewTextBoxColumn
            // 
            this.szobaIdDataGridViewTextBoxColumn.DataPropertyName = "SzobaId";
            this.szobaIdDataGridViewTextBoxColumn.HeaderText = "SzobaId";
            this.szobaIdDataGridViewTextBoxColumn.Name = "szobaIdDataGridViewTextBoxColumn";
            // 
            // szobaSzamaDataGridViewTextBoxColumn
            // 
            this.szobaSzamaDataGridViewTextBoxColumn.DataPropertyName = "SzobaSzama";
            this.szobaSzamaDataGridViewTextBoxColumn.HeaderText = "SzobaSzama";
            this.szobaSzamaDataGridViewTextBoxColumn.Name = "szobaSzamaDataGridViewTextBoxColumn";
            // 
            // ferohelyDataGridViewTextBoxColumn
            // 
            this.ferohelyDataGridViewTextBoxColumn.DataPropertyName = "Ferohely";
            this.ferohelyDataGridViewTextBoxColumn.HeaderText = "Ferohely";
            this.ferohelyDataGridViewTextBoxColumn.Name = "ferohelyDataGridViewTextBoxColumn";
            // 
            // potagyDataGridViewTextBoxColumn
            // 
            this.potagyDataGridViewTextBoxColumn.DataPropertyName = "Potagy";
            this.potagyDataGridViewTextBoxColumn.HeaderText = "Potagy";
            this.potagyDataGridViewTextBoxColumn.Name = "potagyDataGridViewTextBoxColumn";
            // 
            // klimasDataGridViewTextBoxColumn
            // 
            this.klimasDataGridViewTextBoxColumn.DataPropertyName = "Klimas";
            this.klimasDataGridViewTextBoxColumn.HeaderText = "Klimas";
            this.klimasDataGridViewTextBoxColumn.Name = "klimasDataGridViewTextBoxColumn";
            // 
            // szallasFkDataGridViewTextBoxColumn
            // 
            this.szallasFkDataGridViewTextBoxColumn.DataPropertyName = "SzallasFk";
            this.szallasFkDataGridViewTextBoxColumn.HeaderText = "SzallasFk";
            this.szallasFkDataGridViewTextBoxColumn.Name = "szallasFkDataGridViewTextBoxColumn";
            // 
            // foglalasDataGridViewTextBoxColumn
            // 
            this.foglalasDataGridViewTextBoxColumn.DataPropertyName = "Foglalas";
            this.foglalasDataGridViewTextBoxColumn.HeaderText = "Foglalas";
            this.foglalasDataGridViewTextBoxColumn.Name = "foglalasDataGridViewTextBoxColumn";
            this.foglalasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szallasFkNavigationDataGridViewTextBoxColumn
            // 
            this.szallasFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "SzallasFkNavigation";
            this.szallasFkNavigationDataGridViewTextBoxColumn.HeaderText = "SzallasFkNavigation";
            this.szallasFkNavigationDataGridViewTextBoxColumn.Name = "szallasFkNavigationDataGridViewTextBoxColumn";
            // 
            // szobaBindingSource
            // 
            this.szobaBindingSource.DataSource = typeof(ZH3_WKIUQF_2.Models2.Szoba);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(986, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn szobaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szobaSzamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ferohelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn potagyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn klimasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szallasFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foglalasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szallasFkNavigationDataGridViewTextBoxColumn;
        private BindingSource szobaBindingSource;
        private ErrorProvider errorProvider1;
    }
}
