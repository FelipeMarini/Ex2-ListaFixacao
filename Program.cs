using System;

namespace Ex2_ListaFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double calculo = 0;

            Console.WriteLine();
            
            Console.WriteLine("Qual o tipo de combustível que foi vendido? A(álcool) ou G(gasolina)? Por gentileza escrever A ou G apenas: \n");
            string combustivel = Console.ReadLine().ToLower();

            Console.WriteLine();

            Console.WriteLine("Quantos litros foram vendidos do combustível selecionado?: \n");
            double litros = double.Parse(Console.ReadLine());

            switch (combustivel) { 
                
                case "a": if (litros <= 20) {calculo = litros * (4.90 * 0.97);}
                          
                          else {calculo = litros * (4.90 * 0.95);};
                          
                          break;

                case "g": if(litros <= 20) {calculo = litros * (5.30 * 0.96);}

                          else {calculo = litros * (5.30 * 0.94);};

                          break;

                default: 
                
                Console.WriteLine();

                Console.WriteLine("Dado Inválido");

                         break;
                                 }

                Console.WriteLine();

                Console.WriteLine($"O total a ser pago deverá ser: ${calculo.ToString("N2")}");

        }
    }
}

                





