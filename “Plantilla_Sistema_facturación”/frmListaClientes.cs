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
            for (int i = 0; i < 10; i++)
            {
                dgClientes.Rows.Add(i, $"Nombre{i} Apellido1 Apellido2", $"{i * 12345}", $"{i * 12345}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en construccion");
            //string nombre;
            //for (int i = 0; i < 10; i++)
            //{
            //    nombre = dgClientes.Rows[i].ToString();

            //    if (txtBuscarClientes.Text == nombre)
            //    {
                    

            //    }
            //}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarClientes Cliente = new frmEditarClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgClientes.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgClientes[0, posActual].Value.ToString()}");//Mostramos mensaje
            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditarCliente")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgClientes.CurrentRow.Index;//Obtenemos el numero de la fila
                frmEditarClientes Cliente = new frmEditarClientes();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Cliente.ShowDialog();//muestra el formulario de forma modal
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                      
    }
}
