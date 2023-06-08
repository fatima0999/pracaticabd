using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using empresa_Negocio;
using empresa_identidad;
namespace EMPRESAFD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingrasar_Click(object sender, EventArgs e)
        {

            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario oUsuario = new CN_Usuario().Listar().Where(u => u.Documento == textdocumento.Text && u.Clave == textclave.Text).FirstOrDefault();

            if (oUsuario != null)
            {


                Inicio form = new Inicio(oUsuario);

                form.Show();
                this.Hide();
                form.FormClosing += form_closing;

            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "mensaje", MessageBoxButtons.OK, MessageBoxButtons.Exclamation);
            }
              
            }
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            textdocumento.Text = "";
            textclave.Text = "";
            this.Show();
        }
    }
}
