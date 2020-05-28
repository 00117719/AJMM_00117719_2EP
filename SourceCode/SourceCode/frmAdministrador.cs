using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
            

        }
        
        private void actualizarControles()
                {
                    List<Usuario> lista = DatosUsuario.getList();
                    
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lista;
                    comboBox1.DataSource = null;
                    comboBox1.ValueMember = "password";
                    comboBox1.DisplayMember = "username";
                    comboBox1.DataSource = lista;
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = lista;
                    comboBox2.DataSource = null;
                    comboBox2.ValueMember = "password";
                    comboBox2.DisplayMember = "username";
                    comboBox2.DataSource = lista;
                }


        private void buttonAddUser_Click(object sender, EventArgs e)
        {
             try
                        {
                            if (textBox1.Text.Length >= 5)
                            {
                                DatosUsuario.crearNuevoUsuario(textBox1.Text);
                                
                                MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                                "contrasena igual a usuario, no admin y si activo.", 
                                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                textBox1.Clear();
                                actualizarControles();
                            }
                            else
                                MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                                "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
        }


        private void buttonAddBussiness_Click(object sender, EventArgs e)
        {
            try
                                    {
                                        if (textBox1.Text.Length >= 5)
                                        {
                                            DatosUsuario.crearNuevoUsuario(textBox1.Text);
                                            
                                            MessageBox.Show("¡Negocio agregado exitosamente! Valores por defecto: " 
                                                            , 
                                                "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            
                                            textBox1.Clear();
                                            actualizarControles();
                                        }
                                        else
                                            MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                                                "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                                            "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
        }
    }
}