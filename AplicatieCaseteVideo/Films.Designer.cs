namespace AplicatieCaseteVideo {
    partial class Films {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Films));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.home1 = new AplicatieCaseteVideo.Home();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FloralWhite;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameLV,
            this.Year,
            this.Director});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(30, 150);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1351, 671);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 74;
            // 
            // NameLV
            // 
            this.NameLV.Text = "Name";
            this.NameLV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameLV.Width = 238;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Year.Width = 132;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Director.Width = 216;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilmToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.removeFilmToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addFilmToolStripMenuItem
            // 
            this.addFilmToolStripMenuItem.Name = "addFilmToolStripMenuItem";
            this.addFilmToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.addFilmToolStripMenuItem.Text = "Add Film";
            this.addFilmToolStripMenuItem.Click += new System.EventHandler(this.addFilmToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.saveToolStripMenuItem.Text = "Save as...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // removeFilmToolStripMenuItem
            // 
            this.removeFilmToolStripMenuItem.Name = "removeFilmToolStripMenuItem";
            this.removeFilmToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.removeFilmToolStripMenuItem.Text = "Remove Film";
            this.removeFilmToolStripMenuItem.Click += new System.EventHandler(this.removeFilmToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(845, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reload from database";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "VHS Film Tapes Administration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.Transparent;
            this.home1.Location = new System.Drawing.Point(1302, 48);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(94, 96);
            this.home1.TabIndex = 4;
            // 
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1420, 910);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Films";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Films_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameLV;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private Home home1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem removeFilmToolStripMenuItem;
    }
}