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
    public partial class CommandText : Form
    {
        public CommandText()
        {
            InitializeComponent();
        }

        private void CommandText_Load(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                integrated security = true; database = AdventureWorks2014;");

            // Crear el comando
            SqlCommand cmd = new SqlCommand();

            try
            {
                // Establecer la conexión
                conn.Open();

                txtCommandText.AppendText("Conexión establecida\n");
                txtCommandText.AppendText("Comando creado.\n");

                // Estableciendo el valor del comando
                cmd.CommandText = @"SELECT Name, ProductNumber
                                    FROM Production.Product";

                txtCommandText.AppendText("Listo para la ejecución del query SQL: \n\t\t" + cmd.CommandText);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalle de la excepción!");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
                txtCommandText.AppendText("\n\nConexión cerrada");
            }
        }
    }
}
