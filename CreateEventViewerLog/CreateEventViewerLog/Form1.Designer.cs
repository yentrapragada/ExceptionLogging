namespace CreateEventViewerLog
{
    partial class Form1
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
            this.lblEventLogName = new System.Windows.Forms.Label();
            this.lblEventLogSOurce = new System.Windows.Forms.Label();
            this.txtEventLogName = new System.Windows.Forms.TextBox();
            this.txtEventLogSource = new System.Windows.Forms.TextBox();
            this.btnEventViewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventLogName
            // 
            this.lblEventLogName.AutoSize = true;
            this.lblEventLogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventLogName.Location = new System.Drawing.Point(29, 35);
            this.lblEventLogName.Name = "lblEventLogName";
            this.lblEventLogName.Size = new System.Drawing.Size(190, 20);
            this.lblEventLogName.TabIndex = 0;
            this.lblEventLogName.Text = "Enter Event Log Name";
            // 
            // lblEventLogSOurce
            // 
            this.lblEventLogSOurce.AutoSize = true;
            this.lblEventLogSOurce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventLogSOurce.Location = new System.Drawing.Point(29, 74);
            this.lblEventLogSOurce.Name = "lblEventLogSOurce";
            this.lblEventLogSOurce.Size = new System.Drawing.Size(201, 20);
            this.lblEventLogSOurce.TabIndex = 1;
            this.lblEventLogSOurce.Text = "Enter Event Log Source";
            // 
            // txtEventLogName
            // 
            this.txtEventLogName.Location = new System.Drawing.Point(244, 32);
            this.txtEventLogName.Name = "txtEventLogName";
            this.txtEventLogName.Size = new System.Drawing.Size(157, 26);
            this.txtEventLogName.TabIndex = 2;
            // 
            // txtEventLogSource
            // 
            this.txtEventLogSource.Location = new System.Drawing.Point(244, 74);
            this.txtEventLogSource.Name = "txtEventLogSource";
            this.txtEventLogSource.Size = new System.Drawing.Size(157, 26);
            this.txtEventLogSource.TabIndex = 3;
            // 
            // btnEventViewer
            // 
            this.btnEventViewer.Location = new System.Drawing.Point(178, 127);
            this.btnEventViewer.Name = "btnEventViewer";
            this.btnEventViewer.Size = new System.Drawing.Size(171, 33);
            this.btnEventViewer.TabIndex = 4;
            this.btnEventViewer.Text = "Create Event Viewer";
            this.btnEventViewer.UseVisualStyleBackColor = true;
            this.btnEventViewer.Click += new System.EventHandler(this.btnEventViewer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 243);
            this.Controls.Add(this.btnEventViewer);
            this.Controls.Add(this.txtEventLogSource);
            this.Controls.Add(this.txtEventLogName);
            this.Controls.Add(this.lblEventLogSOurce);
            this.Controls.Add(this.lblEventLogName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventLogName;
        private System.Windows.Forms.Label lblEventLogSOurce;
        private System.Windows.Forms.TextBox txtEventLogName;
        private System.Windows.Forms.TextBox txtEventLogSource;
        private System.Windows.Forms.Button btnEventViewer;
    }
}

