namespace proyecto
{
    partial class Inventario
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
            dataGridView1 = new DataGridView();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnBuscar = new Button();
            txtIDProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomProducto = new TextBox();
            txtIDprovee = new TextBox();
            txtPrecio = new TextBox();
            txtDescuento = new TextBox();
            panel1 = new Panel();
            txtStock = new TextBox();
            label7 = new Label();
            txtBuscar = new TextBox();
            label = new Label();
            BtnActualizar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Chocolate;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 325);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 404);
            dataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnAgregar.BackColor = Color.Sienna;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.Black;
            BtnAgregar.Location = new Point(488, 103);
            BtnAgregar.Margin = new Padding(5, 4, 5, 4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(137, 47);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar Producto";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnEditar.BackColor = Color.Sienna;
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Location = new Point(635, 103);
            BtnEditar.Margin = new Padding(5, 4, 5, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(137, 47);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar ";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnEliminar.BackColor = Color.Sienna;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Location = new Point(488, 184);
            BtnEliminar.Margin = new Padding(5, 4, 5, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(137, 51);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar ";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.Sienna;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Location = new Point(488, 257);
            BtnBuscar.Margin = new Padding(5, 4, 5, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(284, 50);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDProducto.BackColor = Color.BlanchedAlmond;
            txtIDProducto.Location = new Point(9, 131);
            txtIDProducto.Margin = new Padding(5, 4, 5, 4);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(126, 27);
            txtIDProducto.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(10, 103);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 6;
            label1.Text = "Id del producto:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(160, 103);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(10, 184);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 8;
            label3.Text = "Id del proveedor:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(160, 184);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(270, 184);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 10;
            label5.Text = "Descuento";
            // 
            // txtNomProducto
            // 
            txtNomProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomProducto.BackColor = Color.BlanchedAlmond;
            txtNomProducto.Location = new Point(160, 131);
            txtNomProducto.Margin = new Padding(5, 4, 5, 4);
            txtNomProducto.Name = "txtNomProducto";
            txtNomProducto.Size = new Size(309, 27);
            txtNomProducto.TabIndex = 11;
            // 
            // txtIDprovee
            // 
            txtIDprovee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDprovee.BackColor = Color.BlanchedAlmond;
            txtIDprovee.Location = new Point(10, 208);
            txtIDprovee.Margin = new Padding(5, 4, 5, 4);
            txtIDprovee.Name = "txtIDprovee";
            txtIDprovee.Size = new Size(126, 27);
            txtIDprovee.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.BackColor = Color.BlanchedAlmond;
            txtPrecio.Location = new Point(160, 208);
            txtPrecio.Margin = new Padding(5, 4, 5, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(97, 27);
            txtPrecio.TabIndex = 13;
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescuento.BackColor = Color.BlanchedAlmond;
            txtDescuento.Location = new Point(270, 208);
            txtDescuento.Margin = new Padding(5, 4, 5, 4);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(101, 27);
            txtDescuento.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label);
            panel1.Controls.Add(BtnActualizar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNomProducto);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BtnBuscar);
            panel1.Controls.Add(txtDescuento);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(txtIDProducto);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtIDprovee);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 747);
            panel1.TabIndex = 15;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.BackColor = Color.BlanchedAlmond;
            txtStock.Location = new Point(381, 208);
            txtStock.Margin = new Padding(5, 4, 5, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(88, 27);
            txtStock.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(381, 184);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 19;
            label7.Text = "Stock";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.BlanchedAlmond;
            txtBuscar.ForeColor = SystemColors.WindowText;
            txtBuscar.Location = new Point(9, 280);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(460, 27);
            txtBuscar.TabIndex = 18;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(10, 257);
            label.Name = "label";
            label.Size = new Size(119, 20);
            label.TabIndex = 17;
            label.Text = "Buscar Producto:";
            // 
            // BtnActualizar
            // 
            BtnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnActualizar.BackColor = Color.Sienna;
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Location = new Point(635, 184);
            BtnActualizar.Margin = new Padding(5, 4, 5, 4);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(137, 51);
            BtnActualizar.TabIndex = 16;
            BtnActualizar.Text = "Actualizar Vista";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(270, 12);
            label6.Name = "label6";
            label6.Size = new Size(239, 45);
            label6.TabIndex = 15;
            label6.Text = "INVENTARIO";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 747);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtIDProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomProducto;
        private TextBox txtIDprovee;
        private TextBox txtPrecio;
        private TextBox txtDescuento;
        private Panel panel1;
        private Label label6;
        private Button BtnActualizar;
        private TextBox txtBuscar;
        private Label label;
        private TextBox txtStock;
        private Label label7;
    }
}