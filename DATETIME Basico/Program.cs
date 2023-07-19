using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATETIME_Basico {
    internal class Program {
        static void Main(string[] args) {
            //dateTime representa um instante data ou data e horario
            //tipo struct (basicamente não seria, string,int,double).
            //ticks "100 nanosegundos"
            /* DateTime Data1 = DateTime.Now; // ira devolver o instante atual do sistema (data-hora-minuto)
             Console.WriteLine(Data1);
             Console.WriteLine(Data1.Ticks);// numero long //todos os dados e horas-minutos-ano-mes-dia/extraido
             DateTime DataContrutores = new DateTime(2023, 08, 11);
             DateTime DataContrutores2 = new DateTime(2023, 08, 11,22,30,20);
             DateTime DataContrutores3 = new DateTime(2023, 08, 11,23,30,25,500);
             Console.WriteLine("---------------------------------");


             Criar datas usando o builds
              * DateTime = d1 = DateTime.Now;
              * DateTime = d2 = DateTime.Today;
              * DateTime = d3 = DateTime.utcNow;
              */

            //utilizando DateTime conversão string
            DateTime DataString = DateTime.Parse("2022/08/11");
            DateTime DataStringMinutos = DateTime.Parse("2022-08-11 20:00:55");
            DateTime DataFormatoBrasileiro = DateTime.Parse("19/07/2023 20:00:30");
            //so ira aceitar / ou - no formato
            Console.WriteLine("Utilizando o conversor de string para Data " + DataString);
            Console.WriteLine(DataStringMinutos);
            Console.WriteLine(DataFormatoBrasileiro);
            //Caso queira determinar o formato utilizaremos Parse
            DateTime DataFormatada = DateTime.ParseExact("1991-08-11","yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime DataFormatadaHorasMinutos = DateTime.ParseExact("27/08/1955 13:00:20","dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            Console.WriteLine(DataFormatada);

            Console.WriteLine("Data * horas * minutos * segundos = " + DataFormatadaHorasMinutos);
        }
    }
}
