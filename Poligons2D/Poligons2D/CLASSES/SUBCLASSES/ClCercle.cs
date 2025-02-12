using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClCercle : ClPoligons
    {
        private int radi { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        private Point posVertex { get; set; }



        public ClCercle(Form xfrmMain, Point xcentre,int xradi) : base(xfrmMain, xcentre)
        {
            radi = xradi;
            Width = radi*2;
            Height = radi*2;
            dibuixarFigura();
        }

        public ClCercle(Form xfrmMain, Point xcentre, Color xcolor, int xradi) : base(xfrmMain, xcentre, xcolor)
        {
            radi = xradi;
            Width = radi * 2;
            Height = radi * 2;
            colorInterior = xcolor;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            posVertex = new Point((int)(posCentre.X - (Width / 2)), (int)(posCentre.Y - (Height / 2)));
            pnl.Size = new Size(Width, Height);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferCercle);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferCercle(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);

            Rectangle r = new Rectangle(new Point(0, 0), new Size(Width, Height));
            if (colorInterior != Color.Empty)
            {
                e.Graphics.FillEllipse(new SolidBrush(colorInterior), r);
            }
            e.Graphics.DrawEllipse(p, r);
        }
    }

}
