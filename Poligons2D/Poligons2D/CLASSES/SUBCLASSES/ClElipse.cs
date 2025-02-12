using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClElipse : ClPoligons
    {
        private int RadiA { get; set; }
        private int RadiB { get; set; }
        private Point posVertex { get; set; }
        public ClElipse(Form xfrmMain, Point xcentre, int xRadiA, int xRadiB) : base(xfrmMain, xcentre)
        {
            RadiA = xRadiA;
            RadiB = xRadiB;
            dibuixarFigura();
        }

        public ClElipse(ClBd xbd, String xNom, int xRadiA, int xRadiB, String xColor, int xTeInterior, String xGrup) : base(xbd, xNom, xColor, xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO Elipse (Nom, RadiA,RadiB) VALUES('{xNom}', {xRadiA},{xRadiB})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClElipse(Form xfrmMain, Point xcentre, Color xcolor, int xRadiA, int xRadiB) : base(xfrmMain, xcentre, xcolor)
        {
            RadiA = xRadiA;
            RadiB = xRadiB;
            colorInterior = xcolor;
            dibuixarFigura();
        }

        private void dibuixarFigura()
        {
            posVertex = new Point(posCentre.X - RadiA, posCentre.Y - RadiB);
            pnl.Size = new Size(RadiA * 2, RadiB * 2);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferElipse);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferElipse(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);

            if (colorInterior != Color.Empty)
            {
                g.FillEllipse(new SolidBrush(colorInterior), rect);
            }
            g.DrawEllipse(p, rect);
        }

        public override Double Area()
        {
            return Math.PI * RadiA * RadiB;
        }

        public override Double Perimetre()
        {
            // Aproximación de Ramanujan para el perímetro de una elipse
            double h = Math.Pow((RadiA - RadiB), 2) / Math.Pow((RadiA + RadiB), 2);
            return Math.PI * (RadiA + RadiB) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }


    }
}
