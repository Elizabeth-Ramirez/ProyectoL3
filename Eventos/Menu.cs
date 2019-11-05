using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTamañomesas = new FormTamañomesas();
            formTamañomesas.MdiParent = this;
            formTamañomesas.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();


        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formColoresManteles = new FormColoresManteles();
            formColoresManteles.MdiParent = this;
            formColoresManteles.Show();
        }

        private void tamañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTamañosManteles = new FormTamañosManteles();
            formTamañosManteles.MdiParent = this;
            formTamañosManteles.Show();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTipoManteles = new FormTipoManteles();
            formTipoManteles.MdiParent = this;
            formTipoManteles.Show();
        }

        private void formaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFormaMesas = new FormFormaMesas();
            formFormaMesas.MdiParent = this;
            formFormaMesas.Show();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMaterialMesas = new FormMaterialMesas();
            formMaterialMesas.MdiParent = this;
            formMaterialMesas.Show();
        }

        private void cantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCantidadmesas = new FormCantidadmesas();
            formCantidadmesas.MdiParent = this;
            formCantidadmesas.Show();
        }

        private void materialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formMaterialSillas = new FormMaterialSillas();
            formMaterialSillas.MdiParent = this;
            formMaterialSillas.Show();
        }

        private void tamañoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formTamañoSillas = new FormTamañoSillas();
            formTamañoSillas.MdiParent = this;
            formTamañoSillas.Show();
        }

        private void restaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formComida = new FormComida();
            formComida.MdiParent = this;
            formComida.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salonesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReservaSalones= new FormReservaSalones();
            formReservaSalones.MdiParent = this;
            formReservaSalones.Show();
        }

        private void sillasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReservaSillas= new FormReservaSillas();
            formReservaSillas.MdiParent = this;
            formReservaSillas.Show();
        }

        private void mesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReservaMesas = new FormReservaMesas();
            formReservaMesas.MdiParent = this;
            formReservaMesas.Show();
        }

        private void comidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReservaComida = new FormReservaComida();
            formReservaComida.MdiParent = this;
            formReservaComida.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReservasRealizadas = new FormReservasRealizadas();
            formReservasRealizadas.MdiParent = this;
            formReservasRealizadas.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRegistar = new Registro();
            formRegistar.MdiParent = this;
            formRegistar.Show();
        }

       

        private void politicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPoliticas = new Politicas();
            formPoliticas.MdiParent = this;
            formPoliticas.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
