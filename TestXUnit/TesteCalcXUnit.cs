using CalculadoraIMC;

namespace TestXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void CalcularIMC()
        {
            //Arrange - Preparação
            double kg = 40;
            double altura = 1.49;
            string c = "Abaixo do peso";

            //Act - Ação
            var result = Calculadora.CalcularIMC(kg, altura);

            //Assert - Verificação
            Assert.Equal(c, result);
        }
        [Theory]
        [InlineData(40, 1.49, "Abaixo do peso")]
        [InlineData(50, 1.45, "Peso normal")]
        [InlineData(69, 1.64, "Sobrepeso")]
        [InlineData(89, 1.72, "Obesidade Grau 1")]
        [InlineData(99, 1.68, "Obesidade Grau 2")]
        [InlineData(122, 1.74, "Obesidade Grau 3")]

        public void CalcularIMCLista(double kg, double altura, string c)
        {
            var result = Calculadora.CalcularIMC(kg, altura);
            Assert.Equal(c, result);
        }
    }
}