
namespace Menu_Designs
{
    partial class UpdateLoad
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
            this.ProgressBarUpdating = new System.Windows.Forms.ProgressBar();
            this.RichTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBarUpdating
            // 
            this.ProgressBarUpdating.Location = new System.Drawing.Point(12, 414);
            this.ProgressBarUpdating.Name = "ProgressBarUpdating";
            this.ProgressBarUpdating.Size = new System.Drawing.Size(475, 37);
            this.ProgressBarUpdating.TabIndex = 0;
            // 
            // RichTextBoxLog
            // 
            this.RichTextBoxLog.Location = new System.Drawing.Point(12, 78);
            this.RichTextBoxLog.Name = "RichTextBoxLog";
            this.RichTextBoxLog.Size = new System.Drawing.Size(475, 317);
            this.RichTextBoxLog.TabIndex = 1;
            this.RichTextBoxLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "DO NOT CLOSE";
            // 
            // UpdateLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(499, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBoxLog);
            this.Controls.Add(this.ProgressBarUpdating);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 502);
            this.MinimumSize = new System.Drawing.Size(515, 502);
            this.Name = "UpdateLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manga Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateLoad_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarUpdating;
        private System.Windows.Forms.RichTextBox RichTextBoxLog;
        private System.Windows.Forms.Label label1;
    }
}