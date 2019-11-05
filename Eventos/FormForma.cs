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
    public partial class FormFormaMesas : Form
    {
        public FormFormaMesas()
        {
            InitializeComponent();
        }

        private void FormFormaMesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet3.Inventaria_de_Mesas' Puede moverla o quitarla según sea necesario.
            this.inventaria_de_MesasTableAdapter.Fill(this.fiestasDataSet3.Inventaria_de_Mesas);

        }
    }
}
