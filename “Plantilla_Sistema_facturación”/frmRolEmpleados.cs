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
        public string descripcion { get; set; }

        Acceso_datos cn = new Acceso_datos();

        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        public void campoVacio(System.Windows.Forms.Control campo)
        {
            if (campo.Text == String.Empty)
            {
                errorProvider1.SetError(campo, "Se debe llenar este campo");
            }
            else
            {
                errorProvider1.SetError(campo, "");
            }
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
                txbDescripcionRol.Text = descripcion;
                txtNombreRol.Text = descripcion;
                txbIdRolEmpleado.Text = IdRol.ToString();
            }

        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            if (IdRol >= 0)
            {
                MessageBox.Show("No se puede actualizar ya que esta asociado a una empleado");
            }
            else
            {
                cn.insertarRol(txtNombreRol.Text);
                
            }
            //campoVacio(txbDescripcionRol);
            ////campoVacio(txbIdRolEmpleado);
            //campoVacio(txtNombreRol);
            
        }

        private void lblSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
