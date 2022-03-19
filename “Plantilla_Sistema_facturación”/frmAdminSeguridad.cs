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
        public static string usuario;
        public static string clave;
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }
        Acceso_datos cn = new Acceso_datos();

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

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            cn.llenarComboEmpleado(cxbEmpleadoUsuario);
            
        }


        private void cxbEmpleadoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string user = cxbEmpleadoUsuario.SelectedValue.ToString();
            //cn.traerDatosSeguridad(user.ToString());


           
        }

        private void cxbEmpleadoUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string user = cxbEmpleadoUsuario.SelectedValue.ToString();
            bool registro=cn.traerDatosSeguridad(int.Parse(user));
            if (registro == true)
            {
                txtClave.Text = clave;
                txtUsuario.Text = usuario;
            }
            else
            {
                txtClave.Clear();
                txtUsuario.Clear();
                MessageBox.Show("Este empleado no tiene usuario ni contraseña");
            }
            
        }
    }
}
