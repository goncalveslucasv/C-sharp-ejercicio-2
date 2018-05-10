using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_3
{
    public class EstaciondeServicio
    {
        public EstaciondeServicio()
        {
            this.normal.Descripcion = "normal";
            this.super.Descripcion = "super";
            this.premium.Descripcion = "premium";

            this.surtidor1.Numero = 1;
            this.surtidor2.Numero = 2;
            this.surtidor3.Numero = 3;
            this.surtidor1.Capacidad = 50;
            this.surtidor2.Capacidad = 50;
            this.surtidor3.Capacidad = 50;
        }


        #region "Datos Miembros"
        private Surtidor surtidor1 = new Surtidor();
        private Surtidor surtidor2 = new Surtidor();
        private Surtidor surtidor3 = new Surtidor();

        private Nafta normal = new Nafta();
        private Nafta super = new Nafta();
        private Nafta premium = new Nafta();
        #endregion
        #region "Operaciones"

        public Surtidor Surtidor1
        {
            get
            {
                return surtidor1;
            }   
        }

        public Surtidor Surtidor2
        {
            get
            {
                return surtidor2;
            }
        }

        public Surtidor Surtidor3
        {
            get
            {
                return surtidor3;
            }
        }

        public Nafta Normal
        {
            get
            {
                return normal;
            }
        }

        public Nafta Super
        {
            get
            {
                return super;
            }

        }

        public Nafta Premium
        {
            get
            {
                return premium;
            }
        }
        #endregion

        public float ObtenerRecaudacion()
        {
            return this.surtidor1.Recaudacion + this.surtidor2.Recaudacion + this.surtidor3.Recaudacion;
        }

        public int DevolverCantidaddeVentas ()
        {
            return surtidor1.CantidadVentas + surtidor2.CantidadVentas + surtidor3.CantidadVentas;
        }

        public Surtidor ObtenerSurtidorMayorRecaudacion()
        {
            Surtidor tmp = surtidor1;
            if (tmp.Recaudacion < surtidor2.Recaudacion)
            {
                tmp = surtidor2;
            }
            if (tmp.Recaudacion < surtidor3.Recaudacion)
            {
                tmp = surtidor3;
            }

            return tmp;
        }

        public Surtidor ObtenerSurtidorMenorRecaudacion()
        {
            Surtidor tmp = surtidor1;
            if (tmp.Recaudacion > surtidor2.Recaudacion)
            {
                tmp = surtidor2;
            }
            if (tmp.Recaudacion > surtidor3.Recaudacion)
            {
                tmp = surtidor3;
            }

            return tmp;
        }

        public Surtidor ObtenerSurtidorMayorClientes()
        {
            Surtidor tmp = surtidor1;
            if (tmp.CantidadVentas < surtidor2.CantidadVentas)
            {
                tmp = surtidor2;
            }
            if (tmp.CantidadVentas < surtidor3.CantidadVentas)
            {
                tmp = surtidor3;
            }

            return tmp;
        }

        public float DevolverPorcentajedeVentasdeTipoNafta (Nafta nafta)
        {
            return nafta.CantidadVentas * 100 / DevolverCantidaddeVentas();
        }

        public float DevolverPorcentajedeRecaudaciondeTipoNafta(Nafta nafta)
        {
            return nafta.Recaudacion * 100 / ObtenerRecaudacion();
        }

        public Surtidor ObtenerSurtidorMayorRecargas()
        {
            Surtidor tmp = surtidor1;
            if (tmp.CantidadRecargas < surtidor2.CantidadRecargas)
            {
                tmp = surtidor2;
            }
            if (tmp.CantidadRecargas < surtidor3.CantidadRecargas)
            {
                tmp = surtidor3;
            }

            return tmp;
        }
        public float DevolverPromedioVentas()
        {
            return this.DevolverCantidaddeVentas() / 3;

        }

        public float DevolverPromedioRecaudacion()
        {
            return this.ObtenerRecaudacion() / 3;

        }
    }
}