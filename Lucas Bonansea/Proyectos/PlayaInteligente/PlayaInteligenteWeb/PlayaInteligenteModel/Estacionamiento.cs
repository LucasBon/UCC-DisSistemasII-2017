using System;
using System.Collections.Generic;

namespace PlayaInteligenteModel
{
    public class Estacionamiento
    {
        public static Estacionamiento _instancia;

        public static Estacionamiento Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Estacionamiento();
                }

                return _instancia;
            }
        }

        private Estacionamiento()
        {
            this.Darsenas = new List<Darsena>();
            this.EstadiasCompletas = new List<EstadiaCompleta>();
            this.EstadiasEnCurso = new List<Estadia>();
            CostoXHora = 40;
            CostoXHoraDarsenaErronea = 45;
        }

        private List<Darsena> _darsenas;
        private float _costoXHora;
        private float _costoXHoraDarsenaErronea;
        private List<Estadia> _estadiasEnCurso;
        private List<EstadiaCompleta> _estadiasCompletas;

        public List<Darsena> Darsenas { get => _darsenas; private set => _darsenas = value; }
        public float CostoXHora { get => _costoXHora; set => _costoXHora = value; }
        public float CostoXHoraDarsenaErronea { get => _costoXHoraDarsenaErronea; set => _costoXHoraDarsenaErronea = value; }
        public List<Estadia> EstadiasEnCurso { get => _estadiasEnCurso; private set => _estadiasEnCurso = value; }
        public List<EstadiaCompleta> EstadiasCompletas { get => _estadiasCompletas; private set => _estadiasCompletas = value; }
    }
}