using System;
using System.ComponentModel;

namespace PlayaInteligenteModel
{
    public class EstadiaCompleta : Estadia
    {
        private TimeSpan _salida;
        private float _montoAbonado;

        public TimeSpan Salida { get => _salida; set => _salida = value; }
        public float MontoAbonado { get => _montoAbonado; set => _montoAbonado = value; }

        public EstadiaCompleta(Estadia estadiaEnCurso, float monto) : base (estadiaEnCurso)
        {
            this.MontoAbonado = monto;
        }
    }
}