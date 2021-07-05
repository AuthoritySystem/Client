
namespace AuthoritySystem.RoleManager
{
    partial class FrmRoleMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoleMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRoleMenu = new System.Windows.Forms.DataGridView();
            this.dgvCbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 41);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Save,
            this.toolStripSeparator1,
            this.tsbtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 41);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Save
            // 
            this.tsbtn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Save.Image")));
            this.tsbtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Save.Name = "tsbtn_Save";
            this.tsbtn_Save.Size = new System.Drawing.Size(36, 38);
            this.tsbtn_Save.Text = "保存";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // tsbtn_Exit
            // 
            this.tsbtn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Exit.Image")));
            this.tsbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Exit.Name = "tsbtn_Exit";
            this.tsbtn_Exit.Size = new System.Drawing.Size(36, 38);
            this.tsbtn_Exit.Text = "关闭";
            this.tsbtn_Exit.Click += new System.EventHandler(this.tsbtn_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvRoleMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 373);
            this.panel2.TabIndex = 1;
            // 
            // dgvRoleMenu
            // 
            this.dgvRoleMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCbx});
            this.dgvRoleMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoleMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvRoleMenu.Name = "dgvRoleMenu";
            this.dgvRoleMenu.RowTemplate.Height = 25;
            this.dgvRoleMenu.Size = new System.Drawing.Size(788, 373);
            this.dgvRoleMenu.TabIndex = 0;
            // 
            // dgvCbx
            // 
            this.dgvCbx.HeaderText = "Column1";
            this.dgvCbx.Name = "dgvCbx";
            // 
            // FrmRoleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 414);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoleMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRoleMenu";
            this.Load += new System.EventHandler(this.FrmRoleMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRoleMenu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCbx;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_Exit;
    }
}