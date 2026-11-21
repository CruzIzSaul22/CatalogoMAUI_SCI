using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMAUI_SCI.Models
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        //Nombre de la imagen del producto
        public string Foto { get; set; } = "";

        public string Detalle { get; set; } = "";

    }
}
