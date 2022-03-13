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
    public partial class frmListaCategoria : Form
    {
        Acceso_datos cn = new Acceso_datos();
        public frmListaCategoria()
        {
            InitializeComponent();
        }

        private void frmListaCategoria_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            cn.llenarTablas(dgvCategoria, "TBLCATEGORIA_PROD");

        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            cn.buscarYLlenarTablas(dgvCategoria, "TBLCATEGORIA_PROD", "StrDescripcion", txtBuscarCategoria.Text);
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriasProductos Categorias = new frmCategoriasProductos();
            Categorias.IdCategoria = 0;
            Categorias.ShowDialog();
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvCategoria.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar, tenga en cuenta que se borrará los productos asociados a este categoría", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCategoria = int.Parse(dgvCategoria[2, posActual].Value.ToString());
                    cn.eliminarDeCualquierLista(idCategoria, "Eliminar_CategoriaProducto", "@IdCategoria");
                    llenar_grid();
                }
            }

            if (dgvCategoria.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvCategoria.CurrentRow.Index;//Obtenemos el numero de la fila
                frmCategoriasProductos Categoria = new frmCategoriasProductos();
                Categoria.IdCategoria = int.Parse(dgvCategoria[2, posActual].Value.ToString());
                Categoria.Descripcion = dgvCategoria[3, posActual].Value.ToString();//pasamos al formulario el id del cliente seleccionado
                Categoria.ShowDialog();//muestra el formulario de forma modal
            }
        }
    }
}
