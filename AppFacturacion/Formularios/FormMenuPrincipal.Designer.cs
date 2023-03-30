namespace AppFacturacion.Formularios
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            BtnFormClientes = new Button();
            SuspendLayout();
            // 
            // BtnFormClientes
            // 
            BtnFormClientes.Image = Properties.Resources.icons8_usuario_50;
            BtnFormClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFormClientes.Location = new Point(46, 42);
            BtnFormClientes.Margin = new Padding(2);
            BtnFormClientes.Name = "BtnFormClientes";
            BtnFormClientes.Size = new Size(130, 56);
            BtnFormClientes.TabIndex = 0;
            BtnFormClientes.Text = "Clientes";
            BtnFormClientes.UseVisualStyleBackColor = true;
            BtnFormClientes.Click += BtnFormClientes_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 225);
            Controls.Add(BtnFormClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnFormClientes;
    }
}