using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameClub
{
    public class Prestamo
    {
        public int idPrestamo;
        public int idUnidad;
        public DateTime fechaPrestamo;     //aaaammdd
        public DateTime fechaDevolucion;   //aaaammdd
        public bool activo;
        public string aliasSocio;
        
        void ComprobarRechazo()
        {
            
        }
    }
}
