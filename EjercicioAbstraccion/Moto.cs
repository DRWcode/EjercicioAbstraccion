using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Moto : Vehiculo
    {
        // Atributos adicionales de la clase hija Moto
        public string Tipo { get; set; }

        // Implementación de los atributos abstractos
        public override double VelocidadMaxima => 200.0;
        public override double Aceleracion => 10.0;
        public override string TipoCombustible => "Gasolina";

        // Constructor de la clase hija Moto
        public Moto(string tipo)
        {
            Tipo = tipo;
        }

        // Implementación de los métodos abstractos
        public override void Info()
        {
            Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Tipo: {Tipo}, Año: {AnioFabricacion}");
            Console.WriteLine($"Velocidad Máxima: {VelocidadMaxima} km/h, Aceleración: {Aceleracion} m/s^2, Combustible: {TipoCombustible}");
        }

        public override void Rentar()
        {
            Console.WriteLine("La moto ha sido rentada.");
        }

        public override void Devolver()
        {
            Console.WriteLine("La moto ha sido devuelta.");
        }
    }
}

