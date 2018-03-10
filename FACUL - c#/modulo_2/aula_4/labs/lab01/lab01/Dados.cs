using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab01
{
    public static class Dados
    {
        public static void Gravar(Carro car)
        {
            string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "Carro.txt";

            string arquivoCompleto = Path.Combine(meusDocumentos, arquivo);

            string titulo = @"PLACA;MODELO;COR;ANO;MARCA;COMBUSTIVEL;CAMBIO;OBSERVAÇÃO;USUARIO;DATA;HORA";

            bool flag = File.Exists(arquivoCompleto);

            using (var sw = new StreamWriter(arquivoCompleto,true,Encoding.UTF8))
            {
                if (!flag)
                {
                    sw.WriteLine(titulo);
                }
                sw.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};",
                            car.Placa,car.Modelo,car.Cor,car.Ano,
                            car.Marca,car.Combustivel,car.Cambio,
                            car.Observação,Environment.UserName,
                            DateTime.Now.ToString("dd/MM/yyyy;HH:mm:ss"));



            }
            
        }
    }
}
