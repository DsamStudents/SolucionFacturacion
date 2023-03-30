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
    public partial class FormClientes : Form
    {
        private List<Clientes> Clientes;
        public FormClientes(List<Clientes> clientes)
        {
            InitializeComponent();
            Clientes = clientes;
        }

        private void BtGuardarCliente_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes(TbNombre.Text, TbDocumento.Text, TbTelefono.Text, TbDireccion.Text);
            Clientes.Add(cli);
            TbNombre.Text = string.Empty;
            TbDocumento.Text = string.Empty;
            TbDireccion.Text = string.Empty;
            TbTelefono.Text = string.Empty;
            TbNombre.Focus();
        }

        private void BtMostrarClientes_Click(object sender, EventArgs e)
        {
            FormListadoClientes f = new FormListadoClientes(Clientes);
            f.ShowDialog();
        }
    }
}
