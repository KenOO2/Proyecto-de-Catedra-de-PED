using proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class principaladministrador : Form
    {
        public static ListaEnlazada lista = new ListaEnlazada();
        public principaladministrador()
        {
            InitializeComponent();
        }



        #region PANEL TITULO

        private void pnltitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //metodo redimencionar 
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //excluir esquina de panel 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlcontenedor.Region = region;
            this.Invalidate();
        }
        //color y grip rectangulo inferior
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //movimiento panel titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;
        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen!.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnrestaurar_Click_1(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        #endregion


        //metodo abrir forms dentro de panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlcontenedorforms.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                       //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlcontenedorforms.Controls.Add(formulario);
                pnlcontenedorforms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btninventario_Click_1(object sender, EventArgs e)
        {
            pnlcontenedorforms.Controls.Clear(); // Limpiar el panel completamente
            Inventario formInventario = new Inventario();
            formInventario.TopLevel = false;
            formInventario.FormBorderStyle = FormBorderStyle.None;
            formInventario.Dock = DockStyle.Fill;
            pnlcontenedorforms.Controls.Add(formInventario);
            formInventario.Show();
        }
        private void btnproveedores_Click_1(object sender, EventArgs e)
        {
            pnlcontenedorforms.Controls.Clear(); // Limpiar el panel ANTES de agregar el formulario

            Proveedores formproveedores = pnlcontenedorforms.Controls
                .OfType<Proveedores>()
                .FirstOrDefault();

            if (formproveedores == null || formproveedores.IsDisposed)
            {
                formproveedores = new Proveedores();
                formproveedores.TopLevel = false;
                formproveedores.FormBorderStyle = FormBorderStyle.None;
                formproveedores.Dock = DockStyle.Fill;

                pnlcontenedorforms.Controls.Add(formproveedores);
                formproveedores.Show();

                formproveedores.CargarDatos();
                formproveedores.ActualizarDatagrid();
            }
            else
            {
                formproveedores.Show();
                formproveedores.CargarDatos();
                formproveedores.ActualizarDatagrid();
                formproveedores.Focus();
            }

        }



       

        #region SUBMENU

        bool menuexpand = true;

        private void submenuad_Tick(object sender, EventArgs e)
        {
            if (menuexpand)
            {
                pnlmenu.Width -= 10;
                if (pnlmenu.Width <= 72)
                {
                    menuexpand = false;
                    submenuad.Stop();

                }
            }
            else
            {
                pnlmenu.Width += 10;
                if (pnlmenu.Width >= 250)
                {
                    menuexpand = true;
                    submenuad.Stop();
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            submenuad.Start();
        }



        #endregion
             



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            principalusuario1 formusuario = new principalusuario1 ();
            formusuario.Show();
            this.Hide();
        }
    }


}
