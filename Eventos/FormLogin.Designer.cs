namespace Eventos
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label comtraseñaLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fiestasDataSet1 = new Eventos.FiestasDataSet1();
            this.usuariosTableAdapter = new Eventos.FiestasDataSet1TableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Eventos.FiestasDataSet1TableAdapters.TableAdapterManager();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            usuarioLabel = new System.Windows.Forms.Label();
            comtraseñaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(82, 48);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(68, 17);
            usuarioLabel.TabIndex = 7;
            usuarioLabel.Text = "Usuario:";
            // 
            // comtraseñaLabel
            // 
            comtraseñaLabel.AutoSize = true;
            comtraseñaLabel.Location = new System.Drawing.Point(82, 100);
            comtraseñaLabel.Name = "comtraseñaLabel";
            comtraseñaLabel.Size = new System.Drawing.Size(92, 17);
            comtraseñaLabel.TabIndex = 9;
            comtraseñaLabel.Text = "Comtraseña:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.fiestasDataSet1;
            // 
            // fiestasDataSet1
            // 
            this.fiestasDataSet1.DataSetName = "FiestasDataSet1";
            this.fiestasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComidaTableAdapter = null;
            this.tableAdapterManager.Equipo_de_SonidoTableAdapter = null;
            this.tableAdapterManager.Inventaria_de_MesasTableAdapter = null;
            this.tableAdapterManager.Inventario_de_MantelesTableAdapter = null;
            this.tableAdapterManager.Inventario_de_SillasTableAdapter = null;
            this.tableAdapterManager.SalonesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Eventos.FiestasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.Txt_usuario.Location = new System.Drawing.Point(180, 45);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(194, 24);
            this.Txt_usuario.TabIndex = 8;
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Comtraseña", true));
            this.Txt_contraseña.Location = new System.Drawing.Point(180, 97);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.PasswordChar = '*';
            this.Txt_contraseña.Size = new System.Drawing.Size(194, 24);
            this.Txt_contraseña.TabIndex = 10;
            this.Txt_contraseña.TextChanged += new System.EventHandler(this.comtraseñaTextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(235, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Mostras Contraseña";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventos.Properties.Resources.proteccion_datos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 291);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(comtraseñaLabel);
            this.Controls.Add(this.Txt_contraseña);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                      Ingresar al Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FiestasDataSet1 fiestasDataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private FiestasDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private FiestasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

