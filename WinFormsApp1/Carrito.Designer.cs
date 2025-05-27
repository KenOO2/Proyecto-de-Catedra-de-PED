namespace Vista
{
    partial class Carrito
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvCarrito = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTarjeta = new TextBox();
            txtCVV = new TextBox();
            label9 = new Label();
            txtCaducidad = new TextBox();
            lblSubtotal = new Label();
            lblDescuentos = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(301, 27);
            label1.Name = "label1";
            label1.Size = new Size(189, 39);
            label1.TabIndex = 0;
            label1.Text = "Mi carrito";
            // 
            // dgvCarrito
            // 
            dgvCarrito.Anchor = AnchorStyles.Top;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvCarrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = Color.SteelBlue;
            dgvCarrito.Location = new Point(14, 88);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCarrito.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCarrito.Size = new Size(774, 345);
            dgvCarrito.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(42, 50, 150);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 441);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 59);
            button1.TabIndex = 2;
            button1.Text = "Concluir  pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(509, 623);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Total a pagar :";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = Color.FromArgb(42, 50, 150);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(601, 441);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(187, 59);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top;
            btnLimpiar.BackColor = Color.FromArgb(42, 50, 150);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 12F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(301, 441);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(187, 59);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar carrito";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(509, 545);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Sub Total:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(509, 584);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 8;
            label4.Text = "Total Descuentos:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 545);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 584);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Direccion:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 623);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 13;
            label7.Text = "N. Tarjeta:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 661);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 14;
            label8.Text = "CVV:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.FromArgb(80, 94, 129);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Century Gothic", 9F);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(107, 535);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 26);
            txtNombre.TabIndex = 15;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top;
            txtDireccion.BackColor = Color.FromArgb(80, 94, 129);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Century Gothic", 9F);
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(107, 578);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(160, 26);
            txtDireccion.TabIndex = 16;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Anchor = AnchorStyles.Top;
            txtTarjeta.BackColor = Color.FromArgb(80, 94, 129);
            txtTarjeta.BorderStyle = BorderStyle.FixedSingle;
            txtTarjeta.Font = new Font("Century Gothic", 9F);
            txtTarjeta.ForeColor = Color.White;
            txtTarjeta.Location = new Point(107, 617);
            txtTarjeta.Margin = new Padding(3, 4, 3, 4);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(160, 26);
            txtTarjeta.TabIndex = 17;
            txtTarjeta.KeyPress += txtTarjeta_KeyPress;
            // 
            // txtCVV
            // 
            txtCVV.Anchor = AnchorStyles.Top;
            txtCVV.BackColor = Color.FromArgb(80, 94, 129);
            txtCVV.BorderStyle = BorderStyle.FixedSingle;
            txtCVV.Font = new Font("Century Gothic", 9F);
            txtCVV.ForeColor = Color.White;
            txtCVV.Location = new Point(107, 653);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(160, 26);
            txtCVV.TabIndex = 18;
            txtCVV.KeyPress += txtCVV_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(14, 697);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 19;
            label9.Text = "Vence:";
            // 
            // txtCaducidad
            // 
            txtCaducidad.Anchor = AnchorStyles.Top;
            txtCaducidad.BackColor = Color.FromArgb(80, 94, 129);
            txtCaducidad.BorderStyle = BorderStyle.FixedSingle;
            txtCaducidad.Font = new Font("Century Gothic", 9F);
            txtCaducidad.ForeColor = Color.White;
            txtCaducidad.Location = new Point(107, 691);
            txtCaducidad.Margin = new Padding(3, 4, 3, 4);
            txtCaducidad.Name = "txtCaducidad";
            txtCaducidad.Size = new Size(160, 26);
            txtCaducidad.TabIndex = 20;
            txtCaducidad.Text = "MM/YYYY";
            txtCaducidad.Click += txtCaducidad_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Century Gothic", 9F);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(701, 545);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(21, 20);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "...";
            // 
            // lblDescuentos
            // 
            lblDescuentos.Anchor = AnchorStyles.Top;
            lblDescuentos.AutoSize = true;
            lblDescuentos.Font = new Font("Century Gothic", 9F);
            lblDescuentos.ForeColor = Color.White;
            lblDescuentos.Location = new Point(701, 584);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(21, 20);
            lblDescuentos.TabIndex = 22;
            lblDescuentos.Text = "...";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 9F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(701, 623);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 20);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "...";
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 747);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuentos);
            Controls.Add(lblSubtotal);
            Controls.Add(txtCaducidad);
            Controls.Add(label9);
            Controls.Add(txtCVV);
            Controls.Add(txtTarjeta);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dgvCarrito);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carrito";
            Text = "Carrito";
            Load += Carrito_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCarrito;
        private Button button1;
        private Label label2;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTarjeta;
        private TextBox txtCVV;
        private Label label9;
        private TextBox txtCaducidad;
        private Label lblSubtotal;
        private Label lblDescuentos;
        private Label lblTotal;
    }
}