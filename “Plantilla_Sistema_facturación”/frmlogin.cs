﻿using System;
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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        Acceso_datos cn = new Acceso_datos();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != String.Empty && txtPassword.Text != String.Empty)//Valida usuario y contraseña 
            {
                bool existe= cn.login(txtUsuario.Text, txtPassword.Text);
                if (existe == true)
                {
                    frmPrincipal frmPpal = new frmPrincipal();//objeto tipo formPrincipal 
                    this.Hide();//Hacemos invisible el login
                    frmPpal.Show();//Mostramos el principal

                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUsuario.Focus();
                }

            }

            //string usuario = "";//Varible para validar con la BD el usuario
            //if (txtUsuario.Text=="admin" && txtPassword.Text=="123")//Valida usuario y contraseña 
            //{
            //    cn.conectar();
            //    //usuario = "Juan Quiceno";
            //    frmPrincipal frmPpal = new frmPrincipal();//objeto tipo formPrincipal 
            //    this.Hide();//Hacemos invisible el login
            //    frmPpal.Show();//Mostramos el principal
                
            //}
            //if (usuario != string.Empty)
            //{
            //    MessageBox.Show("Usuario valido Bienvenido" + usuario);
            //}
            //else
            //{
            //    MessageBox.Show("USUARIO O CONTRASEÑA INVALIDA INTENTELO DE NUEVO");
            //    txtUsuario.Text = string.Empty;
            //    txtPassword.Text = string.Empty;
            //    txtUsuario.Focus();
            //}

        }
    }
}
