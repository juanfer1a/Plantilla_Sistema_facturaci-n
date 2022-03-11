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

            for (int i = 0; i < 10; i++)
            {

                dgvRol.Rows.Add(i, $"ID {i}", $"ROL {i}", $"DESCRIPCION ROL {i}");
            }
        }
        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRol.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvRol.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvRol[0, posActual].Value.ToString()}");//Mostramos mensaje
            }

            if (dgvRol.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvRol.CurrentRow.Index;//Obtenemos el numero de la fila
                frmFacturas Facturas = new frmFacturas();
                Facturas.NroFactura = int.Parse(dgvRol[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Facturas.ShowDialog();//muestra el formulario de forma modal
            }
        }
        private void btnRolNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados Rol = new frmRolEmpleados();
            Rol.IdRol = 0;
            Rol.ShowDialog();
        }



        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en desarrollo");
        }

        private void btnSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
