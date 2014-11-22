using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameClub
{
    public class Socio
    {
        public string alias { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public bool esAdmin { get; set; }
        public string contraseña { get; set; }
    }
}
