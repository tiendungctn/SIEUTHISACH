namespace SieuThiSach.SystemForm
{
    partial class frmPassword
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtNEWpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOLDpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNEWpasscheck = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(244, 15);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(91, 23);
            this.btnCommit.TabIndex = 4;
            this.btnCommit.Text = "Xác nhận";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtNEWpass
            // 
            this.txtNEWpass.Location = new System.Drawing.Point(118, 36);
            this.txtNEWpass.Name = "txtNEWpass";
            this.txtNEWpass.PasswordChar = '*';
            this.txtNEWpass.Size = new System.Drawing.Size(108, 20);
            this.txtNEWpass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtOLDpass
            // 
            this.txtOLDpass.Location = new System.Drawing.Point(118, 10);
            this.txtOLDpass.Name = "txtOLDpass";
            this.txtOLDpass.PasswordChar = '*';
            this.txtOLDpass.Size = new System.Drawing.Size(108, 20);
            this.txtOLDpass.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtOLDpass, "Nếu đây là lần đăng nhập đầu tiên, không cần nhập ở ô này");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mật khẩu cũ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Xác nhận";
            // 
            // txtNEWpasscheck
            // 
            this.txtNEWpasscheck.Location = new System.Drawing.Point(118, 62);
            this.txtNEWpasscheck.Name = "txtNEWpasscheck";
            this.txtNEWpasscheck.PasswordChar = '*';
            this.txtNEWpasscheck.Size = new System.Drawing.Size(108, 20);
            this.txtNEWpasscheck.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "*Nếu đây là lần đăng nhập đầu tiên. Để trống ô \"Mật khẩu cũ\"";
            // 
            // frmPassword
            // 
            this.AcceptButton = this.btnCommit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(349, 106);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.txtNEWpasscheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNEWpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOLDpass);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassword";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtNEWpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOLDpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNEWpasscheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
    }
}