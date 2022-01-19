using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class MyEllipse : BaseObject
    {
        public MyEllipse(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Yellow), -25, -15, 30, 30);
            g.DrawEllipse(new Pen(Color.Red, 2), -25, -15, 30, 30);
        }
    }
}
