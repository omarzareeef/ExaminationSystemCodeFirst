namespace ExaminationSys
{
    partial class FormAddBranch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltxtBranch = new System.Windows.Forms.Label();
            this.panel2branch = new System.Windows.Forms.Panel();
            this.BtnInsertBranch = new System.Windows.Forms.Button();
            this.txtNameBranch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2branch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.labeltxtBranch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 97);
            this.panel1.TabIndex = 2;
            // 
            // labeltxtBranch
            // 
            this.labeltxtBranch.AutoSize = true;
            this.labeltxtBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxtBranch.ForeColor = System.Drawing.Color.Black;
            this.labeltxtBranch.Location = new System.Drawing.Point(34, 40);
            this.labeltxtBranch.Name = "labeltxtBranch";
            this.labeltxtBranch.Size = new System.Drawing.Size(93, 21);
            this.labeltxtBranch.TabIndex = 0;
            this.labeltxtBranch.Text = "Add Branch";
            // 
            // panel2branch
            // 
            this.panel2branch.BackColor = System.Drawing.Color.White;
            this.panel2branch.Controls.Add(this.BtnInsertBranch);
            this.panel2branch.Controls.Add(this.txtNameBranch);
            this.panel2branch.Controls.Add(this.label1);
            this.panel2branch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2branch.Location = new System.Drawing.Point(38, 128);
            this.panel2branch.Name = "panel2branch";
            this.panel2branch.Size = new System.Drawing.Size(312, 185);
            this.panel2branch.TabIndex = 3;
            // 
            // BtnInsertBranch
            // 
            this.BtnInsertBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnInsertBranch.FlatAppearance.BorderSize = 0;
            this.BtnInsertBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertBranch.ForeColor = System.Drawing.Color.Black;
            this.BtnInsertBranch.Location = new System.Drawing.Point(92, 126);
            this.BtnInsertBranch.Name = "BtnInsertBranch";
            this.BtnInsertBranch.Size = new System.Drawing.Size(95, 32);
            this.BtnInsertBranch.TabIndex = 6;
            this.BtnInsertBranch.Text = "Save";
            this.BtnInsertBranch.UseVisualStyleBackColor = false;
            this.BtnInsertBranch.Click += new System.EventHandler(this.BtnInsertBranch_Click);
            // 
            // txtNameBranch
            // 
            this.txtNameBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBranch.Location = new System.Drawing.Point(143, 53);
            this.txtNameBranch.Name = "txtNameBranch";
            this.txtNameBranch.Size = new System.Drawing.Size(139, 24);
            this.txtNameBranch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // FormAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 358);
            this.Controls.Add(this.panel2branch);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddBranch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2branch.ResumeLayout(false);
            this.panel2branch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltxtBranch;
        private System.Windows.Forms.Panel panel2branch;
        private System.Windows.Forms.Button BtnInsertBranch;
        private System.Windows.Forms.TextBox txtNameBranch;
        private System.Windows.Forms.Label label1;
    }
}