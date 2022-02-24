
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaEmpleados
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
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.intIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNameEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnClienteNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intIdEmpleado,
            this.strNameEmpleado,
            this.strEmail,
            this.strRol,
            this.strFechaIngreso,
            this.strFechaRetiro,
            this.intDocumento,
            this.strDireccion,
            this.intTelefono,
            this.btnEditar,
            this.btnBorrar});
            this.dgvListaEmpleados.Location = new System.Drawing.Point(25, 183);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.Size = new System.Drawing.Size(890, 177);
            this.dgvListaEmpleados.TabIndex = 0;
            this.dgvListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellContentClick_1);
            // 
            // intIdEmpleado
            // 
            this.intIdEmpleado.HeaderText = "ID";
            this.intIdEmpleado.Name = "intIdEmpleado";
            // 
            // strNameEmpleado
            // 
            this.strNameEmpleado.HeaderText = "NOMBRE";
            this.strNameEmpleado.Name = "strNameEmpleado";
            // 
            // strEmail
            // 
            this.strEmail.HeaderText = "EMAIL";
            this.strEmail.Name = "strEmail";
            // 
            // strRol
            // 
            this.strRol.HeaderText = "ROL";
            this.strRol.Name = "strRol";
            // 
            // strFechaIngreso
            // 
            this.strFechaIngreso.HeaderText = "F. INGRESO";
            this.strFechaIngreso.Name = "strFechaIngreso";
            // 
            // strFechaRetiro
            // 
            this.strFechaRetiro.HeaderText = "F.RETIRO";
            this.strFechaRetiro.Name = "strFechaRetiro";
            // 
            // intDocumento
            // 
            this.intDocumento.HeaderText = "DOCUMENTO";
            this.intDocumento.Name = "intDocumento";
            // 
            // strDireccion
            // 
            this.strDireccion.HeaderText = "DIRECCION";
            this.strDireccion.Name = "strDireccion";
            // 
            // intTelefono
            // 
            this.intTelefono.HeaderText = "TELEFONO";
            this.intTelefono.Name = "intTelefono";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(450, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Depth = 0;
            this.txtBuscarEmpleado.Hint = "Buscar Empleado";
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(39, 151);
            this.txtBuscarEmpleado.MaxLength = 32767;
            this.txtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.SelectionLength = 0;
            this.txtBuscarEmpleado.SelectionStart = 0;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(241, 23);
            this.txtBuscarEmpleado.TabIndex = 5;
            this.txtBuscarEmpleado.TabStop = false;
            this.txtBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.AutoSize = true;
            this.btnClienteNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClienteNuevo.Depth = 0;
            this.btnClienteNuevo.Icon = null;
            this.btnClienteNuevo.Location = new System.Drawing.Point(849, 138);
            this.btnClienteNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Primary = true;
            this.btnClienteNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnClienteNuevo.TabIndex = 19;
            this.btnClienteNuevo.Text = "NUEVO";
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            this.btnClienteNuevo.Click += new System.EventHandler(this.btnClienteNuevo_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Icon = null;
            this.btnBuscarProducto.Location = new System.Drawing.Point(315, 138);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.AutoSize = true;
            this.btnSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCliente.Depth = 0;
            this.btnSalirCliente.Icon = null;
            this.btnSalirCliente.Location = new System.Drawing.Point(857, 366);
            this.btnSalirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Primary = true;
            this.btnSalirCliente.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCliente.TabIndex = 20;
            this.btnSalirCliente.Text = "SALIR";
            this.btnSalirCliente.UseVisualStyleBackColor = true;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // frmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.btnClienteNuevo);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dgvListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaEmpleados";
            this.Text = "frmListaEmpleados";
            this.Load += new System.EventHandler(this.frmListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnClienteNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNameEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn strRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}