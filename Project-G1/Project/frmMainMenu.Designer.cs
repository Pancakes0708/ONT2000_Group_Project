namespace Project
{
    partial class frmMainMenu
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
            this.lblProjectSystem = new System.Windows.Forms.Label();
            this.btnStuDetails = new System.Windows.Forms.Button();
            this.btnProTaskDetails = new System.Windows.Forms.Button();
            this.btnAssDetails = new System.Windows.Forms.Button();
            this.btnProGroupDetails = new System.Windows.Forms.Button();
            this.btnBuddyRating = new System.Windows.Forms.Button();
            this.btnSuDetails = new System.Windows.Forms.Button();
            this.btnAssTaskDetails = new System.Windows.Forms.Button();
            this.btnProDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectSystem
            // 
            this.lblProjectSystem.AutoSize = true;
            this.lblProjectSystem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblProjectSystem.Font = new System.Drawing.Font("Felix Titling", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectSystem.Location = new System.Drawing.Point(143, 33);
            this.lblProjectSystem.Name = "lblProjectSystem";
            this.lblProjectSystem.Size = new System.Drawing.Size(584, 148);
            this.lblProjectSystem.TabIndex = 0;
            this.lblProjectSystem.Text = "PROJECT SYSTEM:\r\nMAIN MENU\r\n";
            this.lblProjectSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStuDetails
            // 
            this.btnStuDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuDetails.Location = new System.Drawing.Point(156, 213);
            this.btnStuDetails.Name = "btnStuDetails";
            this.btnStuDetails.Size = new System.Drawing.Size(232, 35);
            this.btnStuDetails.TabIndex = 1;
            this.btnStuDetails.Text = "Student Details";
            this.btnStuDetails.UseVisualStyleBackColor = true;
            this.btnStuDetails.Click += new System.EventHandler(this.btnStuDetails_Click);
            // 
            // btnProTaskDetails
            // 
            this.btnProTaskDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProTaskDetails.Location = new System.Drawing.Point(156, 337);
            this.btnProTaskDetails.Name = "btnProTaskDetails";
            this.btnProTaskDetails.Size = new System.Drawing.Size(232, 35);
            this.btnProTaskDetails.TabIndex = 2;
            this.btnProTaskDetails.Text = "Project-Task Details";
            this.btnProTaskDetails.UseVisualStyleBackColor = true;
            this.btnProTaskDetails.Click += new System.EventHandler(this.btnProTaskDetails_Click);
            // 
            // btnAssDetails
            // 
            this.btnAssDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssDetails.Location = new System.Drawing.Point(484, 337);
            this.btnAssDetails.Name = "btnAssDetails";
            this.btnAssDetails.Size = new System.Drawing.Size(232, 35);
            this.btnAssDetails.TabIndex = 3;
            this.btnAssDetails.Text = "Assignment Details";
            this.btnAssDetails.UseVisualStyleBackColor = true;
            this.btnAssDetails.Click += new System.EventHandler(this.btnAssDetails_Click);
            // 
            // btnProGroupDetails
            // 
            this.btnProGroupDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProGroupDetails.Location = new System.Drawing.Point(484, 277);
            this.btnProGroupDetails.Name = "btnProGroupDetails";
            this.btnProGroupDetails.Size = new System.Drawing.Size(232, 35);
            this.btnProGroupDetails.TabIndex = 4;
            this.btnProGroupDetails.Text = "Project-Group Details";
            this.btnProGroupDetails.UseVisualStyleBackColor = true;
            this.btnProGroupDetails.Click += new System.EventHandler(this.btnProGroupDetails_Click);
            // 
            // btnBuddyRating
            // 
            this.btnBuddyRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuddyRating.Location = new System.Drawing.Point(484, 399);
            this.btnBuddyRating.Name = "btnBuddyRating";
            this.btnBuddyRating.Size = new System.Drawing.Size(232, 35);
            this.btnBuddyRating.TabIndex = 5;
            this.btnBuddyRating.Text = "Buddy Rating";
            this.btnBuddyRating.UseVisualStyleBackColor = true;
            this.btnBuddyRating.Click += new System.EventHandler(this.btnBuddyRating_Click);
            // 
            // btnSuDetails
            // 
            this.btnSuDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuDetails.Location = new System.Drawing.Point(484, 213);
            this.btnSuDetails.Name = "btnSuDetails";
            this.btnSuDetails.Size = new System.Drawing.Size(232, 35);
            this.btnSuDetails.TabIndex = 6;
            this.btnSuDetails.Text = "Supervisor Details";
            this.btnSuDetails.UseVisualStyleBackColor = true;
            this.btnSuDetails.Click += new System.EventHandler(this.btnSuDetails_Click);
            // 
            // btnAssTaskDetails
            // 
            this.btnAssTaskDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssTaskDetails.Location = new System.Drawing.Point(156, 399);
            this.btnAssTaskDetails.Name = "btnAssTaskDetails";
            this.btnAssTaskDetails.Size = new System.Drawing.Size(232, 35);
            this.btnAssTaskDetails.TabIndex = 7;
            this.btnAssTaskDetails.Text = "Assignment-Task Details";
            this.btnAssTaskDetails.UseVisualStyleBackColor = true;
            this.btnAssTaskDetails.Click += new System.EventHandler(this.btnAssTaskDetails_Click);
            // 
            // btnProDetails
            // 
            this.btnProDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDetails.Location = new System.Drawing.Point(156, 277);
            this.btnProDetails.Name = "btnProDetails";
            this.btnProDetails.Size = new System.Drawing.Size(232, 35);
            this.btnProDetails.TabIndex = 8;
            this.btnProDetails.Text = "Project Details";
            this.btnProDetails.UseVisualStyleBackColor = true;
            this.btnProDetails.Click += new System.EventHandler(this.btnProDetails_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.acceleration_of_acceleration_future_tech_1_1440x598;
            this.ClientSize = new System.Drawing.Size(879, 470);
            this.Controls.Add(this.btnProDetails);
            this.Controls.Add(this.btnAssTaskDetails);
            this.Controls.Add(this.btnSuDetails);
            this.Controls.Add(this.btnBuddyRating);
            this.Controls.Add(this.btnProGroupDetails);
            this.Controls.Add(this.btnAssDetails);
            this.Controls.Add(this.btnProTaskDetails);
            this.Controls.Add(this.btnStuDetails);
            this.Controls.Add(this.lblProjectSystem);
            this.Name = "frmMainMenu";
            this.Text = "Project System";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectSystem;
        private System.Windows.Forms.Button btnStuDetails;
        private System.Windows.Forms.Button btnProTaskDetails;
        private System.Windows.Forms.Button btnAssDetails;
        private System.Windows.Forms.Button btnProGroupDetails;
        private System.Windows.Forms.Button btnBuddyRating;
        private System.Windows.Forms.Button btnSuDetails;
        private System.Windows.Forms.Button btnAssTaskDetails;
        private System.Windows.Forms.Button btnProDetails;
    }
}