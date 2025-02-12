﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES.SUBCLASSES
{
    internal class ClHexagon : ClPoligons
    {
        private int Mida { get; set; }

        private Point posVertex { get; set; }
        private double apotema {  get; set; }   

        public ClHexagon(Form xfrmMain, Point xcentre, int xmida) : base(xfrmMain, xcentre)
        {
            Mida = xmida;
            dibuixarFigura();
        }

        public ClHexagon(Form xfrmMain, Point xcentre, Color xcolor, int xmida) : base(xfrmMain, xcentre, xcolor)
        {
            Mida = xmida;
            colorInterior = xcolor;
            dibuixarFigura();
        }
        private void dibuixarFigura()
        {
            apotema = calcularApotema();
            posVertex = new Point((posCentre.X - (Mida / 2)), (posCentre.Y - (Mida / 2)));
            pnl.Size = new Size(Mida*2, Mida*2);
            pnl.Location = posVertex;
            pnl.Paint += new PaintEventHandler(ferHexagon);
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

        private void ferHexagon(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
            int centerX = pnl.Width/2; 
            int centerY = pnl.Height/2; 
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i; 
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
    }
}
