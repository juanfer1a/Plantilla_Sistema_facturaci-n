
namespace _Plantilla_Sistema_facturación_
{
    partial class frmFacturas
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
            this.grbAdminClientes = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTotalIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblNroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.grbDetalleFactura = new System.Windows.Forms.GroupBox();
            this.txtDetalleFactura = new System.Windows.Forms.TextBox();
            this.lblSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grbAdminClientes.SuspendLayout();
            this.grbDetalleFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdminClientes
            // 
            this.grbAdminClientes.Controls.Add(this.dateTimePicker1);
            this.grbAdminClientes.Controls.Add(this.comboBox3);
            this.grbAdminClientes.Controls.Add(this.comboBox2);
            this.grbAdminClientes.Controls.Add(this.comboBox1);
            this.grbAdminClientes.Controls.Add(this.txtTotalIva);
            this.grbAdminClientes.Controls.Add(this.txtTotalFactura);
            this.grbAdminClientes.Controls.Add(this.txtDescuento);
            this.grbAdminClientes.Controls.Add(this.lblCliente);
            this.grbAdminClientes.Controls.Add(this.lblEmpleado);
            this.grbAdminClientes.Controls.Add(this.lblFechaRegistro);
            this.grbAdminClientes.Controls.Add(this.lblEstadoFactura);
            this.grbAdminClientes.Controls.Add(this.lblNroFactura);
            this.grbAdminClientes.Controls.Add(this.txtIdCliente);
            this.grbAdminClientes.Location = new System.Drawing.Point(26, 64);
            this.grbAdminClientes.Name = "grbAdminClientes";
            this.grbAdminClientes.Size = new System.Drawing.Size(718, 311);
            this.grbAdminClientes.TabIndex = 0;
            this.grbAdminClientes.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(512, 148);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(305, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.Depth = 0;
            this.txtTotalIva.Hint = "Total Iva";
            this.txtTotalIva.Location = new System.Drawing.Point(35, 209);
            this.txtTotalIva.MaxLength = 32767;
            this.txtTotalIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.PasswordChar = '\0';
            this.txtTotalIva.SelectedText = "";
            this.txtTotalIva.SelectionLength = 0;
            this.txtTotalIva.SelectionStart = 0;
            this.txtTotalIva.Size = new System.Drawing.Size(268, 23);
            this.txtTotalIva.TabIndex = 29;
            this.txtTotalIva.TabStop = false;
            this.txtTotalIva.UseSystemPasswordChar = false;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(35, 259);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(268, 23);
            this.txtTotalFactura.TabIndex = 28;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(35, 167);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(268, 23);
            this.txtDescuento.TabIndex = 27;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCliente.Location = new System.Drawing.Point(29, 77);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(29, 117);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleado.TabIndex = 25;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Depth = 0;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRegistro.Location = new System.Drawing.Point(509, 50);
            this.lblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(125, 19);
            this.lblFechaRegistro.TabIndex = 21;
            this.lblFechaRegistro.Text = "Fecha de registro";
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(509, 117);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(107, 19);
            this.lblEstadoFactura.TabIndex = 20;
            this.lblEstadoFactura.Text = "Estado factura";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Depth = 0;
            this.lblNroFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroFactura.Location = new System.Drawing.Point(29, 39);
            this.lblNroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(88, 19);
            this.lblNroFactura.TabIndex = 19;
            this.lblNroFactura.Text = "Nro Factura";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(150, 37);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(155, 20);
            this.txtIdCliente.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(398, 26);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 19);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "ADMINISTRACION CLIENTES";
            // 
            // grbDetalleFactura
            // 
            this.grbDetalleFactura.Controls.Add(this.txtDetalleFactura);
            this.grbDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleFactura.Location = new System.Drawing.Point(27, 394);
            this.grbDetalleFactura.Name = "grbDetalleFactura";
            this.grbDetalleFactura.Size = new System.Drawing.Size(717, 187);
            this.grbDetalleFactura.TabIndex = 1;
            this.grbDetalleFactura.TabStop = false;
            this.grbDetalleFactura.Text = "Detalle de la factura";
            // 
            // txtDetalleFactura
            // 
            this.txtDetalleFactura.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDetalleFactura.Location = new System.Drawing.Point(21, 21);
            this.txtDetalleFactura.Multiline = true;
            this.txtDetalleFactura.Name = "txtDetalleFactura";
            this.txtDetalleFactura.Size = new System.Drawing.Size(671, 150);
            this.txtDetalleFactura.TabIndex = 0;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblSalir.Depth = 0;
            this.lblSalir.Icon = null;
            this.lblSalir.Location = new System.Drawing.Point(789, 469);
            this.lblSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Primary = true;
            this.lblSalir.Size = new System.Drawing.Size(58, 36);
            this.lblSalir.TabIndex = 12;
            this.lblSalir.Text = "SALIR";
            this.lblSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(789, 151);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 607);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDetalleFactura);
            this.Controls.Add(this.grbAdminClientes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.grbAdminClientes.ResumeLayout(false);
            this.grbAdminClientes.PerformLayout();
            this.grbDetalleFactura.ResumeLayout(false);
            this.grbDetalleFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdminClientes;
        private MaterialSkin.Controls.MaterialLabel lblNroFactura;
        private System.Windows.Forms.TextBox txtIdCliente;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.GroupBox grbDetalleFactura;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblFechaRegistro;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtDetalleFactura;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
    }
}