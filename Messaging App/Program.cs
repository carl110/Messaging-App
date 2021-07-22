using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                MMSMessage message = new MMSMessage();
                message.Sender = "John" + i;
                message.Recipient = "Ian" + i;
                message.GroupMessage = false;
                message.StatusRecieved = "Recieved";
                message.TextContent = "This is the "+i+" Message";
                message.AttachmentType = "Picture";
                message.AttachmentTypeFile = "NewPic.jpeg";
                TextMessageList.messagesList.Add(message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
