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
        public int IdCategoria;
        public frmCategoriasProductos()
        {
            InitializeComponent();
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
                txtNombreCategoria.Text = "Nombre Categoria";
            }

        }



        private void btnActualizarCatProduc_Click(object sender, EventArgs e)
        {

            errorProvider1.SetError(txtIdCatProduc, "Ingrese un valor");
            errorProvider1.SetError(txtNombreCategoria, "Ingrese un valor");


        }

        private void lblSalirCatProduc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
