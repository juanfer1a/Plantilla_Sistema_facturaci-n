
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNuevoEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnBorrar});
            this.dgvEmpleados.Location = new System.Drawing.Point(25, 183);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(890, 177);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellContentClick_1);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Depth = 0;
            this.lblEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleados.Location = new System.Drawing.Point(433, 47);
            this.lblEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(96, 19);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "EMPLEADOS";
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Depth = 0;
            this.txtBuscarEmpleado.Hint = "Buscar Empleado";
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(25, 151);
            this.txtBuscarEmpleado.MaxLength = 32767;
            this.txtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.SelectionLength = 0;
            this.txtBuscarEmpleado.SelectionStart = 0;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(456, 23);
            this.txtBuscarEmpleado.TabIndex = 5;
            this.txtBuscarEmpleado.TabStop = false;
            this.txtBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSize = true;
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.Icon = null;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(849, 138);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Primary = true;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoEmpleado.TabIndex = 19;
            this.btnNuevoEmpleado.Text = "NUEVO";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.AutoSize = true;
            this.btnBuscarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.Icon = null;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(684, 138);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Primary = true;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarEmpleado.TabIndex = 18;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnSalirEmpleado
            // 
            this.btnSalirEmpleado.AutoSize = true;
            this.btnSalirEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirEmpleado.Depth = 0;
            this.btnSalirEmpleado.Icon = null;
            this.btnSalirEmpleado.Location = new System.Drawing.Point(857, 366);
            this.btnSalirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirEmpleado.Name = "btnSalirEmpleado";
            this.btnSalirEmpleado.Primary = true;
            this.btnSalirEmpleado.Size = new System.Drawing.Size(58, 36);
            this.btnSalirEmpleado.TabIndex = 20;
            this.btnSalirEmpleado.Text = "SALIR";
            this.btnSalirEmpleado.UseVisualStyleBackColor = true;
            this.btnSalirEmpleado.Click += new System.EventHandler(this.btnSalirEmpleado_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // frmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.Controls.Add(this.btnSalirEmpleado);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaEmpleados";
            this.Text = "frmListaEmpleados";
            this.Load += new System.EventHandler(this.frmListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private MaterialSkin.Controls.MaterialLabel lblEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}