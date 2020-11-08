using Recetatic.Clases;
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

namespace Recetatic
{
    public partial class frmPeriodos : Form

        
    {
        public string consulta = "SELECT * FROM Perioricidad";

        public frmPeriodos()
        {
            InitializeComponent();
        }

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            
            try
            {
                mostrarDatos(consulta);
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BasesDeDatos.Desconexion();
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
           string cadenaInsertar = "INSERT INTO Perioricidad (Codigo, Descripcion) values ('" + txtCodigo.Text +
                "','" + txtPeriodo.Text + "')";
            try
            {
                SqlCommand comandoInsercion = new SqlCommand(cadenaInsertar, BasesDeDatos.con);
                comandoInsercion.ExecuteNonQuery();
                txtCodigo.Text = "";
                txtPeriodo.Text = "";
                BasesDeDatos.Desconexion();
                mostrarDatos(consulta);
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void mostrarDatos(string consulta)
        {
            BasesDeDatos.Conexion();
            SqlCommand comandoConsultaPeriodos = new SqlCommand(consulta, BasesDeDatos.con);
            SqlDataAdapter adaptadorPeriodos = new SqlDataAdapter(comandoConsultaPeriodos);
            DataTable datosPeriodos = new DataTable();
            adaptadorPeriodos.Fill(datosPeriodos);

            dgvPeriodos.DataSource = datosPeriodos;
        }

    }
}
