// See https://aka.ms/new-console-template for more information
//Console.WriteLine("czvoj4o");
//Console.WriteLine("Hello from Rider");

/*
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace VyvojAplikaciS2
{
    internal class program
    {
        static void Main(string[] args)
        {
            


        }
    }
}
*/

//32bit cela cislo = int
int stranaA = 10;
int stranaB = 15;
int result;

//64bit cela cislo = long
long dlouheCislo = 42L;

//3,4 * 10^-38 - 3,4 * 10^38
float desetinneCislo = 3.14F;

//3,4 * 10^-380 - 3,4 * 10^380
double desetinneCisloPresnejsi = 3.14;

decimal penize = 0.42M;

string jmeno = "David";
// NELZE string jmeno2 = 'Petr';
char pismeno = 'A';

bool pravda = true;
bool nepravda = false;

var promenna = "";





Console.Write("Delka strany A ->");
string strana1 = Console.ReadLine();
Console.Write("Delka strany B ->");
string strana2 = Console.ReadLine();

stranaA = Int32.Parse(strana1);
stranaB = Int32.Parse(strana2);

        
int obvod = (stranaA + stranaB) * 2;
int obsah = stranaA * stranaB;
//string textResult = result.ToString() + "cm";

Console.Write("Obvod je: ");
Console.Write(obvod.ToString());
Console.WriteLine("cm");

Console.WriteLine("Obsah je: " + obsah.ToString() + "cm^2");
//Console.WriteLine($"Obsah je: {obsah.ToString()} cm^2");

Console.WriteLine($"Moje jméno je: {jmeno}");

Console.WriteLine();
Console.Write("Pro ukončení stiskni enter..");
Console.ReadLine();