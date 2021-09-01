using System;
using System.Globalization;


namespace trianguloooo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao da variavel da classe triangulo x
            triangulo x;

            //Declaraçao da variavel da classe triangulo y
            triangulo y;

            //instaciar a variavel
            x = new triangulo();
            //instaciar a variavel
            y = new triangulo();


            //informaçao para o meu usuario
            Console.WriteLine("Quais são as medidas do triângulo X?");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculando a area do triangulo x
            Double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //resuldado da area do triangulo x
            Console.WriteLine("Área de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));


            //informaçao para o meu usuario
            Console.WriteLine("Quais são as medidas do triângulo Y?");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculando a area do triangulo y
            Double j = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(j * (j - y.A) * (j - y.B) * (j - y.C));

            //resuldado da area do triangulo y
            Console.WriteLine("Área de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));


            //definição da area maior
            if (areaX > areaY)
            {
                Console.WriteLine("AreaX é a maior área!!");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("areaY é a maior área!!");
            }
            else 
            {
                Console.WriteLine("as 2 areas tem o mesmo tamanho");
            }
        }
    }
}

