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
    public partial class FormColoresManteles : Form
    {
        public FormColoresManteles()
        {
            InitializeComponent();
        }

        private void inventario_de_MantelesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventario_de_MantelesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasDataSet1);

        }

        private void FormColoresManteles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet1.Inventario_de_Manteles' Puede moverla o quitarla según sea necesario.
            this.inventario_de_MantelesTableAdapter.Fill(this.fiestasDataSet1.Inventario_de_Manteles);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventario_de_MantelesTableAdapter.FillBy(this.fiestasDataSet1.Inventario_de_Manteles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
