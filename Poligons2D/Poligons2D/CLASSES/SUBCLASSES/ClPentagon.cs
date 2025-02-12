using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClPentagon : ClPoligons
    {
        private int Costat { get; set; }

        private Point posVertex { get; set; }
        private double apotema { get; set; }

        public ClPentagon(Form xfrmMain, Point xcentre, int xcostat) : base(xfrmMain, xcentre)
        {
            Costat = xcostat;
            dibuixarFigura();
        }
        public ClPentagon(ClBd xbd, String xNom, int xCostat, String xColor, int xTeInterior, String xGrup) : base(xbd, xNom, xColor, xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO Pentagon (Nom, Costat) VALUES('{xNom}', {xCostat})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClPentagon(Form xfrmMain, Point xcentre, Color xcolor, int xcostat) : base(xfrmMain, xcentre, xcolor)
        {
            Costat = xcostat;
            colorInterior = xcolor;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            int panelSize = (Costat * 2); 

            apotema = calcularApotema();
            posVertex = new Point((posCentre.X - (panelSize / 2)), (posCentre.Y - (panelSize / 2)));
            pnl.Size = new Size(panelSize, panelSize);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferPentagon);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }
        private double calcularApotema()
        {

            return (Costat / 2) * Math.Sqrt(3);

        }

        private double CalculateArea(double lado)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(lado, 2);
        }

        private void ferPentagon(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
            int centerX = pnl.Width / 2; 
            int centerY = pnl.Height / 2;
            Point[] points = new Point[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = -Math.PI / 2 + (Math.PI * 2 / 5) * i;
                double x = centerX + (int)(Costat * Math.Cos(angle));
                double y = centerY + (int)(Costat * Math.Sin(angle));
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
            return (1.0 / 4.0) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Costat * Costat;
        }
        public override Double Perimetre()
        {
            return 5 * Costat;
        }
    }
}
