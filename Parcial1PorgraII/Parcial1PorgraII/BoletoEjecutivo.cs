using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PorgraII
{
    internal class BoletoEjecutivo : BoletoAbst
    {
        public BoletoEjecutivo()
        {
            //---Bloque para generar el ID, para la clase de Boleto Ejecutivo se van a generar de 300 hasta 600 de forma aleatoria
            Random r = new Random();//Genera un número ramdom
            int id = r.Next(301-1, 599+1);//Almacena el número ela variable ID
            setId(id);//Mandamos el ID generado

            //---Asignamos el tipo de voleto automáticamente
            this.tipoBoleto = "Boleto Ejecutivo";

            //---Bloque para asignar la fecha en que se vendió el boleto
            DateTime fecha = DateTime.Today.Date;
            setFechaVenta("Fecha de la venta: "+fecha.ToShortDateString());

            //---Bloque para definir la fecha del vuelo
            int Mes, Dia;
            Random mes = new Random();
            Random dia = new Random();
            Mes = mes.Next(0+1, 13-1);//Generamos un número entre 1 y 12, porque solo hay 12 meses en el año
            Dia = dia.Next(2-1, 29+1);//Generamos un número entre 1 y 30 para derfinir el día del mes en que será el vuelo
            DateTime anio = DateTime.Today;//Generamos un tipo de dato de DateTime para mostrar que el vuelo será del presente año
            setFechaVuelo("Fecha de vuelo: "+Dia+"/"+Mes+"/"+anio.Year);//Enviamos la información

        }

        public override void setDescripcion()//Le pedimos que inserte el destino del viaje para generar una breve descripción
        {
            string destino;
            Console.WriteLine("Inserte el destino del vuelo:");
            Console.Write("Destino -> ");
            destino = Console.ReadLine();
            this.descripcion = "Boleto de Clase Ejecutivo con destino a "+destino;
        }

        public override void setCosto()//Le pedimos que inserte el costo del boleto
        {
            int costo;
            Console.WriteLine("Inserte el costo del boleto: ");
            Console.Write("$");
            costo = Int32.Parse(Console.ReadLine());
            this.costo = costo;
        }

        public override void setSucursal()//Le pedimos la información necesaria para definir la sucursal en la que se llevó a cabo la venta
        {
            int op = 0;
            bool bandera = false;
            string sucursal;
            sucursal = null;
            do
            {
                bandera = false;
                try
                {
                    Console.WriteLine("---> INSERTE EL NUMERO QUE LE CORRESPONDE A LA SUCURSAL <---");
                    Console.WriteLine("1 -> San Salvador");
                    Console.WriteLine("2 -> Santa Ana");
                    Console.WriteLine("3 -> Morazan");
                    op = Int32.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    bandera = true;
                }
                finally
                {
                    if (bandera)
                    {
                        Console.WriteLine(" ------------------------------------------------");
                        Console.WriteLine("|-> Lo sentimos, parece queocurrio un ERROR :( <- |");
                        Console.WriteLine("|->       POR FAVOR, INTENTELO NUEVAMENTE      <- |");
                        Console.WriteLine(" ------------------------------------------------");
                    }
                    else
                    {
                        switch (op)
                        {
                            case 1:
                                sucursal = "San Salvador";
                                break;
                            case 2:
                                sucursal = "Santa Ana";
                                break;
                            case 3:
                                sucursal = "Morazan";
                                break;
                            default:
                                Console.WriteLine("--> LA OPCION QUE INSERTO NO ES VALIDA, INTENTELO NUEVAMENTE <---");
                                break;
                        }
                    }
                }

            } while (bandera);
            this.sucursal = sucursal;
        }
    }
}
