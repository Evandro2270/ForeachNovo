using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string[] pessoas = new string[] {"Maria", "Carlos", "Marcela", "Ana" };

                foreach (string nPesssoas in pessoas) {
                    Console.WriteLine(nPesssoas);
                }
            }
        }
    }
}