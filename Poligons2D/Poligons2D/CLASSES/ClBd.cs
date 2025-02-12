using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Poligons2D.CLASSES
{
    public class ClBd
    {
        //sintaxis => Data Source=DESKTOP-M1DO2MK;Initial Catalog=Poligons2D;Integrated Security=True

        //public String cadenaConnexio = @"Data Source=DESKTOP-M1DO2MK;Initial Catalog=Poligons2D;Integrated Security=True";
        public String cadenaConnexio = @"Data Source=YASINELED\SQLEXPRESS;Initial Catalog=Poligons2D;Integrated Security=True";


        SqlConnection dbConnexio { get; set; }        // Permet establir la connexió amb SQL Server
        SqlDataAdapter dbAdaptador { get; set; }      // El DataAdapter és l'intermediari que executarà les instruccions SQL a la base de dades  


        // NO HI HA CONSTRUCTOR PERÒ CALDRÀ HAVER POSAT LA CADENA DE CONNEXIÓ A LA PROPIETAT PÚBLICA CORRESPONENT

        #region --- MÈTODES PÚBLICS DE LA CLASSE ---
        public Boolean testConnexio()
        {
            // comprovem si tenim connexió amb la BD
            Boolean xb = false;

            if (cadenaConnexio == "null")
            {
                MessageBox.Show("No s'ha introduït cadena de connexió", "ERROR - testConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((dbConnexio == null) || (dbConnexio.State != ConnectionState.Open))
                {
                    try
                    {
                        dbConnexio = new SqlConnection(cadenaConnexio);
                        xb = obrirConnexio();
                    }
                    catch (Exception excp)
                    {
                        MessageBox.Show(excp.Message, "Excepció - testConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    xb = true;
                }
            }
            return xb;
        }
        public Boolean executarOrdre(String xsql)
        {
            Boolean xb = false;
            SqlCommand xcommand = new SqlCommand(xsql, dbConnexio);

            try
            {
                xcommand.ExecuteNonQuery();
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - ferOperacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return xb;
        }
        public Boolean obrirConnexio()
        {
            Boolean xb = false;

            try
            {
                if (dbConnexio != null)
                {
                    dbConnexio.Open();
                    xb = (dbConnexio.State == ConnectionState.Open);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - obrirConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return xb;
        }

        public Boolean hihaConnexio()
        {
            return (dbConnexio != null && dbConnexio.State == ConnectionState.Open);
        }

        public SqlConnection getConnexio()
        {
            return dbConnexio;
        }

        public Boolean getDades(String xsql, DataSet xdset)
        {
            Boolean xb = false;

            try
            {
                dbAdaptador = new SqlDataAdapter(xsql, dbConnexio);
                xdset.Tables.Clear();
                dbAdaptador.Fill(xdset);
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - getDades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return xb;
        }

        public void tancarConnexio()
        {
            dbConnexio.Close();
        }
        #endregion

    }
}
