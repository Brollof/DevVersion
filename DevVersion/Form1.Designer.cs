namespace DevVersion
{
    partial class mainForm
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
            this.btnGetVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetVer
            // 
            this.btnGetVer.Enabled = false;
            this.btnGetVer.Location = new System.Drawing.Point(12, 12);
            this.btnGetVer.Name = "btnGetVer";
            this.btnGetVer.Size = new System.Drawing.Size(75, 23);
            this.btnGetVer.TabIndex = 0;
            this.btnGetVer.Text = "Get version";
            this.btnGetVer.UseVisualStyleBackColor = true;
            this.btnGetVer.Click += new System.EventHandler(this.btnGetVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version:";
            // 
            // labVer
            // 
            this.labVer.AutoSize = true;
            this.labVer.Location = new System.Drawing.Point(154, 17);
            this.labVer.Name = "labVer";
            this.labVer.Size = new System.Drawing.Size(0, 13);
            this.labVer.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 49);
            this.Controls.Add(this.labVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Dev Version Viewer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labVer;
    }
}

