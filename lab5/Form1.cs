using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        List<BaseObject> objects = new List<BaseObject>();
        Player player;
        Marker marker;

        public Form1()
        {
            InitializeComponent();
            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);
            objects.Add(player);
            objects.Add(new MyEllipse(50, 50, 0));
            objects.Add(new MyEllipse(100, 100, 45));
            marker = new Marker(0, 0, 0);
            objects.Add(marker);
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics; // вытащили объект графики из события
            g.Clear(Color.White);
            foreach (var obj in objects)
            {
                g.Transform = obj.GetTransform();
                obj.Render(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float lenght
        }
    }
}
