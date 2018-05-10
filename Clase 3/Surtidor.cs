using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_3
{
    public class Surtidor
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        private Nafta nafta;
        public Nafta Nafta
        {
            get
            {
                return nafta;
            }

            set
            {
                nafta = value;
            }
        }

        private float capacidad;

        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }
        }

        private int cantidadventas;

        public int CantidadVentas
        {
            get { return cantidadventas; }
           
        }

        private float cantidadlitros;

        public float CantidadLitros
        {
            get { return cantidadlitros; }
          
        }

        private float cantidadrecargas;
        public float CantidadRecargas
        {
            get { return cantidadrecargas; }

        }

        public void Recargar ()
        {
            this.cantidadlitros = this.capacidad;
            this.cantidadrecargas++;
        }

        public bool Vender (float litros)
        {
            if (this.cantidadlitros < litros)
            {
                return false;
            }
            else
            {
                this.recaudacion += this.nafta.Precio * litros;
                this.cantidadventas++;
                this.nafta.RegistrarVenta(litros);
                this.cantidadlitros -= litros;
                return true;
            }

        }







    }


}