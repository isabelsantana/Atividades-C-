using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 3;
        int c = 4;

        if ((a + b + c > 10) || (a == b))
        {

            Console.WriteLine("A resposta é maior que 10");
            Console.WriteLine("Ou o primeiro numero é igual ao segundo");
        }
        else
        {
            Console.WriteLine("A resposta não é maior que 10");
            Console.WriteLine("E o primeiro numero é igual ao segundo");
        }
    }
}