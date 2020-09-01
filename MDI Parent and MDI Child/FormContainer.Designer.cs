namespace MDI_Parent_and_MDI_Child
{
    partial class formContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSingleTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMultipleTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllOpenFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSingleTimeToolStripMenuItem,
            this.openMultipleTimeToolStripMenuItem,
            this.closeAllOpenFormToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openSingleTimeToolStripMenuItem
            // 
            this.openSingleTimeToolStripMenuItem.Name = "openSingleTimeToolStripMenuItem";
            this.openSingleTimeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openSingleTimeToolStripMenuItem.Text = "Open Form Ones";
            this.openSingleTimeToolStripMenuItem.Click += new System.EventHandler(this.openSingleTimeToolStripMenuItem_Click);
            // 
            // openMultipleTimeToolStripMenuItem
            // 
            this.openMultipleTimeToolStripMenuItem.Name = "openMultipleTimeToolStripMenuItem";
            this.openMultipleTimeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openMultipleTimeToolStripMenuItem.Text = "Open Form Multiple Times";
            this.openMultipleTimeToolStripMenuItem.Click += new System.EventHandler(this.openMultipleTimeToolStripMenuItem_Click);
            // 
            // closeAllOpenFormToolStripMenuItem
            // 
            this.closeAllOpenFormToolStripMenuItem.Name = "closeAllOpenFormToolStripMenuItem";
            this.closeAllOpenFormToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.closeAllOpenFormToolStripMenuItem.Text = "Close All Open Form";
            this.closeAllOpenFormToolStripMenuItem.Click += new System.EventHandler(this.closeAllOpenFormToolStripMenuItem_Click);
            // 
            // formContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formContainer";
            this.Text = "MDI Parent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSingleTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMultipleTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllOpenFormToolStripMenuItem;
    }
}

