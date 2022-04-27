//Ejercicios de la clase 3
/*
 Dado que se tiene almacenado en una lista, los resultados de los últimos 10
exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
notas de los exámenes y el promedio resultante.
 */



var notas = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
int suma = 0;
foreach (int nota in notas)
{
    suma += nota;
}
int promedio = suma / notas.Count;
//Mostrar las notas del alumno
Console.WriteLine("Las notas de los exámenes son: ");
foreach (int nota in notas){
    Console.WriteLine(nota);}
Console.WriteLine($"Promedio de notas: {promedio}");
Console.WriteLine("----------------------------------------------------");
/*
 Dada las edades de 20 personas guardadas en una lista, imprimir por
pantalla cuántos son mayores de edad y cuántos no.
 */
var edades = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1,23,94,75,27,58,92,12,35,44,25 };
int mayores = 0;
int menores = 0;
foreach (int edad in edades)
{
    if (edad >= 18)
    {
        mayores++;
    }
    else
    {
        menores++;
    }
}
Console.WriteLine($"Mayores de edad: {mayores}");
Console.WriteLine($"Menores de edad: {menores}");
Console.WriteLine("----------------------------------------------------");
/*
 Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y
el que tenga menos letras de todos.
 */
var nombres = new List<string>() { "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge", "Luis", "Javier", "Juan", "Pedro", "Maria", "Ana", "Juana", "Jorge"};
//find which one has more letters and which one has less
int mayor = 5;
int menor = 5;
foreach (string nombre in nombres)
{
    if (nombre.Length > mayor)
    {
        mayor = nombre.Length;
    }
    if (nombre.Length < menor)
    {
        menor = nombre.Length;
    }
}
//print the result
Console.WriteLine($"El nombre con más letras es: {nombres.Find(nombre => nombre.Length == mayor)}");
Console.WriteLine($"El nombre con menos letras es: {nombres.Find(nombre => nombre.Length == menor)}");
Console.WriteLine("----------------------------------------------------");
/*
 Crear una variable para guardar los nombres de elementos para una “lista de
supermercado”. Solicitar al usuario que ingrese el nombre de un elemento
que va a comprar en el super y verificar que el elemento esté en la lista. Si no
está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar
que sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y
los que compró pero no estaban en la lista. Si se quiere, mostrar también
todos los elementos que el usuario compró. Para salir el usuario debe
ingresar “fin”.
 */
var groceryList = new List<String>() {"Leche", "Cookies", "jugo", "ades", "salchichas"};
var comprados = new List<String>();
//Solicita al cliente que ingrese los nombres de los productos que desea comprar
Console.WriteLine("Ingrese los nombres de los productos que desea comprar, o ingrese 'fin' para salir");
string producto = Console.ReadLine();
//verifica si el producto está en la lista
while (producto != "fin")
{
    if (groceryList.Contains(producto))
    {
        groceryList.Remove(producto);
        comprados.Add(producto);
        Console.WriteLine($"El producto {producto} ya estaba en la lista");
    }
    else
    {
        groceryList.Add(producto);
        Console.WriteLine($"El producto {producto} no estaba en la lista");
    }
    Console.WriteLine("Ingrese los nombres de los productos que desea comprar, o ingrese 'fin' para salir");
    producto = Console.ReadLine();
}
//Muestra los productos que no compró
Console.WriteLine("Los productos que no compró son: ");
for (int i = 0; i < groceryList.Count; i++)
{
    Console.WriteLine((string)groceryList[i]);
}
//Muestra los productos que compró
Console.WriteLine("Los productos que compró son: ");
for (int i = 0; i < comprados.Count; i++)
{
    Console.WriteLine((string)comprados[i]);
}
Console.WriteLine("----------------------------------------------------");
/*
 Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en
lugares pares. Imprimir la matriz por pantalla
 */
//Crea una matriz de 5 x 5
var matriz = new char[5, 5];
//Almacena una ‘I’ en lugares impares y una ‘P’ en lugares pares
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i % 2 == 0)
        {
            matriz[i, j] = 'P';
        }
        else
        {
            matriz[i, j] = 'I';
        }
    }
}
//Imprime la matriz por la pantalla respetando los lugares pares e impares
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matriz[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("----------------------------------------------------");
/*
 Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los
días de la semana. La estructura es para registrar la temperatura diaria de
una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la
matriz de forma aleatoria para el mes de mayo donde el primer día inicia en
lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada
con valores aleatorios desde el principio del programa, no es necesario pedir
los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
a. Obtener la temperatura más alta y baja de la semana y que día se
produjo (lunes,martes, etc etc).
b. Promedio de temperatura de la semana.
c. Temperatura más alta del mes y su día.
 */
//Crea una matriz de 5 x 7
var matriz2 = new int[5, 7];
//Llena la matriz de forma aleatoria
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        matriz2[i, j] = new Random().Next(7, 38);
    }
}
//Imprime la matriz por la pantalla
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(matriz2[i, j]);
    }
    Console.WriteLine();
}
//Obtiene la temperatura más alta y baja de la semana y que día se produjo
int mayor2 = matriz2[0, 0];
int menor2 = matriz2[0, 0];
int diaMayor = 0;
int diaMenor = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (matriz2[i, j] > mayor2)
        {
            mayor2 = matriz2[i, j];
            diaMayor = j;
        }
        if (matriz2[i, j] < menor2)
        {
            menor2 = matriz2[i, j];
            diaMenor = j;
        }
    }
}
//Imprime la temperatura más alta y baja de la semana y que día se produjo
Console.WriteLine($"La temperatura más alta es {mayor} y se produjo el día {diaMayor}");
Console.WriteLine($"La temperatura más baja es {menor} y se produjo el día {diaMenor}");
//Obtiene el promedio de temperatura de la semana
int suma2 = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        suma2 += matriz2[i, j];
    }
}
int promedio2 = suma / 35;
//Imprime el promedio de temperatura de la semana
Console.WriteLine($"El promedio de temperatura de la semana es {promedio2}");
//Obtiene la temperatura más alta del mes y su día
int mayor3 = matriz2[0, 0];
int diaMayor2 = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (matriz2[i, j] > mayor3)
        {
            mayor3 = matriz2[i, j];
            diaMayor2 = j;
        }
    }
}
//Imprime la temperatura más alta del mes y su día
Console.WriteLine($"La temperatura más alta del mes es {mayor2} y se produjo el día {diaMayor2}");
Console.WriteLine("----------------------------------------------------");
/*
 Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la
primera fila y la primera columna se debe guardar los números (de 0 a 9),
estando el cero en la primera posición (fila 0, columna 0). El resto de los
lugares debe ser calculado usando los números que se dispone, por ejemplo,
en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o
arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla
 */
//crea una matriz de 9 x 9
var matriz3 = new int[9, 9];
//llena la matriz con tablas de multiplicar del 1 al 9
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        if (i == 0 && j == 0)
        {
            matriz3[i, j] = 0;
        }
        else
        {
            matriz3[i, j] = i * j;
        }
    }
}
//imprime la matriz por la pantalla
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(matriz3[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("----------------------------------------------------");