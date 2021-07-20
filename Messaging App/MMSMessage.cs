using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_App
{
    public class MMSMessage : TextMessage
    {

        private string attachmentType;
        private string attachmentTypeFile;

        public string AttachmentTypeFile { get => attachmentTypeFile; set => attachmentTypeFile = value; }
        public string AttachmentType { get => attachmentType; set => attachmentType = value; }
    }
    public enum AttachmentType
    {
        Picture,
        Audio,
        Video
    }
}
