using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro("i30",2012,20);

            car.Status();
            
            car.Ligar();

            car.Acelerar();
            car.Status();

            while(car.QuantidadeAtualCombustivel > 0)
            {
                car.Acelerar();
            }
            car.Status();

            car.Abastecer(20);
            car.Acelerar();
            car.Status();

            Console.ReadKey();
        }
    }
}
