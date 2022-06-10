using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoLogin1
{
    public partial class Administrador_interfaz : Form
    {
        public Administrador_interfaz()
        {
            InitializeComponent();
        }

        private void Administrador_interfaz_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int m, mx, my;

        private void pTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            AbrirFormTiempo(new Tiempo_Administrador());
        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Pedidos());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            AbrirFormMateriales(new Materiales_Administrador());
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirFormCatalogo(new Catalogo_Administrador());
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            AbrirFormHerramientas(new Herramientas_Administrador());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pTitulo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        private void AbrirFormHija(object formHija)
        {
            if (this.pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirFormMateriales(object formMateriales)
        {
            if (this.pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form fh = formMateriales as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirFormCatalogo(object formCatalogo)
        {
            if (this.pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form fh = formCatalogo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormTiempo(object formTiempo)
        {
            if (this.pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form fh = formTiempo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirFormHerramientas(object formHerramientas)
        {
            if (this.pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form fh = formHerramientas as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }
    }
}
