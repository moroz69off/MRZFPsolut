﻿
namespace WTelegramClientTestWF
{
	partial class MainForm
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonGetChats = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.labelCode = new System.Windows.Forms.Label();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.buttonSendCode = new System.Windows.Forms.Button();
			this.panelActions = new System.Windows.Forms.Panel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.buttonSendMsg = new System.Windows.Forms.Button();
			this.buttonGetMembers = new System.Windows.Forms.Button();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.textBoxApiHash = new System.Windows.Forms.TextBox();
			this.textBoxApiID = new System.Windows.Forms.TextBox();
			this.buttonGetDialogs = new System.Windows.Forms.Button();
			this.panelActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(355, 38);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(112, 26);
			this.buttonLogin.TabIndex = 7;
			this.buttonLogin.Text = "Connect/Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonGetChats
			// 
			this.buttonGetChats.Location = new System.Drawing.Point(3, 3);
			this.buttonGetChats.Name = "buttonGetChats";
			this.buttonGetChats.Size = new System.Drawing.Size(105, 36);
			this.buttonGetChats.TabIndex = 0;
			this.buttonGetChats.Text = "Get chats";
			this.buttonGetChats.UseVisualStyleBackColor = true;
			this.buttonGetChats.Click += new System.EventHandler(this.buttonGetChats_Click);
			// 
			// listBox
			// 
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(12, 118);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(788, 308);
			this.listBox.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(2);
			this.label1.Size = new System.Drawing.Size(58, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "api_id:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(187, 12);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(2);
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "api_hash:";
			// 
			// linkLabel
			// 
			this.linkLabel.AutoSize = true;
			this.linkLabel.LinkArea = new System.Windows.Forms.LinkArea(13, 28);
			this.linkLabel.Location = new System.Drawing.Point(559, 14);
			this.linkLabel.Name = "linkLabel";
			this.linkLabel.Padding = new System.Windows.Forms.Padding(2);
			this.linkLabel.Size = new System.Drawing.Size(252, 24);
			this.linkLabel.TabIndex = 4;
			this.linkLabel.TabStop = true;
			this.linkLabel.Tag = "https://my.telegram.org/apps";
			this.linkLabel.Text = "get these at https://my.telegram.org/apps";
			this.linkLabel.UseCompatibleTextRendering = true;
			this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 40);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(2);
			this.label3.Size = new System.Drawing.Size(147, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "user phone number:";
			// 
			// labelCode
			// 
			this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCode.Location = new System.Drawing.Point(473, 40);
			this.labelCode.Margin = new System.Windows.Forms.Padding(0);
			this.labelCode.Name = "labelCode";
			this.labelCode.Padding = new System.Windows.Forms.Padding(2);
			this.labelCode.Size = new System.Drawing.Size(143, 21);
			this.labelCode.TabIndex = 8;
			this.labelCode.Text = "verification_code:";
			this.labelCode.Visible = false;
			// 
			// textBoxCode
			// 
			this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCode.Location = new System.Drawing.Point(619, 40);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(94, 22);
			this.textBoxCode.TabIndex = 9;
			this.textBoxCode.Visible = false;
			// 
			// buttonSendCode
			// 
			this.buttonSendCode.Location = new System.Drawing.Point(719, 38);
			this.buttonSendCode.Name = "buttonSendCode";
			this.buttonSendCode.Size = new System.Drawing.Size(81, 26);
			this.buttonSendCode.TabIndex = 10;
			this.buttonSendCode.Text = "Verify";
			this.buttonSendCode.UseVisualStyleBackColor = true;
			this.buttonSendCode.Visible = false;
			this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
			// 
			// panelActions
			// 
			this.panelActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelActions.Controls.Add(this.buttonGetDialogs);
			this.panelActions.Controls.Add(this.linkLabel2);
			this.panelActions.Controls.Add(this.buttonSendMsg);
			this.panelActions.Controls.Add(this.buttonGetMembers);
			this.panelActions.Controls.Add(this.buttonGetChats);
			this.panelActions.Location = new System.Drawing.Point(12, 70);
			this.panelActions.Name = "panelActions";
			this.panelActions.Size = new System.Drawing.Size(788, 42);
			this.panelActions.TabIndex = 11;
			this.panelActions.Visible = false;
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(27, 17);
			this.linkLabel2.Location = new System.Drawing.Point(533, 11);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Padding = new System.Windows.Forms.Padding(2);
			this.linkLabel2.Size = new System.Drawing.Size(273, 24);
			this.linkLabel2.TabIndex = 4;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Tag = "https://t.me/WTelegramBot?start=donate";
			this.linkLabel2.Text = "Like the library? Consider making a donation";
			this.linkLabel2.UseCompatibleTextRendering = true;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// buttonSendMsg
			// 
			this.buttonSendMsg.Location = new System.Drawing.Point(336, 3);
			this.buttonSendMsg.Name = "buttonSendMsg";
			this.buttonSendMsg.Size = new System.Drawing.Size(105, 36);
			this.buttonSendMsg.TabIndex = 3;
			this.buttonSendMsg.Text = "Send to self...";
			this.buttonSendMsg.UseVisualStyleBackColor = true;
			this.buttonSendMsg.Click += new System.EventHandler(this.buttonSendMsg_Click);
			// 
			// buttonGetMembers
			// 
			this.buttonGetMembers.Location = new System.Drawing.Point(114, 3);
			this.buttonGetMembers.Name = "buttonGetMembers";
			this.buttonGetMembers.Size = new System.Drawing.Size(105, 36);
			this.buttonGetMembers.TabIndex = 1;
			this.buttonGetMembers.Text = "Get members";
			this.buttonGetMembers.UseVisualStyleBackColor = true;
			this.buttonGetMembers.Click += new System.EventHandler(this.buttonGetMembers_Click);
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WTelegramClientTestWF.Properties.Settings.Default, "phone_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(170, 40);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(179, 22);
			this.textBoxPhone.TabIndex = 6;
			this.textBoxPhone.Text = global::WTelegramClientTestWF.Properties.Settings.Default.phone_number;
			// 
			// textBoxApiHash
			// 
			this.textBoxApiHash.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WTelegramClientTestWF.Properties.Settings.Default, "api_hash", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxApiHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApiHash.Location = new System.Drawing.Point(273, 12);
			this.textBoxApiHash.Name = "textBoxApiHash";
			this.textBoxApiHash.Size = new System.Drawing.Size(280, 22);
			this.textBoxApiHash.TabIndex = 3;
			this.textBoxApiHash.Text = global::WTelegramClientTestWF.Properties.Settings.Default.api_hash;
			// 
			// textBoxApiID
			// 
			this.textBoxApiID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WTelegramClientTestWF.Properties.Settings.Default, "api_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxApiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApiID.Location = new System.Drawing.Point(71, 12);
			this.textBoxApiID.Name = "textBoxApiID";
			this.textBoxApiID.Size = new System.Drawing.Size(100, 22);
			this.textBoxApiID.TabIndex = 1;
			this.textBoxApiID.Text = global::WTelegramClientTestWF.Properties.Settings.Default.api_id;
			// 
			// buttonGetDialogs
			// 
			this.buttonGetDialogs.Location = new System.Drawing.Point(225, 3);
			this.buttonGetDialogs.Name = "buttonGetDialogs";
			this.buttonGetDialogs.Size = new System.Drawing.Size(105, 36);
			this.buttonGetDialogs.TabIndex = 2;
			this.buttonGetDialogs.Text = "Get dialogs";
			this.buttonGetDialogs.UseVisualStyleBackColor = true;
			this.buttonGetDialogs.Click += new System.EventHandler(this.buttonGetDialogs_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 438);
			this.Controls.Add(this.panelActions);
			this.Controls.Add(this.buttonSendCode);
			this.Controls.Add(this.labelCode);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.linkLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxApiHash);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxApiID);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.buttonLogin);
			this.MinimumSize = new System.Drawing.Size(830, 300);
			this.Name = "MainForm";
			this.Text = "WTelegramClient - WinForms example";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.panelActions.ResumeLayout(false);
			this.panelActions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonGetChats;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.TextBox textBoxApiID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxApiHash;
		private System.Windows.Forms.LinkLabel linkLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelCode;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonSendCode;
		private System.Windows.Forms.Panel panelActions;
		private System.Windows.Forms.Button buttonGetMembers;
		private System.Windows.Forms.Button buttonSendMsg;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Button buttonGetDialogs;
	}
}

