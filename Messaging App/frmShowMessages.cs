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
    public partial class frmShowMessages : Form
    {
        public frmShowMessages()
        {
            InitializeComponent();
            showMessages();
            Text = "Messaging App - Show Messages";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void showMessages()
        {
            lstMessages.Items.Clear();
            foreach (var item in TextMessageList.messagesList)
            {   //Set textType as SMS
                string textType = "SMS";
                if (item.AttachmentTypeFile.Length > 0)
                {   //if there is a string in file name then message is MMS
                    textType = "MMS";
                } //add data to listboc from global list
                lstMessages.Items.Add($"{textType}\t Sender: {item.Sender}\t Recipient: {item.Recipient}\t Statsus: {item.StatusRecieved}\t");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {   
            try
            {   //if message highlighted then delete that from global list
                TextMessageList.messagesList.RemoveAt(lstMessages.SelectedIndex);
            } catch (Exception)
            {   //if no message selected then show error message
                MessageBox.Show("You must select a message to Delete", "No Message Selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } //Reload data on list box
            showMessages();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {   //Close form and open main menu
            frmMainMenu mainMenu = new frmMainMenu();
            this.Dispose();
            mainMenu.Show();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {   //if button text is Read
            if ((sender as Button).Text == "&Read")
            {
                try
                {   //For selected message show all elements in the listbox view
                    int index = lstMessages.SelectedIndex;
                    lstMessages.Items.Clear();

                    lstMessages.Items.Add("Sender\t\t\t" + TextMessageList.messagesList[index].Sender);
                    lstMessages.Items.Add("Recipient\t\t\t" + TextMessageList.messagesList[index].Recipient);
                    lstMessages.Items.Add("Message\t\t\t" + TextMessageList.messagesList[index].TextContent);
                    lstMessages.Items.Add("Group of Msg's\t\t" + TextMessageList.messagesList[index].GroupMessage);
                    lstMessages.Items.Add("Status\t\t\t" + TextMessageList.messagesList[index].StatusRecieved);
                    if (TextMessageList.messagesList[index].AttachmentTypeFile.Length > 0)
                    {   //only show multimedia data if MMS
                        lstMessages.Items.Add("Media Type\t\t" + TextMessageList.messagesList[index].AttachmentType);
                        lstMessages.Items.Add("File Name\t\t" + TextMessageList.messagesList[index].AttachmentTypeFile);
                    } //Change button text to Back
                    (sender as Button).Text = "&Back";
                    //Hide Delete Button
                    btnDelete.Visible = false;
                } catch (Exception ex){ //If no message selected show error message
                    MessageBox.Show("You must select a message to read\n ", "No Message Selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    showMessages();
                }
                } else //if message text is back
            {   //Reload data for listbox
                showMessages();
                //Change button text to Read
                (sender as Button).Text = "&Read";
                //set delete button to visable
                btnDelete.Visible = true;
            }
        }
    }
}
