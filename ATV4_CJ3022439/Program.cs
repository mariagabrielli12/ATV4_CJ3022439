using System.Diagnostics;

namespace ATV4_CJ3022439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int opc;
            Console.WriteLine("Digite o exercício que deseja visualizar:");
            opc = int.Parse(Console.ReadLine());




            float n1, n2, op;

            Console.WriteLine("digite um número:");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" 1 = soma, 2 = subtração, 3 = Divisão, 4 = multiplicação ");
            op = float.Parse(Console.ReadLine());

            switch (op)
            {

                case 0:

                    Console.WriteLine("Soma = {0}", n1 + n2);

                    break;

                case 1:

                    Console.WriteLine("subtração = {0}", n1 - n2);

                    break;

                case 2:

                    Console.WriteLine("Divisão = {0}", n1 / n2);

                    break;

                case 3:

                    Console.WriteLine("multiplicação = {0}", n1 * n2);

                    break;

                default:

                    Console.WriteLine("Opção inválida");
                    break;



                    // 1          
            }
            int s;

            Console.WriteLine("entre com um número correspondente a um dia  da  semana(1  a  7)");
            s = int.Parse(Console.ReadLine());



            switch (s)
            {

                case 0:

                    Console.WriteLine("Domingo");
                    break;

                case 1:

                    Console.WriteLine("Segunda - feira");

                    break;

                case 2:
                    Console.WriteLine("Terça - feira");

                    break;

                case 3:
                    Console.WriteLine("Quarta - feira");

                    break;

                case 4:
                    Console.WriteLine("Quinta - feira");
                    break;

                case 5:
                    Console.WriteLine("sexta - feira");
                    break;

                case 6:
                    Console.WriteLine("sábado");

                    break;

                default:

                    Console.WriteLine("Opção inválida");
                    break;



            }

            // 2

            float p, c;

            Console.WriteLine("Digite o valor da sua compra");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua forma de pagamento: 1 - à vista, 2 - PIX, 3 - débito, 4 - cartão de crédito");
            p = float.Parse(Console.ReadLine());

            switch (p)

            {

                case 1:
                    Console.WriteLine("o valor para pagar é:{0}", ((15 / 100) * c) - c);

                    break;

                case 2:

                    Console.WriteLine("o valor a pagar é {0}", ((10 / 100) * c) - c);

                    break;

                case 3:

                    Console.WriteLine("o valor a ser pago é{0}", ((5 / 100) * c) + c);

                    break;

                case 4:

                    Console.WriteLine("o valor a ser pago é{0}", ((10 / 100) * c) + c);
                    break;


                    Console.WriteLine("Opção inválida");
            }

            // 3

            int m, a;

            Console.WriteLine("Digite um número de um mês");
            m = int.Parse(Console.ReadLine());

            switch (m)
            {

                case 1:
                    Console.WriteLine("Janeiro - 31 dias");
                    break;

                case 2:

                    Console.WriteLine("o ano é bissexto 1- sim, 2 - não");
                    a = int.Parse(Console.ReadLine());

                    switch (a)
                    {

                        case 0:
                            Console.WriteLine("Digite 1 se o ano for bissexto e 2 se o ano não for");

                            break;

                        case 1:
                            Console.WriteLine("Fevereiro - 29 dias");

                            break;

                        case 2:
                            Console.WriteLine("Fevereiro - 28 dias");

                            break;
                    }

                case 3:
                    Console.WriteLine("Março - 31 dias");
                    break;

                case 4:
                    Console.WriteLine("Abril - 30 dias");
                    break;

                case 5:
                    Console.WriteLine("Maio - 31 dias");
                    break;

                case 6:
                    Console.WriteLine("Junho - 30 dias");
                    break;

                case 7:
                    Console.WriteLine("Julho - 31 dias");
                    break;

                case 8:
                    Console.WriteLine("Agosto - 31 Dias");
                    break;

                case 9:
                    Console.WriteLine("Setembro - 30 dias");

                    break;

                case 10:
                    Console.WriteLine("Outubro - 31 dias");

                    break;

                case 11:
                    Console.WriteLine("Novembro - 30 dias");
                    break;

                case 12:
                    Console.WriteLine("Dezembro - 31 dias");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }

            //4

            int nn, b;
            char c1;

            Console.WriteLine("Digite um número");
            nn = int.Parse(Console.ReadLine());

            Console.WriteLine("digite outro número");
            b = int.Parse(Console.ReadLine());

            c1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua operação 1 = +,2 = -,3 = * ou 4 = /");

            switch (c1)
            {

                case '1':
                    Console.WriteLine("Seu resultado é {0}:", (nn + b));
                    break;

                case '2':
                    Console.WriteLine("Seu resultado é {0}:", (nn - b));
                    break;

                case '3':
                    Console.WriteLine("Seu resultado é {0}:", (nn * b));
                    break;

                case '4':
                    Console.WriteLine("Seu resultado é {0}:", (nn / b));
                    break;


                    // 6

                    float s2, c2;

                    Console.WriteLine("Digite seu salário");
                    s2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite seu cargo:1-professor, 2 - secetário, 3 - publicitário");
                    c2 = float.Parse(Console.ReadLine());

                    switch (c2)
                    {
                        case 1:
                            Console.WriteLine("Novo salário = {0},", s2 + ((7.5 / 100) * s2));

                            break;

                        case 2:
                            Console.WriteLine("Novo salário = {0},", s2 + ((9.7 / 100) * s2));

                            break;

                        case 3:
                            Console.WriteLine("Novo salário = {0},", s2 + ((8.9 / 100) * s2));

                            break;

                        case 4:
                            Console.WriteLine("Novo salário = {0},", s2 + ((13.24 / 100) * s2));

                            break;

                        case 5:
                            Console.WriteLine("Novo salário = {0},", s2 + ((10.4 / 100) * s2));
                            break;


                        case 6:
                            Console.WriteLine("Novo salário = {0},", s2 + ((14.6 / 100) * s2));
                            break;

                        default:
                            Console.WriteLine("Novo salário = {0},", s2 + ((43.5 / 100) * s2));
                            break;

                    }

                    //6 

                    float kl;

                    Console.WriteLine("digite o seu salário mensal:");
                    kl = float.Parse(Console.ReadLine());

                    if (kl < 1903.98)
                    {
                        Console.WriteLine("Insento de impostos, salário líquido = {0}", kl);
                    }
                    if (kl <= 2826.65 && kl >= 1903.99)
                    {
                        Console.WriteLine("Imposto = {0}, ", 7.5 / 100 * kl, "salário líquido = {1}", kl);

                    }

                    if (kl >= 2826.66 && kl <= 3751.05)
                    {
                        Console.WriteLine("Imposto = {0}, ", 15 / 100 * kl, "salário líquido = {1}", kl);
                    }
                    if (kl >= 3751.05 && kl <= 4664.68)
                    {
                        Console.WriteLine("Imposto = {0}, ", 22.5 / 100 * kl, "salário líquido = {1}", kl);
                    }
                    else
                    {
                        Console.WriteLine("Imposto = {0}, ", 27.5 / 100 * kl, "salário líquido = {1}", kl);
                    }
            }




        }

    }
}
            
