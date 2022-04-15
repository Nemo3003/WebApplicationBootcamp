//.NET - C# - Ejercicios - Clases 1 y 2

using System.Linq;

Console.WriteLine("Ejercicios de clases 1 y 2");
//Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición.
Console.WriteLine("Ingrese un numero");
int userNumber = Convert.ToInt32(Console.ReadLine());
if(userNumber > 100){Console.WriteLine("El valor es mayor que 100");}
if (userNumber < 100) { Console.WriteLine("El valor es menor que 100"); }

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
//Pedir un número entero por teclado y calcular si es par o impar.

Console.WriteLine("Ingrese un entero");
int userInt = Convert.ToInt32(Console.ReadLine());
if (userInt % 2 == 0){Console.WriteLine("Es par");}
if (userInt % 2 != 0){ Console.WriteLine("Es impar");}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
//Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición
if (userInt % 2 == 0) {
    int posInt = userInt / 2;
    if (posInt % 2 != 0) { Console.WriteLine($"{userInt} es numero el doble de un impar!"); } }

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

if (age1 < age2){byte howMuch = (byte)(age2 - age1);
    Console.WriteLine($"El menor es {pers1} por {howMuch} annos");
}
if (age1 > age2){ byte howMuch = (byte)(age1 - age2);
    Console.WriteLine($"El menor es {pers2} por {howMuch} annos");
}
if(age1 == age2){ Console.WriteLine("Ambos tienen la misma edad");}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
//Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.
Console.Write("Ingese el lado 1 del triangulo ");
int sidea = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el lado 2 del triangulo ");
int sideb = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el lado 3 del triangulo ");
int sidec = Convert.ToInt32(Console.ReadLine());

if (sidea == sideb && sideb == sidec){ Console.Write("Este es un triangulo equilatero");}
else if (sidea == sideb || sidea == sidec || sideb == sidec){Console.Write("Este es un triangulo isoceles");}
else{ Console.Write("Este es un triangulo escaleno");}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

//Desarrolle un programa que calcule el desglose de una cantidad dada, en
//billetes y monedas tal que se minimice la cantidad de monedas y billetes.
//Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
//donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
//imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
//$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
//tratar todos los valores como números, para los cálculos.
Console.WriteLine("Ingrese la cantidad de dinero que desea desglosar");
int dineroDado = Convert.ToInt32(Console.ReadLine());
int miles = dineroDado / 1000;
string mil = String.Format("{0:0}", miles);//devuelve los miles
int milInt = Convert.ToInt32(mil); //convierte los miles de string a int

int cientos = dineroDado / 100;
string cien = String.Format("{0:0}", cientos);
int intCien = Convert.ToInt32(cien);
int lastCalc = intCien - milInt * 10; //devuelve los cientos

int decimos = dineroDado / 10;
string diez = String.Format("{0:0}", decimos);
int decimInt = Convert.ToInt32(diez);
int newAtt = Convert.ToInt32(string.Format("{0}{1}", milInt, lastCalc));
int lastDec = decimInt - (newAtt * 10);//devuelve los decimos

int unidades = dineroDado / 1;
int lastNumber = dineroDado % 10; //devuelve el ultimo numero

List<string> cient1 = new List<string>();
int count = (int)Math.Floor(Math.Log10(dineroDado) + 1);
if(count >= 4){
    var mil1 = $"Recibes {mil} billetes de $1000";
    cient1.Add(mil1);}
if (lastCalc == 9){int cienF = lastCalc - 4; int cienF2 = lastCalc - 7; var first = $"1 billetes de ${cienF}00 y 2 de ${cienF2}00";
    cient1.Add(first);}
if (lastCalc == 8) { int cienF1 = lastCalc - 3; int cienF21 = lastCalc - 6; var second = $"1 billetes de ${cienF1}00, 1 de ${cienF21}00 y uno de $100";
    cient1.Add(second); }
if (lastCalc == 7){int cienF = lastCalc - 2; int cienF2 = lastCalc - 5; var third = $"1 billetes de ${cienF}00 y 1 de ${cienF2}00";
    cient1.Add(third);}
if (lastCalc == 6){int cienF = lastCalc - 1; int cienF2 = lastCalc - 5; var fourth = $"1 billetes de ${cienF}00 y 1 de ${cienF2}00";
    cient1.Add(fourth);}
