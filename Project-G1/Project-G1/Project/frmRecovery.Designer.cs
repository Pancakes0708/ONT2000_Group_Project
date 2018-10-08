namespace Project
{
    partial class frmRecovery
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
            this.dgvRecovery = new System.Windows.Forms.DataGridView();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnRecover = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecovery
            // 
            this.dgvRecovery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecovery.Location = new System.Drawing.Point(102, 174);
            this.dgvRecovery.Name = "dgvRecovery";
            this.dgvRecovery.Size = new System.Drawing.Size(726, 336);
            this.dgvRecovery.TabIndex = 0;
            this.dgvRecovery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecovery_CellContentClick);
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(396, 119);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(121, 21);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.SelectedValueChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(389, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 37);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Recovery";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(343, 89);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(245, 13);
            this.lblDesc.TabIndex = 47;
            this.lblDesc.Text = "Please select from which table you wish to recover";
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(396, 540);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(111, 23);
            this.btnRecover.TabIndex = 48;
            this.btnRecover.Text = "Recover Selected";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(270, 540);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 49;
            // 
            // frmRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 603);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.dgvRecovery);
            this.Name = "frmRecovery";
            this.Text = "Recovery";
            this.Load += new System.EventHandler(this.frmRecovery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecovery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecovery;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.TextBox txtID;
    }
}