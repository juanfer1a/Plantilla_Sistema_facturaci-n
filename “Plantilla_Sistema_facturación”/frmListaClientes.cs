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
    public partial class frmListaClientes : Form
    {
        Acceso_datos cn = new Acceso_datos();
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            cn.llenarTablas(dgvClientes, "TBLCLIENTES");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cn.buscarYLlenarTablas(dgvClientes, "TBLCLIENTES","StrNombre",txtBuscarClientes.Text);
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarClientes Cliente = new frmEditarClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvClientes.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar, tenga en cuenta que también se borrará el registro de las facturas", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   int idCliente = int.Parse(dgvClientes[2, posActual].Value.ToString());
                    cn.eliminarDeCualquierLista(idCliente, "Eliminar_Cliente", "@IdCliente");
                    llenar_grid();
                }
                   
            }

            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditarCliente")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvClientes.CurrentRow.Index;//Obtenemos el numero de la fila
                frmEditarClientes Cliente = new frmEditarClientes();
                Cliente.IdCliente = int.Parse(dgvClientes[2, posActual].Value.ToString());
                Cliente.Nombre = (dgvClientes[3, posActual].Value.ToString());
                Cliente.Documento = int.Parse(dgvClientes[4, posActual].Value.ToString());
                Cliente.Direccion = (dgvClientes[5, posActual].Value.ToString());
                Cliente.Telefono = int.Parse(dgvClientes[6, posActual].Value.ToString());
                Cliente.Email = (dgvClientes[7, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Cliente.ShowDialog();//muestra el formulario de forma modal
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
