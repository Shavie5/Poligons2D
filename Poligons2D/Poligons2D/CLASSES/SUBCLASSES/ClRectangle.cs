using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClRectangle : ClPoligons
    {
        private int Base { get; set; }
        private int Alçada { get; set; }

        private Point posVertex { get; set; }

        public ClRectangle(Form xfrmMain, Point xcentre, int xbase, int xalçada) : base(xfrmMain, xcentre)
        {
            Base = xbase;
            Alçada = xalçada;
            dibuixarFigura();
        }

        public ClRectangle(Form xfrmMain, Point xcentre, Color xcolor, int xbase, int xalçada) : base(xfrmMain, xcentre, xcolor)
        {
            Base = xbase;
            Alçada = xalçada;
            colorInterior = xcolor;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            posVertex = new Point((int)(posCentre.X - (Base / 2)), (int)(posCentre.Y - (Alçada / 2)));
            pnl.Size = new Size(Base, Alçada);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferQuadrat);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferQuadrat(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);   // Pen per a traçar el contorn que farem de color negre i de 2 pixels de gruix

            //Ho declaro amb el system.drawing perquè sinó entra amb conflicte amb la taula Rectangle de la base de dades.

            System.Drawing.Rectangle r = new System.Drawing.Rectangle(new Point(0, 0), new Size(Base, Alçada));

            if (colorInterior != Color.Empty)
            {
                e.Graphics.FillRectangle(new SolidBrush(colorInterior), r);
            }
            e.Graphics.DrawRectangle(p, r);
        }
    }
}

