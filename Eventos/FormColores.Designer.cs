namespace Eventos
{
    partial class FormColoresManteles
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
            System.Windows.Forms.Label colorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColoresManteles));
            this.inventario_de_MantelesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.inventario_de_MantelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fiestasDataSet1 = new Eventos.FiestasDataSet1();
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
            this.inventario_de_MantelesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inventario_de_MantelesTableAdapter = new Eventos.FiestasDataSet1TableAdapters.Inventario_de_MantelesTableAdapter();
            this.tableAdapterManager = new Eventos.FiestasDataSet1TableAdapters.TableAdapterManager();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_MantelesBindingNavigator)).BeginInit();
            this.inventario_de_MantelesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_MantelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(9, 71);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 1;
            colorLabel.Text = "Color:";
            // 
            // inventario_de_MantelesBindingNavigator
            // 
            this.inventario_de_MantelesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventario_de_MantelesBindingNavigator.BindingSource = this.inventario_de_MantelesBindingSource;
            this.inventario_de_MantelesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventario_de_MantelesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventario_de_MantelesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventario_de_MantelesBindingNavigatorSaveItem});
            this.inventario_de_MantelesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventario_de_MantelesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventario_de_MantelesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventario_de_MantelesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventario_de_MantelesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventario_de_MantelesBindingNavigator.Name = "inventario_de_MantelesBindingNavigator";
            this.inventario_de_MantelesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventario_de_MantelesBindingNavigator.Size = new System.Drawing.Size(425, 25);
            this.inventario_de_MantelesBindingNavigator.TabIndex = 0;
            this.inventario_de_MantelesBindingNavigator.Text = "bindingNavigator1";
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
            // inventario_de_MantelesBindingSource
            // 
            this.inventario_de_MantelesBindingSource.DataMember = "Inventario de Manteles";
            this.inventario_de_MantelesBindingSource.DataSource = this.fiestasDataSet1;
            // 
            // fiestasDataSet1
            // 
            this.fiestasDataSet1.DataSetName = "FiestasDataSet1";
            this.fiestasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // inventario_de_MantelesBindingNavigatorSaveItem
            // 
            this.inventario_de_MantelesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventario_de_MantelesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventario_de_MantelesBindingNavigatorSaveItem.Image")));
            this.inventario_de_MantelesBindingNavigatorSaveItem.Name = "inventario_de_MantelesBindingNavigatorSaveItem";
            this.inventario_de_MantelesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventario_de_MantelesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.inventario_de_MantelesBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventario_de_MantelesBindingNavigatorSaveItem_Click);
            // 
            // inventario_de_MantelesTableAdapter
            // 
            this.inventario_de_MantelesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComidaTableAdapter = null;
            this.tableAdapterManager.Equipo_de_SonidoTableAdapter = null;
            this.tableAdapterManager.Inventaria_de_MesasTableAdapter = null;
            this.tableAdapterManager.Inventario_de_MantelesTableAdapter = this.inventario_de_MantelesTableAdapter;
            this.tableAdapterManager.Inventario_de_SillasTableAdapter = null;
            this.tableAdapterManager.SalonesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Eventos.FiestasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Mantel.jpg");
            this.imageList1.Images.SetKeyName(1, "Mantel1.jpg");
            this.imageList1.Images.SetKeyName(2, "Mantel2.jpg");
            this.imageList1.Images.SetKeyName(3, "Mantel4.jpg");
            this.imageList1.Images.SetKeyName(4, "Mantel5.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Negros",
            "Blacos",
            "Azules"});
            this.comboBox1.Location = new System.Drawing.Point(49, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // FormColoresManteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 263);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.inventario_de_MantelesBindingNavigator);
            this.Name = "FormColoresManteles";
            this.Text = "           Colore De Manteles ";
            this.Load += new System.EventHandler(this.FormColoresManteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_MantelesBindingNavigator)).EndInit();
            this.inventario_de_MantelesBindingNavigator.ResumeLayout(false);
            this.inventario_de_MantelesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_de_MantelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FiestasDataSet1 fiestasDataSet1;
        private System.Windows.Forms.BindingSource inventario_de_MantelesBindingSource;
        private FiestasDataSet1TableAdapters.Inventario_de_MantelesTableAdapter inventario_de_MantelesTableAdapter;
        private FiestasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventario_de_MantelesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inventario_de_MantelesBindingNavigatorSaveItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}