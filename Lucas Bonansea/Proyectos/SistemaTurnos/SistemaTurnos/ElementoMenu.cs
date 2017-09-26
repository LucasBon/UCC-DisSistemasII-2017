using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public interface ElementoMenu
    {
        int Id { get; set; }

        string Nombre { get; }

        void Seleccionar(AnfitrionController anfitrion);
    }
}