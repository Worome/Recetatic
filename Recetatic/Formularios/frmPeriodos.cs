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
                dgvPeriodos.DataSource = BasesDeDatos.mostrarPeriodos(consulta);
               
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
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("El código debe estar relleno");
                txtCodigo.Focus();
            } else
            {
    
                try
                {
                    BasesDeDatos.insertarPeriodo(txtCodigo.Text, txtPeriodo.Text);

                    txtCodigo.Text = "";
                    txtPeriodo.Text = "";
                    BasesDeDatos.Desconexion();
                    dgvPeriodos.DataSource = BasesDeDatos.mostrarPeriodos(consulta);
                    
                    txtCodigo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
                }
            }
        }
    }
}
