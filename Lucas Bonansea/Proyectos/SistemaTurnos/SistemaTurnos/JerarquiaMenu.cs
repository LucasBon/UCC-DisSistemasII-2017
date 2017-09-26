using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public abstract class JerarquiaMenu : ElementoMenu
    {
        private int _id;
        private string _nombre;
        private List<ElementoMenu> _elementosMenu;

        public List<ElementoMenu> ElementosMenu { get => _elementosMenu; set => _elementosMenu = value; }
        public string Nombre { get => _nombre; private set => _nombre = value; }
        public int Id { get => _id; set => _id = value; }

        public JerarquiaMenu() { } // Solo para uso de EF

        public JerarquiaMenu(string nombre)
        {
            this.Nombre = nombre;
        }

        public void Seleccionar(AnfitrionController anfitrion)
        {
            // Mostrar los elementos de Menu que dependen de el
            throw new NotImplementedException();
        }
    }
}