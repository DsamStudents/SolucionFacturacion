using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacion.Modelo
{
    public class Clientes
    {
        public Clientes(string nombre,
                        string documento,
                        string telefono,
                        string direccion)
        {
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
            this.Direccion = direccion;
            
        }



        public string? Nombre { get; set; }
        public string? Documento { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
    }
}
