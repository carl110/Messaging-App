using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_App
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            Text = "Messaging App - Main Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnViewMessages_Click(object sender, EventArgs e)
        {   //Hide from and open show messages
            frmShowMessages showMessages = new frmShowMessages();
            this.Hide();
            showMessages.ShowDialog();
        }
        private void btnCreateMessage_Click(object sender, EventArgs e)
        {   //Hide form and show create message
            frmCreateMessage createMessage = new frmCreateMessage();
            this.Hide();
            createMessage.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {   //Close program
            Application.Exit();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {   //Show a message box containing the help txt saved in the project file
            string helpTxt = File.ReadAllText(@"help.txt");
            MessageBox.Show(helpTxt, "Help Menu", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
