using System;
using System.Collections.Generic;

namespace LuisCarlosMySql.Models;

public partial class Producto
{
    public int IdProductos { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Precio { get; set; }
}
