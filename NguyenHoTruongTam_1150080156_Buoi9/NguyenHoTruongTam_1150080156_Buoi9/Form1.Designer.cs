using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Buoi9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnHienThi;
        private DataGridView dgvNhaXB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnHienThi = new System.Windows.Forms.Button();
            this.dgvNhaXB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHienThi.Location = new System.Drawing.Point(192, 20); // sẽ được canh giữa lại ở Form1_Resize
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(400, 60);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị danh sách_1150080156_Nguyễn Hồ TRường Tam";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dgvNhaXb
            // 
            this.dgvNhaXB.AllowUserToAddRows = false;
            this.dgvNhaXB.AllowUserToDeleteRows = false;
            this.dgvNhaXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaXB.BackgroundColor = System.Drawing.SystemColors.ControlDark; // xám giống ảnh
            this.dgvNhaXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaXB.Location = new System.Drawing.Point(30, 100);
            this.dgvNhaXB.MultiSelect = false;
            this.dgvNhaXB.Name = "dgvNhaXB";
            this.dgvNhaXB.ReadOnly = true;
            this.dgvNhaXB.RowHeadersVisible = false;
            this.dgvNhaXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaXB.Size = new System.Drawing.Size(740, 340);
            this.dgvNhaXB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnHienThi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.dgvNhaXB);
            this.Controls.Add(this.btnHienThi);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(720, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize); // để canh giữa nút
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXB)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}