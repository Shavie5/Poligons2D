using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClTriangleIsosceles : ClPoligons
    {
        private int Base { get; set; }
        private int Alçada { get; set; }
        private Point posVertex { get; set; }

        public ClTriangleIsosceles(Form xfrmMain, Point xcentre, int xBase, int xAlçada) : base(xfrmMain, xcentre)
        {
            Base = xBase;
            Alçada = xAlçada;
            dibuixarFigura();
        }
        public ClTriangleIsosceles(ClBd xbd, String xNom, int xBase, int xAlçada, String xColor, int xTeInterior, String xGrup) : base(xbd, xNom, xColor, xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO TriangleIsosceles (Nom, Base,Alçada) VALUES('{xNom}', {xBase},{xAlçada})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public ClTriangleIsosceles(Form xfrmMain, Point xcentre, Color xcolor, int xBase, int xAlçada) : base(xfrmMain, xcentre, xcolor)
        {
            Base = xBase;
            Alçada = xAlçada;
            dibuixarFigura();
        }

        private void dibuixarFigura()
        {
            posVertex = new Point(posCentre.X - (Base / 2), posCentre.Y - (Alçada / 2));
            pnl.Size = new Size(Base, Alçada);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferTriangle);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferTriangle(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;

            Point[] points = new Point[3];
            points[0] = new Point(Base / 2, 0);  // Vértice superior
            points[1] = new Point(0, Alçada);    // Vértice inferior izquierdo
            points[2] = new Point(Base, Alçada); // Vértice inferior derecho

            if (colorInterior != Color.Empty)
            {
                g.FillPolygon(new SolidBrush(colorInterior), points);
            }
            g.DrawPolygon(p, points);
        }

        public override Double Area()
        {
            return (Base * Alçada) / 2.0;
        }

        public override Double Perimetre()
        {
            double lado = Math.Sqrt(Math.Pow(Base / 2.0, 2) + Math.Pow(Alçada, 2));
            return (2 * lado) + Base;
        }
    }

}
