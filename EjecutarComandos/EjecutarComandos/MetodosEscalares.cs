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
    public partial class MetodosEscalares : Form
    {
        public MetodosEscalares()
        {
            InitializeComponent();
        }

        private void btnTotalFilas_Click(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                integrated security = true; database = AdventureWorks2014;");

            // Crear el query scalar
            string sql = @"SELECT COUNT(*)
                           FROM Production.Product";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                txtEscalar.AppendText("Comando creado y conexión establecida\n.");
                txtEscalar.AppendText("El número de productos en Production.Product es: ");

                // Ejecutar el query scalar
                txtEscalar.AppendText(cmd.ExecuteScalar().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles del error!");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
                txtEscalar.AppendText("\nConexión cerrada.");
            }
        }
    }
}