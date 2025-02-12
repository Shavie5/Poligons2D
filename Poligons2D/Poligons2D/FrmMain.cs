using Poligons2D.CLASSES.SUBCLASSES;
using Poligons2D.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Poligons2D.FORMULARIS;

namespace Poligons2D
{

    public partial class FrmMain : Form
    {
        FrmControlPoligon FControlPoligon = null;
        public string tipus = "";
        public string nom ="";
        
        List<ClPoligons> llPoligons { get; set; } = new List<ClPoligons>();
        ClBd clbd = null;
        String xsql = "";
        DataSet dSet { get; set; } = new DataSet();
        public FrmMain()
        {
            InitializeComponent();
            tbInfo.Multiline = true; // Habilitar la propiedad Multiline
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            clbd = new ClBd();
            resizeItems();
            inicialitzarDades();
            chk_totes.Checked = true;

        }

        #region *****************POSITIONS****************
        private void resizeItems()
        {
            this.WindowState = FormWindowState.Maximized;
            #region ********************** LABEL POLIGONS *********************************
            lbPoligons.Location = new Point(30, lbGrup.Location.Y + 50);
            lbPoligons.Size = new Size(this.Width / 2 - 50, 30);
            #endregion

            #region ********************** DataGridView POLIGONS ************************************
            dgPoligons.Location = new Point(30, lbPoligons.Height + 75);
            dgPoligons.Size = new Size(this.Width / 2 - 50, 800);
            #endregion

            #region*************************** LABEL DIBUIXOS ********************************
            lbDibuixos.Location = new Point(lbPoligons.Width + 55, lbGrup.Location.Y + 50);
            lbDibuixos.Size = new Size(this.Width / 2 - 50, 30);
            #endregion

            #region******************************** PANELL DIBUIXOS **************************************
            pnlDibuixos.Location = new Point(lbPoligons.Width + 55, lbDibuixos.Height + 75);
            pnlDibuixos.Size = new Size(this.Width / 2 - 50, 600);
            #endregion

            #region*********************************** LABEL INFO *****************************************
            lbInfo.Location = new Point(lbPoligons.Width + 55, pnlDibuixos.Height + 125);
            lbInfo.Size = new Size(this.Width / 2 - 50, 30);
            #endregion

            #region************************************** TEXTBOX INFO *****************************************
            tbInfo.Location = new Point(lbPoligons.Width + 55, lbInfo.Location.Y + 40);
            tbInfo.Size = new Size(this.Width / 2 - 50, 140);
            #endregion

            #region******************************************* ADD BUTTON **************************************
            pbAdd.Location = new Point(30, dgPoligons.Height + 130);
            #endregion

            #region*************************************** DELETE BUTTON ************************************
            pbDelete.Location = new Point(110, dgPoligons.Height + 130);
            #endregion

            #region************************************ LABEL GRUP **********************************
            lbGrup.Location = new Point(30, 20);
            #endregion

            #region********************************** COMBOBOX GRUP ******************************************
            cbGrup.Location = new Point(lbGrup.Width + 40, 25);
            #endregion
        }
        #endregion

        #region ******************SQL********************
        private void inicialitzarDades()
        {
            clbd.obrirConnexio();

            if (clbd.testConnexio())
            {
                getPoligons();
                omplirComboBox();
            }
        }
        private void getPoligons()
        {
            xsql = $"SELECT * FROM Poligon";
            clbd.getDades(xsql, dSet);
            dgPoligons.DataSource = dSet.Tables[0];
            iniGrid();

        }
        private void iniGrid()
        {
            dgPoligons.Columns[0].HeaderText = "Nom";
            dgPoligons.Columns[1].HeaderText = "Color";
            dgPoligons.Columns[2].HeaderText = "Interior"; 
            dgPoligons.Columns[3].HeaderText = "Tipus"; 
        }

        #endregion


