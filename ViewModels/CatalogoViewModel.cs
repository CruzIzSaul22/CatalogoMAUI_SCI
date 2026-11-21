using System;
using System.Collections.Generic;
using CatalogoMAUI_SCI.Models;

namespace CatalogoMAUI_SCI.ViewModels
{
    internal class CatalogoViewModel
    {
        //Cada objeto de esta lista se convertirá en una tarjeta.
        public List<Producto> Productos { get; } = new()
        {
            new Producto
            {
                Nombre = "Mochila urbana",
                Descripcion = "Con espacio para laptop y cuadernos",
                Precio = 499.00m,
                Detalle = "Mochila de uso diario con bolsillo frontal",
                Foto = "mochila.png"
            },
            new Producto
            {
                Nombre = "Libreta A5",
                Descripcion = "80 hojas rayadas, tapa dura",
                Precio = 89.50m,
                Detalle = "Libreta de calidad con hojas de buena textura",
                Foto = "cuaderno.png"
            },
            new Producto
            {
                Nombre = "Termo de acero",
                Descripcion = "Botella reutilizable de 500 ml",
                Precio = 219.00m,
                Detalle = "Termo de acero inoxidable con aislamiento térmico",
                Foto = "termo.png"
            }
        };
    }
}
