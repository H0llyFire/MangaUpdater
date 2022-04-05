
namespace Menu_Designs
{
    partial class MangaList
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
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonUpdateAll = new System.Windows.Forms.Button();
            this.ListViewMangas = new System.Windows.Forms.ListView();
            this.Chapters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MangaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMenu.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenu.Location = new System.Drawing.Point(800, 464);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(154, 50);
            this.ButtonMenu.TabIndex = 12;
            this.ButtonMenu.Text = "Back";
            this.ButtonMenu.UseVisualStyleBackColor = false;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSettings.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.Location = new System.Drawing.Point(800, 520);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(154, 54);
            this.ButtonSettings.TabIndex = 14;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonUpdateAll
            // 
            this.ButtonUpdateAll.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonUpdateAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUpdateAll.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateAll.Location = new System.Drawing.Point(800, 12);
            this.ButtonUpdateAll.Name = "ButtonUpdateAll";
            this.ButtonUpdateAll.Size = new System.Drawing.Size(154, 88);
            this.ButtonUpdateAll.TabIndex = 15;
            this.ButtonUpdateAll.Text = "Update All";
            this.ButtonUpdateAll.UseVisualStyleBackColor = false;
            this.ButtonUpdateAll.Click += new System.EventHandler(this.ButtonUpdateAll_Click);
            // 
            // ListViewMangas
            // 
            this.ListViewMangas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chapters,
            this.MangaName});
            this.ListViewMangas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewMangas.FullRowSelect = true;
            this.ListViewMangas.HideSelection = false;
            this.ListViewMangas.Location = new System.Drawing.Point(12, 12);
            this.ListViewMangas.MultiSelect = false;
            this.ListViewMangas.Name = "ListViewMangas";
            this.ListViewMangas.ShowGroups = false;
            this.ListViewMangas.Size = new System.Drawing.Size(782, 562);
            this.ListViewMangas.TabIndex = 16;
            this.ListViewMangas.UseCompatibleStateImageBehavior = false;
            this.ListViewMangas.View = System.Windows.Forms.View.Details;
            this.ListViewMangas.DoubleClick += new System.EventHandler(this.ListViewMangas_DoubleClick);
            // 
            // Chapters
            // 
            this.Chapters.Text = "Chapters To Read";
            this.Chapters.Width = 180;
            // 
            // MangaName
            // 
            this.MangaName.Text = "Name";
            this.MangaName.Width = 600;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(800, 164);
            this.TextBoxSearch.MaxLength = 32;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(154, 29);
            this.TextBoxSearch.TabIndex = 17;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearch.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(800, 205);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(154, 50);
            this.ButtonSearch.TabIndex = 19;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // MangaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(966, 593);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListViewMangas);
            this.Controls.Add(this.ButtonUpdateAll);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(982, 632);
            this.MinimumSize = new System.Drawing.Size(982, 632);
            this.Name = "MangaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manga Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MangaList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonMenu;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonUpdateAll;
        private System.Windows.Forms.ListView ListViewMangas;
        private System.Windows.Forms.ColumnHeader Chapters;
        private System.Windows.Forms.ColumnHeader MangaName;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
    }
}