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
    public partial class frmListaRol : Form
    {
        Acceso_datos cn = new Acceso_datos();
        public int IdRol { get; set; }
        public frmListaRol()
        {
            InitializeComponent();
        }


        private void frmListaRol_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        public void llenar_grid()
        {
            cn.llenarTablas(dgvRol, "TBLROLES");

        }
        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            cn.buscarYLlenarTablas(dgvRol, "TBLROLES", "StrDescripcion", txtBuscarRol.Text);
        }

        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRol.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvRol.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar, tenga en cuenta que se borrará las facturas realizadas por el empleado", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Falta corregir el borrado
                    int idRol = int.Parse(dgvRol[2, posActual].Value.ToString());
                    cn.eliminarDeCualquierLista(idRol, "Eliminar_Rol", "@IdRol");
                    llenar_grid();
                }
            }

            if (dgvRol.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvRol.CurrentRow.Index;//Obtenemos el numero de la fila
                frmRolEmpleados Facturas = new frmRolEmpleados();
                Facturas.IdRol = int.Parse(dgvRol[2, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Facturas.descripcion = dgvRol[3, posActual].Value.ToString();
                Facturas.ShowDialog();//muestra el formulario de forma modal
            }
        }
        private void btnRolNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados Rol = new frmRolEmpleados();
            Rol.IdRol = 0;
            Rol.ShowDialog();
        }



       

        private void btnSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
