namespace Lab2
{
	partial class TimKiem
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
			this.gbTim = new System.Windows.Forms.GroupBox();
			this.rdSDT = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdmaGV = new System.Windows.Forms.RadioButton();
			this.btOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.gbTim.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTim
			// 
			this.gbTim.Controls.Add(this.rdSDT);
			this.gbTim.Controls.Add(this.rdHoTen);
			this.gbTim.Controls.Add(this.rdmaGV);
			this.gbTim.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTim.Location = new System.Drawing.Point(12, 19);
			this.gbTim.Name = "gbTim";
			this.gbTim.Size = new System.Drawing.Size(360, 71);
			this.gbTim.TabIndex = 0;
			this.gbTim.TabStop = false;
			this.gbTim.Text = "Tìm theo";
			// 
			// rdSDT
			// 
			this.rdSDT.AutoSize = true;
			this.rdSDT.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdSDT.Location = new System.Drawing.Point(245, 30);
			this.rdSDT.Name = "rdSDT";
			this.rdSDT.Size = new System.Drawing.Size(100, 19);
			this.rdSDT.TabIndex = 2;
			this.rdSDT.TabStop = true;
			this.rdSDT.Text = "Số điện thoại";
			this.rdSDT.UseVisualStyleBackColor = true;
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdHoTen.Location = new System.Drawing.Point(134, 30);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(66, 19);
			this.rdHoTen.TabIndex = 1;
			this.rdHoTen.TabStop = true;
			this.rdHoTen.Text = "Họ Tên";
			this.rdHoTen.UseVisualStyleBackColor = true;
			// 
			// rdmaGV
			// 
			this.rdmaGV.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.rdmaGV.AutoSize = true;
			this.rdmaGV.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdmaGV.Location = new System.Drawing.Point(24, 30);
			this.rdmaGV.Name = "rdmaGV";
			this.rdmaGV.Size = new System.Drawing.Size(64, 19);
			this.rdmaGV.TabIndex = 0;
			this.rdmaGV.TabStop = true;
			this.rdmaGV.Text = "Mã GV";
			this.rdmaGV.UseVisualStyleBackColor = true;
			// 
			// btOK
			// 
			this.btOK.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btOK.Location = new System.Drawing.Point(296, 111);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(67, 23);
			this.btOK.TabIndex = 2;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã GV";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(124, 112);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(161, 20);
			this.txtTimKiem.TabIndex = 1;
			// 
			// TimKiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.gbTim);
			this.Name = "TimKiem";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TimKiem";
			this.gbTim.ResumeLayout(false);
			this.gbTim.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbTim;
		private System.Windows.Forms.RadioButton rdSDT;
		private System.Windows.Forms.RadioButton rdHoTen;
		private System.Windows.Forms.RadioButton rdmaGV;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTimKiem;
	}
}