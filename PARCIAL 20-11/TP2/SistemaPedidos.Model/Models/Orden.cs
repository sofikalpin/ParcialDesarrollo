using System;
using System.Collections.Generic;

namespace SistemaPedidos.Model.Models;

public partial class Orden
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? UsuarioId { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
