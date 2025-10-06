using System.Drawing;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Lap3_TH1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox picLogo;
        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox gbMenu;
        private FlowLayoutPanel flpMon;
        private Panel pnlBottom;
        private Button btnXoa;
        private Label lblChonBan;
        private ComboBox cbBan;
        private Button btnOrder;
        private DataGridView dgvOrder;
        private Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.flpMon = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblChonBan = new System.Windows.Forms.Label();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::NguyenHoTruongTam_1150080156_Lap3_TH1.Properties.Resources.LOGO1_64;
            this.picLogo.Location = new System.Drawing.Point(12, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(70, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(88, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(740, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(740, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quán ăn nhanh Trường Tam";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.flpMon);
            this.gbMenu.Location = new System.Drawing.Point(12, 78);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(816, 299);
            this.gbMenu.TabIndex = 2;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Danh sách món ăn:";
            // 
            // flpMon
            // 
            this.flpMon.Location = new System.Drawing.Point(10, 22);
            this.flpMon.Name = "flpMon";
            this.flpMon.Padding = new System.Windows.Forms.Padding(8);
            this.flpMon.Size = new System.Drawing.Size(796, 298);
            this.flpMon.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnXoa);
            this.pnlBottom.Controls.Add(this.lblChonBan);
            this.pnlBottom.Controls.Add(this.cbBan);
            this.pnlBottom.Controls.Add(this.btnOrder);
            this.pnlBottom.Location = new System.Drawing.Point(12, 404);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(816, 44);
            this.pnlBottom.TabIndex = 3;
            this.pnlBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottom_Paint);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(10, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 28);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblChonBan
            // 
            this.lblChonBan.AutoSize = true;
            this.lblChonBan.Location = new System.Drawing.Point(128, 12);
            this.lblChonBan.Name = "lblChonBan";
            this.lblChonBan.Size = new System.Drawing.Size(75, 20);
            this.lblChonBan.TabIndex = 1;
            this.lblChonBan.Text = "Chọn bàn:";
            // 
            // cbBan
            // 
            this.cbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBan.Location = new System.Drawing.Point(196, 8);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(170, 28);
            this.cbBan.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(720, 8);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(84, 28);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvOrder.ColumnHeadersHeight = 29;
            this.dgvOrder.Location = new System.Drawing.Point(12, 454);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(816, 231);
            this.dgvOrder.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(728, 688);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 23);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Tổng: 0 đ";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(840, 720);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lblTotal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.gbMenu.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
