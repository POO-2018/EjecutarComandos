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

            }
            catch (SqlException ex)
            {
                
            }
        }
    }
}
