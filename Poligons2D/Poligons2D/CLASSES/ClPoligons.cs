using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D.CLASSES
{
    public abstract class ClPoligons
    {
        //Propietats:
        protected Form frmPare { get; set; }                    // Form on es dibuixarà el polígon
        protected private Panel pnl { get; set; } = new Panel(); // panell dins el qual es dibuixa el polígon
        protected Point posCentre { get; set; }                // posició del centre del Panel   
        protected Color colorInterior { get; set; }             // color de l'interior
        protected Boolean teInterior { get; set; }


        protected ClPoligons(Form xfrmMain, Point xpos)
        {
            frmPare = xfrmMain;
            colorInterior = Color.Empty;
            teInterior = false;
            posCentre = xpos;
            //iniPanell();
        }

        protected ClPoligons(Form xfrmMain, Point xpos, Color xcolor)
        {
            frmPare = xfrmMain;
            colorInterior = xcolor;
            teInterior = true;
            posCentre = xpos;
            //iniPanell();
        }
    }
}
