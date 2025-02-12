using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClRombe : ClPoligons
    {
        private int DiagonalA { get; set; }
        private int DiagonalB { get; set; }

        private Point posVertex { get; set; }

        public ClRombe(Form xfrmMain, Point xcentre, int xdiagonalA, int xdiagonalB) : base(xfrmMain, xcentre)
        {
            DiagonalA = xdiagonalA;
            DiagonalB = xdiagonalB;
            dibuixarFigura();
        }

        public ClRombe(Form xfrmMain, Point xcentre, Color xcolor, int xdiagonalA, int xdiagonalB) : base(xfrmMain, xcentre, xcolor)
        {
            DiagonalA = xdiagonalA;
            DiagonalB = xdiagonalB;
            colorInterior = xcolor;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            posVertex = new Point((int)(posCentre.X - (DiagonalA / 2)), (int)(posCentre.Y - (DiagonalB / 2)));
            pnl.Size = new Size(DiagonalA, DiagonalB);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferRombe);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferRombe(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;

            
            int centerX = pnl.Width / 2;
            int centerY = pnl.Height/2;
            Point[] points = new Point[4];
            points[0] = new Point(centerX, centerY - (int)(DiagonalB/ 2));  // Vértice superior
            points[2] = new Point(centerX, centerY + (int)(DiagonalB / 2));  // Vértice inferior
            points[1] = new Point(centerX - (int)(DiagonalA / 2), centerY);  // Vértice izquierdo
            points[3] = new Point(centerX + (int)(DiagonalA / 2), centerY);

            if (colorInterior != Color.Empty)
            {
                g.FillPolygon(new SolidBrush(colorInterior), points);
            }
            g.DrawPolygon(p, points);
        }
    }
}
