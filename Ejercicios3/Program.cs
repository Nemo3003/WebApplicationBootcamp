
using System;
namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            Ejercicios3.Ejercicios.Mayor100();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.GetYourNum();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Doble();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Romanos();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.YourAge();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Triangulo();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Billetes();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Fors();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Suma();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.mult3();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Contras();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.ContraLimit();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Adivina();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.MayMen();
            Console.WriteLine("----------------------------------------------------");
            Ejercicios3.Ejercicios.Count();
            Console.WriteLine("----------------------------------------------------");
            //------------------------------------
            Cuadrado cuadrado = new();
            cuadrado.Area(3,5);
            Console.WriteLine("----------------------------------------------------");
            //------------------------------------
            Persona persona = new();
            persona.FullName("Juan", "Perez");
            Console.WriteLine("----------------------------------------------------");
            //-------------------------------------
            persona.Age(2000);
            Console.WriteLine("----------------------------------------------------");
            //-------------------------------------
            Auto auto = new();
            auto.AutoInfo("Ford", "Fiesta", 2090, "Rojo");
            auto.ConductorHay("si"); //si o no
            auto.EdadConductor(18);
            auto.Encender();
            auto.Mascota("chico");
            //si el auto esta encendido se acelera o frena
            auto.Acelerar();
            auto.Frenar();
            auto.Apagar();
            auto.Acelerar();
            auto.Frenar();
            auto.Pasajeros(2);
            auto.MoverMascota();
            auto.BajarPasajeros();
            Console.WriteLine("----------------------------------------------------");
            //-------------------------------------
            Mascota mascota = new();
            mascota.MascotaInfo("Pepito", "Gato");
            mascota.Correr();
            mascota.Alimentar();
            mascota.Correr();
            mascota.Correr();
            Console.WriteLine("----------------------------------------------------");
            //---------------------------------------
            Smarthphone smarthphone = new();
            smarthphone.SmarthphoneInfo("Iphone", "X");
            smarthphone.Encender();
            smarthphone.Apagar();
            smarthphone.VolumenUp();
            smarthphone.VolumenDown();
            smarthphone.Silenciar();
            smarthphone.BrilloUp();
            smarthphone.BrilloDown();
            Console.WriteLine("----------------------------------------------------");
            //---------------------------------------
            Libro libro = new();
            libro.LibroInfo("El Quijote", "Cervantes", 1000, 1805);
            Estudiante estudiante = new();
            estudiante.Libros();
            estudiante.LibrosLeidos();
            estudiante.LibrosNoLeidos();
            estudiante.PaginasLeidas();
            estudiante.CantidadLibrosNoLeidos();
            estudiante.AgregarLibros();
            estudiante.QuitarLibros();
            Console.WriteLine("----------------------------------------------------");
        }
    }
}