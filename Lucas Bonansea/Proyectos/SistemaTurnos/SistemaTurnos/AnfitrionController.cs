using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public interface AnfitrionController
    {
        Cliente Cliente { get; set; }

        List<MotivoAtencion> mostarMenu();

        List<MotivoAtencion> mostrarMenu(JerarquiaMenu jerarquia);

        void solicitarTurno(MotivoAtencion motivo);
    }
}