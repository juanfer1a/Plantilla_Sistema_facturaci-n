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
            Llenar_grid();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos


        public void Llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            string sentencia = $"select IdProducto,strNombre,Strcodigo,NumPrecioCompra,NumPrecioVenta,NumStock from TBLPRODUCTO"; // CONSULTO REGISTRO DEL iDcLIENTE

            dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach (DataRow row in dt.Rows)
            {
                // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                dgvProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
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

       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string sentencia = $"select IdProducto,strNombre,Strcodigo,NumPrecioCompra,NumPrecioVenta,NumStock from TBLPRODUCTO " +
                $"where StrNombre='{txtBuscarProductos.Text}'"; // CONSULTO REGISTRO DEL iDcLIENTE
            

            if (dt.Rows.Count > 0)
            {
                dgvProductos.Rows.Clear();

                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                    dgvProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra un usuario con el nuemero de documento ingresado");
                Llenar_grid();

            }
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
