using System;

namespace EstudoSharp
{
    class ConversorDeMoedas
    {
        public ConversorDeMoedas()
        {
            double dolar = 23.73;
            int dong = UsdToVnd(dolar); // vietnamita

            Console.WriteLine($"${dolar} USD = ${dong} VND");
            Console.WriteLine($"${dong} VND = ${VndToUsd(dong)} USD");

            int UsdToVnd(double dolar)
            {
                int taxa = 23500;
                return (int)(taxa * dolar);
            }

            double VndToUsd(int dong)
            {
                double taxa = 23500;
                return dong / taxa;
            }
        }
    }
}
