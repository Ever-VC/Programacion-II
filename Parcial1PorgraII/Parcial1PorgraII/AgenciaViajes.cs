using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PorgraII
{
    internal class AgenciaViajes<Boleto>//Le decimos que será una lista de un tipo de dato llamado "Boleto"
    {
        List<Boleto> listaBoletos = new List<Boleto>();//Instanciamos la lista de boletos donde serán almacenadas todas las vetas


        //---Bloque para agregar una nueva venta de boletos a la lista
        public void AgregarVenta(Boleto nuevoBoleto)
        {
            listaBoletos.Add(nuevoBoleto);//Agregamos a la lista una nueva venta de voleto
        }

        //---Bloque para mostrar el listado completo de los boletos vendidos
        public Boleto[] MostrarLista()
        {
            Boleto[] lista = listaBoletos.ToArray();
            return lista;
        }

        //---Bloque para eliminar el listado completo de boletos
        public Boleto[] EliminarVentas()
        {
            Boleto[] lista = listaBoletos.ToArray();//Creamos una copia de seguridad de la lista
            listaBoletos.Clear();//Eliminamos lista
            return lista;
        }

        /*
         * 
         * ---- PRUEBA DE FUNCIONES NUEVAS DEL SISTEMA (FUNCIONES NO ESPECIFICAS) ----
         * 
        */

        //---Bloque para buscar un elemento dentro de la lista, con parámetro el índice o posición a eliminar
        public Boleto buscarBoleto(int indice)
        {
            Boleto buscar = default(Boleto);
            if( listaBoletos.Count !=0 )
            {
                buscar = listaBoletos[indice];
                //listaBoletos.RemoveAt(indice);

            }
            return buscar;
        }

        public Boleto eliminarBoleto(int indice2)
        {
            Boleto eliminar = default(Boleto);
            if(listaBoletos.Count !=0 )
            {
                eliminar = listaBoletos[indice2];
                listaBoletos.RemoveAt(indice2);

            }
            return eliminar;
        }

    }
}
