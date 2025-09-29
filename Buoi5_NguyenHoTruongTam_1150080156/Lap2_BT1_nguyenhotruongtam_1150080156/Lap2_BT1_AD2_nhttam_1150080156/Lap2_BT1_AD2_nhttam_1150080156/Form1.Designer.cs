using System.Drawing;
using System.Windows.Forms;

namespace Lab2_BT1_AD2_nhttam_1150080156
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpPassword;
        private Label lblPassword;
        private TextBox txtPass;

        private GroupBox grpKeyboard;
        private Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0;
        private Button btnClear, btnEnter, btnRing;

        private GroupBox grpLog;
        private DataGridView dgvLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.grpKeyboard = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.grpPassword.SuspendLayout();
            this.grpKeyboard.SuspendLayout();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPassword
            // 
            this.grpPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Controls.Add(this.txtPass);
            this.grpPassword.Location = new System.Drawing.Point(12, 12);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(776, 70);
            this.grpPassword.TabIndex = 0;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Password:";
            this.grpPassword.Enter += new System.EventHandler(this.grpPassword_Enter);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 31);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 16);
            this.lblPassword.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(110, 27);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(640, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // grpKeyboard
            // 
            this.grpKeyboard.BackColor = System.Drawing.Color.Gainsboro;
            this.grpKeyboard.Controls.Add(this.btn1);
            this.grpKeyboard.Controls.Add(this.btn2);
            this.grpKeyboard.Controls.Add(this.btn3);
            this.grpKeyboard.Controls.Add(this.btn4);
            this.grpKeyboard.Controls.Add(this.btn5);
            this.grpKeyboard.Controls.Add(this.btn6);
            this.grpKeyboard.Controls.Add(this.btn7);
            this.grpKeyboard.Controls.Add(this.btn8);
            this.grpKeyboard.Controls.Add(this.btn9);
            this.grpKeyboard.Controls.Add(this.btn0);
            this.grpKeyboard.Controls.Add(this.btnClear);
            this.grpKeyboard.Controls.Add(this.btnEnter);
            this.grpKeyboard.Controls.Add(this.btnRing);
            this.grpKeyboard.Location = new System.Drawing.Point(12, 92);
            this.grpKeyboard.Name = "grpKeyboard";
            this.grpKeyboard.Size = new System.Drawing.Size(776, 210);
            this.grpKeyboard.TabIndex = 1;
            this.grpKeyboard.TabStop = false;
            this.grpKeyboard.Text = "Keyboard:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(245, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 45);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(330, 30);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 45);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(415, 30);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 45);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(245, 90);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 45);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(330, 90);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 45);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(415, 90);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 45);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(245, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 45);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(330, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 45);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(415, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 45);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(330, 180);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 0);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(520, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(520, 95);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 45);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnRing
            // 
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.ForeColor = System.Drawing.Color.White;
            this.btnRing.Location = new System.Drawing.Point(520, 160);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(120, 45);
            this.btnRing.TabIndex = 12;
            this.btnRing.Text = "RING";
            this.btnRing.UseVisualStyleBackColor = false;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.dgvLog);
            this.grpLog.Location = new System.Drawing.Point(12, 310);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(776, 238);
            this.grpLog.TabIndex = 2;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Login Log:";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(16, 26);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.Size = new System.Drawing.Size(744, 196);
            this.dgvLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpKeyboard);
            this.Controls.Add(this.grpPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Panel";
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.grpKeyboard.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
