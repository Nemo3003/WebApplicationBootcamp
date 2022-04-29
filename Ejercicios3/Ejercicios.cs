using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3
{
    class Ejercicios
    {
        public static void Mayor100()
        {
            //Pedir un numero al usuario
            Console.WriteLine("Ingrese un numero");
            int num = int.Parse(Console.ReadLine());
            //ver si es mayor a 100
            if (num > 100)
            {
                Console.WriteLine("El numero es mayor a 100");
            }
            else
            {
                Console.WriteLine("El numero es menor a 100");
            }
        }
        public static void GetYourNum()
        {
            //Pedir un número entero por teclado y calcular si es par o impar.
            Console.WriteLine("Ingrese un numero entero");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        public static void Doble()
        {
            //Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición
            Console.WriteLine("Ingrese un numero entero");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                if (num * 2 == num)
                {
                    Console.WriteLine("El numero es doble de un impar");
                }
                else
                {
                    Console.WriteLine("El numero no es doble de un impar");
                }
            }
            else
            {
                Console.Write("El numero es par");
            }
        }
        public static void Romanos()
        {
            //Dada un número del 1 al 10, devolver su “versión” en números romanos.
            Console.WriteLine("Ingrese un numero del 1 al 10");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }

        }
        public static void YourAge()
        {
            // Leer el nombre y las edades de dos personas y devolver el nombre del menor.En caso de que tengan la misma edad también debe indicarse.
            //Devolver también la diferencia de edad en caso de corresponder.
            Console.WriteLine("Ingrese el nombre de la primera persona");
#pragma warning disable CS8600
            string pers1 = Console.ReadLine();
#pragma warning restore CS8600
            Console.WriteLine("Ingrese la edad de la pimera persona");
            byte age1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre de la segunda persona");
#pragma warning disable CS8600
            string pers2 = Console.ReadLine();
#pragma warning restore CS8600
            Console.WriteLine("Ingrese la edad de la segunda persona");
            byte age2 = Convert.ToByte(Console.ReadLine());

            if (age1 < age2)
            {
                byte howMuch = (byte)(age2 - age1);
                Console.WriteLine($"El menor es {pers1} por {howMuch} annos");
            }
            if (age1 > age2)
            {
                byte howMuch = (byte)(age1 - age2);
                Console.WriteLine($"El menor es {pers2} por {howMuch} annos");
            }
            if (age1 == age2) { Console.WriteLine("Ambos tienen la misma edad"); }
        }
        public static void Triangulo()
        {
            //Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.
            Console.WriteLine("Ingrese la longitud del primer lado");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del segundo lado");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del tercer lado");
            int lado3 = int.Parse(Console.ReadLine());
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triangulo es isosceles");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }
            Console.WriteLine("El perimetro del triangulo es " + (lado1 + lado2 + lado3));
            Console.WriteLine("El area del triangulo es " + ((lado1 + lado2 + lado3) / 2));

        }
        public static void Billetes()
        {
            //Desarrolle un programa que calcule el desglose de una cantidad dada, en
            //billetes y monedas tal que se minimice la cantidad de monedas y billetes.
            //Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
            //donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
            //imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
            //$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
            //tratar todos los valores como números, para los cálculos.
            Console.WriteLine("Ingrese la cantidad a desglosar");
            int cantidad = int.Parse(Console.ReadLine());
            int billetes1000 = 0;
            int billetes500 = 0;
            int billetes200 = 0;
            int billetes100 = 0;
            int billetes50 = 0;
            int billetes20 = 0;
            int billetes10 = 0;
            int billetes5 = 0;
            int monedas2 = 0;
            int monedas1 = 0;

            while (cantidad > 0)
            {
                if (cantidad >= 1000)
                {
                    billetes1000++;
                    cantidad -= 1000;
                }
                else if (cantidad >= 500)
                {
                    billetes500++;
                    cantidad -= 500;
                }
                else if (cantidad >= 200)
                {
                    billetes200++;
                    cantidad -= 200;
                }
                else if (cantidad >= 100)
                {
                    billetes100++;
                    cantidad -= 100;
                }
                else if (cantidad >= 50)
                {
                    billetes50++;
                    cantidad -= 50;
                }
                else if (cantidad >= 20)
                {
                    billetes20++;
                    cantidad -= 20;
                }
                else if (cantidad >= 10)
                {
                    billetes10++;
                    cantidad -= 10;
                }
                else if (cantidad >= 5)
                {
                    billetes5++;
                    cantidad -= 5;
                }
                else if (cantidad >= 2)
                {
                    monedas2++;
                    cantidad -= 2;
                }
                else if (cantidad >= 1)
                {
                    monedas1++;
                    cantidad -= 1;
                }

            }
            Console.WriteLine("Billetes de $1000: " + billetes1000);
            Console.WriteLine("Billetes de $500: " + billetes500);
            Console.WriteLine("Billetes de $200: " + billetes200);
            Console.WriteLine("Billetes de $100: " + billetes100);
            Console.WriteLine("Billetes de $50: " + billetes50);
            Console.WriteLine("Billetes de $20: " + billetes20);
            Console.WriteLine("Billetes de $10: " + billetes10);
            Console.WriteLine("Billetes de $5: " + billetes5);
            Console.WriteLine("Billetes de $2: " + monedas2);
            Console.WriteLine("Monedas de $1: " + monedas1);


        }
        public static void Fors()
        {
            //Pide un número N, y muestra todos los números del 1 al N
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void Suma()
        {
            //Pedir 15 numeros, los guarda en un array, los suma y muestra el resultado
            var list1 = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese un numero");
                int userFor2 = Convert.ToInt32(Console.ReadLine());
                list1.Add(userFor2);
            }
            Console.WriteLine("El total de los numeros es: " + list1.Sum());
        }
        public static void mult3()
        {
            //Pide 5 números e indica si alguno es múltiplo de 3.
            Console.WriteLine("Chequeando si alguno es multiple de 3");
            Console.WriteLine("Ingrese un numero");
            int firsUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            var firsDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int firsTres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int firsCuatro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int firstCinco = Convert.ToInt32(Console.ReadLine());

            if (firsUno % 3 == 0 || firsDos % 3 == 0 || firsTres % 3 == 0 || firsCuatro % 3 == 0 || firstCinco % 3 == 0)
            { Console.WriteLine("Alguno de los numeros es multiplo de 3"); }
            else { Console.WriteLine("Ninguno de los numeros es multiplo de 3"); }
        }
        public static void Contras()
        {
            //Escriba un programa que solicite una contraseña (el texto de la contraseña no es importante) y la vuelva a solicitar
            //hasta que las dos contraseñas coincidan.
            Console.WriteLine("Ingrese una contraseña");
#pragma warning disable CS8600
            string pass = Console.ReadLine();
#pragma warning restore CS8600
            Console.WriteLine("Ingrese la contraseña nuevamente");
#pragma warning disable CS8600
            string pass2 = Console.ReadLine();
#pragma warning restore CS8600
            while (pass != pass2)
            {
                Console.WriteLine("Las contraseñas no coinciden, por favor ingrese la contraseña nuevamente");
#pragma warning disable CS8600
                pass2 = Console.ReadLine();
#pragma warning restore CS8600
            }
            Console.WriteLine("Las contraseñas coinciden");
        }
        public static void ContraLimit()
        {
            Console.WriteLine("Ingrese una contraseña");
#pragma warning disable CS8600
            string pass3 = Console.ReadLine();
#pragma warning restore CS8600
            Console.WriteLine("Ingrese la contraseña nuevamente");
#pragma warning disable CS8600
            string pass4 = Console.ReadLine();
#pragma warning restore CS8600
            int cont = 0;
            while (pass3 != pass4)
            {
                Console.WriteLine("Las contraseñas no coinciden, por favor ingrese la contraseña nuevamente");
#pragma warning disable CS8600
                pass4 = Console.ReadLine();
#pragma warning restore CS8600
                cont++;
                if (cont == 3)
                {
                    Console.WriteLine("Ha excedido el numero de intentos");
                    break;
                }
            }

        }
        public static void Adivina()
        {
            //Proponer al usuario que adivine un número a base de intentarlo.
            Console.WriteLine("Adivina un numero");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 100);
            int cont2 = 0;
            while (userNum != rndNum)
            {
                if (userNum > rndNum)
                {
                    Console.WriteLine("El numero es mas pequeño");
                    Console.WriteLine("Ingrese un numero");
                }
                else
                {
                    Console.WriteLine("El numero es mas grande");
                    Console.WriteLine("Ingrese un numero");
                }
                userNum = Convert.ToInt32(Console.ReadLine());
                cont2++;
                if (cont2 == 25)
                {
                    Console.WriteLine("Ha excedido el numero de intentos");
                    break;
                }
            }
            Console.WriteLine("El numero era: " + rndNum);
        }
        public static void MayMen()
        {
            Console.WriteLine("Adivina un numero");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            Random rnd2 = new Random();
            int rndNum2 = rnd2.Next(1, 100);
            int cont3 = 0;
            while (userNum2 != rndNum2)
            {
                if (userNum2 > rndNum2)
                {
                    Console.WriteLine("Menor");
                    Console.WriteLine("Ingrese un numero");
                }
                else
                {
                    Console.WriteLine("Mayor");
                    Console.WriteLine("Ingrese un numero");
                }
                userNum2 = Convert.ToInt32(Console.ReadLine());
                cont3++;
                if (cont3 == 25)
                {
                    Console.WriteLine("Ha excedido el numero de intentos");
                    break;
                }
            }
            Console.WriteLine("El numero era: " + rndNum2);
        }
        public static void Count()
        {
            Console.WriteLine("Ingrese un numero");
            var list2 = new List<int>();
            var userFor3 = Convert.ToInt32(Console.ReadLine());
            var exit = false;
            list2.Add(userFor3);
            while (exit != true)
            {
                try
                {
                    Console.WriteLine("Ingrese un numero");
                    userFor3 = Convert.ToInt32(Console.ReadLine());
                    list2.Add(userFor3);
                    Console.WriteLine("Ingrese fin para terminar, si desea continuar ingrese N");
                    Console.WriteLine("De lo contrario su numero no sera tenido en cuenta");
                    var userFor4 = Convert.ToString(Console.ReadLine());
                    if (userFor4 == "fin")
                    {
                        exit = true;
                    }
                    else
                    {
                        exit = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese un numero");
                    userFor3 = Convert.ToInt32(Console.ReadLine());
                    list2.Add(userFor3);
                    Console.WriteLine("Ingrese fin para terminar");
                    var userFor4 = Convert.ToString(Console.ReadLine());
                    if (userFor4 == "fin")
                    {
                        exit = true;
                    }
                    else
                    {
                        exit = false;
                    }
                }
            }
            Console.WriteLine("El total de los numeros es: " + list2.Sum());
        }
    }
    //Crear una clase Cuadrado con método para calcular el área del mismo.
    public class Cuadrado
    {
        public int base1;
        public int altura;
        public int area;

        public void Area(int base1, int altura)
        {
            area = base1 * altura;
            Console.WriteLine("El area del cuadrado es: " + area);
        }
        
    }
    public class Persona
    {
        public string? Name;
        public string? LastName;
        public void FullName(string Name, string LastName)
        {
            Console.WriteLine("El nombre completo es: " + Name + " " + LastName);
        }
        //Recibir fecha de nacimiento y calcular la edad.
        public int BirthDate;
        //calcular la edad
        public int Age1;
        public void Age(int BirthDate)
        {
            var Age = DateTime.Now.Year - BirthDate;
            Console.WriteLine("La edad es: " + Age);
        }
    }
    //WARNING! Ejercicios 13 y 14 aun no completados
    public class Auto
    {
        public string? Marca;
        public string? Modelo;
        public int? Año;
        public string? Color;
        public int Velocidad = 50;
        //estado del auto, encendido o apagado
        public bool? Estado;
        public bool? Conductor;
        public int Edad1;
        public bool? Mayor;
        public int Capacidad = 4;
        public bool? Disponible;
        public string? Tamano = "Chico";
        public bool? masky;
        public void AutoInfo(string Marca = "Nissan", string Modelo = "Nigara", int Año = 2028, string Color = "Rojo")
        {
            Console.WriteLine("La marca del auto es: " + Marca + " " + Modelo + " " + Año + " " + Color);
        }
        public void EdadConductor( int edad)
        {
            if (edad >= 18)
            {
                Mayor = true;
                Console.WriteLine("El conductor es mayor de edad");
            }
            else
            {
                Mayor = false;
                Console.WriteLine("El conductor es menor de edad");
            }
        }
        public void ConductorHay(string conductor)
        {
            if (conductor == "si")
            {
                Conductor = true;
                Console.WriteLine("El conductor esta dentro del auto");
            }
            else
            {
                Conductor = false;
                Console.WriteLine("El conductor no esta dentro del auto");
            }
            }
            //metodo encender y apagar el motor
            //Si el motor esta encendido, podemos acelerar y frenar
            //Al acelerar el auto incrementa unn 10% su velocidad
            //Al frenar el auto decrementa un 20% su velocidad
        public void Encender()
        {
            if (Conductor == true && Mayor == true)
            {
                Estado = true;                
                Console.WriteLine("El auto esta encendido");
            }
            if (Conductor == false && Mayor == true)
            {
                Console.WriteLine("El auto esta apagado ya que no hay conductor");
            }
            if (Conductor == true && Mayor == false)
            {
                Console.WriteLine("El auto esta apagado ya que el conductor es menor de edad");
            }
            if (Conductor == false || Mayor == false)
            {
                Console.WriteLine("El auto esta apagado ya que o el conductor no esta en el vehiculo o el conductor es menor de edad");
            }
        }
        public void Acelerar()
        {
            if (Estado == true)
            {
                Velocidad = Velocidad * 10/100;
                Console.WriteLine("La velocidad es: " + Velocidad);
            }
            else
            {
                Console.WriteLine("El auto esta apagado");
            }
        }
        public void Frenar()
        {
            if (Estado == true)
            {
                Velocidad = Velocidad * 20/100;
                Console.WriteLine("La velocidad es: " + Velocidad);
            }
            else
            {
                Console.WriteLine("El auto esta apagado");
            }

        }
        public void Apagar()
        {
            
            Estado = false;
            Console.WriteLine("El auto esta apagado");
        }
        //metodo para conocer la velocidad
        public void Velocidad1()
        {
            Console.WriteLine("La velocidad actual es: " + Velocidad);
        }
        //estado del auto, encendido o apagado
        public void Estado1()
        {   
            if (Estado == true)
            {
                Console.WriteLine("El auto esta encendido");
            }
            else
            {
                Console.WriteLine("El auto esta apagado");
            }
        }
        public void Pasajeros(int pasaj)
        {
            if (pasaj >= Capacidad)
            {
                Disponible = false;
                Console.WriteLine("El auto esta lleno.");
            }
            if (masky == true)
            {
                pasaj++;
                if (pasaj <= Capacidad)
                {
                    Disponible = false;
                    Console.WriteLine("El auto esta lleno y con un animal mas!.");
                }
                else
                {
                    Disponible = true;
                    Console.WriteLine("El auto aun tiene capacidad.");
                }
            }
            else
            {
                Disponible = true;
                Console.WriteLine("El auto aun tiene capacidad.");
            }
        }

        //WARNING!! Ejercicios 13 y 14 aun no completados
        public void Mascota( string mascota1)
        {
            if (Conductor == true && Mayor == true && mascota1 == "chico" && Capacidad <= 4)
            {
                masky = false;                
                Console.WriteLine("El auto ahora tiene una mascota");
            }
            if (Conductor == false || Mayor == false)
            {
                masky = false;
                Console.WriteLine("El auto no lleva mascota, de hecho no va a ningun lado!!");
            }
            if (mascota1 != "chico" && Capacidad < 4)
            {
                masky = true;
                Console.WriteLine("La mascota ha tomado el lugar de alguien :)");
            }
            if (mascota1 != "chico" && Capacidad == 4)
            {
                masky = false;
                Console.WriteLine("El auto no puede llevar mas mascotas");
            }

            
        }
        
    }
    public class Mascota
    {
        public string? Nombre;
        public string? tipo;//perro o gato
        public int energia = 20;
        //La mascota tiene nombre y tipo
        public void MascotaInfo(string Nombre, string tipo)
        {
            Console.WriteLine("El nombre de la mascota es: " + Nombre + " " + tipo);
        }
        //metodo para alimentarlo. Cada vez que come su energia aumenta en un 30%
        public void Alimentar()
        {
            energia = energia + energia * 30 / 100;
            Console.WriteLine("Tu mascota se ha alimentado, ahora su energia es: " + energia);
        }
        public void Correr()
        {
            //cada vez que corre su energia disminuye en un 10% y solo puede correr si tiene energia superior a 20
            if (energia > 20)
            {
                energia = energia - energia * 10 / 100;
                Console.WriteLine("Tu mascota ha corrido, ahora su energia es: " + energia);
            }
            else
            {
                Console.WriteLine("Tu mascota no tiene energia suficiente para correr");
            }

        }

    }
    public class Smarthphone
    {
        public string? Marca;
        public string? Modelo;
        public int? Volumen = 10;
        public int? Brillo = 20;
        //Smarthphone info
        public void SmarthphoneInfo(string Marca, string Modelo)
        {
            Console.WriteLine("La marca del smartphone es: " + Marca + " " + Modelo);
        }

        //Encender o apagar el celular
        public void Encender()
        {
            Console.WriteLine("El celular esta encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("El celular esta apagado");
        }
        //Silenciar el celular
        public void Silenciar()
        {
            Console.WriteLine("El celular esta silenciado");
        }
        //metodo para subir y bajar el volumen
        public void VolumenUp()
        {
            Volumen = Volumen + 1;
            Console.WriteLine("El volumen es: " + Volumen);
        }
        public void VolumenDown()
        {
            Volumen = Volumen - 1;
            Console.WriteLine("El volumen es: " + Volumen);
        }
        //Subir o bajar el brillo
        public void BrilloUp()
        {
            Brillo = Brillo + 1;
            Console.WriteLine("El brillo es: " + Brillo);
        }
        public void BrilloDown()
        {
            Brillo = Brillo - 1;
            Console.WriteLine("El brillo es: " + Brillo);
        }
    }
    public class Libro
    {
        public string? Titulo;
        public string? Autor;
        public int? Paginas;
        public int? Precio;
        public bool? WasRead;
        //Libro info
        public void LibroInfo(string Titulo, string Autor, int Paginas, int Precio)
        {
            Console.WriteLine("El titulo del libro es: " + Titulo + " " + Autor + " " + Paginas + " " + Precio);
        }
        //metodo para comprar el libro
        public void Comprar()
        {
            Console.WriteLine("El libro ha sido comprado");
        }
        //metodo que diga si fue leido o no
        public void Leido()
        {
            if (WasRead == true)
            {
                Console.WriteLine("El libro ha sido leido");
            }
            else
            {
                Console.WriteLine("El libro no ha sido leido");
            }
        }
        //metodo para vender el libro
        public void Vender()
        {
            Console.WriteLine("El libro ha sido vendido");
        }
    }
    //Crear una clase Estudiante, que hereda de Persona (la clase de los puntos anteriores).
    public class Estudiante : Persona
    {
        List<Libro> libros = new List<Libro>();
        public void Libros()
        {
            //Crea Lista de libros que tiene el estudiante
            
            //Crea un libro
            Libro libro1 = new Libro();
            libro1.Titulo = "El señor de los anillos";
            libro1.Autor = "J.R.R. Tolkien";
            libro1.Paginas = 1000;
            libro1.Precio = 1000;
            libro1.WasRead = true;
            //Crea otro libro
            Libro libro2 = new Libro();
            libro2.Titulo = "El señor de los anillos 2";
            libro2.Autor = "J.R.R. Tolkien";
            libro2.Paginas = 1000;
            libro2.Precio = 1000;
            libro2.WasRead = false;
            //Crea otro libro
            Libro libro3 = new Libro();
            libro3.Titulo = "El señor de los anillos 3";
            libro3.Autor = "J.R.R. Tolkien";
            libro3.Paginas = 1000;
            libro3.Precio = 1000;
            libro3.WasRead = true;
            //Agrega los libros a la lista
            libros.Add(libro1);
            libros.Add(libro2);
            libros.Add(libro3);
        }
        //Metodo que muestre los libros leidos
        public void LibrosLeidos()
        {
            foreach (Libro libro in libros)
            {
                if (libro.WasRead == true)
                {
                    Console.WriteLine("El libro ha leido es: " + libro.Titulo);
                }
            }
        }
        //Metodo que muestre los libros no leidos
        public void LibrosNoLeidos()
        {
            foreach (Libro libro in libros)
            {
                if (libro.WasRead == false)
                {
                    Console.WriteLine("El libro no ha leido es: " + libro.Titulo);
                }
            }
        }
        //Metodo que muestra la cantidad de paginas leidas en total
        public void PaginasLeidas()
        {
            int paginas = 0;
            foreach (Libro libro in libros)
            {
                if (libro.WasRead == true)
                {
                    _ = paginas + libro.Paginas;
                }
            }
            Console.WriteLine("La cantidad de paginas leidas es: " + paginas);
        }
        //metodo que muestre cuantos libros no fueron leidos
        public void CantidadLibrosNoLeidos()
        {
            int librosNoLeidos = 0;
            foreach (Libro libro in libros)
            {
                if (libro.WasRead == false)
                {
                    _ = librosNoLeidos + 1;
                }
            }
            Console.WriteLine("La cantidad de libros no leidos es: " + librosNoLeidos);
        }
        //metodo que permita agregar o quitar libros a la lista
        public void AgregarLibros()
        {
            Console.WriteLine("Ingrese el titulo del libro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de paginas del libro");
            int paginas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del libro");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese si el libro ha sido leido o no");
            bool wasRead = Convert.ToBoolean(Console.ReadLine());
            Libro libro = new Libro();
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Paginas = paginas;
            libro.Precio = precio;
            libro.WasRead = wasRead;
            libros.Add(libro);
        }
        public void QuitarLibros()
        {
            Console.WriteLine("Ingrese el titulo del libro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de paginas del libro");
            int paginas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del libro");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese si el libro ha sido leido o no");
            bool wasRead = Convert.ToBoolean(Console.ReadLine());
            Libro libro = new Libro();
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Paginas = paginas;
            libro.Precio = precio;
            libro.WasRead = wasRead;
            libros.Remove(libro);
        }
    }
}

