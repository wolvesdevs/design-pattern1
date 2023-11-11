using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A060.Objects
{
    public sealed class Luigi : CharaBase
    {
        public Luigi() : base(10, 50, Color.Lime)
        {
        }

        public override string GetMessage()
        {
            return "ルイージです。";
        }

        public override bool IsMessageTiming()
        {
            _count++;

            if (_count == 5)
            {
                _count = 0;
                return true;
            }

            return false;
        }

        public override void MoveRight()
        {
            base.X += 20;
        }
    }
}
