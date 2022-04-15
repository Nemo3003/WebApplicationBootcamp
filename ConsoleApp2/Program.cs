//.NET - C# - Ejercicios - Clases 1 y 2

Console.WriteLine("Ejercicios de clases 1 y 2");
//Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición.
Console.WriteLine("Ingrese un numero");
int userNumber = Convert.ToInt32(Console.ReadLine());
if(userNumber > 100){Console.WriteLine("El valor es mayor que 100");}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
//Pedir un número entero por teclado y calcular si es par o impar.

Console.WriteLine("Ingrese un entero");
int userInt = Convert.ToInt32(Console.ReadLine());
if (userInt % 2 == 0){Console.WriteLine("Es par");}
if (userInt % 2 != 0){ Console.WriteLine("Es impar");}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
//Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición
Console.WriteLine("Espere! veamos si este numero par es el doble de un impar!");
if (userInt % 2 == 0){
    int posInt = userInt / 2;
    if (posInt % 2 != 0){Console.WriteLine($"{userInt} es numero el doble de un impar!");}}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
//Dada un número del 1 al 10, devolver su “versión” en números romanos.
Console.WriteLine("Ingrese un numero del 1 al 10");
byte numberInt = Convert.ToByte(Console.ReadLine());
switch (numberInt)
{
    case 1:
        Console.WriteLine($"{numberInt} en numeros romanos es I");
        break;
    case 2:
        Console.WriteLine($"{numberInt} en numeros romanos es II");
        break;
    case 3:
        Console.WriteLine($"{numberInt} en numeros romanos es III");
        break;
    case 4:
        Console.WriteLine($"{numberInt} en numeros romanos es IV");
        break;
    case 5:
        Console.WriteLine($"{numberInt} en numeros romanos es V");
        break;
    case 6:
        Console.WriteLine($"{numberInt} en numeros romanos es VI");
        break;
    case 7:
        Console.WriteLine($"{numberInt} en numeros romanos es VII");
        break;
    case 8:
        Console.WriteLine($"{numberInt} en numeros romanos es VIII");
        break;
    case 9:
        Console.WriteLine($"{numberInt} en numeros romanos es IX");
        break;
    case 10:
        Console.WriteLine($"{numberInt} en numeros romanos es X");
        break;
}
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
// Leer el nombre y las edades de dos personas y devolver el nombre del menor.En caso de que tengan la misma edad también debe indicarse.
//Devolver también la diferencia de edad en caso de corresponder.
Console.WriteLine("Ingrese el nombre de la primera persona");
string pers1 = Console.ReadLine();
Console.WriteLine("Ingrese la edad de la pimera persona");
byte age1 = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Ingrese el nombre de la segunda persona");
string pers2 = Console.ReadLine();
Console.WriteLine("Ingrese la edad de la segunda persona");
byte age2 = Convert.ToByte(Console.ReadLine());

if (age1 < age2){byte howMuch = (byte)(age2 - age1);
    Console.WriteLine($"El menor es {pers1} por {howMuch} annos");
}
if (age1 > age2){ byte howMuch = (byte)(age1 - age2);
    Console.WriteLine($"El menor es {pers2} por {howMuch} annos");
}
if(age1 == age2){ Console.WriteLine("Ambos tienen la misma edad");}