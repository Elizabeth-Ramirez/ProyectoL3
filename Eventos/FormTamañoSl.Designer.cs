namespace Eventos
{
    partial class FormTamañoSillas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tamañoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTamañoSillas));
            this.fiestasDataSet1 = new Eventos.FiestasDataSet1();
            this.inventario_de_SillasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventario_de_SillasTableAdapter = new Eventos.FiestasDataSet1TableAdapters.Inventario_de_SillasTableAdapter();
            this.tableAdapterManager = new Eventos.FiestasDataSet1TableAdapters.TableAdapterManager();
            this.inventario_de_SillasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventario_de_SillasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tamañoComboBox = new System.Windows.Forms.ComboBox();
            tamañoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_SillasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_SillasBindingNavigator)).BeginInit();
            this.inventario_de_SillasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tamañoLabel
            // 
            tamañoLabel.AutoSize = true;
            tamañoLabel.Location = new System.Drawing.Point(57, 82);
            tamañoLabel.Name = "tamañoLabel";
            tamañoLabel.Size = new System.Drawing.Size(49, 13);
            tamañoLabel.TabIndex = 2;
            tamañoLabel.Text = "Tamaño:";
            // 
            // fiestasDataSet1
            // 
            this.fiestasDataSet1.DataSetName = "FiestasDataSet1";
            this.fiestasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventario_de_SillasBindingSource
            // 
            this.inventario_de_SillasBindingSource.DataMember = "Inventario de Sillas";
            this.inventario_de_SillasBindingSource.DataSource = this.fiestasDataSet1;
            // 
            // inventario_de_SillasTableAdapter
            // 
            this.inventario_de_SillasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComidaTableAdapter = null;
            this.tableAdapterManager.Equipo_de_SonidoTableAdapter = null;
            this.tableAdapterManager.Inventaria_de_MesasTableAdapter = null;
            this.tableAdapterManager.Inventario_de_MantelesTableAdapter = null;
            this.tableAdapterManager.Inventario_de_SillasTableAdapter = this.inventario_de_SillasTableAdapter;
            this.tableAdapterManager.SalonesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Eventos.FiestasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // inventario_de_SillasBindingNavigator
            // 
            this.inventario_de_SillasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventario_de_SillasBindingNavigator.BindingSource = this.inventario_de_SillasBindingSource;
            this.inventario_de_SillasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventario_de_SillasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventario_de_SillasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inventario_de_SillasBindingNavigatorSaveItem,
            this.toolStripDropDownButton1});
            this.inventario_de_SillasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventario_de_SillasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventario_de_SillasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventario_de_SillasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventario_de_SillasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventario_de_SillasBindingNavigator.Name = "inventario_de_SillasBindingNavigator";
            this.inventario_de_SillasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventario_de_SillasBindingNavigator.Size = new System.Drawing.Size(601, 25);
            this.inventario_de_SillasBindingNavigator.TabIndex = 0;
            this.inventario_de_SillasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // inventario_de_SillasBindingNavigatorSaveItem
            // 
            this.inventario_de_SillasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventario_de_SillasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventario_de_SillasBindingNavigatorSaveItem.Image")));
            this.inventario_de_SillasBindingNavigatorSaveItem.Name = "inventario_de_SillasBindingNavigatorSaveItem";
            this.inventario_de_SillasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventario_de_SillasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.inventario_de_SillasBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventario_de_SillasBindingNavigatorSaveItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tamañoComboBox
            // 
            this.tamañoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario_de_SillasBindingSource, "Tamaño", true));
            this.tamañoComboBox.FormattingEnabled = true;
            this.tamañoComboBox.Items.AddRange(new object[] {
            "Grandes",
            "Medianas",
            "Pequeñass"});
            this.tamañoComboBox.Location = new System.Drawing.Point(112, 79);
            this.tamañoComboBox.Name = "tamañoComboBox";
            this.tamañoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tamañoComboBox.TabIndex = 3;
            // 
            // FormTamañoSillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 274);
            this.Controls.Add(tamañoLabel);
            this.Controls.Add(this.tamañoComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inventario_de_SillasBindingNavigator);
            this.Name = "FormTamañoSillas";
            this.Text = "       Tamaño De Sillas";
            this.Load += new System.EventHandler(this.FormTamañoSillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_SillasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_SillasBindingNavigator)).EndInit();
            this.inventario_de_SillasBindingNavigator.ResumeLayout(false);
            this.inventario_de_SillasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FiestasDataSet1 fiestasDataSet1;
        private System.Windows.Forms.BindingSource inventario_de_SillasBindingSource;
        private FiestasDataSet1TableAdapters.Inventario_de_SillasTableAdapter inventario_de_SillasTableAdapter;
        private FiestasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventario_de_SillasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inventario_de_SillasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tamañoComboBox;
    }
}