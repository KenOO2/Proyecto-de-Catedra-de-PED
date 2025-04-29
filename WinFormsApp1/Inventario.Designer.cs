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
            BtnDescuento = new Button();
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
            dataGridView1.Location = new Point(9, 208);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 339);
            dataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnAgregar.BackColor = Color.Sienna;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.Black;
            BtnAgregar.Location = new Point(440, 77);
            BtnAgregar.Margin = new Padding(4, 3, 4, 3);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(120, 40);
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
            BtnEditar.Location = new Point(568, 77);
            BtnEditar.Margin = new Padding(4, 3, 4, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(120, 40);
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
            BtnEliminar.Location = new Point(440, 146);
            BtnEliminar.Margin = new Padding(4, 3, 4, 3);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(120, 40);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar ";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnDescuento
            // 
            BtnDescuento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnDescuento.BackColor = Color.Sienna;
            BtnDescuento.FlatAppearance.BorderSize = 0;
            BtnDescuento.FlatStyle = FlatStyle.Flat;
            BtnDescuento.Location = new Point(568, 146);
            BtnDescuento.Margin = new Padding(4, 3, 4, 3);
            BtnDescuento.Name = "BtnDescuento";
            BtnDescuento.Size = new Size(120, 40);
            BtnDescuento.TabIndex = 4;
            BtnDescuento.Text = "Editar Descuento";
            BtnDescuento.UseVisualStyleBackColor = false;
            BtnDescuento.Click += BtnDescuento_Click;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDProducto.BackColor = Color.BlanchedAlmond;
            txtIDProducto.Location = new Point(8, 98);
            txtIDProducto.Margin = new Padding(4, 3, 4, 3);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(111, 23);
            txtIDProducto.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(9, 77);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 6;
            label1.Text = "Id del producto:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(140, 77);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(9, 138);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 8;
            label3.Text = "Id del proveedor:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(140, 138);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(288, 138);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Descuento";
            // 
            // txtNomProducto
            // 
            txtNomProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomProducto.BackColor = Color.BlanchedAlmond;
            txtNomProducto.Location = new Point(140, 98);
            txtNomProducto.Margin = new Padding(4, 3, 4, 3);
            txtNomProducto.Name = "txtNomProducto";
            txtNomProducto.Size = new Size(271, 23);
            txtNomProducto.TabIndex = 11;
            // 
            // txtIDprovee
            // 
            txtIDprovee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDprovee.BackColor = Color.BlanchedAlmond;
            txtIDprovee.Location = new Point(9, 156);
            txtIDprovee.Margin = new Padding(4, 3, 4, 3);
            txtIDprovee.Name = "txtIDprovee";
            txtIDprovee.Size = new Size(111, 23);
            txtIDprovee.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.BackColor = Color.BlanchedAlmond;
            txtPrecio.Location = new Point(140, 156);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(119, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescuento.BackColor = Color.BlanchedAlmond;
            txtDescuento.Location = new Point(288, 156);
            txtDescuento.Margin = new Padding(4, 3, 4, 3);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(123, 23);
            txtDescuento.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNomProducto);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BtnDescuento);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 560);
            panel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(236, 9);
            label6.Name = "label6";
            label6.Size = new Size(191, 34);
            label6.TabIndex = 15;
            label6.Text = "INVENTARIO";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(700, 560);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Button BtnDescuento;
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
    }
}