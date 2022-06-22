
namespace Menu_Designs
{
    partial class ConsoleLog
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
            this.ConsoleLogBox = new System.Windows.Forms.RichTextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextBoxCommand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConsoleLogBox
            // 
            this.ConsoleLogBox.Location = new System.Drawing.Point(12, 12);
            this.ConsoleLogBox.Name = "ConsoleLogBox";
            this.ConsoleLogBox.Size = new System.Drawing.Size(668, 351);
            this.ConsoleLogBox.TabIndex = 0;
            this.ConsoleLogBox.Text = "";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(24, 396);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(96, 36);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxCommand
            // 
            this.TextBoxCommand.Location = new System.Drawing.Point(24, 370);
            this.TextBoxCommand.Name = "TextBoxCommand";
            this.TextBoxCommand.Size = new System.Drawing.Size(225, 20);
            this.TextBoxCommand.TabIndex = 2;
            // 
            // ConsoleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 447);
            this.Controls.Add(this.TextBoxCommand);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.ConsoleLogBox);
            this.Name = "ConsoleLog";
            this.Text = "ConsoleLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleLog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleLogBox;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextBoxCommand;
    }
}