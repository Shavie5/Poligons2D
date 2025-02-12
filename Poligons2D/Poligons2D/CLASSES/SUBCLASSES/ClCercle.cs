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
        public ClCercle(ClBd xbd, String xNom, int xRadi, String xColor, int xTeInterior, String xGrup) : base(xbd, xNom, xColor, xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO Cercle (Nom, Radi) VALUES('{xNom}', {xRadi})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClCercle(Form xfrmMain, Point xcentre, Color xcolor, int xradi) : base(xfrmMain, xcentre, xcolor)
        {
            radi = xradi;
            Width = radi * 2;
            Height = radi * 2;
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
        public override Double Area()
        {
            return Math.PI * radi * radi;
        }
        public override Double Perimetre()
        {
            return 2 * Math.PI * radi;
        }
    }

}
