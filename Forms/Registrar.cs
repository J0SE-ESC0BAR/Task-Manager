using System;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    public partial class Registrar : Form
    {
        private string tipo;
        public Registrar(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }
        private void Registrar_Load(object sender, EventArgs e)
        {
            if (tipo == "Estudiante")
            {
                lbl_Titulo.Text = "Registrar Estudiante";
            }
            else if (tipo == "Tutor")
            {
                txb_Carnet.Visible = false;
                txb_Universidad.Visible = false;
                txb_Carrera.Visible = false;
                txb_Contraseña.Visible = false;

                lbl_Carnet.Visible = false;
                lbl_Universidad.Visible = false;
                lbl_Carrera.Visible = false;
                lbl_Contraseña.Visible = false;
                lbl_Titulo.Text = "Registrar Tutor";
            }
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (tipo == "Estudiante")
            {
                if (!string.IsNullOrWhiteSpace(txb_Nombre.Text) && !string.IsNullOrWhiteSpace(mkTB_Celular.Text))
                {
                    Estudiante estudiante = new Estudiante(txb_Nombre.Text, mkTB_Celular.Text);
                    estudiante.Descripcion = txb_Descripcion.Text ?? string.Empty;
                    estudiante.Universidad = txb_Universidad.Text ?? null;
                    estudiante.Carnet = txb_Carnet.Text ?? null;
                    estudiante.Correo = txb_Correo.Text ?? null;
                    estudiante.Direccion = txb_Direccion.Text ?? null;
                    estudiante.Carrera = txb_Carrera.Text ?? null;
                    estudiante.Creado = dTP_Creado.Value;
                    estudiante.Edad = Convert.ToInt32(nUD_Edad.Value);
                    estudiante.Registrar(txb_Contraseña.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("Nombre y celular son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (tipo == "Tutor")
            {
                if (!string.IsNullOrWhiteSpace(txb_Nombre.Text) && !string.IsNullOrWhiteSpace(mkTB_Celular.Text))
                {
                    Tutor tutor = new Tutor(txb_Nombre.Text, mkTB_Celular.Text);
                    tutor.Correo = txb_Correo.Text ?? null;
                    tutor.Creado = dTP_Creado.Value;
                    tutor.Descripcion = txb_Descripcion.Text ?? string.Empty;
                    tutor.Direccion = txb_Direccion.Text ?? null;
                    tutor.Edad = Convert.ToInt32(nUD_Edad.Value);

                    tutor.Registrar();
                    Close();
                }
                else
                {
                    MessageBox.Show("Nombre y celular son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
