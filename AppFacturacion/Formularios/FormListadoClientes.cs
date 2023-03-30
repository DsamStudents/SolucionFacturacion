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
    public partial class FormListadoClientes : Form
    {
        public FormListadoClientes( List<Clientes> clientes)
        {
            InitializeComponent();
            foreach (var item in clientes)
            {
                listBox1.Items.Add(item.Nombre+" | "+item.Documento);
            }
        }

        private void FormListadoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
