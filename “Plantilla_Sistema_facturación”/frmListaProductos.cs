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
        Acceso_datos cn = new Acceso_datos();
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        public void llenar_grid()
        {
            cn.llenarTablas(dgvProductos, "TBLPRODUCTO");
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            cn.buscarYLlenarTablas(dgvProductos, "TBLPRODUCTO", "StrNombre", txtBuscarProductos.Text);
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
                {
                    int idProducto = int.Parse(dgvProductos[2, posActual].Value.ToString());
                    cn.eliminarDeCualquierLista(idProducto, "Eliminar_Producto", "@IdProducto");
                    llenar_grid();
                }
            }

            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvProductos.CurrentRow.Index;//Obtenemos el numero de la fila
                frmProductos Producto = new frmProductos();
                Producto.IdProducto = int.Parse(dgvProductos[2, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Producto.Nombre = dgvProductos[3, posActual].Value.ToString();
                Producto.Referencia = dgvProductos[4, posActual].Value.ToString();
                Producto.PrecioCompra = float.Parse(dgvProductos[5, posActual].Value.ToString());
                Producto.PrecioVenta = float.Parse(dgvProductos[6, posActual].Value.ToString());
                Producto.Detalle = dgvProductos[8, posActual].Value.ToString();
                Producto.Foto = dgvProductos[9, posActual].Value.ToString();
                Producto.Cantidad = int.Parse(dgvProductos[10, posActual].Value.ToString());
                Producto.ShowDialog();//muestra el formulario de forma modal
                
            }
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
