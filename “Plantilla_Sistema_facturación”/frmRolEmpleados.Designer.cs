
namespace _Plantilla_Sistema_facturación_
{
    partial class frmRolEmpleados
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
            this.grbRolEmpleados = new System.Windows.Forms.GroupBox();
            this.lblSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdRolEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblRolEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.grbRolEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRolEmpleados
            // 
            this.grbRolEmpleados.Controls.Add(this.txtDescripcionRol);
            this.grbRolEmpleados.Controls.Add(this.lblDescripcionRol);
            this.grbRolEmpleados.Controls.Add(this.txtIdRolEmpleado);
            this.grbRolEmpleados.Controls.Add(this.txtNombreRol);
            this.grbRolEmpleados.Location = new System.Drawing.Point(39, 79);
            this.grbRolEmpleados.Name = "grbRolEmpleados";
            this.grbRolEmpleados.Size = new System.Drawing.Size(519, 306);
            this.grbRolEmpleados.TabIndex = 0;
            this.grbRolEmpleados.TabStop = false;
            // 
            // lblSalirRol
            // 
            this.lblSalirRol.AutoSize = true;
            this.lblSalirRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblSalirRol.Depth = 0;
            this.lblSalirRol.Icon = null;
            this.lblSalirRol.Location = new System.Drawing.Point(364, 402);
            this.lblSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalirRol.Name = "lblSalirRol";
            this.lblSalirRol.Primary = true;
            this.lblSalirRol.Size = new System.Drawing.Size(58, 36);
            this.lblSalirRol.TabIndex = 21;
            this.lblSalirRol.Text = "SALIR";
            this.lblSalirRol.UseVisualStyleBackColor = true;
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.AutoSize = true;
            this.btnActualizarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarRol.Depth = 0;
            this.btnActualizarRol.Icon = null;
            this.btnActualizarRol.Location = new System.Drawing.Point(179, 402);
            this.btnActualizarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.Primary = true;
            this.btnActualizarRol.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarRol.TabIndex = 20;
            this.btnActualizarRol.Text = "ACTUALIZAR";
            this.btnActualizarRol.UseVisualStyleBackColor = true;
            // 
            // txtIdRolEmpleado
            // 
            this.txtIdRolEmpleado.Location = new System.Drawing.Point(56, 36);
            this.txtIdRolEmpleado.Name = "txtIdRolEmpleado";
            this.txtIdRolEmpleado.Size = new System.Drawing.Size(36, 20);
            this.txtIdRolEmpleado.TabIndex = 19;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(56, 81);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(420, 23);
            this.txtNombreRol.TabIndex = 18;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // lblRolEmpleados
            // 
            this.lblRolEmpleados.AutoSize = true;
            this.lblRolEmpleados.Depth = 0;
            this.lblRolEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleados.Location = new System.Drawing.Point(246, 38);
            this.lblRolEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleados.Name = "lblRolEmpleados";
            this.lblRolEmpleados.Size = new System.Drawing.Size(127, 19);
            this.lblRolEmpleados.TabIndex = 17;
            this.lblRolEmpleados.Text = "ROL EMPLEADOS";
            this.lblRolEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Depth = 0;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionRol.Location = new System.Drawing.Point(52, 128);
            this.lblDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(180, 19);
            this.lblDescripcionRol.TabIndex = 20;
            this.lblDescripcionRol.Text = "Descripcion detallada Rol";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Location = new System.Drawing.Point(56, 164);
            this.txtDescripcionRol.Multiline = true;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(420, 101);
            this.txtDescripcionRol.TabIndex = 21;
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 469);
            this.Controls.Add(this.lblSalirRol);
            this.Controls.Add(this.btnActualizarRol);
            this.Controls.Add(this.lblRolEmpleados);
            this.Controls.Add(this.grbRolEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRolEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRolEmpleados";
            this.grbRolEmpleados.ResumeLayout(false);
            this.grbRolEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRolEmpleados;
        private System.Windows.Forms.TextBox txtIdRolEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalirRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionRol;
    }
}