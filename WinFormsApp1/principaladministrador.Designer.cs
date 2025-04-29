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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principaladministrador));
            pnlcontenedor = new Panel();
            pnlcontenedorforms = new Panel();
            pictureBox2 = new PictureBox();
            pnlmenu = new Panel();
            btnproveedores = new Button();
            btninventario = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnltitulo = new Panel();
            btnrestaurar = new PictureBox();
            btnminimizar = new PictureBox();
            btnmaximizar = new PictureBox();
            btncerrar = new PictureBox();
            pnlcontenedor.SuspendLayout();
            pnlcontenedorforms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlmenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // pnlcontenedor
            // 
            pnlcontenedor.BackColor = Color.BlanchedAlmond;
            pnlcontenedor.Controls.Add(pnlcontenedorforms);
            pnlcontenedor.Controls.Add(pnlmenu);
            pnlcontenedor.Controls.Add(pnltitulo);
            pnlcontenedor.Dock = DockStyle.Fill;
            pnlcontenedor.Location = new Point(0, 0);
            pnlcontenedor.MinimumSize = new Size(950, 600);
            pnlcontenedor.Name = "pnlcontenedor";
            pnlcontenedor.Size = new Size(950, 600);
            pnlcontenedor.TabIndex = 0;
            // 
            // pnlcontenedorforms
            // 
            pnlcontenedorforms.Controls.Add(pictureBox2);
            pnlcontenedorforms.Dock = DockStyle.Fill;
            pnlcontenedorforms.Location = new Point(250, 40);
            pnlcontenedorforms.Name = "pnlcontenedorforms";
            pnlcontenedorforms.Size = new Size(700, 560);
            pnlcontenedorforms.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(223, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 255);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlmenu
            // 
            pnlmenu.BackColor = Color.PeachPuff;
            pnlmenu.Controls.Add(btnproveedores);
            pnlmenu.Controls.Add(btninventario);
            pnlmenu.Controls.Add(panel1);
            pnlmenu.Dock = DockStyle.Left;
            pnlmenu.Location = new Point(0, 40);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(250, 560);
            pnlmenu.TabIndex = 1;
            // 
            // btnproveedores
            // 
            btnproveedores.BackColor = Color.SandyBrown;
            btnproveedores.Dock = DockStyle.Top;
            btnproveedores.FlatAppearance.BorderSize = 0;
            btnproveedores.FlatStyle = FlatStyle.Flat;
            btnproveedores.ForeColor = SystemColors.ButtonHighlight;
            btnproveedores.Location = new Point(0, 174);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Padding = new Padding(10, 0, 0, 0);
            btnproveedores.Size = new Size(250, 75);
            btnproveedores.TabIndex = 14;
            btnproveedores.Text = "Proveedores";
            btnproveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnproveedores.UseVisualStyleBackColor = false;
            btnproveedores.Click += btnproveedores_Click;
            // 
            // btninventario
            // 
            btninventario.BackColor = Color.SandyBrown;
            btninventario.Dock = DockStyle.Top;
            btninventario.FlatAppearance.BorderSize = 0;
            btninventario.FlatStyle = FlatStyle.Flat;
            btninventario.ForeColor = SystemColors.ButtonHighlight;
            btninventario.Location = new Point(0, 100);
            btninventario.Name = "btninventario";
            btninventario.Padding = new Padding(10, 0, 0, 0);
            btninventario.Size = new Size(250, 74);
            btninventario.TabIndex = 13;
            btninventario.Text = "Inventario";
            btninventario.TextAlign = ContentAlignment.MiddleLeft;
            btninventario.UseVisualStyleBackColor = false;
            btninventario.Click += btninventario_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnltitulo
            // 
            pnltitulo.BackColor = Color.Peru;
            pnltitulo.Controls.Add(btnrestaurar);
            pnltitulo.Controls.Add(btnminimizar);
            pnltitulo.Controls.Add(btnmaximizar);
            pnltitulo.Controls.Add(btncerrar);
            pnltitulo.Dock = DockStyle.Top;
            pnltitulo.Location = new Point(0, 0);
            pnltitulo.Name = "pnltitulo";
            pnltitulo.Size = new Size(950, 40);
            pnltitulo.TabIndex = 0;
            pnltitulo.MouseDown += pnltitulo_MouseDown_1;
            // 
            // btnrestaurar
            // 
            btnrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnrestaurar.Image = (Image)resources.GetObject("btnrestaurar.Image");
            btnrestaurar.Location = new Point(900, 12);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(16, 16);
            btnrestaurar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnrestaurar.TabIndex = 7;
            btnrestaurar.TabStop = false;
            btnrestaurar.Visible = false;
            btnrestaurar.Click += btnrestaurar_Click_1;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(878, 12);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(16, 16);
            btnminimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnminimizar.TabIndex = 6;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click_1;
            // 
            // btnmaximizar
            // 
            btnmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmaximizar.Image = (Image)resources.GetObject("btnmaximizar.Image");
            btnmaximizar.Location = new Point(900, 12);
            btnmaximizar.Name = "btnmaximizar";
            btnmaximizar.Size = new Size(16, 16);
            btnmaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnmaximizar.TabIndex = 5;
            btnmaximizar.TabStop = false;
            btnmaximizar.Click += btnmaximizar_Click_1;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(922, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(16, 16);
            btncerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btncerrar.TabIndex = 4;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click_1;
            // 
            // principaladministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(pnlcontenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "principaladministrador";
            Text = "principaladministrador";
            pnlcontenedor.ResumeLayout(false);
            pnlcontenedorforms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlmenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnltitulo.ResumeLayout(false);
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
        private Panel panel1;
        private Button btnproveedores;
        private Button btninventario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}