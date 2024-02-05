using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Sedan : Vehiculo
    {
        // Atributos adicionales de la clase hija Sedan
        public int NumeroPuertas { get; set; }

        // Implementación de los atributos abstractos
        public override double VelocidadMaxima => 180.0;
        public override double Aceleracion => 8.0;
        public override string TipoCombustible => "Gasolina o Diésel";

        // Constructor de la clase hija Sedan
        public Sedan(int numeroPuertas)
        {
            NumeroPuertas = numeroPuertas;
        }

        // Implementación de los métodos abstractos
        public override void Info()
        {
            Console.WriteLine($"Sedan - Marca: {Marca}, Modelo: {Modelo}, Puertas: {NumeroPuertas}, Año: {AnioFabricacion}");
            Console.WriteLine($"Velocidad Máxima: {VelocidadMaxima} km/h, Aceleración: {Aceleracion} m/s^2, Combustible: {TipoCombustible}");
        }

        public override void Rentar()
        {
            Console.WriteLine("El sedan ha sido rentado.");
        }

        public override void Devolver()
        {
            Console.WriteLine("El sedan ha sido devuelto.");
        }
    }
}
