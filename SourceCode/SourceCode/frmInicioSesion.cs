using System;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;
using Npgsql;

namespace SourceCode
{
    public partial class frmInicioSesion : Form
    {
        private UserControl current = null;
        public frmInicioSesion()
        {
            InitializeComponent();
            
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            actualizarControles();
        }

        private void actualizarControles()
        {
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "password";
            comboBox2.DisplayMember = "username";
            comboBox2.DataSource = DatosUsuario.getList();
        }


        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonIniciarSesionAdministrador_Click(object sender, EventArgs e)
        {
            IniciarSesionAdministrador administrador= new IniciarSesionAdministrador();
            administrador.Show();
            this.Hide();
        }
        
    }
}
        
    