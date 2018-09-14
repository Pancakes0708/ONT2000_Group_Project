namespace Project
{
    partial class frmStudent
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStuFirstName = new System.Windows.Forms.Label();
            this.lblStuSurname = new System.Windows.Forms.Label();
            this.lblStuCellNo = new System.Windows.Forms.Label();
            this.lblStuStatus = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStuFirstName = new System.Windows.Forms.TextBox();
            this.txtStuSurname = new System.Windows.Forms.TextBox();
            this.txtStuCellNo = new System.Windows.Forms.TextBox();
            this.txtStuStatus = new System.Windows.Forms.TextBox();
            this.btnStuAdd = new System.Windows.Forms.Button();
            this.btnStuDelete = new System.Windows.Forms.Button();
            this.btnStuUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectGroupDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectTaskDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentTaskDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buddyRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(249, 48);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(248, 37);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student Details";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(58, 125);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(72, 16);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblStuFirstName
            // 
            this.lblStuFirstName.AutoSize = true;
            this.lblStuFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuFirstName.Location = new System.Drawing.Point(58, 167);
            this.lblStuFirstName.Name = "lblStuFirstName";
            this.lblStuFirstName.Size = new System.Drawing.Size(124, 16);
            this.lblStuFirstName.TabIndex = 3;
            this.lblStuFirstName.Text = "Student First Name:";
            // 
            // lblStuSurname
            // 
            this.lblStuSurname.AutoSize = true;
            this.lblStuSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuSurname.Location = new System.Drawing.Point(58, 213);
            this.lblStuSurname.Name = "lblStuSurname";
            this.lblStuSurname.Size = new System.Drawing.Size(113, 16);
            this.lblStuSurname.TabIndex = 4;
            this.lblStuSurname.Text = "Student Surname:";
            // 
            // lblStuCellNo
            // 
            this.lblStuCellNo.AutoSize = true;
            this.lblStuCellNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuCellNo.Location = new System.Drawing.Point(58, 256);
            this.lblStuCellNo.Name = "lblStuCellNo";
            this.lblStuCellNo.Size = new System.Drawing.Size(103, 16);
            this.lblStuCellNo.TabIndex = 5;
            this.lblStuCellNo.Text = "Student Cell No:";
            // 
            // lblStuStatus
            // 
            this.lblStuStatus.AutoSize = true;
            this.lblStuStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuStatus.Location = new System.Drawing.Point(58, 301);
            this.lblStuStatus.Name = "lblStuStatus";
            this.lblStuStatus.Size = new System.Drawing.Size(96, 16);
            this.lblStuStatus.TabIndex = 6;
            this.lblStuStatus.Text = "Student Status:";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(61, 413);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(658, 183);
            this.dgvStudent.TabIndex = 7;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(256, 122);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(189, 22);
            this.txtStudentID.TabIndex = 8;
            // 
            // txtStuFirstName
            // 
            this.txtStuFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuFirstName.Location = new System.Drawing.Point(256, 166);
            this.txtStuFirstName.Name = "txtStuFirstName";
            this.txtStuFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtStuFirstName.TabIndex = 9;
            // 
            // txtStuSurname
            // 
            this.txtStuSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuSurname.Location = new System.Drawing.Point(256, 210);
            this.txtStuSurname.Name = "txtStuSurname";
            this.txtStuSurname.Size = new System.Drawing.Size(189, 22);
            this.txtStuSurname.TabIndex = 10;
            // 
            // txtStuCellNo
            // 
            this.txtStuCellNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuCellNo.Location = new System.Drawing.Point(256, 253);
            this.txtStuCellNo.Name = "txtStuCellNo";
            this.txtStuCellNo.Size = new System.Drawing.Size(189, 22);
            this.txtStuCellNo.TabIndex = 11;
            // 
            // txtStuStatus
            // 
            this.txtStuStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuStatus.Location = new System.Drawing.Point(256, 298);
            this.txtStuStatus.Name = "txtStuStatus";
            this.txtStuStatus.ReadOnly = true;
            this.txtStuStatus.Size = new System.Drawing.Size(189, 22);
            this.txtStuStatus.TabIndex = 12;
            // 
            // btnStuAdd
            // 
            this.btnStuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuAdd.Location = new System.Drawing.Point(175, 351);
            this.btnStuAdd.Name = "btnStuAdd";
            this.btnStuAdd.Size = new System.Drawing.Size(96, 34);
            this.btnStuAdd.TabIndex = 13;
            this.btnStuAdd.Text = "Add";
            this.btnStuAdd.UseVisualStyleBackColor = true;
            // 
            // btnStuDelete
            // 
            this.btnStuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuDelete.Location = new System.Drawing.Point(490, 351);
            this.btnStuDelete.Name = "btnStuDelete";
            this.btnStuDelete.Size = new System.Drawing.Size(103, 34);
            this.btnStuDelete.TabIndex = 73;
            this.btnStuDelete.Text = "Delete";
            this.btnStuDelete.UseVisualStyleBackColor = true;
            // 
            // btnStuUpdate
            // 
            this.btnStuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuUpdate.Location = new System.Drawing.Point(328, 351);
            this.btnStuUpdate.Name = "btnStuUpdate";
            this.btnStuUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnStuUpdate.TabIndex = 72;
            this.btnStuUpdate.Text = "Update";
            this.btnStuUpdate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.supervisorDetailsToolStripMenuItem,
            this.projectDetailsToolStripMenuItem,
            this.projectGroupDetailsToolStripMenuItem,
            this.projectTaskDetailsToolStripMenuItem,
            this.assignmentDetailsToolStripMenuItem,
            this.assignmentTaskDetailsToolStripMenuItem,
            this.buddyRatingToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Checked = true;
            this.studentDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.studentDetailsToolStripMenuItem.Enabled = false;
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // supervisorDetailsToolStripMenuItem
            // 
            this.supervisorDetailsToolStripMenuItem.Name = "supervisorDetailsToolStripMenuItem";
            this.supervisorDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.supervisorDetailsToolStripMenuItem.Text = "Supervisor Details";
            // 
            // projectDetailsToolStripMenuItem
            // 
            this.projectDetailsToolStripMenuItem.Name = "projectDetailsToolStripMenuItem";
            this.projectDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectDetailsToolStripMenuItem.Text = "Project Details";
            // 
            // projectGroupDetailsToolStripMenuItem
            // 
            this.projectGroupDetailsToolStripMenuItem.Name = "projectGroupDetailsToolStripMenuItem";
            this.projectGroupDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectGroupDetailsToolStripMenuItem.Text = "Project-Group Details";
            // 
            // projectTaskDetailsToolStripMenuItem
            // 
            this.projectTaskDetailsToolStripMenuItem.Name = "projectTaskDetailsToolStripMenuItem";
            this.projectTaskDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectTaskDetailsToolStripMenuItem.Text = "Project-Task Details";
            // 
            // assignmentDetailsToolStripMenuItem
            // 
            this.assignmentDetailsToolStripMenuItem.Name = "assignmentDetailsToolStripMenuItem";
            this.assignmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.assignmentDetailsToolStripMenuItem.Text = "Assignment Details";
            // 
            // assignmentTaskDetailsToolStripMenuItem
            // 
            this.assignmentTaskDetailsToolStripMenuItem.Name = "assignmentTaskDetailsToolStripMenuItem";
            this.assignmentTaskDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.assignmentTaskDetailsToolStripMenuItem.Text = "Assignment-Task Details";
            // 
            // buddyRatingToolStripMenuItem
            // 
            this.buddyRatingToolStripMenuItem.Name = "buddyRatingToolStripMenuItem";
            this.buddyRatingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buddyRatingToolStripMenuItem.Text = "Buddy Rating";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 617);
            this.Controls.Add(this.btnStuDelete);
            this.Controls.Add(this.btnStuUpdate);
            this.Controls.Add(this.btnStuAdd);
            this.Controls.Add(this.txtStuStatus);
            this.Controls.Add(this.txtStuCellNo);
            this.Controls.Add(this.txtStuSurname);
            this.Controls.Add(this.txtStuFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblStuStatus);
            this.Controls.Add(this.lblStuCellNo);
            this.Controls.Add(this.lblStuSurname);
            this.Controls.Add(this.lblStuFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudent";
            this.Text = "Project System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStuFirstName;
        private System.Windows.Forms.Label lblStuSurname;
        private System.Windows.Forms.Label lblStuCellNo;
        private System.Windows.Forms.Label lblStuStatus;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStuFirstName;
        private System.Windows.Forms.TextBox txtStuSurname;
        private System.Windows.Forms.TextBox txtStuCellNo;
        private System.Windows.Forms.TextBox txtStuStatus;
        private System.Windows.Forms.Button btnStuAdd;
        private System.Windows.Forms.Button btnStuDelete;
        private System.Windows.Forms.Button btnStuUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectGroupDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectTaskDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentTaskDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buddyRatingToolStripMenuItem;
    }
}