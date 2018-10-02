namespace Project
{
    partial class frmAssignmentTask
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
            this.dteTaskCompleted = new System.Windows.Forms.DateTimePicker();
            this.lblTaskCompleted = new System.Windows.Forms.Label();
            this.btnTaskAdd = new System.Windows.Forms.Button();
            this.dteTaskEndDate = new System.Windows.Forms.DateTimePicker();
            this.dteTaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtProjectTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskEndDate = new System.Windows.Forms.Label();
            this.lblTaskStartDate = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblProjectTaskID = new System.Windows.Forms.Label();
            this.dgvAsstTask = new System.Windows.Forms.DataGridView();
            this.lblAssignmentTask = new System.Windows.Forms.Label();
            this.txtTaskAssID = new System.Windows.Forms.TextBox();
            this.lblTaskAssID = new System.Windows.Forms.Label();
            this.btnTaskDelete = new System.Windows.Forms.Button();
            this.btnTaskUpdate = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsstTask)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dteTaskCompleted
            // 
            this.dteTaskCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTaskCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTaskCompleted.Location = new System.Drawing.Point(237, 544);
            this.dteTaskCompleted.Name = "dteTaskCompleted";
            this.dteTaskCompleted.Size = new System.Drawing.Size(122, 22);
            this.dteTaskCompleted.TabIndex = 55;
            // 
            // lblTaskCompleted
            // 
            this.lblTaskCompleted.AutoSize = true;
            this.lblTaskCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskCompleted.Location = new System.Drawing.Point(51, 549);
            this.lblTaskCompleted.Name = "lblTaskCompleted";
            this.lblTaskCompleted.Size = new System.Drawing.Size(109, 16);
            this.lblTaskCompleted.TabIndex = 54;
            this.lblTaskCompleted.Text = "Completed Date:";
            // 
            // btnTaskAdd
            // 
            this.btnTaskAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskAdd.Location = new System.Drawing.Point(581, 414);
            this.btnTaskAdd.Name = "btnTaskAdd";
            this.btnTaskAdd.Size = new System.Drawing.Size(103, 34);
            this.btnTaskAdd.TabIndex = 52;
            this.btnTaskAdd.Text = "Add";
            this.btnTaskAdd.UseVisualStyleBackColor = true;
            // 
            // dteTaskEndDate
            // 
            this.dteTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTaskEndDate.Location = new System.Drawing.Point(237, 500);
            this.dteTaskEndDate.Name = "dteTaskEndDate";
            this.dteTaskEndDate.Size = new System.Drawing.Size(122, 22);
            this.dteTaskEndDate.TabIndex = 51;
            // 
            // dteTaskStartDate
            // 
            this.dteTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTaskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTaskStartDate.Location = new System.Drawing.Point(237, 457);
            this.dteTaskStartDate.Name = "dteTaskStartDate";
            this.dteTaskStartDate.Size = new System.Drawing.Size(122, 22);
            this.dteTaskStartDate.TabIndex = 50;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(237, 414);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(198, 22);
            this.txtStudentID.TabIndex = 49;
            // 
            // txtProjectTaskID
            // 
            this.txtProjectTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectTaskID.Location = new System.Drawing.Point(237, 373);
            this.txtProjectTaskID.Name = "txtProjectTaskID";
            this.txtProjectTaskID.Size = new System.Drawing.Size(198, 22);
            this.txtProjectTaskID.TabIndex = 48;
            // 
            // lblTaskEndDate
            // 
            this.lblTaskEndDate.AutoSize = true;
            this.lblTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskEndDate.Location = new System.Drawing.Point(51, 505);
            this.lblTaskEndDate.Name = "lblTaskEndDate";
            this.lblTaskEndDate.Size = new System.Drawing.Size(117, 16);
            this.lblTaskEndDate.TabIndex = 46;
            this.lblTaskEndDate.Text = "End Date Of Task:";
            // 
            // lblTaskStartDate
            // 
            this.lblTaskStartDate.AutoSize = true;
            this.lblTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStartDate.Location = new System.Drawing.Point(51, 462);
            this.lblTaskStartDate.Name = "lblTaskStartDate";
            this.lblTaskStartDate.Size = new System.Drawing.Size(120, 16);
            this.lblTaskStartDate.TabIndex = 45;
            this.lblTaskStartDate.Text = "Start Date Of Task:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(51, 417);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(72, 16);
            this.lblStudentID.TabIndex = 44;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblProjectTaskID
            // 
            this.lblProjectTaskID.AutoSize = true;
            this.lblProjectTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTaskID.Location = new System.Drawing.Point(51, 376);
            this.lblProjectTaskID.Name = "lblProjectTaskID";
            this.lblProjectTaskID.Size = new System.Drawing.Size(103, 16);
            this.lblProjectTaskID.TabIndex = 43;
            this.lblProjectTaskID.Text = "Project Task ID:";
            // 
            // dgvAsstTask
            // 
            this.dgvAsstTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsstTask.Location = new System.Drawing.Point(54, 109);
            this.dgvAsstTask.Name = "dgvAsstTask";
            this.dgvAsstTask.Size = new System.Drawing.Size(712, 180);
            this.dgvAsstTask.TabIndex = 42;
            // 
            // lblAssignmentTask
            // 
            this.lblAssignmentTask.AutoSize = true;
            this.lblAssignmentTask.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAssignmentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentTask.Location = new System.Drawing.Point(203, 45);
            this.lblAssignmentTask.Name = "lblAssignmentTask";
            this.lblAssignmentTask.Size = new System.Drawing.Size(414, 37);
            this.lblAssignmentTask.TabIndex = 41;
            this.lblAssignmentTask.Text = "Assignment - Task Details";
            // 
            // txtTaskAssID
            // 
            this.txtTaskAssID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskAssID.Location = new System.Drawing.Point(237, 333);
            this.txtTaskAssID.Name = "txtTaskAssID";
            this.txtTaskAssID.Size = new System.Drawing.Size(198, 22);
            this.txtTaskAssID.TabIndex = 57;
            // 
            // lblTaskAssID
            // 
            this.lblTaskAssID.AutoSize = true;
            this.lblTaskAssID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskAssID.Location = new System.Drawing.Point(51, 336);
            this.lblTaskAssID.Name = "lblTaskAssID";
            this.lblTaskAssID.Size = new System.Drawing.Size(131, 16);
            this.lblTaskAssID.TabIndex = 56;
            this.lblTaskAssID.Text = "Task Assignment ID:";
            // 
            // btnTaskDelete
            // 
            this.btnTaskDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDelete.Location = new System.Drawing.Point(581, 540);
            this.btnTaskDelete.Name = "btnTaskDelete";
            this.btnTaskDelete.Size = new System.Drawing.Size(103, 34);
            this.btnTaskDelete.TabIndex = 59;
            this.btnTaskDelete.Text = "Delete";
            this.btnTaskDelete.UseVisualStyleBackColor = true;
            // 
            // btnTaskUpdate
            // 
            this.btnTaskUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskUpdate.Location = new System.Drawing.Point(581, 475);
            this.btnTaskUpdate.Name = "btnTaskUpdate";
            this.btnTaskUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnTaskUpdate.TabIndex = 58;
            this.btnTaskUpdate.Text = "Update";
            this.btnTaskUpdate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 60;
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
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
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
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click_1);
            // 
            // supervisorDetailsToolStripMenuItem
            // 
            this.supervisorDetailsToolStripMenuItem.Name = "supervisorDetailsToolStripMenuItem";
            this.supervisorDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.supervisorDetailsToolStripMenuItem.Text = "Supervisor Details";
            this.supervisorDetailsToolStripMenuItem.Click += new System.EventHandler(this.supervisorDetailsToolStripMenuItem_Click);
            // 
            // projectDetailsToolStripMenuItem
            // 
            this.projectDetailsToolStripMenuItem.Name = "projectDetailsToolStripMenuItem";
            this.projectDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectDetailsToolStripMenuItem.Text = "Project Details";
            this.projectDetailsToolStripMenuItem.Click += new System.EventHandler(this.projectDetailsToolStripMenuItem_Click);
            // 
            // projectGroupDetailsToolStripMenuItem
            // 
            this.projectGroupDetailsToolStripMenuItem.Name = "projectGroupDetailsToolStripMenuItem";
            this.projectGroupDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectGroupDetailsToolStripMenuItem.Text = "Project-Group Details";
            this.projectGroupDetailsToolStripMenuItem.Click += new System.EventHandler(this.projectGroupDetailsToolStripMenuItem_Click);
            // 
            // projectTaskDetailsToolStripMenuItem
            // 
            this.projectTaskDetailsToolStripMenuItem.Name = "projectTaskDetailsToolStripMenuItem";
            this.projectTaskDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectTaskDetailsToolStripMenuItem.Text = "Project-Task Details";
            this.projectTaskDetailsToolStripMenuItem.Click += new System.EventHandler(this.projectTaskDetailsToolStripMenuItem_Click);
            // 
            // assignmentDetailsToolStripMenuItem
            // 
            this.assignmentDetailsToolStripMenuItem.Name = "assignmentDetailsToolStripMenuItem";
            this.assignmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.assignmentDetailsToolStripMenuItem.Text = "Assignment Details";
            this.assignmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.assignmentDetailsToolStripMenuItem_Click);
            // 
            // assignmentTaskDetailsToolStripMenuItem
            // 
            this.assignmentTaskDetailsToolStripMenuItem.Checked = true;
            this.assignmentTaskDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.assignmentTaskDetailsToolStripMenuItem.Enabled = false;
            this.assignmentTaskDetailsToolStripMenuItem.Name = "assignmentTaskDetailsToolStripMenuItem";
            this.assignmentTaskDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.assignmentTaskDetailsToolStripMenuItem.Text = "Assignment-Task Details";
            // 
            // buddyRatingToolStripMenuItem
            // 
            this.buddyRatingToolStripMenuItem.Name = "buddyRatingToolStripMenuItem";
            this.buddyRatingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buddyRatingToolStripMenuItem.Text = "Buddy Rating";
            this.buddyRatingToolStripMenuItem.Click += new System.EventHandler(this.buddyRatingToolStripMenuItem_Click);
            // 
            // frmAssignmentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 594);
            this.Controls.Add(this.btnTaskDelete);
            this.Controls.Add(this.btnTaskUpdate);
            this.Controls.Add(this.txtTaskAssID);
            this.Controls.Add(this.lblTaskAssID);
            this.Controls.Add(this.dteTaskCompleted);
            this.Controls.Add(this.lblTaskCompleted);
            this.Controls.Add(this.btnTaskAdd);
            this.Controls.Add(this.dteTaskEndDate);
            this.Controls.Add(this.dteTaskStartDate);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtProjectTaskID);
            this.Controls.Add(this.lblTaskEndDate);
            this.Controls.Add(this.lblTaskStartDate);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblProjectTaskID);
            this.Controls.Add(this.dgvAsstTask);
            this.Controls.Add(this.lblAssignmentTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAssignmentTask";
            this.Text = "Project System";
            this.Load += new System.EventHandler(this.frmAssignmentTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsstTask)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteTaskCompleted;
        private System.Windows.Forms.Label lblTaskCompleted;
        private System.Windows.Forms.Button btnTaskAdd;
        private System.Windows.Forms.DateTimePicker dteTaskEndDate;
        private System.Windows.Forms.DateTimePicker dteTaskStartDate;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtProjectTaskID;
        private System.Windows.Forms.Label lblTaskEndDate;
        private System.Windows.Forms.Label lblTaskStartDate;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblProjectTaskID;
        private System.Windows.Forms.DataGridView dgvAsstTask;
        private System.Windows.Forms.Label lblAssignmentTask;
        private System.Windows.Forms.TextBox txtTaskAssID;
        private System.Windows.Forms.Label lblTaskAssID;
        private System.Windows.Forms.Button btnTaskDelete;
        private System.Windows.Forms.Button btnTaskUpdate;
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
        private System.Windows.Forms.ToolStripMenuItem buddyRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentTaskDetailsToolStripMenuItem;
    }
}