namespace Project
{
    partial class Project
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
            this.lblProject = new System.Windows.Forms.Label();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProTitle = new System.Windows.Forms.Label();
            this.lblProDesc = new System.Windows.Forms.Label();
            this.lblProStartDate = new System.Windows.Forms.Label();
            this.lblProDueDate = new System.Windows.Forms.Label();
            this.lblProOwner = new System.Windows.Forms.Label();
            this.lblProSupervisor = new System.Windows.Forms.Label();
            this.lblProStatus = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProTitle = new System.Windows.Forms.TextBox();
            this.txtProDesc = new System.Windows.Forms.TextBox();
            this.txtProOwner = new System.Windows.Forms.TextBox();
            this.dteProStartDate = new System.Windows.Forms.DateTimePicker();
            this.dteProDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtProSupervisor = new System.Windows.Forms.TextBox();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.txtProStatus = new System.Windows.Forms.TextBox();
            this.btnProDelete = new System.Windows.Forms.Button();
            this.btnProUpdate = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(292, 43);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(237, 37);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Project Details";
            // 
            // dgvProject
            // 
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Location = new System.Drawing.Point(54, 103);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.Size = new System.Drawing.Size(712, 180);
            this.dgvProject.TabIndex = 1;
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(51, 324);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(69, 16);
            this.lblProjectID.TabIndex = 2;
            this.lblProjectID.Text = "Project ID:";
            // 
            // lblProTitle
            // 
            this.lblProTitle.AutoSize = true;
            this.lblProTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProTitle.Location = new System.Drawing.Point(51, 365);
            this.lblProTitle.Name = "lblProTitle";
            this.lblProTitle.Size = new System.Drawing.Size(82, 16);
            this.lblProTitle.TabIndex = 3;
            this.lblProTitle.Text = "Project Title:";
            // 
            // lblProDesc
            // 
            this.lblProDesc.AutoSize = true;
            this.lblProDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProDesc.Location = new System.Drawing.Point(51, 405);
            this.lblProDesc.Name = "lblProDesc";
            this.lblProDesc.Size = new System.Drawing.Size(124, 16);
            this.lblProDesc.TabIndex = 4;
            this.lblProDesc.Text = "Project Description:";
            // 
            // lblProStartDate
            // 
            this.lblProStartDate.AutoSize = true;
            this.lblProStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProStartDate.Location = new System.Drawing.Point(51, 472);
            this.lblProStartDate.Name = "lblProStartDate";
            this.lblProStartDate.Size = new System.Drawing.Size(115, 16);
            this.lblProStartDate.TabIndex = 5;
            this.lblProStartDate.Text = "Project Start Date:";
            // 
            // lblProDueDate
            // 
            this.lblProDueDate.AutoSize = true;
            this.lblProDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProDueDate.Location = new System.Drawing.Point(51, 513);
            this.lblProDueDate.Name = "lblProDueDate";
            this.lblProDueDate.Size = new System.Drawing.Size(113, 16);
            this.lblProDueDate.TabIndex = 6;
            this.lblProDueDate.Text = "Project Due Date:";
            // 
            // lblProOwner
            // 
            this.lblProOwner.AutoSize = true;
            this.lblProOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProOwner.Location = new System.Drawing.Point(51, 553);
            this.lblProOwner.Name = "lblProOwner";
            this.lblProOwner.Size = new System.Drawing.Size(94, 16);
            this.lblProOwner.TabIndex = 7;
            this.lblProOwner.Text = "Project Owner:";
            // 
            // lblProSupervisor
            // 
            this.lblProSupervisor.AutoSize = true;
            this.lblProSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProSupervisor.Location = new System.Drawing.Point(51, 592);
            this.lblProSupervisor.Name = "lblProSupervisor";
            this.lblProSupervisor.Size = new System.Drawing.Size(121, 16);
            this.lblProSupervisor.TabIndex = 8;
            this.lblProSupervisor.Text = "Project Supervisor:";
            // 
            // lblProStatus
            // 
            this.lblProStatus.AutoSize = true;
            this.lblProStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProStatus.Location = new System.Drawing.Point(51, 632);
            this.lblProStatus.Name = "lblProStatus";
            this.lblProStatus.Size = new System.Drawing.Size(93, 16);
            this.lblProStatus.TabIndex = 9;
            this.lblProStatus.Text = "Project Status:";
            // 
            // txtProjectID
            // 
            this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(231, 321);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(198, 22);
            this.txtProjectID.TabIndex = 10;
            // 
            // txtProTitle
            // 
            this.txtProTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProTitle.Location = new System.Drawing.Point(231, 362);
            this.txtProTitle.Name = "txtProTitle";
            this.txtProTitle.Size = new System.Drawing.Size(198, 22);
            this.txtProTitle.TabIndex = 11;
            // 
            // txtProDesc
            // 
            this.txtProDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProDesc.Location = new System.Drawing.Point(231, 402);
            this.txtProDesc.Multiline = true;
            this.txtProDesc.Name = "txtProDesc";
            this.txtProDesc.Size = new System.Drawing.Size(198, 49);
            this.txtProDesc.TabIndex = 12;
            // 
            // txtProOwner
            // 
            this.txtProOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProOwner.Location = new System.Drawing.Point(231, 550);
            this.txtProOwner.Name = "txtProOwner";
            this.txtProOwner.Size = new System.Drawing.Size(198, 22);
            this.txtProOwner.TabIndex = 14;
            // 
            // dteProStartDate
            // 
            this.dteProStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteProStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteProStartDate.Location = new System.Drawing.Point(231, 467);
            this.dteProStartDate.Name = "dteProStartDate";
            this.dteProStartDate.Size = new System.Drawing.Size(122, 22);
            this.dteProStartDate.TabIndex = 15;
            // 
            // dteProDueDate
            // 
            this.dteProDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteProDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteProDueDate.Location = new System.Drawing.Point(231, 508);
            this.dteProDueDate.Name = "dteProDueDate";
            this.dteProDueDate.Size = new System.Drawing.Size(122, 22);
            this.dteProDueDate.TabIndex = 16;
            // 
            // txtProSupervisor
            // 
            this.txtProSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProSupervisor.Location = new System.Drawing.Point(231, 589);
            this.txtProSupervisor.Name = "txtProSupervisor";
            this.txtProSupervisor.Size = new System.Drawing.Size(198, 22);
            this.txtProSupervisor.TabIndex = 17;
            // 
            // btnProAdd
            // 
            this.btnProAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProAdd.Location = new System.Drawing.Point(602, 436);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(103, 34);
            this.btnProAdd.TabIndex = 18;
            this.btnProAdd.Text = "Add";
            this.btnProAdd.UseVisualStyleBackColor = true;
            // 
            // txtProStatus
            // 
            this.txtProStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProStatus.Location = new System.Drawing.Point(231, 629);
            this.txtProStatus.Name = "txtProStatus";
            this.txtProStatus.ReadOnly = true;
            this.txtProStatus.Size = new System.Drawing.Size(198, 22);
            this.txtProStatus.TabIndex = 19;
            // 
            // btnProDelete
            // 
            this.btnProDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDelete.Location = new System.Drawing.Point(602, 553);
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(103, 34);
            this.btnProDelete.TabIndex = 69;
            this.btnProDelete.Text = "Delete";
            this.btnProDelete.UseVisualStyleBackColor = true;
            // 
            // btnProUpdate
            // 
            this.btnProUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUpdate.Location = new System.Drawing.Point(602, 495);
            this.btnProUpdate.Name = "btnProUpdate";
            this.btnProUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnProUpdate.TabIndex = 68;
            this.btnProUpdate.Text = "Update";
            this.btnProUpdate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 70;
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
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Text = "Other";
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
            this.projectDetailsToolStripMenuItem.Checked = true;
            this.projectDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.projectDetailsToolStripMenuItem.Enabled = false;
            this.projectDetailsToolStripMenuItem.Name = "projectDetailsToolStripMenuItem";
            this.projectDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectDetailsToolStripMenuItem.Text = "Project Details";
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
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 679);
            this.Controls.Add(this.btnProDelete);
            this.Controls.Add(this.btnProUpdate);
            this.Controls.Add(this.txtProStatus);
            this.Controls.Add(this.btnProAdd);
            this.Controls.Add(this.txtProSupervisor);
            this.Controls.Add(this.dteProDueDate);
            this.Controls.Add(this.dteProStartDate);
            this.Controls.Add(this.txtProOwner);
            this.Controls.Add(this.txtProDesc);
            this.Controls.Add(this.txtProTitle);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.lblProStatus);
            this.Controls.Add(this.lblProSupervisor);
            this.Controls.Add(this.lblProOwner);
            this.Controls.Add(this.lblProDueDate);
            this.Controls.Add(this.lblProStartDate);
            this.Controls.Add(this.lblProDesc);
            this.Controls.Add(this.lblProTitle);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Project";
            this.Text = "Project System";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProTitle;
        private System.Windows.Forms.Label lblProDesc;
        private System.Windows.Forms.Label lblProStartDate;
        private System.Windows.Forms.Label lblProDueDate;
        private System.Windows.Forms.Label lblProOwner;
        private System.Windows.Forms.Label lblProSupervisor;
        private System.Windows.Forms.Label lblProStatus;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProTitle;
        private System.Windows.Forms.TextBox txtProDesc;
        private System.Windows.Forms.TextBox txtProOwner;
        private System.Windows.Forms.DateTimePicker dteProStartDate;
        private System.Windows.Forms.DateTimePicker dteProDueDate;
        private System.Windows.Forms.TextBox txtProSupervisor;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.TextBox txtProStatus;
        private System.Windows.Forms.Button btnProDelete;
        private System.Windows.Forms.Button btnProUpdate;
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

