using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class IniciarSesionAdministrador : Form
    {
        public IniciarSesionAdministrador()
        {
            InitializeComponent();
        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            frmAdministrador administrador= new frmAdministrador();
            administrador.Show();
            this.Hide();
        }
    }
}