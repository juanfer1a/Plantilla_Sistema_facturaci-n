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
        public int IdRol { get; set; }
        public frmRolEmpleados()
        {
            InitializeComponent();
        }
        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            if (IdRol == 0)
            {//Registro nuevo rol
                lblRolEmpleados.Text = "NUEVO ROL";
            }
            else
            {//Actulizar rol
                lblRolEmpleados.Text = "MODIFICAR ROL";
                txbDescripcionRol.Text = "DESCRIPCION ROL";
                txtNombreRol.Text = "NOMBRE ROL";
                txbIdRolEmpleado.Text = "ID";
            }

        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txbDescripcionRol, "Ingrese un valor");
            errorProvider1.SetError(txbIdRolEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtNombreRol, "Ingrese un valor");
        }

        private void lblSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
