
namespace _2DTileEditor
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.importButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeChangeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.grassBox = new System.Windows.Forms.PictureBox();
            this.roadBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(152, 36);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(700, 700);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(700, 700);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPaint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu,
            this.settingsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.importButton});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(50, 20);
            this.mainMenu.Text = "Menu";
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 22);
            this.saveButton.Text = "Uložit";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // importButton
            // 
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(180, 22);
            this.importButton.Text = "Importovat";
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeChangeBtn});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(71, 20);
            this.settingsMenu.Text = "Nastavení";
            // 
            // sizeChangeBtn
            // 
            this.sizeChangeBtn.Name = "sizeChangeBtn";
            this.sizeChangeBtn.Size = new System.Drawing.Size(153, 22);
            this.sizeChangeBtn.Text = "Velikost plochy";
            this.sizeChangeBtn.Click += new System.EventHandler(this.sizeChangeBtn_Click);
            // 
            // grassBox
            // 
            this.grassBox.Location = new System.Drawing.Point(85, 755);
            this.grassBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.grassBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.grassBox.Name = "grassBox";
            this.grassBox.Size = new System.Drawing.Size(100, 100);
            this.grassBox.TabIndex = 2;
            this.grassBox.TabStop = false;
            this.grassBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grassBox_MouseClick);
            // 
            // roadBox
            // 
            this.roadBox.Location = new System.Drawing.Point(191, 755);
            this.roadBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.roadBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.roadBox.Name = "roadBox";
            this.roadBox.Size = new System.Drawing.Size(100, 100);
            this.roadBox.TabIndex = 3;
            this.roadBox.TabStop = false;
            this.roadBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roadBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 867);
            this.Controls.Add(this.roadBox);
            this.Controls.Add(this.grassBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = this.Text;
            this.Text = "2D Tile Editor";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenu;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem importButton;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem sizeChangeBtn;
        private System.Windows.Forms.PictureBox grassBox;
        private System.Windows.Forms.PictureBox roadBox;
    }
}

