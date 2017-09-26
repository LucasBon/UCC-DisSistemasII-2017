using System;
using System.ComponentModel;

namespace PlayaInteligenteModel
{
    public abstract class Estadia
    {
        private Cliente _cliente;
        private Darsena _darsenaReservada;
        private Darsena _darsenaOcupada;
        private TimeSpan _entrada;
        private int _id;

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Darsena DarsenaReservada { get => _darsenaReservada; set => _darsenaReservada = value; }
        public Darsena DarsenaOcupada { get => _darsenaOcupada; set => _darsenaOcupada = value; }
        public TimeSpan Entrada { get => _entrada; set => _entrada = value; }
        public int Id { get => _id; set => _id = value; }
        

        public Estadia(Cliente cliente, Darsena darsenaReservada)
        {
            this.Cliente = cliente;
            this.DarsenaReservada = darsenaReservada;
            this.DarsenaOcupada = null;
            this.Entrada = DateTime.Now.TimeOfDay;
            this.Id = GeneradorDeId.Generador.siguiente();
        }

        public Estadia(Estadia estadia)
        {
            this.Cliente = estadia.Cliente;
            this.DarsenaReservada = estadia.DarsenaReservada;
            this.Entrada = estadia.Entrada;
            this.Id = estadia.Id;
        }
    }
}