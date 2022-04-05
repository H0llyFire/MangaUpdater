
namespace Menu_Designs
{
    partial class Settings
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
            this.ButtonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.ButtonConsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMenu.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenu.Location = new System.Drawing.Point(84, 316);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(123, 54);
            this.ButtonMenu.TabIndex = 13;
            this.ButtonMenu.Text = "Back";
            this.ButtonMenu.UseVisualStyleBackColor = false;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Database Location";
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLocation.Location = new System.Drawing.Point(12, 39);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(233, 31);
            this.TextBoxLocation.TabIndex = 15;
            // 
            // ButtonConsole
            // 
            this.ButtonConsole.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonConsole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonConsole.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConsole.Location = new System.Drawing.Point(84, 163);
            this.ButtonConsole.Name = "ButtonConsole";
            this.ButtonConsole.Size = new System.Drawing.Size(123, 54);
            this.ButtonConsole.TabIndex = 16;
            this.ButtonConsole.Text = "Console";
            this.ButtonConsole.UseVisualStyleBackColor = false;
            this.ButtonConsole.Click += new System.EventHandler(this.ButtonConsole_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(292, 403);
            this.Controls.Add(this.ButtonConsole);
            this.Controls.Add(this.TextBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 442);
            this.MinimumSize = new System.Drawing.Size(308, 442);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MangaUpdater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.Button ButtonConsole;
    }
}