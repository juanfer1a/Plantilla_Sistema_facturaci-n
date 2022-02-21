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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnActualizarUsuarioEmpleado_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(cxbEmpleadoUsuario, "Ingrese un valor");
            errorProvider1.SetError(txtClave, "Ingrese un valor");
            errorProvider1.SetError(txtUsuario, "Ingrese un valor");

        }


        private void lblSalirAdminUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
