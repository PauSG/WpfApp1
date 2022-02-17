using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Message
    {
        public class TextoMessage : RequestMessage<string>{}
    }
}
