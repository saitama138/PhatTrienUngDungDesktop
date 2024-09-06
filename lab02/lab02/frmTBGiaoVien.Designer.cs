namespace Lab2
{
	partial class frmTBGiaoVien
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
			this.lblTBao = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTBao
			// 
			this.lblTBao.BackColor = System.Drawing.SystemColors.Control;
			this.lblTBao.Location = new System.Drawing.Point(12, 9);
			this.lblTBao.Name = "lblTBao";
			this.lblTBao.Size = new System.Drawing.Size(360, 143);
			this.lblTBao.TabIndex = 0;
			this.lblTBao.Text = "label1";
			// 
			// frmTBGiaoVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.lblTBao);
			this.Name = "frmTBGiaoVien";
			this.Text = "Thông tin giáo viên nhập";
			this.Load += new System.EventHandler(this.frmTBGiaoVien_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTBao;
	}
}