using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligons2D.CLASSES;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClQuadrat : ClPoligons
    {
        private int Mida {  get; set; }

        private Point posVertex {  get; set; }

        public ClQuadrat(Form xfrmMain, Point xcentre, int xmida) : base(xfrmMain, xcentre)
        {
            Mida = xmida;
            dibuixarFigura();
        }
        public ClQuadrat(ClBd xbd, String xNom,int xmida, String xColor, int xTeInterior, String xGrup): base(xbd, xNom,xColor,xTeInterior, xGrup)
        {
            String xsql = $"INSERT INTO Quadrat (Nom, Mida) VALUES('{xNom}', {xmida})";
            if (xbd.executarOrdre(xsql))
            {
                MessageBox.Show($"Poligon inserit correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No s'ha pogut inserir el {xGrup} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClQuadrat(Form xfrmMain, Point xcentre, Color xcolor, int xmida) : base(xfrmMain, xcentre, xcolor)
        {
            Mida = xmida;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            posVertex = new Point((posCentre.X - (Mida / 2)), (posCentre.Y - (Mida / 2)));
            pnl.Size = new Size(Mida, Mida);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferQuadrat);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferQuadrat(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);   // Pen per a traçar el contorn que farem de color negre i de 2 pixels de gruix

            //Ho declaro amb el system.drawing perquè sinó entra amb conflicte amb la taula Rectangle de la base de dades.
            
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(new Point(0, 0), new Size(Mida, Mida));

            if (colorInterior != Color.Empty)
            {
                e.Graphics.FillRectangle(new SolidBrush(colorInterior), r);
            }
            e.Graphics.DrawRectangle(p, r);
        }
        public override Double Area()
        {
            return (Mida * Mida);
        }
        public override Double Perimetre()
        {
            return 4 * Mida;
        }
    }
}
