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
        public ClRombe(ClBd xbd, String xNom, int xdiagonalA,int xdiagonalB, String xColor, int xTeInterior, String xGrup) : base(xbd, xNom, xColor, xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO Rombe (Nom, DiagonalA,DiagonalB) VALUES('{xNom}', {xdiagonalA}, {xdiagonalB})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public override Double Area()
        {
            return (DiagonalA * DiagonalB) / 2.0;
        }
        public override Double Perimetre()
        {
            double ladoRombo = Math.Sqrt(Math.Pow(DiagonalA, 2) + Math.Pow(DiagonalB, 2)) / 2;

            return 4 * ladoRombo;
        }
    }
}
