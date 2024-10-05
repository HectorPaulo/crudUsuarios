using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudUsuarios
{
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();

        }
            //private void button2_Click(object sender, EventArgs e)
            //{
            //    Usuarios Usuario = new Usuarios();
            //    Usuario.Usuario = txtUser.Text.Trim();
            //    Usuario.Passwd = txtPass.Text.Trim();
            //    Usuario.Estado = cmbEstado.SelectedItem.ToString(); ;
            //    Usuario.Tipo_usuario = cmbTipo.SelectedItem.ToString();

            //    int resultado = UsuariosDAO.Agregar(Usuario);
            //    if (resultado > 0)
            //    {
            //        MessageBox.Show("Usuario Guardado Con Exito!!", "Usuario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo guardar el Usuario", "Fallo al insertar!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }

            //}

            //private void button3_Click(object sender, EventArgs e)
            //{
            //    txtUser.Text = "";
            //    txtPass.Text = "";
            //    cmbEstado.Text = "";
            //    cmbTipo.Text = "";
            //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.Usuario = textBox1.Text.Trim();
            Usuario.Passwd = textBox2.Text.Trim();
            Usuario.Estado = comboBox1.SelectedItem.ToString(); ;
            Usuario.Tipo_usuario = comboBox2.SelectedItem.ToString();

            int resultado = DAO.Agregar(Usuario);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Guardado Con Exito!!", "Usuario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo al insertar!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
