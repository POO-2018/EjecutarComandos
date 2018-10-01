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
    public partial class ExecuteReader : Form
    {
        public ExecuteReader()
        {
            InitializeComponent();
        }

        private void ExecuteReader_Load(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                integrated security = true; database = AdventureWorks2014;");

            // Crear el query
            string sql = @"SELECT Name, ProductNumber
                           FROM Production.Product";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                // Crear el comando
                txtReader.AppendText("Comando creado.\n\n");

                // Ejecutar el query vía ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Navegar por todos los registros de Data Reader
                while (rdr.Read())
                {
                    txtReader.AppendText("\nProducto: ");
                    txtReader.AppendText(rdr.GetValue(1) + "\t\t" + rdr.GetValue(0));
                    txtReader.AppendText("\n");
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
                txtReader.AppendText("Conexión finalizada.");
            }
        }
    }
}
