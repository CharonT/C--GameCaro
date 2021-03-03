using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro1
{
   public class PlayInfo
    {
        private Point point;

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

       

        private int currentPlayer;
        public PlayInfo(Point point) {
            this.Point = point;
           
        }
    }
}
