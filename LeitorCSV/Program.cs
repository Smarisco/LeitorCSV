using System;
using System.Collections.Generic;
using System.IO;

namespace LeitorCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arquivos = ObterArquivos();

                LeituraArquivoCSV(arquivos);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private static IEnumerable<string> ObterArquivos()
        {
            var caminhoDaPasta = @"C:\Users\scandido\Desktop\Samara\facul\LBD\Eleicao\consulta_cand_2020";
            var arquivos = Directory.EnumerateFiles(caminhoDaPasta, "*.csv");

            return arquivos;
        }

        public static void LeituraArquivoCSV(IEnumerable<string> arquivos )
        {
            bool cabecalhoLinha = true;
            foreach (var arquivo in arquivos)
            {               
                using (var reader =  new StreamReader(arquivo))
                {
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var valores = linha.Split(';');

                        if (cabecalhoLinha)
                        {
                            cabecalhoLinha = false;
                            continue;
                        }
                    }

                }
            }
        }
    }
}

