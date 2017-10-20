namespace Bai_2
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
			this.txtHost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(88, 12);
			this.txtHost.MaxLength = 20;
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(158, 20);
			this.txtHost.TabIndex = 0;
			this.txtHost.Text = "127.0.0.1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "IP/Hostname";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(15, 38);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(346, 23);
			this.btnCheck.TabIndex = 2;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.txtCheck_Click);
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(15, 80);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(346, 103);
			this.txtResult.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Result";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(252, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Port";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(284, 12);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(77, 20);
			this.txtPort.TabIndex = 5;
			this.txtPort.Text = "1724";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 196);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtHost);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox txtResult;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPort;
	}
}

