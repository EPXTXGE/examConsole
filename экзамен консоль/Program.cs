using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace экзамен_консоль
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сведения об автомобиле состоят из его марки, номера и фамилии владельца. Дан файл f,
            содержащий сведения о нескольких автомобилях.Найти: а) фамилии владельцев и номера
автомобилей данной марки; б) количество автомобилей каждой марки. Найденные данные записать в
файл g.*/
            Console.WriteLine("Введите марку автомобиля");
            string Marka = Convert.ToString(Console.ReadLine());
            string[] Lines0;
            string[] LinesSpace;
            int Arg;
            int BMW=0;
            int Mazda=0;
            int Nissan=0;
            
            Lines0 = File.ReadAllLines("f.txt");
            for (int i = 0; i < Lines0.Length; i++)
            {
              LinesSpace= Lines0[i].Split(' ');
              Arg = 0;

                if (LinesSpace[Arg] == Marka)
                {
                    StreamWriter writer = File.AppendText("g.txt");
                    writer.WriteLine(Lines0[i]);
                    writer.Close();
                    Console.WriteLine("Данные записаны в Debug g.txt");
                }
                if (LinesSpace[Arg] == "BMW") BMW++; 
                if (LinesSpace[Arg] == "Mazda") Mazda++;
                if (LinesSpace[Arg] == "Nissan") Nissan++;
            }
            string b = "BMW =" + BMW+" ";
            string m = "Nissan =" + Nissan+" ";
            string n = "Mazda =" + Mazda+" ";
            File.AppendAllText("g.txt",b);
            File.AppendAllText("g.txt", m);
            File.AppendAllText("g.txt", n);

            Console.ReadKey();
        }
    }
}
