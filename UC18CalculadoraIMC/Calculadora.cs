namespace CalculadoraIMC
{
    public static class Calculadora
    {
        public static string CalcularIMC(double kg, double altura)
        {
            double result = kg / (altura * altura);

            if (result < 18.5) 
            {
                return "Abaixo do peso";
            }
            if (result < 24.9)
            {
                return "Peso normal";
            }
            if (result < 29.9)
            {
                return "Sobrepeso";
            }
            if (result < 34.9)
            {
                return "Obesidade Grau 1";
            }
            if (result < 39.9)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3";
            }
        }
    }
}