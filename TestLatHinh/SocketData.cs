using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLatHinh
{
    [Serializable]
    public class SocketData
    {
        private int command;

        public int Command
        {
            get { return command; }
            set { command = value; }
        }

        public ListCard listcard;
  

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public SocketData(int command, string message, ListCard _listcard)
        {
            this.Command = command;
            this.listcard = _listcard;
            this.Message = message;
        }
    }

    public enum SocketCommand
    {
        SEND_LISTCARD,
        NOTIFY,
        NEW_GAME,
        START_PLAY,
        WIN,
        END_GAME,
        QUIT
    }
}