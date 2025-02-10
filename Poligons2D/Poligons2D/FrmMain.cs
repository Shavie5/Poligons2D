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

namespace Poligons2D
{
    public partial class FrmMain : Form
    {
        private Poligons2DEntities2 poligonsContext { get; set; } = new Poligons2DEntities2();       // necessitem una instància del Context

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chk_totes.Checked = false;
            resizeItems();
            testConnexio();
            getPoligons();
            omplirComboBox();
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
        private Boolean testConnexio()
        {
            Boolean xb = false;

            Cursor = Cursors.WaitCursor;
            try
            {
                xb = (poligonsContext.Database.Connection.State == ConnectionState.Open);
                if (!xb)
                {
                    poligonsContext.Database.Connection.Open();
                    xb = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
            return xb;
        }
        private void getPoligons()
        {
            Cursor = Cursors.WaitCursor;
            var qryPoligons = (from p in poligonsContext.Poligon
                                 orderby p.Id
                                 select new
                                 {
                                     Id = p.Id,
                                     Area = p.Area,
                                     Color = p.Color,
                                     Interior = p.TeInterior,
                                     Tipus = p.TipusPoligon

                                 });

            dgPoligons.DataSource = qryPoligons.ToList();

          

            Cursor = Cursors.Default;
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
           if(cbGrup != null)
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
            if (dgPoligons.SelectedRows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                var qryCmbPoligon = (from p in poligonsContext.Poligon
                                     orderby p.TipusPoligon
                                     select p.TipusPoligon);

                cbGrup.DataSource = qryCmbPoligon.ToList().Distinct().ToList(); ;
                Cursor = Cursors.Default;

            }
        }

        private void seleccionarPerTipus()
        {
            var qrySeleccionarTipus = (from p in poligonsContext.Poligon
                                       orderby p.Id
                                       where p.TipusPoligon == cbGrup.SelectedValue.ToString()
                                       select new
                                       {
                                           Id = p.Id,
                                           Area = p.Area,
                                           Color = p.Color,
                                           Interior = p.TeInterior,
                                           Tipus = p.TipusPoligon
                                       });
            dgPoligons.DataSource = qrySeleccionarTipus.ToList();
            Cursor = Cursors.Default;
        }
    }
}
