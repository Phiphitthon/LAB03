namespace LAB3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxbrithyear = new System.Windows.Forms.TextBox();
            this.textBoxhight = new System.Windows.Forms.TextBox();
            this.textBoxgrade = new System.Windows.Forms.TextBox();
            this.textBoxbranch = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxIgrade = new System.Windows.Forms.Label();
            this.MinIgrade = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(93, 64);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 229);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.ID,
            this.Birthyear,
            this.Hight,
            this.Grade,
            this.Branch});
            this.dataGridView1.Location = new System.Drawing.Point(212, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 246);
            this.dataGridView1.TabIndex = 5;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Birthyear
            // 
            this.Birthyear.HeaderText = "Birthyear";
            this.Birthyear.Name = "Birthyear";
            this.Birthyear.ReadOnly = true;
            // 
            // Hight
            // 
            this.Hight.HeaderText = "Hight";
            this.Hight.Name = "Hight";
            this.Hight.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            // 
            // textBoxbrithyear
            // 
            this.textBoxbrithyear.Location = new System.Drawing.Point(93, 93);
            this.textBoxbrithyear.Name = "textBoxbrithyear";
            this.textBoxbrithyear.Size = new System.Drawing.Size(100, 23);
            this.textBoxbrithyear.TabIndex = 6;
            // 
            // textBoxhight
            // 
            this.textBoxhight.Location = new System.Drawing.Point(93, 122);
            this.textBoxhight.Name = "textBoxhight";
            this.textBoxhight.Size = new System.Drawing.Size(100, 23);
            this.textBoxhight.TabIndex = 7;
            // 
            // textBoxgrade
            // 
            this.textBoxgrade.Location = new System.Drawing.Point(93, 151);
            this.textBoxgrade.Name = "textBoxgrade";
            this.textBoxgrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxgrade.TabIndex = 8;
            // 
            // textBoxbranch
            // 
            this.textBoxbranch.Location = new System.Drawing.Point(93, 180);
            this.textBoxbranch.Name = "textBoxbranch";
            this.textBoxbranch.Size = new System.Drawing.Size(100, 23);
            this.textBoxbranch.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(100, 229);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(82, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "brithyear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "hight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "branch";
            // 
            // MaxIgrade
            // 
            this.MaxIgrade.AutoSize = true;
            this.MaxIgrade.Location = new System.Drawing.Point(265, 337);
            this.MaxIgrade.Name = "MaxIgrade";
            this.MaxIgrade.Size = new System.Drawing.Size(67, 15);
            this.MaxIgrade.TabIndex = 15;
            this.MaxIgrade.Text = "MaxGrade :";
            // 
            // MinIgrade
            // 
            this.MinIgrade.AutoSize = true;
            this.MinIgrade.Location = new System.Drawing.Point(504, 337);
            this.MinIgrade.Name = "MinIgrade";
            this.MinIgrade.Size = new System.Drawing.Size(67, 15);
            this.MinIgrade.TabIndex = 16;
            this.MinIgrade.Text = "MaxGrade :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(338, 329);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(577, 329);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.MinIgrade);
            this.Controls.Add(this.MaxIgrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxbranch);
            this.Controls.Add(this.textBoxgrade);
            this.Controls.Add(this.textBoxhight);
            this.Controls.Add(this.textBoxbrithyear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxID;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Birthyear;
        private DataGridViewTextBoxColumn Hight;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Branch;
        private TextBox textBoxbrithyear;
        private TextBox textBoxhight;
        private TextBox textBoxgrade;
        private TextBox textBoxbranch;
        private Button buttonClear;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label MaxIgrade;
        private Label MinIgrade;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}