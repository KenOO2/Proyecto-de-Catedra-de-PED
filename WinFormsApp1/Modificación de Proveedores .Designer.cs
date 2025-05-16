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
            label1.Location = new Point(15, 101);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top;
            txtname.BackColor = Color.BlanchedAlmond;
            txtname.Location = new Point(15, 131);
            txtname.Margin = new Padding(5, 5, 5, 5);
            txtname.Name = "txtname";
            txtname.Size = new Size(132, 27);
            txtname.TabIndex = 1;
            // 
            // btnagg
            // 
            btnagg.Anchor = AnchorStyles.Top;
            btnagg.BackColor = Color.Sienna;
            btnagg.FlatAppearance.BorderSize = 0;
            btnagg.FlatStyle = FlatStyle.Flat;
            btnagg.Location = new Point(362, 425);
            btnagg.Margin = new Padding(5, 5, 5, 5);
            btnagg.Name = "btnagg";
            btnagg.Size = new Size(137, 53);
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
            btnvolver.Location = new Point(603, 425);
            btnvolver.Margin = new Padding(5, 5, 5, 5);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(137, 53);
            btnvolver.TabIndex = 4;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // txttelefono
            // 
            txttelefono.BackColor = Color.BlanchedAlmond;
            txttelefono.Location = new Point(131, 127);
            txttelefono.Margin = new Padding(5, 5, 5, 5);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(132, 27);
            txttelefono.TabIndex = 6;
            txttelefono.KeyPress += txttelefono_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 131);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Telefono: ";
            // 
            // txtidprove
            // 
            txtidprove.Anchor = AnchorStyles.Top;
            txtidprove.BackColor = Color.BlanchedAlmond;
            txtidprove.Location = new Point(15, 247);
            txtidprove.Margin = new Padding(5, 5, 5, 5);
            txtidprove.Name = "txtidprove";
            txtidprove.Size = new Size(132, 27);
            txtidprove.TabIndex = 8;
            txtidprove.KeyPress += txtidprove_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(15, 205);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "ID del Proveedor";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.BlanchedAlmond;
            txtemail.Location = new Point(131, 51);
            txtemail.Margin = new Padding(5, 5, 5, 5);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(132, 27);
            txtemail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 51);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // txtiva
            // 
            txtiva.Anchor = AnchorStyles.Top;
            txtiva.BackColor = Color.BlanchedAlmond;
            txtiva.Location = new Point(15, 353);
            txtiva.Margin = new Padding(5, 5, 5, 5);
            txtiva.MaxLength = 5;
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(132, 27);
            txtiva.TabIndex = 12;
            txtiva.KeyPress += txtiva_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(15, 316);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 11;
            label5.Text = "IVA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 20.25F, FontStyle.Bold);
            label6.Location = new Point(137, 28);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(512, 45);
            label6.TabIndex = 13;
            label6.Text = "GESTION DE PROVEEDORES";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Location = new Point(335, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 244);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto";
            // 
            // Modificación_de_Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 747);
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
            Margin = new Padding(5, 5, 5, 5);
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