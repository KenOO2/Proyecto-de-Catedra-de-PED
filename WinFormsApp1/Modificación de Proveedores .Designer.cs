namespace proyecto
{
    partial class Modificación_de_Proveedores
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
            txtname = new TextBox();
            btnagg = new Button();
            btnvolver = new Button();
            txttelefono = new TextBox();
            label2 = new Label();
            txtidprove = new TextBox();
            label3 = new Label();
            txtemail = new TextBox();
            label4 = new Label();
            txtiva = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(13, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top;
            txtname.BackColor = Color.BlanchedAlmond;
            txtname.Location = new Point(13, 98);
            txtname.Margin = new Padding(4);
            txtname.Name = "txtname";
            txtname.Size = new Size(116, 23);
            txtname.TabIndex = 1;
            // 
            // btnagg
            // 
            btnagg.Anchor = AnchorStyles.Top;
            btnagg.BackColor = Color.Sienna;
            btnagg.FlatAppearance.BorderSize = 0;
            btnagg.FlatStyle = FlatStyle.Flat;
            btnagg.Location = new Point(317, 319);
            btnagg.Margin = new Padding(4);
            btnagg.Name = "btnagg";
            btnagg.Size = new Size(120, 40);
            btnagg.TabIndex = 3;
            btnagg.Text = "Agregar";
            btnagg.UseVisualStyleBackColor = false;
            btnagg.Click += btnagg_Click;
            // 
            // btnvolver
            // 
            btnvolver.Anchor = AnchorStyles.Top;
            btnvolver.BackColor = Color.Sienna;
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.Location = new Point(528, 319);
            btnvolver.Margin = new Padding(4);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(120, 40);
            btnvolver.TabIndex = 4;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // txttelefono
            // 
            txttelefono.BackColor = Color.BlanchedAlmond;
            txttelefono.Location = new Point(115, 95);
            txttelefono.Margin = new Padding(4);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(116, 23);
            txttelefono.TabIndex = 6;
            txttelefono.KeyPress += txttelefono_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Telefono: ";
            // 
            // txtidprove
            // 
            txtidprove.Anchor = AnchorStyles.Top;
            txtidprove.BackColor = Color.BlanchedAlmond;
            txtidprove.Location = new Point(13, 185);
            txtidprove.Margin = new Padding(4);
            txtidprove.Name = "txtidprove";
            txtidprove.Size = new Size(116, 23);
            txtidprove.TabIndex = 8;
            txtidprove.KeyPress += txtidprove_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(13, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "ID del Proveedor";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.BlanchedAlmond;
            txtemail.Location = new Point(115, 38);
            txtemail.Margin = new Padding(4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(116, 23);
            txtemail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // txtiva
            // 
            txtiva.Anchor = AnchorStyles.Top;
            txtiva.BackColor = Color.BlanchedAlmond;
            txtiva.Location = new Point(13, 265);
            txtiva.Margin = new Padding(4);
            txtiva.MaxLength = 5;
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(116, 23);
            txtiva.TabIndex = 12;
            txtiva.KeyPress += txtiva_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(13, 237);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 11;
            label5.Text = "IVA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 20.25F, FontStyle.Bold);
            label6.Location = new Point(153, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(371, 34);
            label6.TabIndex = 13;
            label6.Text = "AGREGAR PROVEEDORES";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Location = new Point(293, 98);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(354, 183);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto";
            // 
            // Modificación_de_Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(700, 560);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(txtiva);
            Controls.Add(txtname);
            Controls.Add(btnvolver);
            Controls.Add(label1);
            Controls.Add(btnagg);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtidprove);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Modificación_de_Proveedores";
            Text = "Modificación_de_Proveedores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnagg;
        private System.Windows.Forms.Button btnvolver;
        private TextBox txttelefono;
        private Label label2;
        private TextBox txtidprove;
        private Label label3;
        private TextBox txtemail;
        private Label label4;
        private TextBox txtiva;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}