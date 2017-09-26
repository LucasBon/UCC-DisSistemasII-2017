using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class JerarquiaMotivoAtencion : JerarquiaMenu, ElementoEnJerarquiaMenu
    {
        private JerarquiaMenu _jerarquia;

        public JerarquiaMenu Jerarquia { get => _jerarquia; set => _jerarquia = value; }

        public JerarquiaMotivoAtencion() {} // solo para uso de EF

        public JerarquiaMotivoAtencion(string nombre): base (nombre) { }
    }
}