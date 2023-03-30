namespace AppFacturacion.Formularios
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbNombre = new Label();
            TbNombre = new TextBox();
            TbDocumento = new TextBox();
            LbDocumento = new Label();
            TbTelefono = new TextBox();
            LbTelefono = new Label();
            TbDireccion = new TextBox();
            LbDireccion = new Label();
            BtGuardarCliente = new Button();
            BtMostrarClientes = new Button();
            SuspendLayout();
            // 
            // LbNombre
            // 
            LbNombre.AutoSize = true;
            LbNombre.Location = new Point(37, 31);
            LbNombre.Name = "LbNombre";
            LbNombre.Size = new Size(102, 15);
            LbNombre.TabIndex = 0;
            LbNombre.Text = "Ingrese el nombre";
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(37, 49);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(289, 23);
            TbNombre.TabIndex = 1;
            TbNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // TbDocumento
            // 
            TbDocumento.Location = new Point(37, 97);
            TbDocumento.Name = "TbDocumento";
            TbDocumento.Size = new Size(289, 23);
            TbDocumento.TabIndex = 3;
            TbDocumento.TextAlign = HorizontalAlignment.Right;
            // 
            // LbDocumento
            // 
            LbDocumento.AutoSize = true;
            LbDocumento.Location = new Point(37, 79);
            LbDocumento.Name = "LbDocumento";
            LbDocumento.Size = new Size(167, 15);
            LbDocumento.TabIndex = 2;
            LbDocumento.Text = "Ingrese el número documento";
            // 
            // TbTelefono
            // 
            TbTelefono.Location = new Point(37, 143);
            TbTelefono.Name = "TbTelefono";
            TbTelefono.Size = new Size(289, 23);
            TbTelefono.TabIndex = 5;
            TbTelefono.TextAlign = HorizontalAlignment.Right;
            // 
            // LbTelefono
            // 
            LbTelefono.AutoSize = true;
            LbTelefono.Location = new Point(37, 125);
            LbTelefono.Name = "LbTelefono";
            LbTelefono.Size = new Size(158, 15);
            LbTelefono.TabIndex = 4;
            LbTelefono.Text = "Ingrese el número telefonico";
            // 
            // TbDireccion
            // 
            TbDireccion.Location = new Point(37, 192);
            TbDireccion.Name = "TbDireccion";
            TbDireccion.Size = new Size(289, 23);
            TbDireccion.TabIndex = 7;
            TbDireccion.TextAlign = HorizontalAlignment.Right;
            // 
            // LbDireccion
            // 
            LbDireccion.AutoSize = true;
            LbDireccion.Location = new Point(37, 174);
            LbDireccion.Name = "LbDireccion";
            LbDireccion.Size = new Size(109, 15);
            LbDireccion.TabIndex = 6;
            LbDireccion.Text = "Ingrese la dirección";
            // 
            // BtGuardarCliente
            // 
            BtGuardarCliente.Location = new Point(251, 241);
            BtGuardarCliente.Name = "BtGuardarCliente";
            BtGuardarCliente.Size = new Size(75, 23);
            BtGuardarCliente.TabIndex = 9;
            BtGuardarCliente.Text = "Guardar";
            BtGuardarCliente.UseVisualStyleBackColor = true;
            BtGuardarCliente.Click += BtGuardarCliente_Click;
            // 
            // BtMostrarClientes
            // 
            BtMostrarClientes.Location = new Point(64, 241);
            BtMostrarClientes.Name = "BtMostrarClientes";
            BtMostrarClientes.Size = new Size(75, 23);
            BtMostrarClientes.TabIndex = 10;
            BtMostrarClientes.Text = "Mostrar";
            BtMostrarClientes.UseVisualStyleBackColor = true;
            BtMostrarClientes.Click += BtMostrarClientes_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 280);
            Controls.Add(BtMostrarClientes);
            Controls.Add(BtGuardarCliente);
            Controls.Add(TbDireccion);
            Controls.Add(LbDireccion);
            Controls.Add(TbTelefono);
            Controls.Add(LbTelefono);
            Controls.Add(TbDocumento);
            Controls.Add(LbDocumento);
            Controls.Add(TbNombre);
            Controls.Add(LbNombre);
            Name = "FormClientes";
            ShowInTaskbar = false;
            Text = "Formulario de registro de clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbNombre;
        private TextBox TbNombre;
        private TextBox TbDocumento;
        private Label LbDocumento;
        private TextBox TbTelefono;
        private Label LbTelefono;
        private TextBox TbDireccion;
        private Label LbDireccion;
        private Button BtGuardarCliente;
        private Button BtMostrarClientes;
    }
}