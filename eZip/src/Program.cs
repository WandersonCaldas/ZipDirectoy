using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Configuration;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Console.WriteLine("ROTINA INICIADA");

            string _caminho_origem = ConfigurationManager.AppSettings.Get("caminho_origem");
            string _caminho_destino = ConfigurationManager.AppSettings.Get("caminho_destino");
            
            System.IO.Compression.ZipFile.CreateFromDirectory(_caminho_origem, _caminho_destino);

            Console.WriteLine("ROTINA FINALIZADA");
            Console.ReadKey();
        }
    }
}
