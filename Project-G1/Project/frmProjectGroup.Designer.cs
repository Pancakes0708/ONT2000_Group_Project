namespace Project
{
    partial class frmProjectGroup
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
            this.txtFinalMark = new System.Windows.Forms.TextBox();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.lblNoOfMembers = new System.Windows.Forms.Label();
            this.txtSupervisorID = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.lblSupervisorID = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.dgvProjectGroup = new System.Windows.Forms.DataGridView();
            this.lblProjectGroup = new System.Windows.Forms.Label();
            this.txtNoOfMembers = new System.Windows.Forms.TextBox();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.btnGroupDelete = new System.Windows.Forms.Button();
            this.btnGroupUpdate = new System.Windows.Forms.Button();
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
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectGroup)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFinalMark
            // 
            this.txtFinalMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalMark.Location = new System.Drawing.Point(650, 366);
            this.txtFinalMark.Name = "txtFinalMark";
            this.txtFinalMark.Size = new System.Drawing.Size(122, 22);
            this.txtFinalMark.TabIndex = 56;
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.AutoSize = true;
            this.lblFinalMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalMark.Location = new System.Drawing.Point(470, 369);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(73, 16);
            this.lblFinalMark.TabIndex = 55;
            this.lblFinalMark.Text = "Final Mark:";
            // 
            // lblNoOfMembers
            // 
            this.lblNoOfMembers.AutoSize = true;
            this.lblNoOfMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfMembers.Location = new System.Drawing.Point(470, 328);
            this.lblNoOfMembers.Name = "lblNoOfMembers";
            this.lblNoOfMembers.Size = new System.Drawing.Size(135, 16);
            this.lblNoOfMembers.TabIndex = 53;
            this.lblNoOfMembers.Text = "Number Of Members:";
            // 
            // txtSupervisorID
            // 
            this.txtSupervisorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisorID.Location = new System.Drawing.Point(208, 406);
            this.txtSupervisorID.Name = "txtSupervisorID";
            this.txtSupervisorID.Size = new System.Drawing.Size(198, 22);
            this.txtSupervisorID.TabIndex = 52;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(208, 366);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(198, 22);
            this.txtProjectID.TabIndex = 51;
            // 
            // txtGroupID
            // 
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.Location = new System.Drawing.Point(208, 325);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(198, 22);
            this.txtGroupID.TabIndex = 50;
            // 
            // lblSupervisorID
            // 
            this.lblSupervisorID.AutoSize = true;
            this.lblSupervisorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisorID.Location = new System.Drawing.Point(28, 409);
            this.lblSupervisorID.Name = "lblSupervisorID";
            this.lblSupervisorID.Size = new System.Drawing.Size(92, 16);
            this.lblSupervisorID.TabIndex = 49;
            this.lblSupervisorID.Text = "Supervisor ID:";
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(28, 369);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(69, 16);
            this.lblProjectID.TabIndex = 48;
            this.lblProjectID.Text = "Project ID:";
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupID.Location = new System.Drawing.Point(28, 328);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(64, 16);
            this.lblGroupID.TabIndex = 47;
            this.lblGroupID.Text = "Group ID:";
            // 
            // dgvProjectGroup
            // 
            this.dgvProjectGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectGroup.Location = new System.Drawing.Point(31, 107);
            this.dgvProjectGroup.Name = "dgvProjectGroup";
            this.dgvProjectGroup.Size = new System.Drawing.Size(817, 180);
            this.dgvProjectGroup.TabIndex = 46;
            // 
            // lblProjectGroup
            // 
            this.lblProjectGroup.AutoSize = true;
            this.lblProjectGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProjectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectGroup.Location = new System.Drawing.Point(228, 45);
            this.lblProjectGroup.Name = "lblProjectGroup";
            this.lblProjectGroup.Size = new System.Drawing.Size(363, 37);
            this.lblProjectGroup.TabIndex = 45;
            this.lblProjectGroup.Text = "Project - Group Details";
            // 
            // txtNoOfMembers
            // 
            this.txtNoOfMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfMembers.Location = new System.Drawing.Point(650, 325);
            this.txtNoOfMembers.Name = "txtNoOfMembers";
            this.txtNoOfMembers.Size = new System.Drawing.Size(198, 22);
            this.txtNoOfMembers.TabIndex = 57;
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupAdd.Location = new System.Drawing.Point(157, 452);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(103, 34);
            this.btnGroupAdd.TabIndex = 58;
            this.btnGroupAdd.Text = "Enable Add";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // btnGroupDelete
            // 
            this.btnGroupDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupDelete.Location = new System.Drawing.Point(489, 452);
            this.btnGroupDelete.Name = "btnGroupDelete";
            this.btnGroupDelete.Size = new System.Drawing.Size(103, 34);
            this.btnGroupDelete.TabIndex = 71;
            this.btnGroupDelete.Text = "Delete";
            this.btnGroupDelete.UseVisualStyleBackColor = true;
            this.btnGroupDelete.Click += new System.EventHandler(this.btnGroupDelete_Click);
            // 
            // btnGroupUpdate
            // 
            this.btnGroupUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupUpdate.Location = new System.Drawing.Point(327, 452);
            this.btnGroupUpdate.Name = "btnGroupUpdate";
            this.btnGroupUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnGroupUpdate.TabIndex = 70;
            this.btnGroupUpdate.Text = "Update";
            this.btnGroupUpdate.UseVisualStyleBackColor = true;
            this.btnGroupUpdate.Click += new System.EventHandler(this.btnGroupUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 72;
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
            this.projectGroupDetailsToolStripMenuItem.Checked = true;
            this.projectGroupDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.projectGroupDetailsToolStripMenuItem.Enabled = false;
            this.projectGroupDetailsToolStripMenuItem.Name = "projectGroupDetailsToolStripMenuItem";
            this.projectGroupDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.projectGroupDetailsToolStripMenuItem.Text = "Project-Group Details";
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
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(649, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 34);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmProjectGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 507);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGroupDelete);
            this.Controls.Add(this.btnGroupUpdate);
            this.Controls.Add(this.btnGroupAdd);
            this.Controls.Add(this.txtNoOfMembers);
            this.Controls.Add(this.txtFinalMark);
            this.Controls.Add(this.lblFinalMark);
            this.Controls.Add(this.lblNoOfMembers);
            this.Controls.Add(this.txtSupervisorID);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.lblSupervisorID);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.lblGroupID);
            this.Controls.Add(this.dgvProjectGroup);
            this.Controls.Add(this.lblProjectGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProjectGroup";
            this.Text = "Project System";
            this.Load += new System.EventHandler(this.frmProjectGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectGroup)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFinalMark;
        private System.Windows.Forms.Label lblFinalMark;
        private System.Windows.Forms.Label lblNoOfMembers;
        private System.Windows.Forms.TextBox txtSupervisorID;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label lblSupervisorID;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.DataGridView dgvProjectGroup;
        private System.Windows.Forms.Label lblProjectGroup;
        private System.Windows.Forms.TextBox txtNoOfMembers;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Button btnGroupDelete;
        private System.Windows.Forms.Button btnGroupUpdate;
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
        private System.Windows.Forms.Button btnClear;
    }
}