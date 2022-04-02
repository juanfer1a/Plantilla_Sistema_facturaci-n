using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty)//Valida que los campos tengan informacion
            {
                Validar_usuario Obj_Validar = new Validar_usuario();

                Obj_Validar.C_StrUsuario = txtUsuario.Text;
                Obj_Validar.C_StrClave = txtPassword.Text;

                Obj_Validar.ValidarUsuario();
                
                if (Obj_Validar.C_IdEmpleado != 0)
                {
                    MessageBox.Show("Datos de  verificacion validos");
                    frmPrincipal frmPpal = new frmPrincipal();//objeto tipo formPrincipal 
                    this.Hide();//Hacemos invisible el login
                    frmPpal.Show();//Mostramos el principal
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA NO ENCONTRADOS");
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUsuario.Focus();
                }

            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave ");
            }


        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "Debe ingresar un nombre de usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }

            else
            {
                MensajeError.SetError(txtUsuario, string.Empty);
                //Consultar();
            }

            if (txtPassword.Text == string.Empty)
            {
                MensajeError.SetError(txtPassword, "Debe ingresar una contraseña");
                txtPassword.Focus();
                errorCampos = false;
            }

            else
            {
                MensajeError.SetError(txtPassword, string.Empty);

            }
            return errorCampos;
        }
    }
}
