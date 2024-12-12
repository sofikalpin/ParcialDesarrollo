using System;
using System.Collections.Generic;
using System.Linq;
using Modelosusu;

namespace ServicioUsuario
{
   
    public class Servicio : IServicio
    {
        private readonly List<Usuario> _usuarios;

        public Servicio()
        {
            _usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nombre = "Juan" },
                new Usuario { Id = 2, Nombre = "Maria" },
            };
        }

        public bool Existe(string nombre)
        {
            return _usuarios.Any(u => u.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
