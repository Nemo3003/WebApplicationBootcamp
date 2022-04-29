
using System;
namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Ejercicios ejercicios = new Ejercicios();
            Ejercicios3.Ejercicios.Mayor100();
            Ejercicios3.Ejercicios.GetYourNum();
            Ejercicios3.Ejercicios.Doble();
            Ejercicios3.Ejercicios.Romanos();
            Ejercicios3.Ejercicios.YourAge();
            Ejercicios3.Ejercicios.Triangulo();
            Ejercicios3.Ejercicios.Billetes();
            Ejercicios3.Ejercicios.Fors();
            Ejercicios3.Ejercicios.Suma();
            Ejercicios3.Ejercicios.mult3();
            Ejercicios3.Ejercicios.Contras();
            Ejercicios3.Ejercicios.ContraLimit();
            Ejercicios3.Ejercicios.Adivina();
            Ejercicios3.Ejercicios.MayMen();
            Ejercicios3.Ejercicios.Count();*/
            //------------------------------------
            Cuadrado cuadrado = new();
            cuadrado.Area(3,5);
            //------------------------------------
            Persona persona = new();
            persona.FullName("Juan", "Perez");
            //-------------------------------------
            persona.Age(2000);
            //-------------------------------------
            Auto auto = new();
            auto.AutoInfo("Ford", "Fiesta", 2090, "Rojo");
            auto.ConductorHay("si"); //si o no
            auto.EdadConductor(18);
            auto.Encender();
            //si el auto esta encendido se acelera o frena
            auto.Acelerar();
            auto.Frenar();
            auto.Apagar();
            auto.Acelerar();
            auto.Frenar();
            auto.Pasajeros(3);
            //-------------------------------------
            Mascota mascota = new();
            mascota.MascotaInfo("Pepito", "Gato");
            mascota.Correr();
            mascota.Alimentar();
            mascota.Correr();
            mascota.Correr();
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
            //---------------------------------------
        }
    }
}