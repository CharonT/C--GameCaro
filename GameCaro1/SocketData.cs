using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro1
{
    [Serializable]
    class SocketData
    {
        private int command;

        public int Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public Point Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        

        private Point point;
        public SocketData(int command,string message, Point point) {
            this.Command = command;
            this.Point = point;
            this.Message = message;
           
           
        }
        private string message;
        
        
    }
    public enum SocketCommand
    {
        PLAY1,
        PLAY2,
        SEND_POINT,
        SEND_MESSAGE,
        NOTIFY,
        NEW_GAME,
        END_GAME,
        END_GAME_WIN,
        END_GAME_LOST,
        TIME_OUT,
        QUIT

    }
}
