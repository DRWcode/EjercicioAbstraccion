using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    abstract class Vehiculo
    {
        // Atributos de la clase padre
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public int AnioFabricacion { get; set; }

        // Atributos abstractos adicionales
        public abstract double VelocidadMaxima { get; }
        public abstract double Aceleracion { get; }
        public abstract string TipoCombustible { get; }

        // Métodos abstractos
        public abstract void Info();
        public abstract void Rentar();
        public abstract void Devolver();
    }
}
