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

    }
}
