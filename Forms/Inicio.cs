using System;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            // Se oculta el formulario de inicio
            this.Hide();

            // Se crea e instancia el formulario Principal
            var principal = new Prinsipal(mkTB_Carnet.Text, txb_Clave.Text);

            // Se configura para que cuando se cierre el formulario Principal,
            // se cierre también el formulario Inicio (y con ello la aplicación)
            principal.FormClosed += (s, args) => this.Close();

            // Se muestra el formulario Principal
            principal.Show();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
