namespace SieuThiSach.AllForm
{
    partial class frmExecl
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
            this.lstExcel = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstExcel
            // 
            this.lstExcel.GridLines = true;
            this.lstExcel.Location = new System.Drawing.Point(13, 13);
            this.lstExcel.Name = "lstExcel";
            this.lstExcel.Size = new System.Drawing.Size(573, 221);
            this.lstExcel.TabIndex = 0;
            this.lstExcel.UseCompatibleStateImageBehavior = false;
            this.lstExcel.View = System.Windows.Forms.View.Details;
            // 
            // frmExecl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 287);
            this.Controls.Add(this.lstExcel);
            this.Name = "frmExecl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load dữ liệu Excel";
            this.Load += new System.EventHandler(this.frmExecl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstExcel;
    }
}