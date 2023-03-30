using AppFacturacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturacion.Formularios
{
    public partial class FormMenuPrincipal : Form
    {
        public List<Clientes> ListaClientes = new List<Clientes>();
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnFormClientes_Click(object sender, EventArgs e)
        {
            FormClientes f = new(ListaClientes);
            f.ShowDialog();
        }
    }
}
