using System.Drawing;
using System.Windows.Forms;

namespace Lap2_BT1_AD1_nhttam_1150080156
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private GroupBox grpChon;
        private RadioButton rdoUSCLN;
        private RadioButton rdoBSCNN;
        private Button btnTinh;
        private Button btnThoat;
        private Label lblKQ;
        private TextBox txtKQ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblA = new Label();
            this.lblB = new Label();
            this.txtA = new TextBox();
            this.txtB = new TextBox();
            this.grpChon = new GroupBox();
            this.rdoUSCLN = new RadioButton();
            this.rdoBSCNN = new RadioButton();
            this.btnTinh = new Button();
            this.btnThoat = new Button();
            this.lblKQ = new Label();
            this.txtKQ = new TextBox();
            this.grpChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(60, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(333, 25);
            this.lblTitle.Text = "USCLN & BSCNN CUA HAI SO NGUYEN";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new Point(62, 65);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(67, 15);
            this.lblA.Text = "Nhap so a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new Point(62, 100);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(67, 15);
            this.lblB.Text = "Nhap so b:";
            // 
            // txtA
            // 
            this.txtA.Location = new Point(140, 61);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(250, 23);
            // 
            // txtB
            // 
            this.txtB.Location = new Point(140, 96);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(250, 23);
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.rdoUSCLN);
            this.grpChon.Controls.Add(this.rdoBSCNN);
            this.grpChon.Location = new Point(65, 135);
            this.grpChon.Name = "grpChon";
            this.grpChon.Size = new Size(325, 60);
            this.grpChon.Text = "Chon tac vu";
            // 
            // rdoUSCLN
            // 
            this.rdoUSCLN.AutoSize = true;
            this.rdoUSCLN.Location = new Point(20, 25);
            this.rdoUSCLN.Name = "rdoUSCLN";
            this.rdoUSCLN.Size = new Size(64, 19);
            this.rdoUSCLN.Text = "USCLN";
            this.rdoUSCLN.Checked = true;
            // 
            // rdoBSCNN
            // 
            this.rdoBSCNN.AutoSize = true;
            this.rdoBSCNN.Location = new Point(120, 25);
            this.rdoBSCNN.Name = "rdoBSCNN";
            this.rdoBSCNN.Size = new Size(64, 19);
            this.rdoBSCNN.Text = "BSCNN";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new Point(140, 210);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new Size(90, 30);
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new Point(240, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(90, 30);
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new Point(62, 260);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new Size(50, 15);
            this.lblKQ.Text = "Ket qua:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new Point(140, 256);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new Size(250, 23);
            // 
            // Form1
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(470, 310);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.grpChon);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Ap dung 1 - USCLN & BSCNN";
            this.grpChon.ResumeLayout(false);
            this.grpChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


