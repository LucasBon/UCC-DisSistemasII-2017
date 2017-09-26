using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class GeneradorNumeroTurno
    {
        private static GeneradorNumeroTurno _instancia;

        public static GeneradorNumeroTurno Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GeneradorNumeroTurno();
                }
                return _instancia;
            }
        }

        private class MotivoPrioridad
        {
            private string _letraMotivo;

            public string LetraMotivo
            {
                get { return _letraMotivo; }
                set { _letraMotivo = value.ToUpper(); }
            }

            private string _letraPrioridad;

            public string LetraPrioridad
            {
                get { return _letraPrioridad; }
                set { _letraPrioridad = value.ToUpper(); }
            }

            public MotivoPrioridad(string letraMotivo, string letraPrioridad)
            {
                this.LetraMotivo = letraMotivo;
                this.LetraPrioridad = LetraPrioridad;
            }

            public override string ToString()
            {
                return this.LetraMotivo + this.LetraPrioridad;
            }

            public override bool Equals(object obj)
            {
                if (this == obj) return true;

                if (obj == null) return false;

                MotivoPrioridad otro = obj as MotivoPrioridad;
                if (otro == null) return false;

                return this.ToString().Equals(otro.ToString());
            }

            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }
        }

        private GeneradorNumeroTurno()
        {
            _mapaContador = new Dictionary<MotivoPrioridad, int>();
        }

        private Dictionary<MotivoPrioridad, int> _mapaContador;

        public string generarCodigo (MotivoAtencion motivo, Cliente cliente)
        {
            MotivoPrioridad mp = new MotivoPrioridad(motivo.LetraDescriptiva, cliente.LetraCategoriaPrioridad);
            if (!_mapaContador.ContainsKey (mp))
            {
                _mapaContador.Add(mp, 0);
            }

            int nroAsignado = _mapaContador[mp]++;

            return mp + _mapaContador[mp].ToString("0000");
        }
    }
}

