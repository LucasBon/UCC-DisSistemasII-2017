using SistemaTurnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaTurnosWeb.Models
{
    public class TurnosContexto
    {
        private static TurnosContexto _instancia;

        public static TurnosContexto Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new TurnosContexto();
                }

                return _instancia;
            }
        }

        public List<MotivoAtencion> MotivosAtencion
        {
            get { return _motivosAtencion; }
            set { _motivosAtencion = value; }
        }

        private TurnosContexto()
        {
            MotivosAtencion = new List<MotivoAtencion>();
        }

        private List<MotivoAtencion> _motivosAtencion;
    }
}