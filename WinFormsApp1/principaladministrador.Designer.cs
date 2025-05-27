namespace Vista
{
    partial class principaladministrador
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principaladministrador));
            pnlcontenedor = new Panel();
            pnlcontenedorforms = new Panel();
            pictureBox2 = new PictureBox();
            pnlmenu = new Panel();
            button2 = new Button();
            pnl2 = new PictureBox();
            panel2 = new Panel();
            btnproveedores = new Button();
            panel1 = new Panel();
            btninventario = new Button();
            pnltitulo = new Panel();
            pictureBox3 = new PictureBox();
            btnrestaurar = new PictureBox();
            btnminimizar = new PictureBox();
            btnmaximizar = new PictureBox();
            btncerrar = new PictureBox();
            submenuad = new System.Windows.Forms.Timer(components);
            pnlcontenedor.SuspendLayout();
            pnlcontenedorforms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnl2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // pnlcontenedor
            // 
            pnlcontenedor.BackColor = Color.FromArgb(45, 66, 100);
            pnlcontenedor.Controls.Add(pnlcontenedorforms);
            pnlcontenedor.Controls.Add(pnlmenu);
            pnlcontenedor.Controls.Add(pnltitulo);
            pnlcontenedor.Dock = DockStyle.Fill;
            pnlcontenedor.Location = new Point(0, 0);
            pnlcontenedor.Margin = new Padding(3, 4, 3, 4);
            pnlcontenedor.MinimumSize = new Size(1086, 800);
            pnlcontenedor.Name = "pnlcontenedor";
            pnlcontenedor.Size = new Size(1086, 800);
            pnlcontenedor.TabIndex = 0;
            // 
            // pnlcontenedorforms
            // 
            pnlcontenedorforms.BackColor = Color.SlateGray;
            pnlcontenedorforms.Controls.Add(pictureBox2);
            pnlcontenedorforms.Dock = DockStyle.Fill;
            pnlcontenedorforms.Location = new Point(286, 53);
            pnlcontenedorforms.Margin = new Padding(3, 4, 3, 4);
            pnlcontenedorforms.Name = "pnlcontenedorforms";
            pnlcontenedorforms.Size = new Size(800, 747);
            pnlcontenedorforms.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 99);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlmenu
            // 
            pnlmenu.BackColor = Color.FromArgb(42, 50, 120);
            pnlmenu.Controls.Add(button2);
            pnlmenu.Controls.Add(pnl2);
            pnlmenu.Controls.Add(panel2);
            pnlmenu.Controls.Add(panel1);
            pnlmenu.Dock = DockStyle.Left;
            pnlmenu.Location = new Point(0, 53);
            pnlmenu.Margin = new Padding(3, 4, 3, 4);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(286, 747);
            pnlmenu.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 50, 150);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 672);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(286, 75);
            button2.TabIndex = 17;
            button2.Text = "Regresar a modo usuario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnl2
            // 
            pnl2.Dock = DockStyle.Top;
            pnl2.Image = (Image)resources.GetObject("pnl2.Image");
            pnl2.Location = new Point(0, 0);
            pnl2.Margin = new Padding(3, 4, 3, 4);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(286, 121);
            pnl2.SizeMode = PictureBoxSizeMode.Zoom;
            pnl2.TabIndex = 0;
            pnl2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnproveedores);
            panel2.Location = new Point(0, 285);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 96);
            panel2.TabIndex = 1;
            // 
            // btnproveedores
            // 
            btnproveedores.BackColor = Color.FromArgb(42, 50, 150);
            btnproveedores.Cursor = Cursors.Hand;
            btnproveedores.Dock = DockStyle.Top;
            btnproveedores.FlatAppearance.BorderSize = 0;
            btnproveedores.FlatStyle = FlatStyle.Flat;
            btnproveedores.ForeColor = SystemColors.ButtonHighlight;
            btnproveedores.Image = (Image)resources.GetObject("btnproveedores.Image");
            btnproveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnproveedores.Location = new Point(0, 0);
            btnproveedores.Margin = new Padding(3, 4, 3, 4);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Padding = new Padding(11, 0, 0, 0);
            btnproveedores.Size = new Size(286, 88);
            btnproveedores.TabIndex = 15;
            btnproveedores.Text = "Proveedores";
            btnproveedores.UseVisualStyleBackColor = false;
            btnproveedores.Click += btnproveedores_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btninventario);
            panel1.Location = new Point(0, 189);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 95);
            panel1.TabIndex = 0;
            // 
            // btninventario
            // 
            btninventario.BackColor = Color.FromArgb(42, 50, 150);
            btninventario.Cursor = Cursors.Hand;
            btninventario.Dock = DockStyle.Top;
            btninventario.FlatAppearance.BorderSize = 0;
            btninventario.FlatStyle = FlatStyle.Flat;
            btninventario.ForeColor = SystemColors.ButtonHighlight;
            btninventario.Image = (Image)resources.GetObject("btninventario.Image");
            btninventario.ImageAlign = ContentAlignment.MiddleLeft;
            btninventario.Location = new Point(0, 0);
            btninventario.Margin = new Padding(3, 4, 3, 4);
            btninventario.Name = "btninventario";
            btninventario.Padding = new Padding(11, 0, 0, 0);
            btninventario.Size = new Size(286, 88);
            btninventario.TabIndex = 14;
            btninventario.Text = "Inventario";
            btninventario.UseVisualStyleBackColor = false;
            btninventario.Click += btninventario_Click_1;
            // 
            // pnltitulo
            // 
            pnltitulo.BackColor = Color.FromArgb(42, 50, 120);
            pnltitulo.Controls.Add(pictureBox3);
            pnltitulo.Controls.Add(btnrestaurar);
            pnltitulo.Controls.Add(btnminimizar);
            pnltitulo.Controls.Add(btnmaximizar);
            pnltitulo.Controls.Add(btncerrar);
            pnltitulo.Dock = DockStyle.Top;
            pnltitulo.Location = new Point(0, 0);
            pnltitulo.Margin = new Padding(3, 4, 3, 4);
            pnltitulo.Name = "pnltitulo";
            pnltitulo.Size = new Size(1086, 53);
            pnltitulo.TabIndex = 0;
            pnltitulo.MouseDown += pnltitulo_MouseDown_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 3);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnrestaurar
            // 
            btnrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnrestaurar.Cursor = Cursors.Hand;
            btnrestaurar.Image = (Image)resources.GetObject("btnrestaurar.Image");
            btnrestaurar.Location = new Point(1029, 16);
            btnrestaurar.Margin = new Padding(3, 4, 3, 4);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(18, 21);
            btnrestaurar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnrestaurar.TabIndex = 7;
            btnrestaurar.TabStop = false;
            btnrestaurar.Visible = false;
            btnrestaurar.Click += btnrestaurar_Click_1;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.Cursor = Cursors.Hand;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(1003, 16);
            btnminimizar.Margin = new Padding(3, 4, 3, 4);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(18, 21);
            btnminimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnminimizar.TabIndex = 6;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click_1;
            // 
            // btnmaximizar
            // 
            btnmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmaximizar.Image = (Image)resources.GetObject("btnmaximizar.Image");
            btnmaximizar.Location = new Point(1029, 16);
            btnmaximizar.Margin = new Padding(3, 4, 3, 4);
            btnmaximizar.Name = "btnmaximizar";
            btnmaximizar.Size = new Size(18, 21);
            btnmaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnmaximizar.TabIndex = 5;
            btnmaximizar.TabStop = false;
            btnmaximizar.Click += btnmaximizar_Click_1;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.Cursor = Cursors.Hand;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(1054, 16);
            btncerrar.Margin = new Padding(3, 4, 3, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(18, 21);
            btncerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btncerrar.TabIndex = 4;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click_1;
            // 
            // submenuad
            // 
            submenuad.Interval = 10;
            submenuad.Tick += submenuad_Tick;
            // 
            // principaladministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 800);
            Controls.Add(pnlcontenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1086, 800);
            Name = "principaladministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "principaladministrador";
            pnlcontenedor.ResumeLayout(false);
            pnlcontenedorforms.ResumeLayout(false);
            pnlcontenedorforms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl2).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnltitulo.ResumeLayout(false);
            pnltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlcontenedor;
        private Panel pnltitulo;
        private Panel pnlmenu;
        private Panel pnlcontenedorforms;
        private PictureBox btnrestaurar;
        private PictureBox btnminimizar;
        private PictureBox btnmaximizar;
        private PictureBox btncerrar;
        private PictureBox pnl2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer submenuad;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btnproveedores;
        private Panel panel1;
        private Button btninventario;
        private Button button2;
    }
}