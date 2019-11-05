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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasDataSet2);

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet2.Registro' Puede moverla o quitarla según sea necesario.
            this.registroTableAdapter.Fill(this.fiestasDataSet2.Registro);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
