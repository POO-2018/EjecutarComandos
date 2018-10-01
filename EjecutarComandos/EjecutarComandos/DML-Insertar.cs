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
    public partial class DML_Insertar : Form
    {
        public DML_Insertar()
        {
            InitializeComponent();
        }

        private void btnInsertarMoneda_Click(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                integrated security = true; database = AdventureWorks2014;");

            // DML Inserción
            // NO UTILIZAR porque es propenso a ataques vía SQLInjection
            /*
            string sqlIns = "INSERT INTO Sales.Currency(CurrencyCode, Name, Modified)" +
                "VALUES (" + "'" + txtCodigoMoneda.Text + "', '" + txtNombreMoneda.Text +
                "', '" + dtpFechaModificacion.Value.ToString() + "')";
            */

            string sqlIns = @"INSERT INTO Sales.Currency (CurrencyCode, Name, ModifiedDate)
                              VALUES (@code, @name, @date)";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sqlIns, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                using (cmd)
                {
                    // Reemplazar los parámetros por los valores del formulario
                    cmd.Parameters.Add("@code", SqlDbType.NChar).Value = txtCodigoMoneda.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNombreMoneda.Text;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtpFechaModificacion.Value;

                    // Ejecutar el query de inserción
                    cmd.ExecuteNonQuery();

                    // Mostrar mensaje satisfactorio al usuario
                    lblEstadoInsercion.Text = "¡Nueva moneda agregada satisfactoriamente!";
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
