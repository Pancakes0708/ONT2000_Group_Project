namespace Project
{
    partial class frmSupervisor
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
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblSupervisorID = new System.Windows.Forms.Label();
            this.lblSuFirstName = new System.Windows.Forms.Label();
            this.lblSuSurname = new System.Windows.Forms.Label();
            this.lblSuCellNo = new System.Windows.Forms.Label();
            this.txtSupervisorID = new System.Windows.Forms.TextBox();
            this.txtSuFirstName = new System.Windows.Forms.TextBox();
            this.txtSuSurname = new System.Windows.Forms.TextBox();
            this.txtSuCellNo = new System.Windows.Forms.TextBox();
            this.btnSuAdd = new System.Windows.Forms.Button();
            this.dgvSupervisor = new System.Windows.Forms.DataGridView();
            this.btnSuDelete = new System.Windows.Forms.Button();
            this.btnSuUpdate = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(246, 40);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(293, 37);
            this.lblSupervisor.TabIndex = 2;
            this.lblSupervisor.Text = "Supervisor Details";
            // 
            // lblSupervisorID
            // 
            this.lblSupervisorID.AutoSize = true;
            this.lblSupervisorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisorID.Location = new System.Drawing.Point(63, 110);
            this.lblSupervisorID.Name = "lblSupervisorID";
            this.lblSupervisorID.Size = new System.Drawing.Size(92, 16);
            this.lblSupervisorID.TabIndex = 3;
            this.lblSupervisorID.Text = "Supervisor ID:";
            // 
            // lblSuFirstName
            // 
            this.lblSuFirstName.AutoSize = true;
            this.lblSuFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuFirstName.Location = new System.Drawing.Point(63, 154);
            this.lblSuFirstName.Name = "lblSuFirstName";
            this.lblSuFirstName.Size = new System.Drawing.Size(144, 16);
            this.lblSuFirstName.TabIndex = 4;
            this.lblSuFirstName.Text = "Supervisor First Name:";
            // 
            // lblSuSurname
            // 
            this.lblSuSurname.AutoSize = true;
            this.lblSuSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuSurname.Location = new System.Drawing.Point(63, 199);
            this.lblSuSurname.Name = "lblSuSurname";
            this.lblSuSurname.Size = new System.Drawing.Size(133, 16);
            this.lblSuSurname.TabIndex = 5;
            this.lblSuSurname.Text = "Supervisor Surname:";
            // 
            // lblSuCellNo
            // 
            this.lblSuCellNo.AutoSize = true;
            this.lblSuCellNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuCellNo.Location = new System.Drawing.Point(63, 244);
            this.lblSuCellNo.Name = "lblSuCellNo";
            this.lblSuCellNo.Size = new System.Drawing.Size(153, 16);
            this.lblSuCellNo.TabIndex = 6;
            this.lblSuCellNo.Text = "Supervisor Cell Number:";
            // 
            // txtSupervisorID
            // 
            this.txtSupervisorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisorID.Location = new System.Drawing.Point(253, 107);
            this.txtSupervisorID.Name = "txtSupervisorID";
            this.txtSupervisorID.ReadOnly = true;
            this.txtSupervisorID.Size = new System.Drawing.Size(189, 22);
            this.txtSupervisorID.TabIndex = 9;
            // 
            // txtSuFirstName
            // 
            this.txtSuFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuFirstName.Location = new System.Drawing.Point(253, 151);
            this.txtSuFirstName.Name = "txtSuFirstName";
            this.txtSuFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtSuFirstName.TabIndex = 10;
            // 
            // txtSuSurname
            // 
            this.txtSuSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuSurname.Location = new System.Drawing.Point(253, 196);
            this.txtSuSurname.Name = "txtSuSurname";
            this.txtSuSurname.Size = new System.Drawing.Size(189, 22);
            this.txtSuSurname.TabIndex = 11;
            // 
            // txtSuCellNo
            // 
            this.txtSuCellNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuCellNo.Location = new System.Drawing.Point(253, 241);
            this.txtSuCellNo.Name = "txtSuCellNo";
            this.txtSuCellNo.Size = new System.Drawing.Size(189, 22);
            this.txtSuCellNo.TabIndex = 12;
            // 
            // btnSuAdd
            // 
            this.btnSuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuAdd.Location = new System.Drawing.Point(193, 289);
            this.btnSuAdd.Name = "btnSuAdd";
            this.btnSuAdd.Size = new System.Drawing.Size(104, 35);
            this.btnSuAdd.TabIndex = 14;
            this.btnSuAdd.Text = "Enable Add";
            this.btnSuAdd.UseVisualStyleBackColor = true;
            this.btnSuAdd.Click += new System.EventHandler(this.btnSuAdd_Click);
            // 
            // dgvSupervisor
            // 
            this.dgvSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupervisor.Location = new System.Drawing.Point(66, 353);
            this.dgvSupervisor.Name = "dgvSupervisor";
            this.dgvSupervisor.Size = new System.Drawing.Size(677, 201);
            this.dgvSupervisor.TabIndex = 15;
            this.dgvSupervisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupervisor_CellContentClick);
            // 
            // btnSuDelete
            // 
            this.btnSuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuDelete.Location = new System.Drawing.Point(519, 290);
            this.btnSuDelete.Name = "btnSuDelete";
            this.btnSuDelete.Size = new System.Drawing.Size(103, 34);
            this.btnSuDelete.TabIndex = 75;
            this.btnSuDelete.Text = "Delete";
            this.btnSuDelete.UseVisualStyleBackColor = true;
            this.btnSuDelete.Click += new System.EventHandler(this.btnSuDelete_Click);
            // 
            // btnSuUpdate
            // 
            this.btnSuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuUpdate.Location = new System.Drawing.Point(348, 290);
            this.btnSuUpdate.Name = "btnSuUpdate";
            this.btnSuUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnSuUpdate.TabIndex = 74;
            this.btnSuUpdate.Text = "Update";
            this.btnSuUpdate.UseVisualStyleBackColor = true;
            this.btnSuUpdate.Click += new System.EventHandler(this.btnSuUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 76;
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
            this.supervisorDetailsToolStripMenuItem.Checked = true;
            this.supervisorDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.supervisorDetailsToolStripMenuItem.Enabled = false;
            this.supervisorDetailsToolStripMenuItem.Name = "supervisorDetailsToolStripMenuItem";
            this.supervisorDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.supervisorDetailsToolStripMenuItem.Text = "Supervisor Details";
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
            // frmSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 580);
            this.Controls.Add(this.btnSuDelete);
            this.Controls.Add(this.btnSuUpdate);
            this.Controls.Add(this.dgvSupervisor);
            this.Controls.Add(this.btnSuAdd);
            this.Controls.Add(this.txtSuCellNo);
            this.Controls.Add(this.txtSuSurname);
            this.Controls.Add(this.txtSuFirstName);
            this.Controls.Add(this.txtSupervisorID);
            this.Controls.Add(this.lblSuCellNo);
            this.Controls.Add(this.lblSuSurname);
            this.Controls.Add(this.lblSuFirstName);
            this.Controls.Add(this.lblSupervisorID);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSupervisor";
            this.Text = "Project System";
            this.Load += new System.EventHandler(this.frmSupervisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblSupervisorID;
        private System.Windows.Forms.Label lblSuFirstName;
        private System.Windows.Forms.Label lblSuSurname;
        private System.Windows.Forms.Label lblSuCellNo;
        private System.Windows.Forms.TextBox txtSupervisorID;
        private System.Windows.Forms.TextBox txtSuFirstName;
        private System.Windows.Forms.TextBox txtSuSurname;
        private System.Windows.Forms.TextBox txtSuCellNo;
        private System.Windows.Forms.Button btnSuAdd;
        private System.Windows.Forms.DataGridView dgvSupervisor;
        private System.Windows.Forms.Button btnSuDelete;
        private System.Windows.Forms.Button btnSuUpdate;
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