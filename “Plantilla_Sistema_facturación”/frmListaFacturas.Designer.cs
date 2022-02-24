
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalirProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnProductoNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.intNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirProducto
            // 
            this.btnSalirProducto.AutoSize = true;
            this.btnSalirProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirProducto.Depth = 0;
            this.btnSalirProducto.Icon = null;
            this.btnSalirProducto.Location = new System.Drawing.Point(913, 413);
            this.btnSalirProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirProducto.Name = "btnSalirProducto";
            this.btnSalirProducto.Primary = true;
            this.btnSalirProducto.Size = new System.Drawing.Size(58, 36);
            this.btnSalirProducto.TabIndex = 19;
            this.btnSalirProducto.Text = "SALIR";
            this.btnSalirProducto.UseVisualStyleBackColor = true;
            this.btnSalirProducto.Click += new System.EventHandler(this.btnSalirProducto_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intNroFactura,
            this.strCliente,
            this.strEmpleado,
            this.intDescuento,
            this.intIva,
            this.intFactura,
            this.strFechaRegistro,
            this.strEstado,
            this.btnEditar,
            this.btnBorrar});
            this.dgvFacturas.Location = new System.Drawing.Point(28, 257);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(943, 150);
            this.dgvFacturas.TabIndex = 18;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // btnProductoNuevo
            // 
            this.btnProductoNuevo.AutoSize = true;
            this.btnProductoNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductoNuevo.Depth = 0;
            this.btnProductoNuevo.Icon = null;
            this.btnProductoNuevo.Location = new System.Drawing.Point(905, 215);
            this.btnProductoNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductoNuevo.Name = "btnProductoNuevo";
            this.btnProductoNuevo.Primary = true;
            this.btnProductoNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnProductoNuevo.TabIndex = 17;
            this.btnProductoNuevo.Text = "NUEVO";
            this.btnProductoNuevo.UseVisualStyleBackColor = true;
            this.btnProductoNuevo.Click += new System.EventHandler(this.btnProductoNuevo_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Icon = null;
            this.btnBuscarProducto.Location = new System.Drawing.Point(371, 215);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarProducto.TabIndex = 16;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Depth = 0;
            this.txtBuscarProductos.Hint = "Buscar Producto";
            this.txtBuscarProductos.Location = new System.Drawing.Point(28, 228);
            this.txtBuscarProductos.MaxLength = 32767;
            this.txtBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.PasswordChar = '\0';
            this.txtBuscarProductos.SelectedText = "";
            this.txtBuscarProductos.SelectionLength = 0;
            this.txtBuscarProductos.SelectionStart = 0;
            this.txtBuscarProductos.Size = new System.Drawing.Size(321, 23);
            this.txtBuscarProductos.TabIndex = 15;
            this.txtBuscarProductos.TabStop = false;
            this.txtBuscarProductos.UseSystemPasswordChar = false;
            // 
            // lblAdminProductos
            // 
            this.lblAdminProductos.AutoSize = true;
            this.lblAdminProductos.Depth = 0;
            this.lblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminProductos.Location = new System.Drawing.Point(367, 78);
            this.lblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminProductos.Name = "lblAdminProductos";
            this.lblAdminProductos.Size = new System.Drawing.Size(212, 19);
            this.lblAdminProductos.TabIndex = 20;
            this.lblAdminProductos.Text = "ADMINISTRACION FACTURAS";
            // 
            // intNroFactura
            // 
            this.intNroFactura.HeaderText = "NRO. FACTURA";
            this.intNroFactura.Name = "intNroFactura";
            this.intNroFactura.Width = 80;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.Name = "strCliente";
            this.strCliente.Width = 250;
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "EMPLEADO";
            this.strEmpleado.Name = "strEmpleado";
            this.strEmpleado.Width = 220;
            // 
            // intDescuento
            // 
            this.intDescuento.HeaderText = "DESCUENTO";
            this.intDescuento.Name = "intDescuento";
            this.intDescuento.Width = 80;
            // 
            // intIva
            // 
            this.intIva.HeaderText = "TOTAL IVA";
            this.intIva.Name = "intIva";
            this.intIva.Width = 80;
            // 
            // intFactura
            // 
            this.intFactura.HeaderText = "TOTAL FACTURA";
            this.intFactura.Name = "intFactura";
            this.intFactura.Width = 80;
            // 
            // strFechaRegistro
            // 
            this.strFechaRegistro.HeaderText = "FECHA REGISTRO";
            this.strFechaRegistro.Name = "strFechaRegistro";
            this.strFechaRegistro.Width = 120;
            // 
            // strEstado
            // 
            this.strEstado.HeaderText = "ESTADO FACTURA";
            this.strEstado.Name = "strEstado";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 500);
            this.Controls.Add(this.lblAdminProductos);
            this.Controls.Add(this.btnSalirProducto);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnProductoNuevo);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.Load += new System.EventHandler(this.frmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalirProducto;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductoNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProductos;
        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEstado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}