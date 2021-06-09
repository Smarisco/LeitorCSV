using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using Npgsql;



namespace LeitorCSV
{
    public class Program
    {

        static void Main(string[] args)
        {
            LerArquivoJson(@"c:\Projetos\DesafioJson\Desafio.json");

        }
        static void LerArquivoJson(string pathJson)
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader(pathJson))
            {
                string json = r.ReadToEnd();
                dynamic array = serializer.DeserializeObject(json);


                var conexao = new NpgsqlConnection("User ID=postgres;Password=123;Host=localhost;Port=5432;Database=Desafio;Pooling=true;");
                Console.Write("Iniciado");

                conexao.Open();

                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine(serializer.Serialize(array));
                Console.WriteLine("");
                Console.WriteLine();

                conexao.Close();
            }
            Console.Write("Execução Finalizada!");
        }


    }


}

