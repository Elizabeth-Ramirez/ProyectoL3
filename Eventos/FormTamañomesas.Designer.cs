namespace Eventos
{
    partial class FormTamañomesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTamañomesas));
            System.Windows.Forms.Label tamañoLabel;
            this.fiestasDataSet1 = new Eventos.FiestasDataSet1();
            this.inventaria_de_MesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventaria_de_MesasTableAdapter = new Eventos.FiestasDataSet1TableAdapters.Inventaria_de_MesasTableAdapter();
            this.tableAdapterManager = new Eventos.FiestasDataSet1TableAdapters.TableAdapterManager();
            this.inventaria_de_MesasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.inventaria_de_MesasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tamañoComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            tamañoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaria_de_MesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaria_de_MesasBindingNavigator)).BeginInit();
            this.inventaria_de_MesasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fiestasDataSet1
            // 
            this.fiestasDataSet1.DataSetName = "FiestasDataSet1";
            this.fiestasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventaria_de_MesasBindingSource
            // 
            this.inventaria_de_MesasBindingSource.DataMember = "Inventaria de Mesas";
            this.inventaria_de_MesasBindingSource.DataSource = this.fiestasDataSet1;
            // 
            // inventaria_de_MesasTableAdapter
            // 
            this.inventaria_de_MesasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComidaTableAdapter = null;
            this.tableAdapterManager.Equipo_de_SonidoTableAdapter = null;
            this.tableAdapterManager.Inventaria_de_MesasTableAdapter = this.inventaria_de_MesasTableAdapter;
            this.tableAdapterManager.Inventario_de_MantelesTableAdapter = null;
            this.tableAdapterManager.Inventario_de_SillasTableAdapter = null;
            this.tableAdapterManager.SalonesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Eventos.FiestasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // inventaria_de_MesasBindingNavigator
            // 
            this.inventaria_de_MesasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventaria_de_MesasBindingNavigator.BindingSource = this.inventaria_de_MesasBindingSource;
            this.inventaria_de_MesasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventaria_de_MesasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventaria_de_MesasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventaria_de_MesasBindingNavigatorSaveItem});
            this.inventaria_de_MesasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventaria_de_MesasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventaria_de_MesasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventaria_de_MesasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventaria_de_MesasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventaria_de_MesasBindingNavigator.Name = "inventaria_de_MesasBindingNavigator";
            this.inventaria_de_MesasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventaria_de_MesasBindingNavigator.Size = new System.Drawing.Size(497, 25);
            this.inventaria_de_MesasBindingNavigator.TabIndex = 0;
            this.inventaria_de_MesasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // inventaria_de_MesasBindingNavigatorSaveItem
            // 
            this.inventaria_de_MesasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventaria_de_MesasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventaria_de_MesasBindingNavigatorSaveItem.Image")));
            this.inventaria_de_MesasBindingNavigatorSaveItem.Name = "inventaria_de_MesasBindingNavigatorSaveItem";
            this.inventaria_de_MesasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.inventaria_de_MesasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.inventaria_de_MesasBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventaria_de_MesasBindingNavigatorSaveItem_Click);
            // 
            // tamañoLabel
            // 
            tamañoLabel.AutoSize = true;
            tamañoLabel.Location = new System.Drawing.Point(12, 74);
            tamañoLabel.Name = "tamañoLabel";
            tamañoLabel.Size = new System.Drawing.Size(49, 13);
            tamañoLabel.TabIndex = 1;
            tamañoLabel.Text = "Tamaño:";
            // 
            // tamañoComboBox
            // 
            this.tamañoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventaria_de_MesasBindingSource, "Tamaño", true));
            this.tamañoComboBox.FormattingEnabled = true;
            this.tamañoComboBox.Items.AddRange(new object[] {
            "Grandes",
            "Medianas",
            "Pequeñas"});
            this.tamañoComboBox.Location = new System.Drawing.Point(67, 71);
            this.tamañoComboBox.Name = "tamañoComboBox";
            this.tamañoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tamañoComboBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormTamañomesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(tamañoLabel);
            this.Controls.Add(this.tamañoComboBox);
            this.Controls.Add(this.inventaria_de_MesasBindingNavigator);
            this.Name = "FormTamañomesas";
            this.Text = "         Tamaño De Mesas";
            this.Load += new System.EventHandler(this.FormTamañomesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaria_de_MesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaria_de_MesasBindingNavigator)).EndInit();
            this.inventaria_de_MesasBindingNavigator.ResumeLayout(false);
            this.inventaria_de_MesasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FiestasDataSet1 fiestasDataSet1;
        private System.Windows.Forms.BindingSource inventaria_de_MesasBindingSource;
        private FiestasDataSet1TableAdapters.Inventaria_de_MesasTableAdapter inventaria_de_MesasTableAdapter;
        private FiestasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventaria_de_MesasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inventaria_de_MesasBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox tamañoComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}