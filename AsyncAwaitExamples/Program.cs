using System;
using System.Threading.Tasks;

namespace AsyncAwaitExamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Zaczynamy przygotowanie śniadania!");

            var smazenieBekonu = SmazBekonAsync(5);
            var przygotowanieJajek = SmazJajeczniceAsync(3);

            await Task.WhenAll(smazenieBekonu, przygotowanieJajek);

            Console.WriteLine("Śniadanie gotowe! Smacznego!");
        }

        static async Task SmazBekonAsync(int iloscPlastrów)
        {
            Console.WriteLine($"Rozpoczynam smażenie {iloscPlastrów} plastrów bekonu...");
            await Task.Delay(3000);
            Console.WriteLine("Bekon jest gotowy!");
        }

        static async Task SmazJajeczniceAsync(int iloscJajek)
        {
            Console.WriteLine($"Rozbijam {iloscJajek} jajka i zaczynam smażenie...");
            await Task.Delay(2000);
            Console.WriteLine("Mieszanie jajek...");
            await Task.Delay(2000);
            Console.WriteLine("Jajecznica jest gotowa!");
        }
    }
}