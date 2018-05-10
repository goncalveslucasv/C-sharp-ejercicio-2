using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_3
{
    public class Nafta
    {
    

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }
        }


        private float cantidadlitrosvendidos;

        public float CantidadLitrosVendidos
        {
            get { return cantidadlitrosvendidos; }
           
        }

        private int cantidadventas;

        public int CantidadVentas
        {
            get { return cantidadventas; }
         
        }

        public void RegistrarVenta (float litros)
        {
            this.cantidadventas++;
            this.cantidadlitrosvendidos += litros;
            this.recaudacion += litros * this.precio;
        }

    }
}