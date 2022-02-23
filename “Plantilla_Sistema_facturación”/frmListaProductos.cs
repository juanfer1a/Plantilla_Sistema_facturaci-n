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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
                frmProductos Producto = new frmProductos();
                Producto.IdProducto = 0;
                Producto.ShowDialog();//muestra el formulario de forma modal
        }
           

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvProductos.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvProductos[0, posActual].Value.ToString()}");//Mostramos mensaje
            }

            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvProductos.CurrentRow.Index;//Obtenemos el numero de la fila
                frmProductos Producto = new frmProductos();
                Producto.IdProducto = int.Parse(dgvProductos[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Producto.ShowDialog();//muestra el formulario de forma modal
            }
        }

        public void llenar_grid()
        {
            for (int i = 0; i < 10; i++)
            {
                dgvProductos.Rows.Add(i, $"Nombre{i}", $"{i * 12345}", $"{i * 12345}", $"{i * 12345}", $"{i * 12345}");
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en desarrollo.");
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
