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
        Acceso_datos cn = new Acceso_datos();
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
            cn.llenarTablas(dgvEmpleados, "TBLEMPLEADO");
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            cn.buscarYLlenarTablas(dgvEmpleados, "TBLEMPLEADO", "StrNombre", txtBuscarEmpleado.Text);
        }
        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgvListaEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvEmpleados.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar, tenga en cuenta que se borrará las facturas realizadas por el empleado", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEmpleado = int.Parse(dgvEmpleados[2, posActual].Value.ToString());
                    cn.eliminarDeCualquierLista(idEmpleado, "Eliminar_Empleado", "@IdCliente");
                    llenar_grid();
                }
            }

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvEmpleados.CurrentRow.Index;//Obtenemos el numero de la fila
                frmEmpleados empleados = new frmEmpleados();
                empleados.idEmpleado = int.Parse(dgvEmpleados[2, posActual].Value.ToString());
                empleados.nombre = dgvEmpleados[3, posActual].Value.ToString();
                empleados.documento = long.Parse(dgvEmpleados[4, posActual].Value.ToString());
                empleados.direccion = dgvEmpleados[5, posActual].Value.ToString();
                empleados.telefono = dgvEmpleados[6, posActual].Value.ToString();
                empleados.email = dgvEmpleados[7, posActual].Value.ToString();
                empleados.rol = int.Parse(dgvEmpleados[8, posActual].Value.ToString());
                empleados.fechaIngreso= dgvEmpleados[9, posActual].Value.ToString();
                empleados.fechaRetiro = dgvEmpleados[10, posActual].Value.ToString();
                empleados.datosAdicionales = dgvEmpleados[11, posActual].Value.ToString();//pasamos al formulario el id del cliente seleccionado
                empleados.ShowDialog();//muestra el formulario de forma modal
            }
        }
        
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.idEmpleado = 0;
            empleados.ShowDialog();
        }

        
    }
}
