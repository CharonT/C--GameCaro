using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro1
{
   
    public class Player
    {
        private String name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Image Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
            }
        }

        private Image mark;
        public Player(String name, Image mark) {
            this.Name = name;
            this.Mark = mark;
        }
        public Player() { }
  
    }
}
