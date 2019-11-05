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
    public partial class FormMaterialSillas : Form
    {
        public FormMaterialSillas()
        {
            InitializeComponent();
        }

        private void inventario_de_SillasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventario_de_SillasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasDataSet1);

        }

        private void FormMaterialSillas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet1.Inventario_de_Sillas' Puede moverla o quitarla según sea necesario.
            this.inventario_de_SillasTableAdapter.Fill(this.fiestasDataSet1.Inventario_de_Sillas);

        }
    }
}
