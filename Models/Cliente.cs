using System;
using System.Collections.Generic;

namespace TallerCrud.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Dirección { get; set; }

    public int? Telefono { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public bool? Estado { get; set; }
}
