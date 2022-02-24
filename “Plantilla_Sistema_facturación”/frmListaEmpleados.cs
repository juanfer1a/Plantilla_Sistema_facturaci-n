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
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {

            llenar_grid();
        }
        public void llenar_grid()
        {

            for (int i = 0; i < 10; i++)
            {

                dgvListaEmpleados.Rows.Add(i, $"TRABAJADOR {i}", $"{i}@EMAIL.COM", $"ROL{i}", $"{DateTime.Now}", $"{DateTime.Now}",$"{i*234234}",$"CALLE{i}",$"{i*232}");
            }
        }
       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en desarrollo");
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvListaEmpleados.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvListaEmpleados[0, posActual].Value.ToString()}");//Mostramos mensaje
            }

            if (dgvListaEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvListaEmpleados.CurrentRow.Index;//Obtenemos el numero de la fila
                frmEmpleados empleados = new frmEmpleados();
                empleados.idEmpleado = int.Parse(dgvListaEmpleados[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                empleados.ShowDialog();//muestra el formulario de forma modal
            }
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.idEmpleado = 0;
            empleados.ShowDialog();
        }
    }
}
