using Poligons2D.CLASSES;
using Poligons2D.CLASSES.SUBCLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Poligons2D.FORMULARIS
{
    public partial class FrmControlPoligon : Form
    {
        // Propietats
        ClBd bd { get; set; }
        public string tipus = "";
        public string nom = "";
        Char op { get; set; } = '\0';
        String grup = "Quadrat";

        public FrmControlPoligon(Char xop, ClBd xbd)
        {
            InitializeComponent();
            op = xop;
            bd = xbd;
        }

        private void pnlColorInterior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (op=='A')
            {
                switch (grup)
                {
                    case "Quadrat":
                        ClQuadrat Quadrat = new ClQuadrat(bd, tbNom.Text.Trim(), (int)nupMida.Value, cbColor.Text.Trim(), chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Cercle":
                        ClCercle Cercle = new ClCercle(bd, tbNom.Text.Trim(), (int)nupRadi.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Triangles rectangle":
                        ClTriangleRectangle TriangleRectangle = new ClTriangleRectangle(bd, tbNom.Text.Trim(), (int)nupBase.Value, (int)nupAlçada.Value, (int)nupDireccio.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Triangles isòscele":
                        ClTriangleIsosceles TriangleIsosceles = new ClTriangleIsosceles(bd, tbNom.Text.Trim(), (int)nupBase.Value, (int)nupAlçada.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Rectangle":
                        ClRectangle Rectangle = new ClRectangle(bd, tbNom.Text.Trim(), (int)nupBase.Value, (int)nupAlçada.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Elipse":
                        ClElipse Elipse = new ClElipse(bd, tbNom.Text.Trim(), (int)nupRadiA.Value, (int)nupRadiB.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Hexagon":
                        ClHexagon Hexagon = new ClHexagon(bd, tbNom.Text.Trim(), (int)nupCostat.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Octogon":
                        ClOctogon Octogon = new ClOctogon(bd, tbNom.Text.Trim(), (int)nupCostat.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Pentagon":
                        ClPentagon Pentagon = new ClPentagon(bd, tbNom.Text.Trim(), (int)nupCostat.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                    case "Rombe":
                        ClRombe Rombe = new ClRombe(bd, tbNom.Text.Trim(), (int)nupDiagonalA.Value, (int)nupDiagonalB.Value, cbColor.Text, chkInterior.Checked ? 1 : 0, grup);
                        break;
                }
            }
            else
            {
                String xsql = $"DELETE FROM {tipus} WHERE Nom = '{nom}'";
                if (bd.executarOrdre(xsql))
                {
                    MessageBox.Show($"{nom} eliminat correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No s'ha pogut inserir el {nom} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                String sql = $"DELETE FROM Poligon WHERE Nom = '{nom}'";
                if (bd.executarOrdre(sql))
                {
                    MessageBox.Show($"Poligon eliminat correctament a la base de dades", "TOT BÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No s'ha pogut inserir el {nom} a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            this.Close();
        }

        private void rdQuadrat_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                grup = ((RadioButton)sender).Text;

                switch (grup)
                {
                    case "Quadrat":
                        nupAlçada.Enabled = false;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = false;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = true;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;

                    case "Cercle":
                        nupAlçada.Enabled = false;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = false;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = true;
                        nupDireccio.Enabled = false;
                        break;

                    case "Triangles rectangle":
                        nupAlçada.Enabled = true;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = true;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = true;
                        break;

                    case "Triangles isòscele":
                        nupAlçada.Enabled = true;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = true;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;

                    case "Rectangle":
                        nupAlçada.Enabled = true;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = true;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;

                    case "Elipse":
                        nupAlçada.Enabled = false;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = false;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = true;
                        nupRadiB.Enabled = true;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;

                    case "Hexagon":
                    case "Octogon":
                    case "Pentagon":
                        nupAlçada.Enabled = false;
                        nupCostat.Enabled = true;
                        nupBase.Enabled = false;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;

                    case "Rombe":
                        nupAlçada.Enabled = false;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = false;
                        nupDiagonalA.Enabled = true;
                        nupDiagonalB.Enabled = true;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;

                    default:
                        nupAlçada.Enabled = false;
                        nupCostat.Enabled = false;
                        nupBase.Enabled = false;
                        nupDiagonalA.Enabled = false;
                        nupDiagonalB.Enabled = false;
                        nupMida.Enabled = false;
                        nupRadiA.Enabled = false;
                        nupRadiB.Enabled = false;
                        nupRadi.Enabled = false;
                        nupDireccio.Enabled = false;
                        break;
                }

            }
        }

        private void FrmControlPoligon_Load(object sender, EventArgs e)
        {
            if (op == 'A')
            {
                nupAlçada.Enabled = false;
                nupCostat.Enabled = false;
                nupBase.Enabled = false;
                nupDiagonalA.Enabled = false;
                nupDiagonalB.Enabled = false;
                nupMida.Enabled = true;
                nupRadiA.Enabled = false;
                nupRadiB.Enabled = false;
                nupRadi.Enabled = false;
                nupDireccio.Enabled = false;
            }
            else
            {
                tbNom.Enabled = false;  
                nupAlçada.Enabled = false;
                nupCostat.Enabled = false;
                nupBase.Enabled = false;
                nupDiagonalA.Enabled = false;
                nupDiagonalB.Enabled = false;
                nupMida.Enabled = false;
                nupRadiA.Enabled = false;
                nupRadiB.Enabled = false;
                nupRadi.Enabled = false;
                nupDireccio.Enabled = false;

                tbNom.Text = nom;

            }
            
        }
    }
}
