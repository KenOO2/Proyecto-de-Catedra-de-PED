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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtStock = new TextBox();
            label7 = new Label();
            txtBuscar = new TextBox();
            label = new Label();
            BtnActualizar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.Location = new Point(13, 271);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(679, 277);
            dataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top;
            BtnAgregar.BackColor = Color.FromArgb(42, 50, 150);
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.FlatAppearance.BorderColor = Color.White;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Century Gothic", 12F);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(450, 117);
            BtnAgregar.Margin = new Padding(4, 3, 4, 3);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(120, 35);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar Producto";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top;
            BtnEditar.BackColor = Color.FromArgb(42, 50, 150);
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatAppearance.BorderColor = Color.White;
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Font = new Font("Century Gothic", 12F);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(572, 117);
            BtnEditar.Margin = new Padding(4, 3, 4, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(120, 35);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar ";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top;
            BtnEliminar.BackColor = Color.FromArgb(42, 50, 150);
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.FlatAppearance.BorderColor = Color.White;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Century Gothic", 12F);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(450, 170);
            BtnEliminar.Margin = new Padding(4, 3, 4, 3);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(120, 38);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar ";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top;
            BtnBuscar.BackColor = Color.FromArgb(42, 50, 150);
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatAppearance.BorderColor = Color.White;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Century Gothic", 12F);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(450, 224);
            BtnBuscar.Margin = new Padding(4, 3, 4, 3);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(242, 31);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Anchor = AnchorStyles.Top;
            txtIDProducto.BackColor = Color.FromArgb(80, 94, 129);
            txtIDProducto.BorderStyle = BorderStyle.None;
            txtIDProducto.Font = new Font("Century Gothic", 11.25F);
            txtIDProducto.ForeColor = Color.White;
            txtIDProducto.Location = new Point(13, 117);
            txtIDProducto.Margin = new Padding(4, 3, 4, 3);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(139, 19);
            txtIDProducto.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 94);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 6;
            label1.Text = "Id del producto:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 94);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 8;
            label3.Text = "Id del proveedor:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(174, 157);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(267, 157);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "Descuento";
            // 
            // txtNomProducto
            // 
            txtNomProducto.Anchor = AnchorStyles.Top;
            txtNomProducto.BackColor = Color.FromArgb(80, 94, 129);
            txtNomProducto.BorderStyle = BorderStyle.None;
            txtNomProducto.Font = new Font("Century Gothic", 11.25F);
            txtNomProducto.ForeColor = Color.White;
            txtNomProducto.Location = new Point(174, 117);
            txtNomProducto.Margin = new Padding(4, 3, 4, 3);
            txtNomProducto.Name = "txtNomProducto";
            txtNomProducto.Size = new Size(268, 19);
            txtNomProducto.TabIndex = 11;
            // 
            // txtIDprovee
            // 
            txtIDprovee.Anchor = AnchorStyles.Top;
            txtIDprovee.BackColor = Color.FromArgb(80, 94, 129);
            txtIDprovee.BorderStyle = BorderStyle.None;
            txtIDprovee.Font = new Font("Century Gothic", 11.25F);
            txtIDprovee.ForeColor = Color.White;
            txtIDprovee.Location = new Point(13, 181);
            txtIDprovee.Margin = new Padding(4, 3, 4, 3);
            txtIDprovee.Name = "txtIDprovee";
            txtIDprovee.Size = new Size(139, 19);
            txtIDprovee.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top;
            txtPrecio.BackColor = Color.FromArgb(80, 94, 129);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Century Gothic", 11.25F);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(174, 181);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(85, 19);
            txtPrecio.TabIndex = 13;
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.Top;
            txtDescuento.BackColor = Color.FromArgb(80, 94, 129);
            txtDescuento.BorderStyle = BorderStyle.None;
            txtDescuento.Font = new Font("Century Gothic", 11.25F);
            txtDescuento.ForeColor = Color.White;
            txtDescuento.Location = new Point(267, 181);
            txtDescuento.Margin = new Padding(4, 3, 4, 3);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(89, 19);
            txtDescuento.TabIndex = 14;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top;
            txtStock.BackColor = Color.FromArgb(80, 94, 129);
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Font = new Font("Century Gothic", 11.25F);
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(364, 181);
            txtStock.Margin = new Padding(4, 3, 4, 3);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(78, 19);
            txtStock.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(373, 157);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 19;
            label7.Text = "Stock";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.BackColor = Color.FromArgb(80, 94, 129);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Century Gothic", 11.25F);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(13, 236);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(429, 19);
            txtBuscar.TabIndex = 18;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top;
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 11.25F);
            label.ForeColor = Color.White;
            label.Location = new Point(13, 214);
            label.Name = "label";
            label.Size = new Size(134, 20);
            label.TabIndex = 17;
            label.Text = "Buscar Producto:";
            // 
            // BtnActualizar
            // 
            BtnActualizar.Anchor = AnchorStyles.Top;
            BtnActualizar.BackColor = Color.FromArgb(42, 50, 150);
            BtnActualizar.Cursor = Cursors.Hand;
            BtnActualizar.FlatAppearance.BorderColor = Color.White;
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Century Gothic", 12F);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(572, 171);
            BtnActualizar.Margin = new Padding(4, 3, 4, 3);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(120, 38);
            BtnActualizar.TabIndex = 16;
            BtnActualizar.Text = "Actualizar Vista";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(230, 32);
            label6.Name = "label6";
            label6.Size = new Size(206, 31);
            label6.TabIndex = 15;
            label6.Text = "INVENTARIO";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(700, 560);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(BtnBuscar);
            Controls.Add(txtStock);
            Controls.Add(label);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnActualizar);
            Controls.Add(txtDescuento);
            Controls.Add(txtIDProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtNomProducto);
            Controls.Add(txtIDprovee);
            Controls.Add(BtnEditar);
            Controls.Add(label3);
            Controls.Add(BtnAgregar);
            Controls.Add(label5);
            Controls.Add(BtnEliminar);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label6;
        private Button BtnActualizar;
        private TextBox txtBuscar;
        private Label label;
        private TextBox txtStock;
        private Label label7;
    }
}