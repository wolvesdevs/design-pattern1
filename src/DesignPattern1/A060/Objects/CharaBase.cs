using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A060.Objects
{
    public abstract class CharaBase
    {
        protected int _count = 0;

        public CharaBase(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; }

        public abstract void MoveRight();
        public abstract bool IsMessageTiming();
        public abstract string GetMessage();
    }
}
