namespace proyecto
{
    partial class Tienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tienda));
            btnBuscar = new Button();
            txtBusqueda = new TextBox();
            dgvProductos = new DataGridView();
            btnAgregar = new Button();
            Titulo = new Label();
            btnReset = new PictureBox();
            label1 = new Label();
            nudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Sienna;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(727, 79);
            btnBuscar.Margin = new Padding(5, 4, 5, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(45, 27);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.BlanchedAlmond;
            txtBusqueda.Location = new Point(35, 79);
            txtBusqueda.Margin = new Padding(5, 4, 5, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(682, 27);
            txtBusqueda.TabIndex = 4;
            txtBusqueda.KeyPress += textBox1_KeyPress;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(35, 119);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(737, 520);
            dgvProductos.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(312, 647);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(224, 68);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(103, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(595, 38);
            Titulo.TabIndex = 8;
            Titulo.Text = "Los mejores descuentos en calzado para Hombres";
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(737, 646);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(35, 35);
            btnReset.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReset.TabIndex = 9;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 661);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 10;
            label1.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(113, 659);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 27);
            nudCantidad.TabIndex = 11;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Tienda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 747);
            Controls.Add(nudCantidad);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(Titulo);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Tienda";
            Text = "Modificacion__inventario";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private DataGridView dgvProductos;
        private Button btnAgregar;
        private Label Titulo;
        private PictureBox btnReset;
        private Label label1;
        private NumericUpDown nudCantidad;
    }
}