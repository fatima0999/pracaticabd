using empresa_identidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EMPRESAFD
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        public Inicio(Usuario objusuario)
        {

            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          lblusuario.Text = usuarioActual.Nombre_Completo;
        }
    }
}
