

namespace Aulas
{
    class Program
    {

        static void Main(string[] args)
        {
            ListName();
            Nota();

        }

        static void ListName()
        {
            Console.Write("Informe seu nome completo:  ");
            string respostaName = Console.ReadLine();



            Console.WriteLine($"Sejá bem vindo {respostaName}! ");
        }

        static void Nota()
        {
            double respostaNotaUm;
            Console.Write("Informe aqui o valor da primeira nota:  ");
            respostaNotaUm = Convert.ToDouble(Console.ReadLine());

            double respostaNotaDois;
            Console.Write("Informe aqui o valor da segunda nota:  ");
            respostaNotaDois = Convert.ToDouble(Console.ReadLine());

            int mesNota;
            Console.Write("Informe o mês do vencimento da sua fatura:  ");
            mesNota = Convert.ToInt32(Console.ReadLine());

            if (mesNota >= 13)
            {
                Console.WriteLine("Dados incorretos!");
                return;
            }
            else if (mesNota <= 0)
            {
                Console.WriteLine("Dados incorretos!");
                return;
            }

            else if (mesNota <= 12)
            {
                switch (mesNota)
                {
                    case 1: Console.WriteLine("Janeiro"); break;
                    case 2: Console.WriteLine("Fevereiro"); break;
                    case 3: Console.WriteLine("Março"); break;
                    case 4: Console.WriteLine("Abril"); break;
                    case 5: Console.WriteLine("Maio"); break;
                    case 6: Console.WriteLine("Junho"); break;
                    case 7: Console.WriteLine("Julho"); break;
                    case 8: Console.WriteLine("Agosto"); break;
                    case 9: Console.WriteLine("Setembro"); break;
                    case 10: Console.WriteLine("Outubro"); break;
                    case 11: Console.WriteLine("Novembro"); break;
                    case 12: Console.WriteLine("Dezembro"); break;
                    default: Console.WriteLine("Dados incorretos!"); break;

                }



            }




            Console.WriteLine("Lembrando que se passar do mês 5, sua fatura vai ter um aumento de 15% ");

            var somaNotas = respostaNotaUm + respostaNotaDois;
            var juros = 10.0 / 100.0;  // 10% de Juros

            var somarJuros = somaNotas + (juros * somaNotas);

            if (mesNota >= 5)
            {
                Console.WriteLine($"Valor total sem os juros: {somaNotas} ");
                Console.WriteLine($"Valor total com os juros: {somarJuros} ");
            }
            else
            {
                Console.WriteLine("Sua fatura venceu no mês anterior que o mês 5, você não irar pagar juros! ");
                Console.WriteLine($"Valor total da sua fatura: {somaNotas} ");
            }

        }






    }


}

