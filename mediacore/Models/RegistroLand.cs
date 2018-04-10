using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class RegistroLand
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Empresa { get; set; }
        public DateTime? FechaInsercion { get; set; }
    }
}
