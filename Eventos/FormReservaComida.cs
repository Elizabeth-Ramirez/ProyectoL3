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
    public partial class FormReservaComida : Form
    {
        public FormReservaComida()
        {
            InitializeComponent();
        }

        private void comidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasDataSet1);

        }

        private void FormReservaComida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet1.Comida' Puede moverla o quitarla según sea necesario.
            this.comidaTableAdapter.Fill(this.fiestasDataSet1.Comida);

        }
    }
}
