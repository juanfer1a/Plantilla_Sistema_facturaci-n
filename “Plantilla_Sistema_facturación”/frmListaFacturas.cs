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
        Acceso_datos cn = new Acceso_datos();
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
            cn.llenarTablas(dgvFacturas, "TBLFACTURA");

        }
        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            cn.buscarYLlenarTablas(dgvFacturas, "TBLFACTURA", "IdCliente", txtBuscarFactura.Text);
        }

        private void btnNuevoFactura_Click(object sender, EventArgs e)
        {
            frmFacturas Categorias = new frmFacturas();
            Categorias.idFactura = 0;
            Categorias.ShowDialog();
        }




        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFactura = int.Parse(dgvFacturas[2, posActual].Value.ToString());
                    cn.eliminarDeCualquierLista(idFactura, "Eliminar_Factura", "@IdFactura");
                    llenar_grid();
                }
            }

            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                frmFacturas Facturas = new frmFacturas();
                Facturas.idFactura = int.Parse(dgvFacturas[2, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Facturas.ShowDialog();//muestra el formulario de forma modal
            }
        }

        
       

        private void btnSalirFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
