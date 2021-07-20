using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_App
{
    public partial class frmCreateMessage : Form
    {
        public frmCreateMessage()
        {
            InitializeComponent();
            Text = "Messaging App - New Message";
            this.StartPosition = FormStartPosition.CenterScreen;
            //Hide MMS specific entry
            gboMultimediaType.Visible = false;
            lblFileName.Visible = false;
            txtFileName.Visible = false;
        }
        private bool checkNotEmpty()
        {   //Check each txtfield if empty
            if (txtSender.TextLength == 0)
            {
                MessageBox.Show("You must enter sender details", "Sender Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (txtRecipient.TextLength == 0)
            {
                MessageBox.Show("You must enter recipient details", "Recipient Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (txtMessage.TextLength == 0)
            {
                MessageBox.Show("You must enter a messages", "Message Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            } //check if MMS radio buttons are empty only if MMS selected
            if (rdoMMS.Checked && rdoAudio.Checked == false && rdoPicture.Checked == false && rdoVideo.Checked == false)
            {
                MessageBox.Show("You select a multi-media type for MMS", "MultiMedia Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (rdoMMS.Checked && txtFileName.TextLength == 0)
            {
                MessageBox.Show("You must a file name for the multimedia type", "File Name Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }
        private void rdoSMS_CheckedChanged(object sender, EventArgs e)
        {   //If SMS selected hide MMS specific items
            if ((sender as RadioButton).Checked)
            {
                gboMultimediaType.Visible = false;
                lblFileName.Visible = false;
                txtFileName.Visible = false;
            }
        }
        private void rdoMMS_CheckedChanged(object sender, EventArgs e)
        {   //if MMS Selected show MMS specific items
            if ((sender as RadioButton).Checked)
            {
                gboMultimediaType.Visible = true;
                lblFileName.Visible = true;
                txtFileName.Visible = true;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {   //Create string for multimedia type and set name depending on radio button selected
            string multiMediaType = "";
            if (rdoAudio.Checked)
            {
                multiMediaType = AttachmentType.Audio.ToString();
            }
            else if (rdoPicture.Checked)
            {
                multiMediaType = AttachmentType.Picture.ToString();
            }
            else if (rdoVideo.Checked)
            {
                multiMediaType = AttachmentType.Video.ToString();
            }
            //Check all required fields have data
            if (checkNotEmpty())
            {   //Add new message to global list
                MMSMessage newMMS = new MMSMessage();
                newMMS.Sender = txtSender.Text;
                newMMS.Recipient = txtRecipient.Text;
                newMMS.GroupMessage = chkGroupMessage.Checked;
                newMMS.StatusRecieved = cboStatus.GetItemText(cboStatus.SelectedItem);
                newMMS.TextContent = txtMessage.Text;
                newMMS.AttachmentType = multiMediaType;
                newMMS.AttachmentTypeFile = txtFileName.Text;
                TextMessageList.messagesList.Add(newMMS);
                //Close thes form and go back to main menu
                frmMainMenu mainMenu = new frmMainMenu();
                this.Dispose();
                mainMenu.Show();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {   //Go back to main menu without adding a new message
            frmMainMenu mainMenu = new frmMainMenu();
            this.Dispose();
            mainMenu.Show();
        }
    }
}
