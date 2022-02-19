
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaClientes
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
            this.lblAdminClientes = new MaterialSkin.Controls.MaterialLabel();
            this.lblBuscarClientes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminClientes
            // 
            this.lblAdminClientes.AutoSize = true;
            this.lblAdminClientes.Depth = 0;
            this.lblAdminClientes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminClientes.Location = new System.Drawing.Point(387, 61);
            this.lblAdminClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminClientes.Name = "lblAdminClientes";
            this.lblAdminClientes.Size = new System.Drawing.Size(206, 19);
            this.lblAdminClientes.TabIndex = 0;
            this.lblAdminClientes.Text = "ADMINISTRACION CLIENTES";
            // 
            // lblBuscarClientes
            // 
            this.lblBuscarClientes.Depth = 0;
            this.lblBuscarClientes.Hint = "Buscar cliente";
            this.lblBuscarClientes.Location = new System.Drawing.Point(68, 178);
            this.lblBuscarClientes.MaxLength = 32767;
            this.lblBuscarClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBuscarClientes.Name = "lblBuscarClientes";
            this.lblBuscarClientes.PasswordChar = '\0';
            this.lblBuscarClientes.SelectedText = "";
            this.lblBuscarClientes.SelectionLength = 0;
            this.lblBuscarClientes.SelectionStart = 0;
            this.lblBuscarClientes.Size = new System.Drawing.Size(420, 23);
            this.lblBuscarClientes.TabIndex = 3;
            this.lblBuscarClientes.TabStop = false;
            this.lblBuscarClientes.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(651, 165);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 36);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(811, 165);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.strcliente,
            this.intDocumentoCliente,
            this.intTelefonoCliente,
            this.btnEditarCliente,
            this.btnBorrar});
            this.dataGridView1.Location = new System.Drawing.Point(68, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_Cliente
            // 
            this.id_Cliente.HeaderText = "ID";
            this.id_Cliente.Name = "id_Cliente";
            this.id_Cliente.Width = 50;
            // 
            // strcliente
            // 
            this.strcliente.HeaderText = "CLIENTE";
            this.strcliente.Name = "strcliente";
            this.strcliente.Width = 300;
            // 
            // intDocumentoCliente
            // 
            this.intDocumentoCliente.HeaderText = "DOCUMENTO";
            this.intDocumentoCliente.Name = "intDocumentoCliente";
            // 
            // intTelefonoCliente
            // 
            this.intTelefonoCliente.HeaderText = "TELEFONO";
            this.intTelefonoCliente.Name = "intTelefonoCliente";
            this.intTelefonoCliente.Width = 80;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.HeaderText = "EDITAR";
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditarCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditarCliente.Text = "EDITAR";
            this.btnEditarCliente.UseColumnTextForButtonValue = true;
            this.btnEditarCliente.Width = 80;
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
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(819, 363);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarClientes);
            this.Controls.Add(this.lblAdminClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblAdminClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblBuscarClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTelefonoCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}