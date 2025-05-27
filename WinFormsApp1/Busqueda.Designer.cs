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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(636, 59);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 20);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top;
            txtBusqueda.BackColor = Color.FromArgb(80, 94, 129);
            txtBusqueda.BorderStyle = BorderStyle.None;
            txtBusqueda.Location = new Point(31, 63);
            txtBusqueda.Margin = new Padding(4, 3, 4, 3);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(597, 16);
            txtBusqueda.TabIndex = 4;
            txtBusqueda.KeyPress += textBox1_KeyPress;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.SteelBlue;
            dgvProductos.Location = new Point(31, 89);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.Size = new Size(645, 401);
            dgvProductos.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.BackColor = Color.FromArgb(42, 50, 150);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(274, 496);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 43);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Cooper Black", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(31, 27);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(626, 29);
            Titulo.TabIndex = 8;
            Titulo.Text = "Los mejores descuentos en calzado para Hombres";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(644, 496);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(31, 26);
            btnReset.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReset.TabIndex = 9;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 513);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Anchor = AnchorStyles.Top;
            nudCantidad.BackColor = Color.FromArgb(80, 94, 129);
            nudCantidad.BorderStyle = BorderStyle.FixedSingle;
            nudCantidad.ForeColor = Color.White;
            nudCantidad.Location = new Point(119, 510);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(88, 23);
            nudCantidad.TabIndex = 11;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Tienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(700, 560);
            Controls.Add(nudCantidad);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(Titulo);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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