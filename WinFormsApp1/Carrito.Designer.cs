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
            label1 = new Label();
            dgvCarrito = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            txtTotal = new TextBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtDescuentos = new TextBox();
            txtSubtotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "Mi carrito";
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(14, 71);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(774, 451);
            dgvCarrito.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(14, 530);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 59);
            button1.TabIndex = 2;
            button1.Text = "Concluir  pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 718);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Total a pagar :";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(629, 712);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(159, 27);
            txtTotal.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(601, 530);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(187, 59);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(312, 530);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(187, 59);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar carrito";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 632);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Sub Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 675);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 8;
            label4.Text = "Total Descuentos:";
            // 
            // txtDescuentos
            // 
            txtDescuentos.Enabled = false;
            txtDescuentos.Location = new Point(629, 672);
            txtDescuentos.Margin = new Padding(3, 4, 3, 4);
            txtDescuentos.Name = "txtDescuentos";
            txtDescuentos.Size = new Size(159, 27);
            txtDescuentos.TabIndex = 9;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(629, 629);
            txtSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(159, 27);
            txtSubtotal.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 593);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 11;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 629);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = "Direccion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 656);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 13;
            label7.Text = "N. Tarjeta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 687);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 14;
            label8.Text = "CVV:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 590);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 622);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 653);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 27);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 684);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 27);
            textBox5.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 719);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 19;
            label9.Text = "Vence:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(85, 716);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(159, 27);
            textBox6.TabIndex = 20;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 747);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSubtotal);
            Controls.Add(txtDescuentos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dgvCarrito);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carrito";
            Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCarrito;
        private Button button1;
        private Label label2;
        private TextBox txtTotal;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label3;
        private Label label4;
        private TextBox txtDescuentos;
        private TextBox txtSubtotal;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
    }
}