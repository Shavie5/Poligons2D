using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligons2D
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            resizeItems();
            
        }

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

    }
}
