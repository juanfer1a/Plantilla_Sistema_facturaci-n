
namespace _Plantilla_Sistema_facturación_
{
    partial class frmAdminSeguridad
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
            this.grbAdminUsuarioSeg = new System.Windows.Forms.GroupBox();
            this.txtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cxbEmpleadoUsuario = new System.Windows.Forms.ComboBox();
            this.lblSalirAdminUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarUsuarioEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblAdminUsuarios = new MaterialSkin.Controls.MaterialLabel();
            this.grbAdminUsuarioSeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdminUsuarioSeg
            // 
            this.grbAdminUsuarioSeg.Controls.Add(this.cxbEmpleadoUsuario);
            this.grbAdminUsuarioSeg.Controls.Add(this.txtClave);
            this.grbAdminUsuarioSeg.Controls.Add(this.lblEmpleado);
            this.grbAdminUsuarioSeg.Controls.Add(this.txtUsuario);
            this.grbAdminUsuarioSeg.Location = new System.Drawing.Point(38, 73);
            this.grbAdminUsuarioSeg.Name = "grbAdminUsuarioSeg";
            this.grbAdminUsuarioSeg.Size = new System.Drawing.Size(541, 218);
            this.grbAdminUsuarioSeg.TabIndex = 0;
            this.grbAdminUsuarioSeg.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Depth = 0;
            this.txtClave.Hint = "Clave";
            this.txtClave.Location = new System.Drawing.Point(23, 152);
            this.txtClave.MaxLength = 32767;
            this.txtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.Size = new System.Drawing.Size(196, 23);
            this.txtClave.TabIndex = 21;
            this.txtClave.TabStop = false;
            this.txtClave.UseSystemPasswordChar = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(21, 41);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(25, 98);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(194, 23);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // cxbEmpleadoUsuario
            // 
            this.cxbEmpleadoUsuario.FormattingEnabled = true;
            this.cxbEmpleadoUsuario.Location = new System.Drawing.Point(119, 42);
            this.cxbEmpleadoUsuario.Name = "cxbEmpleadoUsuario";
            this.cxbEmpleadoUsuario.Size = new System.Drawing.Size(324, 21);
            this.cxbEmpleadoUsuario.TabIndex = 22;
            // 
            // lblSalirAdminUsuario
            // 
            this.lblSalirAdminUsuario.AutoSize = true;
            this.lblSalirAdminUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblSalirAdminUsuario.Depth = 0;
            this.lblSalirAdminUsuario.Icon = null;
            this.lblSalirAdminUsuario.Location = new System.Drawing.Point(342, 316);
            this.lblSalirAdminUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalirAdminUsuario.Name = "lblSalirAdminUsuario";
            this.lblSalirAdminUsuario.Primary = true;
            this.lblSalirAdminUsuario.Size = new System.Drawing.Size(58, 36);
            this.lblSalirAdminUsuario.TabIndex = 23;
            this.lblSalirAdminUsuario.Text = "SALIR";
            this.lblSalirAdminUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizarUsuarioEmpleado
            // 
            this.btnActualizarUsuarioEmpleado.AutoSize = true;
            this.btnActualizarUsuarioEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarUsuarioEmpleado.Depth = 0;
            this.btnActualizarUsuarioEmpleado.Icon = null;
            this.btnActualizarUsuarioEmpleado.Location = new System.Drawing.Point(157, 316);
            this.btnActualizarUsuarioEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarUsuarioEmpleado.Name = "btnActualizarUsuarioEmpleado";
            this.btnActualizarUsuarioEmpleado.Primary = true;
            this.btnActualizarUsuarioEmpleado.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarUsuarioEmpleado.TabIndex = 22;
            this.btnActualizarUsuarioEmpleado.Text = "ACTUALIZAR";
            this.btnActualizarUsuarioEmpleado.UseVisualStyleBackColor = true;
            // 
            // lblAdminUsuarios
            // 
            this.lblAdminUsuarios.AutoSize = true;
            this.lblAdminUsuarios.Depth = 0;
            this.lblAdminUsuarios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminUsuarios.Location = new System.Drawing.Point(153, 29);
            this.lblAdminUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminUsuarios.Name = "lblAdminUsuarios";
            this.lblAdminUsuarios.Size = new System.Drawing.Size(329, 19);
            this.lblAdminUsuarios.TabIndex = 23;
            this.lblAdminUsuarios.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // frmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 371);
            this.Controls.Add(this.lblAdminUsuarios);
            this.Controls.Add(this.lblSalirAdminUsuario);
            this.Controls.Add(this.btnActualizarUsuarioEmpleado);
            this.Controls.Add(this.grbAdminUsuarioSeg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminSeguridad";
            this.Text = "frmAdminSeguridad";
            this.grbAdminUsuarioSeg.ResumeLayout(false);
            this.grbAdminUsuarioSeg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdminUsuarioSeg;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClave;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private System.Windows.Forms.ComboBox cxbEmpleadoUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalirAdminUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarUsuarioEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblAdminUsuarios;
    }
}