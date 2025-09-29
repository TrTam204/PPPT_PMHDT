namespace Lap2_BT3_AD4_nhttam_1150080156
{
    partial class Form1
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
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.btnChon1 = new System.Windows.Forms.Button();
            this.btnChonAll = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblDaChon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Items.AddRange(new object[] {
            "CPU",
            "MainBoard",
            "RAM",
            "Keyboard",
            "Mouse",
            "NIC",
            "FAN"});
            this.lstDanhSach.Location = new System.Drawing.Point(20, 40);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(200, 260);
            this.lstDanhSach.TabIndex = 0;
            // 
            // lstDaChon
            // 
            this.lstDaChon.FormattingEnabled = true;
            this.lstDaChon.ItemHeight = 16;
            this.lstDaChon.Location = new System.Drawing.Point(370, 40);
            this.lstDaChon.Name = "lstDaChon";
            this.lstDaChon.Size = new System.Drawing.Size(200, 260);
            this.lstDaChon.TabIndex = 1;
            // 
            // btnChon1
            // 
            this.btnChon1.Location = new System.Drawing.Point(250, 70);
            this.btnChon1.Name = "btnChon1";
            this.btnChon1.Size = new System.Drawing.Size(90, 30);
            this.btnChon1.TabIndex = 2;
            this.btnChon1.Text = ">";
            this.btnChon1.UseVisualStyleBackColor = true;
            this.btnChon1.Click += new System.EventHandler(this.btnChon1_Click);
            // 
            // btnChonAll
            // 
            this.btnChonAll.Location = new System.Drawing.Point(250, 120);
            this.btnChonAll.Name = "btnChonAll";
            this.btnChonAll.Size = new System.Drawing.Size(90, 30);
            this.btnChonAll.TabIndex = 3;
            this.btnChonAll.Text = ">>";
            this.btnChonAll.UseVisualStyleBackColor = true;
            this.btnChonAll.Click += new System.EventHandler(this.btnChonAll_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(250, 170);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(90, 30);
            this.btnXoa1.TabIndex = 4;
            this.btnXoa1.Text = "<";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(250, 220);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(90, 30);
            this.btnXoaAll.TabIndex = 5;
            this.btnXoaAll.Text = "<<";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(20, 15);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(150, 16);
            this.lblDanhSach.TabIndex = 6;
            this.lblDanhSach.Text = "Danh sách các mặt hàng";
            // 
            // lblDaChon
            // 
            this.lblDaChon.AutoSize = true;
            this.lblDaChon.Location = new System.Drawing.Point(370, 15);
            this.lblDaChon.Name = "lblDaChon";
            this.lblDaChon.Size = new System.Drawing.Size(148, 16);
            this.lblDaChon.TabIndex = 7;
            this.lblDaChon.Text = "Các mặt hàng lựa chọn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.lblDaChon);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.btnChonAll);
            this.Controls.Add(this.btnChon1);
            this.Controls.Add(this.lstDaChon);
            this.Controls.Add(this.lstDanhSach);
            this.Name = "Form1";
            this.Text = "Bài tập 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Button btnChon1;
        private System.Windows.Forms.Button btnChonAll;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblDaChon;
    }
}