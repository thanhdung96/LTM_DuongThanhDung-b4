namespace ChatClient
{
	partial class ChatClient
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
			this.btnVideo = new System.Windows.Forms.Button();
			this.btnSound = new System.Windows.Forms.Button();
			this.btnImg = new System.Windows.Forms.Button();
			this.btnText = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lbxConversation = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnVideo
			// 
			this.btnVideo.Location = new System.Drawing.Point(328, 311);
			this.btnVideo.Name = "btnVideo";
			this.btnVideo.Size = new System.Drawing.Size(97, 23);
			this.btnVideo.TabIndex = 11;
			this.btnVideo.Text = "Send Video";
			this.btnVideo.UseVisualStyleBackColor = true;
			// 
			// btnSound
			// 
			this.btnSound.Location = new System.Drawing.Point(328, 285);
			this.btnSound.Name = "btnSound";
			this.btnSound.Size = new System.Drawing.Size(97, 23);
			this.btnSound.TabIndex = 10;
			this.btnSound.Text = "Send Sound";
			this.btnSound.UseVisualStyleBackColor = true;
			// 
			// btnImg
			// 
			this.btnImg.Location = new System.Drawing.Point(328, 256);
			this.btnImg.Name = "btnImg";
			this.btnImg.Size = new System.Drawing.Size(97, 23);
			this.btnImg.TabIndex = 9;
			this.btnImg.Text = "Send Image";
			this.btnImg.UseVisualStyleBackColor = true;
			// 
			// btnText
			// 
			this.btnText.Location = new System.Drawing.Point(328, 230);
			this.btnText.Name = "btnText";
			this.btnText.Size = new System.Drawing.Size(97, 23);
			this.btnText.TabIndex = 8;
			this.btnText.Text = "Send";
			this.btnText.UseVisualStyleBackColor = true;
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(12, 230);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(310, 104);
			this.txtInput.TabIndex = 7;
			// 
			// lbxConversation
			// 
			this.lbxConversation.FormattingEnabled = true;
			this.lbxConversation.Location = new System.Drawing.Point(12, 12);
			this.lbxConversation.Name = "lbxConversation";
			this.lbxConversation.Size = new System.Drawing.Size(413, 212);
			this.lbxConversation.TabIndex = 6;
			// 
			// ChatClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 343);
			this.Controls.Add(this.btnVideo);
			this.Controls.Add(this.btnSound);
			this.Controls.Add(this.btnImg);
			this.Controls.Add(this.btnText);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.lbxConversation);
			this.Name = "ChatClient";
			this.Text = "Chat Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnVideo;
		private System.Windows.Forms.Button btnSound;
		private System.Windows.Forms.Button btnImg;
		private System.Windows.Forms.Button btnText;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.ListBox lbxConversation;
	}
}

