namespace n01597890_Assignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.tbAssigmentID = new System.Windows.Forms.TextBox();
            this.tbAssignmentScore = new System.Windows.Forms.TextBox();
            this.tbAssignmentMaxScore = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.bt_Find = new System.Windows.Forms.Button();
            this.btAddAssignment = new System.Windows.Forms.Button();
            this.btUpdateScore = new System.Windows.Forms.Button();
            this.bt_Display = new System.Windows.Forms.Button();
            this.gvStudent = new System.Windows.Forms.DataGridView();
            this.btRemove = new System.Windows.Forms.Button();
            this.btRemoveAssignment = new System.Windows.Forms.Button();
            this.btDisplayAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assignment ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assignment Max Score";
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(171, 87);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(207, 22);
            this.tbStudentID.TabIndex = 5;
            this.tbStudentID.TextChanged += new System.EventHandler(this.tbStudentID_TextChanged);
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(172, 142);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(206, 22);
            this.tbStudentName.TabIndex = 6;
            // 
            // tbAssigmentID
            // 
            this.tbAssigmentID.Location = new System.Drawing.Point(172, 204);
            this.tbAssigmentID.Name = "tbAssigmentID";
            this.tbAssigmentID.Size = new System.Drawing.Size(206, 22);
            this.tbAssigmentID.TabIndex = 7;
            // 
            // tbAssignmentScore
            // 
            this.tbAssignmentScore.Location = new System.Drawing.Point(172, 259);
            this.tbAssignmentScore.Name = "tbAssignmentScore";
            this.tbAssignmentScore.Size = new System.Drawing.Size(207, 22);
            this.tbAssignmentScore.TabIndex = 8;
            // 
            // tbAssignmentMaxScore
            // 
            this.tbAssignmentMaxScore.Location = new System.Drawing.Point(171, 325);
            this.tbAssignmentMaxScore.Name = "tbAssignmentMaxScore";
            this.tbAssignmentMaxScore.Size = new System.Drawing.Size(207, 22);
            this.tbAssignmentMaxScore.TabIndex = 9;
            this.tbAssignmentMaxScore.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(15, 430);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 34);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Add Student";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // bt_Find
            // 
            this.bt_Find.Location = new System.Drawing.Point(347, 430);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(130, 34);
            this.bt_Find.TabIndex = 12;
            this.bt_Find.Text = "Find Student";
            this.bt_Find.UseVisualStyleBackColor = true;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // btAddAssignment
            // 
            this.btAddAssignment.Location = new System.Drawing.Point(520, 430);
            this.btAddAssignment.Name = "btAddAssignment";
            this.btAddAssignment.Size = new System.Drawing.Size(142, 34);
            this.btAddAssignment.TabIndex = 13;
            this.btAddAssignment.Text = "Add Assignment";
            this.btAddAssignment.UseVisualStyleBackColor = true;
            this.btAddAssignment.Click += new System.EventHandler(this.btAddAssignment_Click);
            // 
            // btUpdateScore
            // 
            this.btUpdateScore.Location = new System.Drawing.Point(224, 489);
            this.btUpdateScore.Name = "btUpdateScore";
            this.btUpdateScore.Size = new System.Drawing.Size(140, 35);
            this.btUpdateScore.TabIndex = 15;
            this.btUpdateScore.Text = "Update Score";
            this.btUpdateScore.UseVisualStyleBackColor = true;
            this.btUpdateScore.Click += new System.EventHandler(this.btUpdateScore_Click);
            // 
            // bt_Display
            // 
            this.bt_Display.Location = new System.Drawing.Point(432, 489);
            this.bt_Display.Name = "bt_Display";
            this.bt_Display.Size = new System.Drawing.Size(134, 35);
            this.bt_Display.TabIndex = 16;
            this.bt_Display.Text = "Display Student";
            this.bt_Display.UseVisualStyleBackColor = true;
            this.bt_Display.Click += new System.EventHandler(this.bt_Display_Click);
            // 
            // gvStudent
            // 
            this.gvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudent.Location = new System.Drawing.Point(414, 54);
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.RowHeadersWidth = 51;
            this.gvStudent.RowTemplate.Height = 24;
            this.gvStudent.Size = new System.Drawing.Size(443, 315);
            this.gvStudent.TabIndex = 17;
            this.gvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(171, 430);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(135, 34);
            this.btRemove.TabIndex = 11;
            this.btRemove.Text = "Remove Student";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btRemoveAssignment
            // 
            this.btRemoveAssignment.Location = new System.Drawing.Point(723, 430);
            this.btRemoveAssignment.Name = "btRemoveAssignment";
            this.btRemoveAssignment.Size = new System.Drawing.Size(143, 34);
            this.btRemoveAssignment.TabIndex = 18;
            this.btRemoveAssignment.Text = "Remove Assignment";
            this.btRemoveAssignment.UseVisualStyleBackColor = true;
            this.btRemoveAssignment.Click += new System.EventHandler(this.btRemoveAssignment_Click);
            // 
            // btDisplayAssignment
            // 
            this.btDisplayAssignment.Location = new System.Drawing.Point(643, 489);
            this.btDisplayAssignment.Name = "btDisplayAssignment";
            this.btDisplayAssignment.Size = new System.Drawing.Size(166, 35);
            this.btDisplayAssignment.TabIndex = 19;
            this.btDisplayAssignment.Text = "Display Assignment";
            this.btDisplayAssignment.UseVisualStyleBackColor = true;
            this.btDisplayAssignment.Click += new System.EventHandler(this.btDisplayAssignment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 536);
            this.Controls.Add(this.btDisplayAssignment);
            this.Controls.Add(this.btRemoveAssignment);
            this.Controls.Add(this.gvStudent);
            this.Controls.Add(this.bt_Display);
            this.Controls.Add(this.btUpdateScore);
            this.Controls.Add(this.btAddAssignment);
            this.Controls.Add(this.bt_Find);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbAssignmentMaxScore);
            this.Controls.Add(this.tbAssignmentScore);
            this.Controls.Add(this.tbAssigmentID);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TextBox tbAssigmentID;
        private System.Windows.Forms.TextBox tbAssignmentScore;
        private System.Windows.Forms.TextBox tbAssignmentMaxScore;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button bt_Find;
        private System.Windows.Forms.Button btAddAssignment;
        private System.Windows.Forms.Button btUpdateScore;
        private System.Windows.Forms.Button bt_Display;
        private System.Windows.Forms.DataGridView gvStudent;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btRemoveAssignment;
        private System.Windows.Forms.Button btDisplayAssignment;
    }
}

