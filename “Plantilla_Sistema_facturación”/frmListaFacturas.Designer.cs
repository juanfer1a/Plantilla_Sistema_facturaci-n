
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
            this.btnSalirFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevoFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirFactura
            // 
            this.btnSalirFactura.AutoSize = true;
            this.btnSalirFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirFactura.Depth = 0;
            this.btnSalirFactura.Icon = null;
            this.btnSalirFactura.Location = new System.Drawing.Point(910, 335);
            this.btnSalirFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirFactura.Name = "btnSalirFactura";
            this.btnSalirFactura.Primary = true;
            this.btnSalirFactura.Size = new System.Drawing.Size(58, 36);
            this.btnSalirFactura.TabIndex = 19;
            this.btnSalirFactura.Text = "SALIR";
            this.btnSalirFactura.UseVisualStyleBackColor = true;
            this.btnSalirFactura.Click += new System.EventHandler(this.btnSalirFactura_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnBorrar});
            this.dgvFacturas.Location = new System.Drawing.Point(25, 179);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(943, 150);
            this.dgvFacturas.TabIndex = 18;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
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
            // btnNuevoFactura
            // 
            this.btnNuevoFactura.AutoSize = true;
            this.btnNuevoFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoFactura.Depth = 0;
            this.btnNuevoFactura.Icon = null;
            this.btnNuevoFactura.Location = new System.Drawing.Point(902, 137);
            this.btnNuevoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoFactura.Name = "btnNuevoFactura";
            this.btnNuevoFactura.Primary = true;
            this.btnNuevoFactura.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoFactura.TabIndex = 17;
            this.btnNuevoFactura.Text = "NUEVO";
            this.btnNuevoFactura.UseVisualStyleBackColor = true;
            this.btnNuevoFactura.Click += new System.EventHandler(this.btnNuevoFactura_Click);
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.AutoSize = true;
            this.btnBuscarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarFactura.Depth = 0;
            this.btnBuscarFactura.Icon = null;
            this.btnBuscarFactura.Location = new System.Drawing.Point(778, 137);
            this.btnBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Primary = true;
            this.btnBuscarFactura.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarFactura.TabIndex = 16;
            this.btnBuscarFactura.Text = "BUSCAR";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.Depth = 0;
            this.txtBuscarFactura.Hint = "Buscar Producto";
            this.txtBuscarFactura.Location = new System.Drawing.Point(25, 150);
            this.txtBuscarFactura.MaxLength = 32767;
            this.txtBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.PasswordChar = '\0';
            this.txtBuscarFactura.SelectedText = "";
            this.txtBuscarFactura.SelectionLength = 0;
            this.txtBuscarFactura.SelectionStart = 0;
            this.txtBuscarFactura.Size = new System.Drawing.Size(321, 23);
            this.txtBuscarFactura.TabIndex = 15;
            this.txtBuscarFactura.TabStop = false;
            this.txtBuscarFactura.UseSystemPasswordChar = false;
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
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 500);
            this.Controls.Add(this.lblAdminProductos);
            this.Controls.Add(this.btnSalirFactura);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnNuevoFactura);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.txtBuscarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.Load += new System.EventHandler(this.frmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalirFactura;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarFactura;
        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}