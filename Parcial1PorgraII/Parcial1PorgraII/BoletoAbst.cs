using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PorgraII
{
    public abstract class BoletoAbst
    {
        //Atributos
        public int Id;
        protected string tipoBoleto;
        protected string descripcion;
        protected int costo;
        protected string fechaVenta;
        protected string fechaVuelo;
        protected string sucursal;

        //Métodos setters
        public void setId(int id)
        {
            this.Id = id;
        }
        
        public void setTipoBoleto(string tipoBoleto)
        {
            this.tipoBoleto = tipoBoleto;
        }

        public void setFechaVenta(string fechaVenta)
        {
            this.fechaVenta = fechaVenta;
        }

        public void setFechaVuelo(string fechaVuelo)
        {
            this.fechaVuelo = fechaVuelo;
        }

        //Métodos setters abstractos
        public abstract void setSucursal();//metodos que se implementa en cada clase (Porque cada boleto puede ser vendido en una sucursal diferente)
        public abstract void setDescripcion();//metodos que se implementa en cada clase (Porque cada boleto puede tener una descripción distinta)
        public abstract void setCosto();//El costo del boleto dependerá del lugar al que viaje

        //Métodos getters
        public int getId()
        {
            return Id;
        }
        public string getTipoBoleto()
        {
            return tipoBoleto;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public int getCosto()
        {
            return costo;
        }

        public string getFechaVenta()
        {
            return fechaVenta;
        }

        public string getFechaVuelo()
        {
            return fechaVuelo;
        }

        public string getSucursal()
        {
            return sucursal;
        }
    }
}
