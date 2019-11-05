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
    public partial class FormReservaMesas : Form
    {
        public FormReservaMesas()
        {
            InitializeComponent();
        }

        private void inventaria_de_MesasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventaria_de_MesasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasDataSet1);

        }

        private void FormReservaMesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet1.Inventaria_de_Mesas' Puede moverla o quitarla según sea necesario.
            this.inventaria_de_MesasTableAdapter.Fill(this.fiestasDataSet1.Inventaria_de_Mesas);

        }
    }
}
