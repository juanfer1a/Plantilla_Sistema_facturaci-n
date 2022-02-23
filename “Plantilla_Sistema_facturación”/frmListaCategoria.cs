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
            for (int i = 0; i < 10; i++)
            {
                dgvCategoria.Rows.Add(i, $"Categoria{i}");
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en desarrollo");
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
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvCategoria[0, posActual].Value.ToString()}");//Mostramos mensaje
            }

            if (dgvCategoria.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvCategoria.CurrentRow.Index;//Obtenemos el numero de la fila
                frmCategoriasProductos Categoria = new frmCategoriasProductos();
                Categoria.IdCategoria = int.Parse(dgvCategoria[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Categoria.ShowDialog();//muestra el formulario de forma modal
            }
        }
    }
}
