using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Player : BaseObject
    {
        public Player(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.DeepSkyBlue),//кружочек с синим фоном
                -15, -15,
                30, 30
                );
            g.DrawEllipse(
                new Pen(Color.Black, 2),//рамка кружочка
                -15, -15,
                30, 30);
            g.DrawLine(new Pen(Color.Black, 2), 0, 0, 25, 0); //указатель, направленный на игрока
        }
    }
}
