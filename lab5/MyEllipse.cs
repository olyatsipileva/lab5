using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class MyEllipse : BaseObject
    {

        public MyEllipse(float x, float y, float angle, float size) : base(x, y, angle, size)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.LightGreen), -Size / 2, -Size / 2, Size, Size);
            //g.DrawEllipse(new Pen(Color.LightGreen, 2), -15, -15, 30, 30);
            Size -= 0.1f;
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-Size / 2, -Size / 2, Size, Size);
            return path;
        }
    }
}
