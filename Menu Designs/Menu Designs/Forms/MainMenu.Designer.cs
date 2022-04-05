
namespace Menu_Designs
{
    partial class MainMenu
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
            this.ButtonAddManga = new System.Windows.Forms.Button();
            this.ButtonViewManga = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddManga
            // 
            this.ButtonAddManga.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonAddManga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddManga.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddManga.Location = new System.Drawing.Point(74, 57);
            this.ButtonAddManga.Name = "ButtonAddManga";
            this.ButtonAddManga.Size = new System.Drawing.Size(158, 54);
            this.ButtonAddManga.TabIndex = 0;
            this.ButtonAddManga.Text = "Add";
            this.ButtonAddManga.UseVisualStyleBackColor = false;
            this.ButtonAddManga.Click += new System.EventHandler(this.ButtonAddManga_Click);
            // 
            // ButtonViewManga
            // 
            this.ButtonViewManga.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonViewManga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonViewManga.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewManga.Location = new System.Drawing.Point(74, 148);
            this.ButtonViewManga.Name = "ButtonViewManga";
            this.ButtonViewManga.Size = new System.Drawing.Size(158, 57);
            this.ButtonViewManga.TabIndex = 1;
            this.ButtonViewManga.Text = "View";
            this.ButtonViewManga.UseVisualStyleBackColor = false;
            this.ButtonViewManga.Click += new System.EventHandler(this.ButtonViewManga_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSettings.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.Location = new System.Drawing.Point(74, 242);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(158, 57);
            this.ButtonSettings.TabIndex = 2;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(74, 338);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(158, 57);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(307, 470);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonViewManga);
            this.Controls.Add(this.ButtonAddManga);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 509);
            this.MinimumSize = new System.Drawing.Size(323, 509);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manga Updater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddManga;
        private System.Windows.Forms.Button ButtonViewManga;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonExit;
    }
}

