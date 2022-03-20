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
            Llenar_grid();

        }


        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos


        public void Llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            string sentencia = $"EXEC SpConsultaFactura"; // CONSULTA TABLA DETALLE FACTURAS

            dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach (DataRow row in dt.Rows)
            {
                // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                dgvFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
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
            string sentencia = $"EXEC SpConsultaFactura";

            if (dt.Rows.Count > 0)
            {
                dgvFacturas.Rows.Clear();

                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[2].Equals(txtBuscarFactura.Text))
                    {
                        // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                        dgvFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    }
                    else MessageBox.Show($"No hay una factura asociada al cliente {txtBuscarFactura.Text}");
                    break;
                                     
                }
            }
            Llenar_grid();
          
        }
        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvFacturas[0, posActual].Value.ToString()}");//Mostramos mensaje
                int IdFactura = Convert.ToInt32(dgvFacturas[0, posActual].Value.ToString());
                string sentencia = $"Delete TBLFACTURA WHERE IdFactura = {IdFactura}";
                string mensaje = Acceso.EjecutarComando(sentencia);
                dgvFacturas.Rows.Clear();
                Llenar_grid();
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
