﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace proyectoLogin1
{
    public partial class Form1 : Form
    {
        static bool estadodelOjo ;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int m, mx, my;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.Gray;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;

            }

        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.Gray;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
                btMostrar.BringToFront();
                estadodelOjo = true;
                txtcontraseña.PasswordChar = '*';
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if(txtcontraseña.Text != "Contraseña")
            {
                ptOcultar.BringToFront();
                estadodelOjo = false;
                txtcontraseña.PasswordChar = '\0';
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Login verificaciónDeCredenciales = new Login(txtusuario.Text, txtcontraseña.Text);
            if (verificaciónDeCredenciales.VerificacionDeUsuario() == true)
            {
                if (verificaciónDeCredenciales.VerificacionDeContra() == true)
                {
                    Administrador_interfaz ventanadeAdmin = new Administrador_interfaz();
                    ventanadeAdmin.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            if (estadodelOjo == false)
            {
                ptOcultar.BringToFront();
                txtcontraseña.PasswordChar = '\0';
            }
            if(txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.PasswordChar = '\0';
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
