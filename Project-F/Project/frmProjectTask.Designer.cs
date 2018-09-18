namespace Project
{
    partial class frmProjectTask
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
            this.txtTaskStatus = new System.Windows.Forms.TextBox();
            this.btnProTaskAdd = new System.Windows.Forms.Button();
            this.dteTaskEndDate = new System.Windows.Forms.DateTimePicker();
            this.dteTaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProjectTaskID = new System.Windows.Forms.TextBox();
            this.lblTasktatus = new System.Windows.Forms.Label();
            this.lblTaskEndDate = new System.Windows.Forms.Label();
            this.lblTaskStartDate = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectTaskID = new System.Windows.Forms.Label();
            this.dgvProjectTask = new System.Windows.Forms.DataGridView();
            this.lblProjectTask = new System.Windows.Forms.Label();
            this.lblTaskCompleted = new System.Windows.Forms.Label();
            this.dteTaskCompleted = new System.Windows.Forms.DateTimePicker();
            this.btnProTaskDelete = new System.Windows.Forms.Button();
            this.btnProTaskUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectGroupDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectTaskDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentTaskDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buddyRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectTask)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskStatus.Location = new System.Drawing.Point(230, 533);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.ReadOnly = true;
            this.txtTaskStatus.Size = new System.Drawing.Size(198, 22);
            this.txtTaskStatus.TabIndex = 38;
            // 
            // btnProTaskAdd
            // 
            this.btnProTaskAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProTaskAdd.Location = new System.Drawing.Point(591, 348);
            this.btnProTaskAdd.Name = "btnProTaskAdd";
            this.btnProTaskAdd.Size = new System.Drawing.Size(103, 34);
            this.btnProTaskAdd.TabIndex = 37;
            this.btnProTaskAdd.Text = "Add";
            this.btnProTaskAdd.UseVisualStyleBackColor = true;
            // 
            // dteTaskEndDate
            // 
            this.dteTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTaskEndDate.Location = new System.Drawing.Point(230, 444);
            this.dteTaskEndDate.Name = "dteTaskEndDate";
            this.dteTaskEndDate.Size = new System.Drawing.Size(122, 22);
            this.dteTaskEndDate.TabIndex = 35;
            // 
            // dteTaskStartDate
            // 
            this.dteTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTaskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTaskStartDate.Location = new System.Drawing.Point(230, 401);
            this.dteTaskStartDate.Name = "dteTaskStartDate";
            this.dteTaskStartDate.Size = new System.Drawing.Size(122, 22);
            this.dteTaskStartDate.TabIndex = 34;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(230, 358);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(198, 22);
            this.txtProjectID.TabIndex = 31;
            // 
            // txtProjectTaskID
            // 
            this.txtProjectTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectTaskID.Location = new System.Drawing.Point(230, 317);
            this.txtProjectTaskID.Name = "txtProjectTaskID";
            this.txtProjectTaskID.Size = new System.Drawing.Size(198, 22);
            this.txtProjectTaskID.TabIndex = 30;
            // 
            // lblTasktatus
            // 
            this.lblTasktatus.AutoSize = true;
            this.lblTasktatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasktatus.Location = new System.Drawing.Point(50, 536);
            this.lblTasktatus.Name = "lblTasktatus";
            this.lblTasktatus.Size = new System.Drawing.Size(82, 16);
            this.lblTasktatus.TabIndex = 29;
            this.lblTasktatus.Text = "Task Status:";
            // 
            // lblTaskEndDate
            // 
            this.lblTaskEndDate.AutoSize = true;
            this.lblTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskEndDate.Location = new System.Drawing.Point(50, 449);
            this.lblTaskEndDate.Name = "lblTaskEndDate";
            this.lblTaskEndDate.Size = new System.Drawing.Size(117, 16);
            this.lblTaskEndDate.TabIndex = 26;
            this.lblTaskEndDate.Text = "End Date Of Task:";
            // 
            // lblTaskStartDate
            // 
            this.lblTaskStartDate.AutoSize = true;
            this.lblTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStartDate.Location = new System.Drawing.Point(50, 406);
            this.lblTaskStartDate.Name = "lblTaskStartDate";
            this.lblTaskStartDate.Size = new System.Drawing.Size(120, 16);
            this.lblTaskStartDate.TabIndex = 25;
            this.lblTaskStartDate.Text = "Start Date Of Task:";
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(50, 361);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(69, 16);
            this.lblProjectID.TabIndex = 23;
            this.lblProjectID.Text = "Project ID:";
            // 
            // lblProjectTaskID
            // 
            this.lblProjectTaskID.AutoSize = true;
            this.lblProjectTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTaskID.Location = new System.Drawing.Point(50, 320);
            this.lblProjectTaskID.Name = "lblProjectTaskID";
            this.lblProjectTaskID.Size = new System.Drawing.Size(103, 16);
            this.lblProjectTaskID.TabIndex = 22;
            this.lblProjectTaskID.Text = "Project Task ID:";
            // 
            // dgvProjectTask
            // 
            this.dgvProjectTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectTask.Location = new System.Drawing.Point(53, 99);
            this.dgvProjectTask.Name = "dgvProjectTask";
            this.dgvProjectTask.Size = new System.Drawing.Size(712, 180);
            this.dgvProjectTask.TabIndex = 21;
            // 
            // lblProjectTask
            // 
            this.lblProjectTask.AutoSize = true;
            this.lblProjectTask.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProjectTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTask.Location = new System.Drawing.Point(253, 40);
            this.lblProjectTask.Name = "lblProjectTask";
            this.lblProjectTask.Size = new System.Drawing.Size(342, 37);
            this.lblProjectTask.TabIndex = 20;
            this.lblProjectTask.Text = "Project - Task Details";
            // 
            // lblTaskCompleted
            // 
            this.lblTaskCompleted.AutoSize = true;
            this.lblTaskCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskCompleted.Location = new System.Drawing.Point(50, 493);
            this.lblTaskCompleted.Name = "lblTaskCompleted";
            this.lblTaskCompleted.Size = new System.Drawing.Size(109, 16);
            this.lblTaskCompleted.TabIndex = 39;
            this.lblTaskCompleted.Text = "Completed Date:";
            // 
            // dteTaskCompleted
            // 
            this.dteTaskCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTaskCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTaskCompleted.Location = new System.Drawing.Point(230, 488);
            this.dteTaskCompleted.Name = "dteTaskCompleted";
            this.dteTaskCompleted.Size = new System.Drawing.Size(122, 22);
            this.dteTaskCompleted.TabIndex = 40;
            // 
            // btnProTaskDelete
            // 
            this.btnProTaskDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProTaskDelete.Location = new System.Drawing.Point(591, 463);
            this.btnProTaskDelete.Name = "btnProTaskDelete";
            this.btnProTaskDelete.Size = new System.Drawing.Size(103, 34);
            this.btnProTaskDelete.TabIndex = 73;
            this.btnProTaskDelete.Text = "Delete";
            this.btnProTaskDelete.UseVisualStyleBackColor = true;
            // 
            // btnProTaskUpdate
            // 
            this.btnProTaskUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProTaskUpdate.Location = new System.Drawing.Point(591, 406);
            this.btnProTaskUpdate.Name = "btnProTaskUpdate";
            this.btnProTaskUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnProTaskUpdate.TabIndex = 72;
            this.btnProTaskUpdate.Text = "Update";
            this.btnProTaskUpdate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.supervisorDetailsToolStripMenuItem,
            this.projectDetailsToolStripMenuItem,
            this.projectGroupDetailsToolStripMenuItem,
            this.projectTaskDetailsToolStripMenuItem,
            this.assignmentDetailsToolStripMenuItem,
            this.assignmentTaskDetailsToolStripMenuItem,
            this.buddyRatingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
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
            this.projectTaskDetailsToolStripMenuItem.Checked = true;
            this.projectTaskDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.projectTaskDetailsToolStripMenuItem.Enabled = false;
            this.projectTaskDetailsToolStripMenuItem.Name = "projectTaskDetailsToolStripMenuItem";
            this.projectTaskDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectTaskDetailsToolStripMenuItem.Text = "Project-Task Details";
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
            this.assignmentTaskDetailsToolStripMenuItem.Name = "assignmentTaskDetailsToolStripMenuItem";
            this.assignmentTaskDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.assignmentTaskDetailsToolStripMenuItem.Text = "Assignment-Task Details";
            this.assignmentTaskDetailsToolStripMenuItem.Click += new System.EventHandler(this.assignmentTaskDetailsToolStripMenuItem_Click);
            // 
            // buddyRatingToolStripMenuItem
            // 
            this.buddyRatingToolStripMenuItem.Name = "buddyRatingToolStripMenuItem";
            this.buddyRatingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buddyRatingToolStripMenuItem.Text = "Buddy Rating";
            this.buddyRatingToolStripMenuItem.Click += new System.EventHandler(this.buddyRatingToolStripMenuItem_Click);
            // 
            // frmProjectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 571);
            this.Controls.Add(this.btnProTaskDelete);
            this.Controls.Add(this.btnProTaskUpdate);
            this.Controls.Add(this.dteTaskCompleted);
            this.Controls.Add(this.lblTaskCompleted);
            this.Controls.Add(this.txtTaskStatus);
            this.Controls.Add(this.btnProTaskAdd);
            this.Controls.Add(this.dteTaskEndDate);
            this.Controls.Add(this.dteTaskStartDate);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.txtProjectTaskID);
            this.Controls.Add(this.lblTasktatus);
            this.Controls.Add(this.lblTaskEndDate);
            this.Controls.Add(this.lblTaskStartDate);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.lblProjectTaskID);
            this.Controls.Add(this.dgvProjectTask);
            this.Controls.Add(this.lblProjectTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProjectTask";
            this.Text = " Project System";
            this.Load += new System.EventHandler(this.frmProjectTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectTask)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskStatus;
        private System.Windows.Forms.Button btnProTaskAdd;
        private System.Windows.Forms.DateTimePicker dteTaskEndDate;
        private System.Windows.Forms.DateTimePicker dteTaskStartDate;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectTaskID;
        private System.Windows.Forms.Label lblTasktatus;
        private System.Windows.Forms.Label lblTaskEndDate;
        private System.Windows.Forms.Label lblTaskStartDate;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectTaskID;
        private System.Windows.Forms.DataGridView dgvProjectTask;
        private System.Windows.Forms.Label lblProjectTask;
        private System.Windows.Forms.Label lblTaskCompleted;
        private System.Windows.Forms.DateTimePicker dteTaskCompleted;
        private System.Windows.Forms.Button btnProTaskDelete;
        private System.Windows.Forms.Button btnProTaskUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
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