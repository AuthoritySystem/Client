
namespace AuthoritySystem.RoleManager
{
    partial class FrmRoleManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoleManager));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.taBtnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAuthority = new System.Windows.Forms.ToolStripButton();
            this.pnlTop.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.toolStrip1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.toolStripSeparator1,
            this.taBtnModify,
            this.toolStripSeparator2,
            this.tsBtnDel,
            this.toolStripSeparator3,
            this.tsTxtSearch,
            this.tsBtnSearch,
            this.toolStripSeparator4,
            this.tsBtnAuthority});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdd.Image")));
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(36, 39);
            this.tsBtnAdd.Text = "新增";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // taBtnModify
            // 
            this.taBtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.taBtnModify.Image = ((System.Drawing.Image)(resources.GetObject("taBtnModify.Image")));
            this.taBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.taBtnModify.Name = "taBtnModify";
            this.taBtnModify.Size = new System.Drawing.Size(36, 39);
            this.taBtnModify.Text = "编辑";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // tsBtnDel
            // 
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDel.Image")));
            this.tsBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.Size = new System.Drawing.Size(36, 39);
            this.tsBtnDel.Text = "删除";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // tsTxtSearch
            // 
            this.tsTxtSearch.Name = "tsTxtSearch";
            this.tsTxtSearch.Size = new System.Drawing.Size(100, 42);
            // 
            // tsBtnSearch
            // 
            this.tsBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearch.Image")));
            this.tsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearch.Name = "tsBtnSearch";
            this.tsBtnSearch.Size = new System.Drawing.Size(36, 39);
            this.tsBtnSearch.Text = "查找";
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgvRole);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 42);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(800, 408);
            this.pnlFill.TabIndex = 1;
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowTemplate.Height = 25;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(800, 408);
            this.dgvRole.TabIndex = 0;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // tsBtnAuthority
            // 
            this.tsBtnAuthority.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAuthority.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAuthority.Image")));
            this.tsBtnAuthority.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAuthority.Name = "tsBtnAuthority";
            this.tsBtnAuthority.Size = new System.Drawing.Size(60, 39);
            this.tsBtnAuthority.Text = "设置权限";
            this.tsBtnAuthority.Click += new System.EventHandler(this.tsBtnAuthority_Click);
            // 
            // FrmRoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoleManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRoleManager_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton taBtnModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearch;
        private System.Windows.Forms.ToolStripButton tsBtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnAuthority;
    }
}

