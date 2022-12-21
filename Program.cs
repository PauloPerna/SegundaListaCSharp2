using System;

namespace Principal{
    public class Program{
        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado){
            decimal resultado = Math.Floor(porcentagem*totalNegociado/(1-porcentagem));
            return ((int)resultado);
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine($"Teste: {funcaoRetornaQuantitadePOV(0.1M, 90)}");
            System.Console.WriteLine($"Teste: {funcaoRetornaQuantitadePOV(0.1M, 100)}");
            System.Console.WriteLine($"Teste: {funcaoRetornaQuantitadePOV(0.2M, 70)}");
        }
    }
}