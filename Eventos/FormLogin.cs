
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fiestasDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contraseña;
            Usuario = Txt_usuario.Text;
            Contraseña = Txt_contraseña.Text;


            //evaluando que la contraseña y usuario sean correctos
            if (Usuario == "Ana" || Contraseña == "1234")
            {
                this.Close();
            }
            else if (Usuario == "Reyna" || Contraseña == "4321")
                {
                    this.Close();

                }

                else
                {
                    //en caso que la contraseña sea erronea mostrara un mensaje
                    //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                    MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error");
                }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var registro = new Registro();
            registro.Show();
        }

        private void comtraseñaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

