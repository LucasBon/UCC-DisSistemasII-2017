using PlayaInteligenteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayaInteligenteWeb
{
    public partial class DarsenaDao
    {

        public Darsena Darsena
        {
            get
            {
                Darsena darsena = new Darsena();
                darsena.Numero = this.Numero;
                darsena.Estado = Enum.IsDefined(typeof(EstadoDarsena), this.Estado) ? 
                                (EstadoDarsena)this.Estado : EstadoDarsena.DISPONIBLE;

                return darsena;
            }
        }
    }
}