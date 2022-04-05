using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PorgraII
{
    internal class ESVC//Clase cliente
    {
        static void Main(string[] args)
        {
            int estadis = 0;//Para generar las estadísticas de ventas
            bool excep, excep2, excep3;//Para las excepciones
            string claseB = "";//Para definir la clase a la que pertenece el Boleto y a partir de ello, instanciar el objeto de esa clase
            int op = 0, clase, op2, elim;//Para ver que opcion elije el usuario del menú principal y para ver la clase que quiere el boleto
            // y si desea o no agregar una nueva venta de boletos
            int vendidosMorazan=0, vendidosClaseEjecutiva=0, vendidosClaseEconomica=0;


            BoletoAbst nuevoBoleto;//El objeto nos ayudará a almacenar en la lista cada nuevo boleto vendido
            AgenciaViajes<BoletoAbst> listaBoletoVendidos = new AgenciaViajes<BoletoAbst>();//Instancia la lista de objetos a manejar
            BoletoAbst[] vectorBoletos;

            do
            {
                excep = false;
                try
                {
                    Console.Clear();
                    //MOSTRAMOS EL MENU
                    Console.WriteLine("---> INSERTE EL NUMERO QUE LE CORRESPONDE A LA OPCION QUE DESEA EJECUTAR <---");
                    Console.WriteLine("1 -> Agregar una nueva venta");
                    Console.WriteLine("2 -> Ver listado de venta");
                    Console.WriteLine("3 -> Eliminar el registro de ventas");
                    Console.WriteLine("4 -> Ver estadistica de ventas");
                    Console.WriteLine("5 -> Ver una venta por su ID");
                    Console.WriteLine("6 -> Eliminar el registro de una venta por su ID");
                    Console.WriteLine("7 -> Salir");
                    op = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)//SI OCURRE UN PROBLEMA EN LA INSERSION DE DATOS, MOSTRAMOS LA EXCEPCION
                {
                    excep=true;
                    Console.WriteLine(ex.Message);
                    
                }
                finally
                {
                    if(excep)//Si ocurió una excepción, le mostramos al usuario un mensaje
                    {
                        Console.WriteLine(" ------------------------------------------------");
                        Console.WriteLine("|-> Lo sentimos, parece queocurrio un ERROR :( <- |");
                        Console.WriteLine("|->       POR FAVOR, INTENTELO NUEVAMENTE      <- |");
                        Console.WriteLine(" ------------------------------------------------");
                    }
                    else//Si todo va bien, le pedimos los datos
                    {
                        switch(op)
                        {
                            case 1://Agregar una nueva venta
                                do
                                {
                                    op2 = 1;
                                    Console.Clear();
                                    //--Solicitamos el tipo de clase que desea el boleto
                                    Console.WriteLine("A QUE CLASE PERTENECE EL BOLETO?");
                                    Console.WriteLine("1 -> Economica");
                                    Console.WriteLine("2 -> Ejecutiva");
                                    Console.WriteLine("3 -> Primera Clase");
                                    clase = Int32.Parse(Console.ReadLine());
                                    if (clase == 1)
                                    {
                                        claseB = "Clase Economica";
                                        vendidosClaseEconomica++;//Contamos cada vez que se venta un boleto económico
                                    }
                                    else if (clase == 2)
                                    {
                                        claseB = "Clase Ejecutiva";
                                        vendidosClaseEjecutiva++;//Contamos cada vez que se venta un boleto ejecutivo
                                    }
                                    else if (clase == 3)
                                    {
                                        claseB = "Primera Clase";
                                    }

                                    nuevoBoleto = FabricaBol.getTipoBoleto(claseB);//Mandamos a fabricar el boleto según sea la clase deseada
                                    nuevoBoleto.setDescripcion();//Pedimos el destino para generar una pequeña descripción
                                    nuevoBoleto.setCosto();//Solicitamos el costo, ya que varía depende la distancia a la que esté el destino
                                    nuevoBoleto.setSucursal();//Almacena la sucursal en que se llevó a cabo la venta del boleto
                                    if (nuevoBoleto.getSucursal() == "Morazan")
                                    {
                                        vendidosMorazan++;//Contamos cada vez que se venta un boleto en la sucursal de Morazán
                                    }
                                    listaBoletoVendidos.AgregarVenta(nuevoBoleto);//Agregramos el boleto vendido con todos los datos, a la lista de boletos vendidos
                                    estadis++;//Le sumamos a un boleto vendido para sacar la estadística
                                    Console.Clear();
                                    Console.WriteLine("Desea agregar otra venta");
                                    Console.WriteLine("1 -> SI");
                                    Console.WriteLine("2 -> NO");
                                    op2 = Int32.Parse(Console.ReadLine());

                                } while (op2 == 1);
                                excep = true;
                                break;
                            case 2://Ver listado completo de ventas
                                Console.Clear();
                                vectorBoletos = listaBoletoVendidos.MostrarLista();//Almacenamos en un vector, la lista de ventas la cual se cambió de lista a arreglo
                                if(vectorBoletos.Length != 0)
                                {
                                    Console.WriteLine("|-------------------------------|");
                                    Console.WriteLine("|-> LISTA DE BOLETOS VENDIDOS <-|");
                                    Console.WriteLine("|-------------------------------|\n");
                                    int y = 1;
                                    //int final = vectorBoletos.Count();
                                    foreach (BoletoAbst boletoAux in vectorBoletos)//Creamos una variable auxiliar para ir mostrando cada boleto vendido con su respectiva información
                                    {
                                        //---Bloque que muestra cada atributo de cada boleto vendido
                                        Console.WriteLine("ID de boleto: "+boletoAux.getId());
                                        Console.WriteLine("Tipo del boleto: "+boletoAux.getTipoBoleto());
                                        Console.WriteLine(boletoAux.getFechaVenta());
                                        Console.WriteLine(boletoAux.getFechaVuelo());
                                        Console.WriteLine("Descripcion de la venta: "+boletoAux.getDescripcion());
                                        Console.WriteLine("Costo del boleto: $"+boletoAux.getCosto());
                                        Console.WriteLine("Boleto vendido en la sucursal de: "+boletoAux.getSucursal());
                                        if (y != vectorBoletos.Length)
                                        {
                                            Console.WriteLine("\n\n|----------------------------------------------------------|");
                                            Console.WriteLine("|-> PRECIONE ENTER PARA VER LA INFORMACION DE OTRA VENTA <-|");
                                            Console.WriteLine("|----------------------------------------------------------|");
                                            Console.ReadKey();
                                        }
                                        y++;
                                    }
                                    Console.WriteLine("\n\n|--------------------------------------------------|");
                                    Console.WriteLine("|->               FIN DE LOS DATOS               <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\n\n|--------------------------------------------------|");
                                    Console.WriteLine("|->   NO HAY NINGUNA VENTA DENTRO DEL REGISTRO   <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }
                                excep = true;
                                break;
                            case 3://Eliminar listado de ventas
                                Console.Clear();
                                vectorBoletos = listaBoletoVendidos.MostrarLista();
                                if (vectorBoletos.Length != 0)
                                {
                                    Console.WriteLine("Esta seguro/a que desea eliminar el registro de ventas?");//Pedimos confirmación para evitar eliminar el registro por error
                                    Console.WriteLine("1 -> NO");
                                    Console.WriteLine("2 -> SI");
                                    elim = Int32.Parse(Console.ReadLine());
                                    if (elim == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("|-> EL REGISTRO NO FUE ELIMINADO, PRECIONE ENTER PARA VOLVER AL MENUPRINCIPAL <-|");
                                        Console.ReadKey();
                                    }
                                    else if (elim == 2)
                                    {
                                        Console.Clear();
                                        BoletoAbst[] vectorBoletosEliminados = listaBoletoVendidos.EliminarVentas();//Eliminamos el registro de ventas y lo copia la mostramos
                                        Console.WriteLine("|---------------------------------|");
                                        Console.WriteLine("|-> LISTA DE BOLETOS ELIMINADOS <-|");
                                        Console.WriteLine("|---------------------------------|\n");
                                        foreach (BoletoAbst boletoAux2 in vectorBoletosEliminados)
                                        {
                                            Console.WriteLine("ID de boleto: "+boletoAux2.getId());
                                            Console.WriteLine("Tipo del boleto: "+boletoAux2.getTipoBoleto());
                                            Console.WriteLine(boletoAux2.getFechaVenta());
                                            Console.WriteLine(boletoAux2.getFechaVuelo());
                                            Console.WriteLine("Descripcion de la venta: "+boletoAux2.getDescripcion());
                                            Console.WriteLine("Costo del boleto: $"+boletoAux2.getCosto());
                                            Console.WriteLine("Boleto vendido en la sucursal de: "+boletoAux2.getSucursal());
                                            Console.WriteLine("\n\n|----------------------------------------------------------|\n");
                                        }
                                        Console.WriteLine("\n\n|--------------------------------------------------|");
                                        Console.WriteLine("|->          FIN DE LOS DATOS ELIMINADOS         <-|");
                                        Console.WriteLine("|--------------------------------------------------|");
                                        Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                        Console.WriteLine("|--------------------------------------------------|");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n\n|--------------------------------------------------|");
                                    Console.WriteLine("|->   NO HAY NINGUNA VENTA DENTRO DEL REGISTRO   <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }
                                excep = true;
                                break;
                            case 4://Ver estadísticas
                                Console.Clear();
                                vectorBoletos = listaBoletoVendidos.MostrarLista();
                                if(vectorBoletos.Length != 0)
                                {
                                    Console.WriteLine("|--------------------------------|");
                                    Console.WriteLine("|-> ESTADISTICAS DE LAS VENTAS <-|");
                                    Console.WriteLine("|--------------------------------|\n");
                                    Console.WriteLine("CANTIDAD TOTAL DE BOLETOS VENDIDOS     -> "+estadis);
                                    Console.WriteLine("TOTAL BOLETOS VENDIDOS EN MORAZAN      ->"+vendidosMorazan);
                                    Console.WriteLine("TOTAL BOLETOS VENDIDOS CLASE EJECUTIVA ->"+vendidosClaseEjecutiva);
                                    Console.WriteLine("TOTAL BOLETOS VENDIDOS CLASE ECONOMICA ->"+vendidosClaseEconomica);
                                    Console.WriteLine("\n|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\n\n|--------------------------------------------------|");
                                    Console.WriteLine("|->   NO HAY NINGUNA VENTA DENTRO DEL REGISTRO   <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }
                                excep = true;
                                break;
                            case 5://Buscar un elemento por su ID
                                Console.Clear();
                                vectorBoletos = listaBoletoVendidos.MostrarLista();
                                if( vectorBoletos.Length != 0)
                                {
                                    Console.WriteLine("Inserte el ID de la venta a buscar");
                                    int id = Int32.Parse(Console.ReadLine());
                                    int i = 0, indice = 0;
                                    excep2 = false;
                                    BoletoAbst buscado;

                                    do
                                    {
                                        try
                                        {
                                            foreach (BoletoAbst boletoAux in vectorBoletos)
                                            {
                                                if (boletoAux.getId() == id)
                                                {
                                                    indice = i;
                                                }
                                                i++;
                                            }

                                            buscado = listaBoletoVendidos.buscarBoleto(indice);
                                            Console.WriteLine("|-> DATOS DEL BOLETO BUSCADO <-|");
                                            Console.WriteLine("ID de boleto: "+buscado.getId());
                                            Console.WriteLine("Tipo del boleto: "+buscado.getTipoBoleto());
                                            Console.WriteLine(buscado.getFechaVenta());
                                            Console.WriteLine(buscado.getFechaVuelo());
                                            Console.WriteLine("Descripcion de la venta: "+buscado.getDescripcion());
                                            Console.WriteLine("Costo del boleto: $"+buscado.getCosto());
                                            Console.WriteLine("Boleto vendido en la sucursal de: "+buscado.getSucursal());
                                            Console.WriteLine("\n|--------------------------------------------------|");
                                            Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                            Console.WriteLine("|--------------------------------------------------|");
                                            Console.ReadKey();
                                        }
                                        catch
                                        {
                                            excep2 = true;
                                            Console.WriteLine("AL PARECER OCURRIO UN PROBLEMA, PRECIONE ENTER PARA INTENTARLO DE NUEVO");
                                            Console.ReadKey();
                                        }
                                    } while (excep2);
                                }
                                else
                                {
                                    Console.WriteLine("\n\n|--------------------------------------------------|");
                                    Console.WriteLine("|->   NO HAY NINGUNA VENTA DENTRO DEL REGISTRO   <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }

                                excep = true;
                                break;
                            case 6://eliminar un dato ---------------NOOO FUNCIONAAAAAAA -----------------
                                Console.Clear();
                                vectorBoletos = listaBoletoVendidos.MostrarLista();
                                if(vectorBoletos.Length != 0)
                                {
                                    Console.WriteLine("Inserte el ID de la venta a eliminar");
                                    int idElim = Int32.Parse(Console.ReadLine());
                                    int x = 0, indice2 = 0;
                                    excep3 = false;
                                    BoletoAbst eliminado;

                                    do
                                    {
                                        try
                                        {
                                            foreach (BoletoAbst boletoAux2 in vectorBoletos)
                                            {
                                                if (boletoAux2.getId() == idElim)
                                                {
                                                    indice2 = x;
                                                }
                                                x++;
                                            }

                                            eliminado = listaBoletoVendidos.eliminarBoleto(indice2);
                                            Console.WriteLine("|-> DATOS DEL BOLETO ELIMINADO <-|");
                                            Console.WriteLine("ID de boleto: "+eliminado.getId());
                                            Console.WriteLine("Tipo del boleto: "+eliminado.getTipoBoleto());
                                            Console.WriteLine(eliminado.getFechaVenta());
                                            Console.WriteLine(eliminado.getFechaVuelo());
                                            Console.WriteLine("Descripcion de la venta: "+eliminado.getDescripcion());
                                            Console.WriteLine("Costo del boleto: $"+eliminado.getCosto());
                                            Console.WriteLine("Boleto vendido en la sucursal de: "+eliminado.getSucursal());
                                            Console.WriteLine("\n|-------------------------------------------------|");
                                            Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENUPRINCIPAL <-|");
                                            Console.WriteLine("|-------------------------------------------------|");
                                            Console.ReadKey();

                                        }
                                        catch
                                        {
                                            excep3 = true;
                                            Console.WriteLine("AL PARECER OCURRIO UN PROBLEMA, PRECIONE ENTER PARA INTENTARLO DE NUEVO");
                                            Console.ReadKey();
                                        }
                                    } while (excep3);
                                }
                                else
                                {
                                    Console.WriteLine("\n\n|--------------------------------------------------|");
                                    Console.WriteLine("|->   NO HAY NINGUNA VENTA DENTRO DEL REGISTRO   <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.WriteLine("|-> PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL <-|");
                                    Console.WriteLine("|--------------------------------------------------|");
                                    Console.ReadKey();
                                }
                                excep = true;
                                break;
                            case 7:
                                excep=false;
                                break;
                        }
                    }
                }

            } while (excep);
        }
    }
}
