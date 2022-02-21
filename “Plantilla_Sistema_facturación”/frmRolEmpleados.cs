using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDescripcionRol, "Ingrese un valor");
            errorProvider1.SetError(txtIdRolEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtNombreRol, "Ingrese un valor");
        }

        private void lblSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
