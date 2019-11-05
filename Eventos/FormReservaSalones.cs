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
    public partial class FormReservaSalones : Form
    {
        public FormReservaSalones()
        {
            InitializeComponent();
        }

        private void salonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasDataSet1);

        }

        private void FormReservaSalones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet1.Salones' Puede moverla o quitarla según sea necesario.
            this.salonesTableAdapter.Fill(this.fiestasDataSet1.Salones);

        }
    }
}
