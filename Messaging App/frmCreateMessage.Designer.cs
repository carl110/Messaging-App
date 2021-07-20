
namespace Messaging_App
{
    partial class frmCreateMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gboMessageType = new System.Windows.Forms.GroupBox();
            this.rdoMMS = new System.Windows.Forms.RadioButton();
            this.rdoSMS = new System.Windows.Forms.RadioButton();
            this.gboMultimediaType = new System.Windows.Forms.GroupBox();
            this.rdoPicture = new System.Windows.Forms.RadioButton();
            this.rdoAudio = new System.Windows.Forms.RadioButton();
            this.rdoVideo = new System.Windows.Forms.RadioButton();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkGroupMessage = new System.Windows.Forms.CheckBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboMessageType.SuspendLayout();
            this.gboMultimediaType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recipient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "MultiMessage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Message";
            // 
            // gboMessageType
            // 
            this.gboMessageType.Controls.Add(this.rdoMMS);
            this.gboMessageType.Controls.Add(this.rdoSMS);
            this.gboMessageType.Location = new System.Drawing.Point(617, 48);
            this.gboMessageType.Name = "gboMessageType";
            this.gboMessageType.Size = new System.Drawing.Size(157, 105);
            this.gboMessageType.TabIndex = 5;
            this.gboMessageType.TabStop = false;
            this.gboMessageType.Text = "Type of Message";
            // 
            // rdoMMS
            // 
            this.rdoMMS.AutoSize = true;
            this.rdoMMS.Location = new System.Drawing.Point(15, 66);
            this.rdoMMS.Name = "rdoMMS";
            this.rdoMMS.Size = new System.Drawing.Size(71, 24);
            this.rdoMMS.TabIndex = 1;
            this.rdoMMS.Text = "MMS";
            this.rdoMMS.UseVisualStyleBackColor = true;
            this.rdoMMS.CheckedChanged += new System.EventHandler(this.rdoMMS_CheckedChanged);
            // 
            // rdoSMS
            // 
            this.rdoSMS.AutoSize = true;
            this.rdoSMS.Checked = true;
            this.rdoSMS.Location = new System.Drawing.Point(15, 26);
            this.rdoSMS.Name = "rdoSMS";
            this.rdoSMS.Size = new System.Drawing.Size(69, 24);
            this.rdoSMS.TabIndex = 0;
            this.rdoSMS.TabStop = true;
            this.rdoSMS.Text = "SMS";
            this.rdoSMS.UseVisualStyleBackColor = true;
            this.rdoSMS.CheckedChanged += new System.EventHandler(this.rdoSMS_CheckedChanged);
            // 
            // gboMultimediaType
            // 
            this.gboMultimediaType.Controls.Add(this.rdoPicture);
            this.gboMultimediaType.Controls.Add(this.rdoAudio);
            this.gboMultimediaType.Controls.Add(this.rdoVideo);
            this.gboMultimediaType.Location = new System.Drawing.Point(160, 355);
            this.gboMultimediaType.Name = "gboMultimediaType";
            this.gboMultimediaType.Size = new System.Drawing.Size(458, 61);
            this.gboMultimediaType.TabIndex = 6;
            this.gboMultimediaType.TabStop = false;
            this.gboMultimediaType.Text = "MultiMedia Type";
            // 
            // rdoPicture
            // 
            this.rdoPicture.AutoSize = true;
            this.rdoPicture.Location = new System.Drawing.Point(311, 25);
            this.rdoPicture.Name = "rdoPicture";
            this.rdoPicture.Size = new System.Drawing.Size(83, 24);
            this.rdoPicture.TabIndex = 3;
            this.rdoPicture.TabStop = true;
            this.rdoPicture.Text = "Picture";
            this.rdoPicture.UseVisualStyleBackColor = true;
            // 
            // rdoAudio
            // 
            this.rdoAudio.AutoSize = true;
            this.rdoAudio.Location = new System.Drawing.Point(158, 25);
            this.rdoAudio.Name = "rdoAudio";
            this.rdoAudio.Size = new System.Drawing.Size(75, 24);
            this.rdoAudio.TabIndex = 2;
            this.rdoAudio.TabStop = true;
            this.rdoAudio.Text = "Audio";
            this.rdoAudio.UseVisualStyleBackColor = true;
            // 
            // rdoVideo
            // 
            this.rdoVideo.AutoSize = true;
            this.rdoVideo.Location = new System.Drawing.Point(6, 25);
            this.rdoVideo.Name = "rdoVideo";
            this.rdoVideo.Size = new System.Drawing.Size(75, 24);
            this.rdoVideo.TabIndex = 1;
            this.rdoVideo.TabStop = true;
            this.rdoVideo.Text = "Video";
            this.rdoVideo.UseVisualStyleBackColor = true;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(160, 80);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(239, 26);
            this.txtSender.TabIndex = 0;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(160, 120);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(239, 26);
            this.txtRecipient.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(160, 235);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(539, 114);
            this.txtMessage.TabIndex = 4;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Sent",
            "Recieved"});
            this.cboStatus.Location = new System.Drawing.Point(160, 160);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(239, 28);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Text = "Sent";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(637, 362);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 60);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkGroupMessage
            // 
            this.chkGroupMessage.AutoSize = true;
            this.chkGroupMessage.Location = new System.Drawing.Point(160, 200);
            this.chkGroupMessage.Name = "chkGroupMessage";
            this.chkGroupMessage.Size = new System.Drawing.Size(22, 21);
            this.chkGroupMessage.TabIndex = 3;
            this.chkGroupMessage.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(40, 445);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(126, 30);
            this.lblFileName.TabIndex = 14;
            this.lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(160, 445);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(239, 26);
            this.txtFileName.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(637, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 60);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 499);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.chkGroupMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.gboMultimediaType);
            this.Controls.Add(this.gboMessageType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateMessage";
            this.Text = "CreateMessage";
            this.gboMessageType.ResumeLayout(false);
            this.gboMessageType.PerformLayout();
            this.gboMultimediaType.ResumeLayout(false);
            this.gboMultimediaType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gboMessageType;
        private System.Windows.Forms.RadioButton rdoMMS;
        private System.Windows.Forms.RadioButton rdoSMS;
        private System.Windows.Forms.GroupBox gboMultimediaType;
        private System.Windows.Forms.RadioButton rdoPicture;
        private System.Windows.Forms.RadioButton rdoAudio;
        private System.Windows.Forms.RadioButton rdoVideo;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkGroupMessage;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnCancel;
    }
}