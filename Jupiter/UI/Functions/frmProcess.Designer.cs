namespace Jupiter.UI.Functions
{
    partial class frmProcess
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstProcess = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdKill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Processes";
            // 
            // lstProcess
            // 
            this.lstProcess.BackColor = System.Drawing.Color.Black;
            this.lstProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colID,
            this.colNum});
            this.lstProcess.ForeColor = System.Drawing.Color.Crimson;
            this.lstProcess.FullRowSelect = true;
            this.lstProcess.GridLines = true;
            this.lstProcess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstProcess.Location = new System.Drawing.Point(12, 39);
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(591, 302);
            this.lstProcess.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstProcess.TabIndex = 2;
            this.lstProcess.UseCompatibleStateImageBehavior = false;
            this.lstProcess.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Process Name";
            this.colName.Width = 400;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 65;
            // 
            // colNum
            // 
            this.colNum.Text = "Handles Number";
            this.colNum.Width = 100;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(496, 347);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(107, 22);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdKill
            // 
            this.cmdKill.Location = new System.Drawing.Point(12, 347);
            this.cmdKill.Name = "cmdKill";
            this.cmdKill.Size = new System.Drawing.Size(107, 22);
            this.cmdKill.TabIndex = 4;
            this.cmdKill.Text = "Kill";
            this.cmdKill.UseVisualStyleBackColor = true;
            this.cmdKill.Click += new System.EventHandler(this.cmdKill_Click);
            // 
            // frmProcess
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 381);
            this.Controls.Add(this.cmdKill);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lstProcess);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcess";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProcess";
            this.Load += new System.EventHandler(this.frmProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lstProcess;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdKill;
    }
}