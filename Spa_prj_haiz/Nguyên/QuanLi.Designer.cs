namespace Spa_prj_haiz.Nguyên
{
    partial class QuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.KHToolst = new System.Windows.Forms.ToolStripMenuItem();
            this.LHTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DVTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NVTool = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TaiChinhTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CaiDattool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KHToolst,
            this.LHTool,
            this.DVTool,
            this.NVTool,
            this.KhoTool,
            this.TaiChinhTool,
            this.BaoCaoTool,
            this.toolStripComboBox1,
            this.CaiDattool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1264, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // KHToolst
            // 
            this.KHToolst.Image = ((System.Drawing.Image)(resources.GetObject("KHToolst.Image")));
            this.KHToolst.Name = "KHToolst";
            this.KHToolst.Size = new System.Drawing.Size(116, 23);
            this.KHToolst.Text = "Khách hàng";
            this.KHToolst.Click += new System.EventHandler(this.kháchToolStripMenuItem_Click);
            // 
            // LHTool
            // 
            this.LHTool.Image = ((System.Drawing.Image)(resources.GetObject("LHTool.Image")));
            this.LHTool.Name = "LHTool";
            this.LHTool.Size = new System.Drawing.Size(94, 27);
            this.LHTool.Text = "Lịch hẹn";
            this.LHTool.Click += new System.EventHandler(this.lịchHẹnToolStripMenuItem_Click);
            // 
            // DVTool
            // 
            this.DVTool.Image = ((System.Drawing.Image)(resources.GetObject("DVTool.Image")));
            this.DVTool.Name = "DVTool";
            this.DVTool.Size = new System.Drawing.Size(88, 27);
            this.DVTool.Text = "Dịch vụ";
            // 
            // NVTool
            // 
            this.NVTool.Image = ((System.Drawing.Image)(resources.GetObject("NVTool.Image")));
            this.NVTool.Name = "NVTool";
            this.NVTool.Size = new System.Drawing.Size(105, 27);
            this.NVTool.Text = "Nhân viên";
            // 
            // KhoTool
            // 
            this.KhoTool.Image = ((System.Drawing.Image)(resources.GetObject("KhoTool.Image")));
            this.KhoTool.Name = "KhoTool";
            this.KhoTool.Size = new System.Drawing.Size(129, 27);
            this.KhoTool.Text = "Kho và vật tư";
            // 
            // TaiChinhTool
            // 
            this.TaiChinhTool.Image = ((System.Drawing.Image)(resources.GetObject("TaiChinhTool.Image")));
            this.TaiChinhTool.Name = "TaiChinhTool";
            this.TaiChinhTool.Size = new System.Drawing.Size(192, 23);
            this.TaiChinhTool.Text = "Tài chính và thanh toán";
            // 
            // BaoCaoTool
            // 
            this.BaoCaoTool.Image = ((System.Drawing.Image)(resources.GetObject("BaoCaoTool.Image")));
            this.BaoCaoTool.Name = "BaoCaoTool";
            this.BaoCaoTool.Size = new System.Drawing.Size(157, 23);
            this.BaoCaoTool.Text = "Báo cáo, thống kê";
            // 
            // CaiDattool
            // 
            this.CaiDattool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CaiDattool.Enabled = false;
            this.CaiDattool.Image = ((System.Drawing.Image)(resources.GetObject("CaiDattool.Image")));
            this.CaiDattool.Name = "CaiDattool";
            this.CaiDattool.Size = new System.Drawing.Size(85, 23);
            this.CaiDattool.Text = "Cài đặt";
            this.CaiDattool.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripComboBox1.Image")));
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(104, 23);
            this.toolStripComboBox1.Text = "Tài khoản";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // QuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuanLi";
            this.Text = "Quản lí";
            this.Load += new System.EventHandler(this.QuanLi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem KHToolst;
        private System.Windows.Forms.ToolStripMenuItem LHTool;
        private System.Windows.Forms.ToolStripMenuItem DVTool;
        private System.Windows.Forms.ToolStripMenuItem NVTool;
        private System.Windows.Forms.ToolStripMenuItem KhoTool;
        private System.Windows.Forms.ToolStripMenuItem TaiChinhTool;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoTool;
        private System.Windows.Forms.ToolStripMenuItem CaiDattool;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
    }
}