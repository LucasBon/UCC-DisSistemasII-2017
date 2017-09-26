using System;
using System.ComponentModel;

namespace PlayaInteligenteModel
{
    public class GeneradorDeId
    {
        private static GeneradorDeId _instancia;

        public static GeneradorDeId Generador
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GeneradorDeId();
                }
                return _instancia;
            }
        }

        private GeneradorDeId()
        {
            _contador = 0;
        }

        private int _contador;

        public int siguiente ()
        {
            return _contador++;
        }

        public int actual ()
        {
            return _contador;
        }
    }
}