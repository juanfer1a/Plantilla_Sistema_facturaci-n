﻿
namespace _Plantilla_Sistema_facturación_
{
    partial class frmCategoriasProductos
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
            this.txtIdCatProduc = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCatProduc = new MaterialSkin.Controls.MaterialLabel();
            this.lblSalirCatProduc = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarCatProduc = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtIdCatProduc
            // 
            this.txtIdCatProduc.Location = new System.Drawing.Point(50, 99);
            this.txtIdCatProduc.Name = "txtIdCatProduc";
            this.txtIdCatProduc.Size = new System.Drawing.Size(36, 20);
            this.txtIdCatProduc.TabIndex = 14;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre Categoria";
            this.txtNombreCategoria.Location = new System.Drawing.Point(50, 135);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(420, 23);
            this.txtNombreCategoria.TabIndex = 13;
            this.txtNombreCategoria.TabStop = false;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // lblCatProduc
            // 
            this.lblCatProduc.AutoSize = true;
            this.lblCatProduc.Depth = 0;
            this.lblCatProduc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCatProduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCatProduc.Location = new System.Drawing.Point(149, 54);
            this.lblCatProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCatProduc.Name = "lblCatProduc";
            this.lblCatProduc.Size = new System.Drawing.Size(180, 19);
            this.lblCatProduc.TabIndex = 12;
            this.lblCatProduc.Text = "CATEGORIA PRODUCTOS";
            // 
            // lblSalirCatProduc
            // 
            this.lblSalirCatProduc.AutoSize = true;
            this.lblSalirCatProduc.Depth = 0;
            this.lblSalirCatProduc.Icon = null;
            this.lblSalirCatProduc.Location = new System.Drawing.Point(319, 205);
            this.lblSalirCatProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalirCatProduc.Name = "lblSalirCatProduc";
            this.lblSalirCatProduc.Primary = true;
            this.lblSalirCatProduc.Size = new System.Drawing.Size(58, 36);
            this.lblSalirCatProduc.TabIndex = 16;
            this.lblSalirCatProduc.Text = "SALIR";
            this.lblSalirCatProduc.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCatProduc
            // 
            this.btnActualizarCatProduc.AutoSize = true;
            this.btnActualizarCatProduc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCatProduc.Depth = 0;
            this.btnActualizarCatProduc.Icon = null;
            this.btnActualizarCatProduc.Location = new System.Drawing.Point(134, 205);
            this.btnActualizarCatProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCatProduc.Name = "btnActualizarCatProduc";
            this.btnActualizarCatProduc.Primary = true;
            this.btnActualizarCatProduc.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCatProduc.TabIndex = 15;
            this.btnActualizarCatProduc.Text = "ACTUALIZAR";
            this.btnActualizarCatProduc.UseVisualStyleBackColor = true;
            // 
            // frmCategoriasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 340);
            this.Controls.Add(this.lblSalirCatProduc);
            this.Controls.Add(this.btnActualizarCatProduc);
            this.Controls.Add(this.txtIdCatProduc);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.lblCatProduc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoriasProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCatProduc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCatProduc;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalirCatProduc;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCatProduc;
    }
}