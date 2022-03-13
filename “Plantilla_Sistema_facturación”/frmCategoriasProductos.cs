using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmCategoriasProductos : Form
    {
        public int IdCategoria { get; set; }

        public string Descripcion { get; set; }

        Acceso_datos cn = new Acceso_datos();
        public frmCategoriasProductos()
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

        private void frmCategoriasProductos_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {//Registro nueva categiria
                lblCatProduc.Text = "CREAR NUEVA CATEGORIA";
            }
            else
            {//Actulizar categoria
                lblCatProduc.Text = "MODIFICAR CATEGORIA";
                txtIdCatProduc.Text = IdCategoria.ToString();
                txtNombreCategoria.Text = Descripcion;
            }

        }

      

        private void btnActualizarCatProduc_Click(object sender, EventArgs e)
        {
            campoVacio(txtIdCatProduc);
            campoVacio(txtNombreCategoria);


            cn.actualizarCategoria(txtIdCatProduc.Text,txtNombreCategoria.Text);

        }

        private void lblSalirCatProduc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
