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
            this.textBoxBrithyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.แบบฟอร์มข้อมูลนักศึกษา = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGrid_StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_StudentBirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_StudentAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_StudentHight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_StudentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_StudentBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Top = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(119, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 31);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ปีเกิด:";
            // 
            // textBoxBrithyear
            // 
            this.textBoxBrithyear.Location = new System.Drawing.Point(119, 149);
            this.textBoxBrithyear.Name = "textBoxBrithyear";
            this.textBoxBrithyear.Size = new System.Drawing.Size(253, 31);
            this.textBoxBrithyear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "อายุ:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(119, 194);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(253, 31);
            this.textBoxAge.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "รหัสนักศึกษา:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(119, 103);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(253, 31);
            this.textBoxID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "ส่วนสูง:";
            // 
            // textBoxHight
            // 
            this.textBoxHight.Location = new System.Drawing.Point(119, 244);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(253, 31);
            this.textBoxHight.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(64, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "เกรด:";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(119, 292);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(253, 31);
            this.textBoxGrade.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(60, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "สาขา:";
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(119, 339);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.Size = new System.Drawing.Size(253, 31);
            this.textBoxBranch.TabIndex = 12;
            // 
            // แบบฟอร์มข้อมูลนักศึกษา
            // 
            this.แบบฟอร์มข้อมูลนักศึกษา.AutoSize = true;
            this.แบบฟอร์มข้อมูลนักศึกษา.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.แบบฟอร์มข้อมูลนักศึกษา.Location = new System.Drawing.Point(162, 9);
            this.แบบฟอร์มข้อมูลนักศึกษา.Name = "แบบฟอร์มข้อมูลนักศึกษา";
            this.แบบฟอร์มข้อมูลนักศึกษา.Size = new System.Drawing.Size(172, 24);
            this.แบบฟอร์มข้อมูลนักศึกษา.TabIndex = 14;
            this.แบบฟอร์มข้อมูลนักศึกษา.Text = "แบบฟอร์มข้อมูลนักศึกษา";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit.Location = new System.Drawing.Point(152, 376);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(182, 34);
            this.submit.TabIndex = 15;
            this.submit.Text = "ยืนยัน";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGrid_StudentName,
            this.DataGrid_StudentID,
            this.DataGrid_StudentBirthYear,
            this.DataGrid_StudentAge,
            this.DataGrid_StudentHight,
            this.DataGrid_StudentGrade,
            this.DataGrid_StudentBranch});
            this.dataGridView1.Location = new System.Drawing.Point(388, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 228);
            this.dataGridView1.TabIndex = 16;
            // 
            // DataGrid_StudentName
            // 
            this.DataGrid_StudentName.HeaderText = "ชื่อ";
            this.DataGrid_StudentName.MinimumWidth = 8;
            this.DataGrid_StudentName.Name = "DataGrid_StudentName";
            this.DataGrid_StudentName.ReadOnly = true;
            this.DataGrid_StudentName.Width = 150;
            // 
            // DataGrid_StudentID
            // 
            this.DataGrid_StudentID.HeaderText = "รหัสนักศึกษา";
            this.DataGrid_StudentID.MinimumWidth = 8;
            this.DataGrid_StudentID.Name = "DataGrid_StudentID";
            this.DataGrid_StudentID.ReadOnly = true;
            this.DataGrid_StudentID.Width = 150;
            // 
            // DataGrid_StudentBirthYear
            // 
            this.DataGrid_StudentBirthYear.HeaderText = "ปีเกิด";
            this.DataGrid_StudentBirthYear.MinimumWidth = 8;
            this.DataGrid_StudentBirthYear.Name = "DataGrid_StudentBirthYear";
            this.DataGrid_StudentBirthYear.ReadOnly = true;
            this.DataGrid_StudentBirthYear.Width = 150;
            // 
            // DataGrid_StudentAge
            // 
            this.DataGrid_StudentAge.HeaderText = "อายุ";
            this.DataGrid_StudentAge.MinimumWidth = 8;
            this.DataGrid_StudentAge.Name = "DataGrid_StudentAge";
            this.DataGrid_StudentAge.ReadOnly = true;
            this.DataGrid_StudentAge.Width = 150;
            // 
            // DataGrid_StudentHight
            // 
            this.DataGrid_StudentHight.HeaderText = "ส่วนสูง";
            this.DataGrid_StudentHight.MinimumWidth = 8;
            this.DataGrid_StudentHight.Name = "DataGrid_StudentHight";
            this.DataGrid_StudentHight.ReadOnly = true;
            this.DataGrid_StudentHight.Width = 150;
            // 
            // DataGrid_StudentGrade
            // 
            this.DataGrid_StudentGrade.HeaderText = "เกรด";
            this.DataGrid_StudentGrade.MinimumWidth = 8;
            this.DataGrid_StudentGrade.Name = "DataGrid_StudentGrade";
            this.DataGrid_StudentGrade.ReadOnly = true;
            this.DataGrid_StudentGrade.Width = 150;
            // 
            // DataGrid_StudentBranch
            // 
            this.DataGrid_StudentBranch.HeaderText = "สาขา";
            this.DataGrid_StudentBranch.MinimumWidth = 8;
            this.DataGrid_StudentBranch.Name = "DataGrid_StudentBranch";
            this.DataGrid_StudentBranch.ReadOnly = true;
            this.DataGrid_StudentBranch.Width = 150;
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(763, 339);
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.Size = new System.Drawing.Size(253, 31);
            this.Last.TabIndex = 19;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(1022, 339);
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Size = new System.Drawing.Size(253, 31);
            this.Count.TabIndex = 18;
            // 
            // Top
            // 
            this.Top.Location = new System.Drawing.Point(504, 339);
            this.Top.Name = "Top";
            this.Top.ReadOnly = true;
            this.Top.Size = new System.Drawing.Size(253, 31);
            this.Top.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 450);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.แบบฟอร์มข้อมูลนักศึกษา);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBranch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrithyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxBrithyear;
        private Label label3;
        private TextBox textBoxAge;
        private Label label4;
        private TextBox textBoxID;
        private Label label5;
        private TextBox textBoxHight;
        private Label label6;
        private TextBox textBoxGrade;
        private Label label7;
        private TextBox textBoxBranch;
        private Label แบบฟอร์มข้อมูลนักศึกษา;
        private Button submit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataGrid_StudentName;
        private DataGridViewTextBoxColumn DataGrid_StudentID;
        private DataGridViewTextBoxColumn DataGrid_StudentBirthYear;
        private DataGridViewTextBoxColumn DataGrid_StudentAge;
        private DataGridViewTextBoxColumn DataGrid_StudentHight;
        private DataGridViewTextBoxColumn DataGrid_StudentGrade;
        private DataGridViewTextBoxColumn DataGrid_StudentBranch;
        private TextBox Last;
        private TextBox Count;
        private TextBox Top;
    }
}