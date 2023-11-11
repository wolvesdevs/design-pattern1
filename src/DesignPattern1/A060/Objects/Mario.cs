using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A060.Objects
{
    public sealed class Mario : CharaBase
    {
        public Mario() : base(10, 10, Color.Red)
        {
        }

        public override string GetMessage()
        {
            return "マリオです。";
        }

        public override bool IsMessageTiming()
        {
            _count++;

            if (_count == 3)
            {
                _count = 0;
                return true;
            }

            return false;
        }

        public override void MoveRight()
        {
            base.X += 10;
        }
    }
}