if (lastCalc == 5){int cienF = lastCalc - 3; int cienF2 = lastCalc - 4; var fifth = $"2 billetes de ${cienF}00 y 1 de ${cienF2}00";
    cient1.Add(fifth);}
if (lastCalc == 4){int cienF = lastCalc / 2; var sixth = $"2 billetes de ${cienF}00";
    cient1.Add(sixth);}
if (lastCalc == 3){int cienF = lastCalc - 2; var seventh = $"3 billetes de ${cienF}00";
    cient1.Add(seventh);}
if (lastCalc == 2) { var eigth = $"1 billete de ${lastCalc}00"; cient1.Add(eigth); }
if(lastCalc == 1) { var ninth = "1 billete de $100"; cient1.Add(ninth); }

//--------------------------------------------------------------------------------------------------------------------------------

if (lastDec == 9){int dieF = lastDec - 4; int dieF2 = lastDec - 7; var first = $"1 billetes de ${dieF}0 y 2 de ${dieF2}0";
    cient1.Add(first);}
if (lastDec == 8) { int dieF = lastDec - 3; int dieF2 = lastDec - 6; var second = $"1 billetes de ${dieF}0, 1 de ${dieF2}0 y uno de $10";
    cient1.Add(second); }
if (lastDec == 7){int dieF = lastDec - 2; int dieF2 = lastDec - 5; var third = $"1 billetes de ${dieF}0 y 1 de ${dieF2}0";
    cient1.Add(third);}
if (lastDec == 6){int dieF = lastDec - 1; int dieF2 = lastDec - 5; var fourth = $"1 billetes de ${dieF}0 y 1 de ${dieF2}0";
    cient1.Add(fourth);}
if (lastDec == 5){int dieF = lastDec - 3; int dieF2 = lastDec - 4; var fifth = $"2 billetes de ${dieF}0 y 1 de ${dieF2}0";
    cient1.Add(fifth);}
if (lastDec == 4){int dieF = lastDec / 2; var sixth = $"2 billetes de ${dieF}0";
    cient1.Add(sixth);}
if (lastDec == 3){int dieF = lastDec - 2; var seventh = $"3 billetes de ${dieF}0";
    cient1.Add(seventh);}
if (lastDec == 2) { var eigth = $"1 billete de ${lastCalc}0"; cient1.Add(eigth); }
if (lastDec == 1) { var ninth = "1 billete de $10"; cient1.Add(ninth); }

//--------------------------------------------------------------------------------------------------------------------------------

if (lastNumber == 9){int lNumF = lastDec - 4; int lNumF2 = lastDec - 7; var first = $"1 billetes de ${lNumF} y 2 de ${lNumF2}";
    cient1.Add(first);}
if (lastNumber == 8){int lNumF = lastDec - 3; int lNumF2 = lastDec - 6; var second = $"1 billetes de ${lNumF}, 1 monedas de ${lNumF2} y 1 moneda de $1";
    cient1.Add(second);}
if (lastNumber == 7){int lNumF = lastDec - 2; int lNumF2 = lastDec - 5; var third = $"1 billetes de ${lNumF} y 1 moneda de ${lNumF2}";
    cient1.Add(third);}
if (lastNumber == 6){int lNumF = lastDec - 1; int lNumF2 = lastDec - 5; var fourth = $"1 billetes de ${lNumF} y 1 moneda de ${lNumF2}";
    cient1.Add(fourth);}
if (lastNumber == 5){int lNumF = lastDec - 3; int lNumF2 = lastDec - 4; var fifth = $"2 monedas de ${lNumF} y 1 de ${lNumF2}";
    cient1.Add(fifth);}
if (lastNumber == 4){int lNumF = lastDec / 2; var sixth = $"2 monedas de ${lNumF}";
    cient1.Add(sixth);}
if (lastNumber == 3){int lNumF = lastDec - 2; var seventh = $"1 moneda de $2 y una moneda de ${lNumF}";
    cient1.Add(seventh);}
if (lastNumber == 2) { var eigth = $"1 moneda de ${lastNumber}"; cient1.Add(eigth); }
if (lastNumber == 1) { var ninth = "1 moneda de $1"; cient1.Add(ninth); }


Console.WriteLine(String.Join(", ", cient1));