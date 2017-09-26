using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class MotivoAtencionMenu : ElementoMenu, ElementoEnJerarquiaMenu
    {
        private int _id;

        private MotivoAtencion _motivoAtencion;

        private JerarquiaMenu _jerarquia;

        public MotivoAtencion MotivoAtencion { get => _motivoAtencion; private set => _motivoAtencion = value; }

        public string Nombre => MotivoAtencion.Nombre;

        public JerarquiaMenu Jerarquia { get => _jerarquia; private set => _jerarquia = value; }
        public int Id { get => _id; set => _id = value; }

        public MotivoAtencionMenu() {} //solo para uso de EF

        public MotivoAtencionMenu(MotivoAtencion motivo) : this(motivo, JerarquiaRoot.Root) { }

        public MotivoAtencionMenu(MotivoAtencion motivo, JerarquiaMenu jerarquia)
        {
            MotivoAtencion = motivo;
            Jerarquia = jerarquia;
        }

        public void Seleccionar(AnfitrionController anfitrion)
        {
            throw new NotImplementedException();
        }
    }
}