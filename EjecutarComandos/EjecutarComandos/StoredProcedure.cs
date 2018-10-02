using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Ejecutar_comandos
{
    public partial class StoredProcedure : Form
    {
        // Crear la conexión
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
            integrated security = true; database = AdventureWorks2014;");

        public StoredProcedure()
        {
            InitializeComponent();
        }

        private void btnCargarMonedas_Click(object sender, EventArgs e)
        {
            // Crear el query
            string sqlSelect = @"SELECT CurrencyCode
                                 FROM Sales.Currency";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                // Ejecutar el query vía un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    lstCodigoMoneda.Items.Add(rdr[0]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}
