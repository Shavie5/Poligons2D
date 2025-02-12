using System;
using System.Collections.Generic;
using System.Data;
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
        public string Name { get; set; }

        protected Form frmPare { get; set; }                    // Form on es dibuixarà el polígon
        protected private Panel pnl { get; set; } = new Panel(); // panell dins el qual es dibuixa el polígon
        protected Point posCentre { get; set; }                // posició del centre del Panel   
        protected Color colorInterior { get; set; }             // color de l'interior
        protected Boolean teInterior { get; set; }

        public ClPoligons(ClBd xbd, String xNom, String xColor, int xTeInterior, String xGrup)
        {

            DataSet xdset = new DataSet();
            
String xsql = $"INSERT INTO Poligon(Nom, Color, TeInterior, TipusPoligon) VALUES('{xNom}', '{xColor}', {xTeInterior}, '{xGrup}')";

            if (xbd.executarOrdre(xsql))
            {
                // Recuperar el nombre del último registro insertado
                xsql = $"SELECT Nom FROM Poligon WHERE Nom = '{xNom}'";
                xbd.getDades(xsql, xdset);
                if (xdset.Tables[0].Rows.Count == 0)
                {
                    Name = "";
                    MessageBox.Show("No s'ha pogut recuperar el nom del nou Poligon", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Name = xdset.Tables[0].Rows[0]["Nom"].ToString().Trim();
                }
            }
        }
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

        public abstract Double Area();      // retorna l'àrea de la figura mesurada en "pixels quadrats"
        public abstract Double Perimetre();      


    }
}
