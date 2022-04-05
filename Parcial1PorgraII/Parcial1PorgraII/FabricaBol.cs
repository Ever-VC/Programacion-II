using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PorgraII
{
    internal class FabricaBol
    {
        public static BoletoAbst getTipoBoleto(string tipoBoleto)
        {
            BoletoAbst boletoGenerado = null;
            if (tipoBoleto == "Clase Economica")
            {
                boletoGenerado = new BoletoEconomico();
            }
            else if (tipoBoleto == "Clase Ejecutiva")
            {
                boletoGenerado = new BoletoEjecutivo();
            }
            else if (tipoBoleto == "Primera Clase")
            {
                boletoGenerado = new BoletoPrimeraClase();
            }
            return boletoGenerado;
        }
    }
}