        #region*********************ALTRESFUNCIONS****************
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void cbGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrup != null)
            {
                seleccionarPerTipus();
            }
        }

        private void chk_totes_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_totes.Checked)
            {
                cbGrup.Enabled = false;
                getPoligons();
            }
            else
            {
                cbGrup.Enabled = true;
                seleccionarPerTipus();
            }

        }

        private void omplirComboBox()
        {
                xsql = $"SELECT DISTINCT(TipusPoligon) FROM Poligon";
                clbd.getDades(xsql, dSet);
                cbGrup.DataSource = dSet.Tables[0];
                cbGrup.DisplayMember = "Tipus";
                cbGrup.ValueMember = "TipusPoligon";    
        }

        private void seleccionarPerTipus()
        {
            string tipus = cbGrup.SelectedValue.ToString();
            xsql = $"SELECT * FROM Poligon WHERE TipusPoligon = '{tipus}'";
            clbd.getDades(xsql, dSet);
            dgPoligons.DataSource = dSet.Tables[0];
            iniGrid();
        }



        private void dgPoligons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPoligons.SelectedRows.Count > 0)
            {
                mostrarDades();
            }
        }
        private void mostrarDades()
        {
            llPoligons.Clear();

            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    this.Controls.Remove(control);
                    control.Dispose(); // Libera los recursos
                }
            }

            Boolean Interior = (Boolean)dgPoligons.SelectedRows[0].Cells["TeInterior"].Value;
            string tipus = dgPoligons.SelectedRows[0].Cells["TipusPoligon"].Value.ToString();
            Color color = Color.FromName(dgPoligons.SelectedRows[0].Cells["Color"].Value.ToString());
            string nom = dgPoligons.SelectedRows[0].Cells["Nom"].Value.ToString();
            switch (tipus)
            {
                case "Quadrat":
                    dibuixarUnQuadrat(Interior, color, nom);
                    break;
                case "Cercle":
                    dibuixarUnCercle(Interior, color, nom);
                    break;
                case "TriangleRectangle":
                    dibuixarUnTriangle(Interior, color, nom,tipus);
                    break;
                case "TriangleIsosceles":
                    dibuixarUnTriangle(Interior, color, nom,tipus);
                    break;
                case "Rectangle":
                    dibuixarUnRectangle(Interior, color, nom);
                    break;
                case "Elipse":
                    dibuixarUnaElipse(Interior, color, nom);
                    break;
                case "Hexagon":
                    dibuixarUnHexagon(Interior, color, nom);
                    break;
                case "Octogon":
                    dibuixarUnOctogon(Interior, color, nom);
                    break;
                case "Pentagon":
                    dibuixarUnPentagon(Interior, color, nom);
                    break;
                case "Rombe":
                    dibuixarUnRombe(Interior, color, nom);
                    break;
            }
        }

        private void dibuixarUnTriangle(bool Interior, Color color, string nom, string tipus)
        {
            if (tipus == "TriangleRectangle")
            {
                ClTriangleRectangle poligon;
                Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
                xsql = $"SELECT Base,Alçada,Direccio FROM TriangleRectangle WHERE Nom = '{nom}'";
                clbd.getDades(xsql, dSet);
                DataRow fila = dSet.Tables[0].Rows[0];


                int Base = (Int32)fila[0];
                int Alçada = (Int32)fila[1];
                int Direccio = Convert.ToInt32(fila[2]);

                if (Interior == true)
                {
                    poligon = new ClTriangleRectangle(this, point, color, Base, Alçada, Direccio);
                    mostrarInformacio(poligon);

                    llPoligons.Add(poligon);
                }
                else
                {
                    poligon = new ClTriangleRectangle(this, point, Base, Alçada, Direccio);
                    mostrarInformacio(poligon);

                    llPoligons.Add(poligon);
                }
            }
            else
            {
                ClTriangleIsosceles poligon;
                Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
                xsql = $"SELECT Base,Alçada FROM TriangleIsosceles WHERE Nom = '{nom}'";
                clbd.getDades(xsql, dSet);
                DataRow fila = dSet.Tables[0].Rows[0];


                int Base = (Int32)fila[0];
                int Alçada = (Int32)fila[1];

                if (Interior == true)
                {
                    poligon = new ClTriangleIsosceles(this, point, color, Base, Alçada);
                    mostrarInformacio(poligon);

                    llPoligons.Add(poligon);
                }
                else
                {
                    poligon = new ClTriangleIsosceles(this, point, Base, Alçada);
                    mostrarInformacio(poligon);

                    llPoligons.Add(poligon);
                }
            }
        }

        private void dibuixarUnaElipse(bool Interior, Color color, string nom)
        {
            ClElipse poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT RadiA,RadiB FROM Elipse WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int RadiA = (Int32)fila[0];
            int RadiB = (Int32)fila[1];

            if (Interior == true)
            {
                poligon = new ClElipse(this, point, color, RadiA, RadiB);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClElipse(this, point, RadiA, RadiB);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }

        private void dibuixarUnQuadrat(Boolean Interior, Color color, String nom)
        {
            ClQuadrat poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width/2, lbDibuixos.Height + 75 + pnlDibuixos.Height/2);
            xsql = $"SELECT Mida FROM Quadrat WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int mida = (Int32)fila[0];

            if (Interior == true)
            {
                poligon = new ClQuadrat(this, point, color, mida);
                mostrarInformacio(poligon);
                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClQuadrat(this, point, mida);
                mostrarInformacio(poligon);
                llPoligons.Add(poligon);
            }

        }

        private void mostrarInformacio(ClPoligons poligon)
        {
            // Por ejemplo, mostramos el área del polígono:
            double area = poligon.Area();
            double perimetre = poligon.Perimetre();
            //MessageBox.Show("Área calculada: " + area.ToString()); // Depuración

            tbInfo.Text = "AREA: " + area.ToString("F2") + Environment.NewLine + "PERIMETRE: " + perimetre.ToString("F2");




        }
        private void dibuixarUnCercle(Boolean Interior, Color color, String nom)
        {
            ClCercle poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT Radi FROM Cercle WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int radi = (Int32)fila[0];

            if (Interior == true)
            {
                poligon = new ClCercle(this, point, color, radi);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClCercle(this, point, radi);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }
        private void dibuixarUnRectangle(Boolean Interior, Color color, String nom)
        {
            ClRectangle poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT Base, Alçada FROM Rectangle WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int Base = (Int32)fila[0];
            int Alçada = (Int32)fila[1];

            if (Interior == true)
            {
                poligon = new ClRectangle(this, point, color, Base, Alçada);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClRectangle(this, point, Base, Alçada);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }

        private void dibuixarUnHexagon(Boolean Interior, Color color, String nom)
        {
            ClHexagon poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT Costat FROM Hexagon WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int costat = (Int32)fila[0];
            

            if (Interior == true)
            {
                poligon = new ClHexagon(this, point, color, costat);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClHexagon(this, point, costat);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }
        private void dibuixarUnOctogon(Boolean Interior, Color color, String nom)
        {
            ClOctogon poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT Costat FROM Octogon WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int costat = (Int32)fila[0];


            if (Interior == true)
            {
                poligon = new ClOctogon(this, point, color, costat);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClOctogon(this, point, costat);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }
        private void dibuixarUnPentagon(Boolean Interior, Color color, String nom)
        {
            ClPentagon poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT Costat FROM Pentagon WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int costat = (Int32)fila[0];


            if (Interior == true)
            {
                poligon = new ClPentagon(this, point, color, costat);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClPentagon(this, point, costat);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }
        private void dibuixarUnRombe(Boolean Interior, Color color, String nom)
        {
            ClRombe poligon;
            Point point = new Point(lbPoligons.Width + 55 + pnlDibuixos.Width / 2, lbDibuixos.Height + 75 + pnlDibuixos.Height / 2);
            xsql = $"SELECT DiagonalA, DiagonalB FROM Rombe WHERE Nom = '{nom}'";
            clbd.getDades(xsql, dSet);
            DataRow fila = dSet.Tables[0].Rows[0];


            int diagonalA = (Int32)fila[0];
            int diagonalB = (Int32)fila[1];

            if (Interior == true)
            {
                poligon = new ClRombe(this, point, color, diagonalA, diagonalB);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
            else
            {
                poligon = new ClRombe(this, point, diagonalA, diagonalB);
                mostrarInformacio(poligon);

                llPoligons.Add(poligon);
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            FControlPoligon = new FrmControlPoligon('A', clbd);
            FControlPoligon.ShowDialog();


            if (clbd.testConnexio())
            {
                getPoligons();
                omplirComboBox();
            }

            FControlPoligon = null;
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            FControlPoligon = new FrmControlPoligon('B', clbd);
   

            FControlPoligon.tipus = dgPoligons.SelectedRows[0].Cells["TipusPoligon"].Value.ToString();
            FControlPoligon.nom = dgPoligons.SelectedRows[0].Cells["Nom"].Value.ToString();
            FControlPoligon.ShowDialog();

            if (clbd.testConnexio())
            {
                getPoligons();
                omplirComboBox();
            }

            FControlPoligon = null;
        }
    }
    
}
