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
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }
        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            llenar_grid();

        }

        
        public void llenar_grid()
        {

            for (int i = 0; i < 10; i++)
            {
              
                dgvFacturas.Rows.Add(i, $"CLIENTE {i}", $"EMPLEADO {i}", $"{i*0,01}", "9", $"{i*34342}", $"{DateTime.Now}");
            }
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas Facturas = new frmFacturas();
            Facturas.NroFactura = 0;
            Facturas.ShowDialog();
        }

       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en desarrollo");
        }
        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvFacturas[0, posActual].Value.ToString()}");//Mostramos mensaje
            }

            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                frmFacturas Facturas = new frmFacturas();
                Facturas.NroFactura = int.Parse(dgvFacturas[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Facturas.ShowDialog();//muestra el formulario de forma modal
            }
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
