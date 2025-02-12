using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClOctogon : ClPoligons
    {
        private int Mida { get; set; }

        private Point posVertex { get; set; }
        private double apotema { get; set; }

        public ClOctogon(Form xfrmMain, Point xcentre, int xmida) : base(xfrmMain, xcentre)
        {
            Mida = xmida;
            dibuixarFigura();
        }
        public ClOctogon(ClBd xbd, String xNom, int xCostat, String xColor, int xTeInterior, String xGrup) : base(xbd, xNom, xColor, xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO Octogon (Nom, Costat) VALUES('{xNom}', {xCostat})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClOctogon(Form xfrmMain, Point xcentre, Color xcolor, int xmida) : base(xfrmMain, xcentre, xcolor)
        {
            Mida = xmida;
            colorInterior = xcolor;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            int panelSize = (Mida * 2);

            apotema = calcularApotema();
            posVertex = new Point((posCentre.X - (panelSize / 2)), (posCentre.Y - (panelSize / 2)));
            pnl.Size = new Size(panelSize, panelSize);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferOctogon);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }
        private double calcularApotema()
        {

            return (Mida / 2) * Math.Sqrt(3);

        }

        private double CalculateArea(double lado)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(lado, 2);
        }

        private void ferOctogon(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
            int centerX = pnl.Width / 2; 
            int centerY = pnl.Height / 2; 
            Point[] points = new Point[8];
            for (int i = 0; i < 8; i++)
            {
                double angle = Math.PI / 4 * i; 
                double x = centerX + (int)(Mida * Math.Cos(angle));
                double y = centerY + (int)(Mida * Math.Sin(angle));
                points[i] = new Point((int)x, (int)y);
            }

            if (colorInterior != Color.Empty)
            {
                g.FillPolygon(new SolidBrush(colorInterior), points);
            }
            g.DrawPolygon(p, points);
        }
        public override Double Area()
        {
            return 2 * (1 + Math.Sqrt(2)) * Mida * Mida;
        }
        public override Double Perimetre()
        {
            return 8 * Mida;
        }
    }
}
