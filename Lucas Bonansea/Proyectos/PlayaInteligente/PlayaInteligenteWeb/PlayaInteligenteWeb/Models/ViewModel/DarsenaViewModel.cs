using PlayaInteligenteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayaInteligenteWeb.Models.ViewModel
{
    public class DarsenaViewModel
    {
        public int Numero { get; set; }

        public String Estado { get; set; }

        public DarsenaViewModel()
        {

        }

        public DarsenaViewModel(Darsena darsena)
        {
            this.Numero = darsena.Numero;
            this.Estado = darsena.Estado.ToString();
        }
    }
}