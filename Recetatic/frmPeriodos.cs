using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetatic
{
    public partial class frmPeriodos : Form
    {
        public frmPeriodos()
        {
            InitializeComponent();
        }

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            double i;
            i = Math.Round(3.6);
            MessageBox.Show(i.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
