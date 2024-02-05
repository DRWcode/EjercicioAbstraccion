
using EjercicioAbstraccion;

// Crear instancias de las clases hijas
Moto moto1 = new Moto("Deportiva");
Sedan sedan1 = new Sedan(4);

// Establecer atributos comunes
moto1.Marca = "Honda";
moto1.Modelo = "CBR1000RR";
moto1.Precio = 15000.0;
moto1.AnioFabricacion = 2022;

sedan1.Marca = "Toyota";
sedan1.Modelo = "Camry";
sedan1.Precio = 25000.0;
sedan1.AnioFabricacion = 2020;

// Mostrar información de las clases hijas en la consola
Console.WriteLine("Información de la Moto:");
moto1.Info();
moto1.Rentar();
moto1.Devolver();

Console.WriteLine("\nInformación del Sedan:");
sedan1.Info();
sedan1.Rentar();
sedan1.Devolver();