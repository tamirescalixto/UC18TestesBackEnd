using CalculadoraIMC;

namespace TestMSTest
{
    [TestClass]
    public class TesteCalcMSTest
    {
        [TestMethod]
        public void CalcularIMC()
        {
            //Arrange - Preparação
            double kg = 40;
            double altura = 1.49;
            string c = "Abaixo do peso";

            //Act - Ação
            var result = Calculadora.CalcularIMC(kg, altura);

            //Assert - Verificação
            Assert.AreEqual(c, result);
        }

        [DataTestMethod]
        [DataRow(40, 1.49, "Abaixo do peso")]
        [DataRow(50, 1.45, "Peso normal")]
        [DataRow(69, 1.64, "Sobrepeso")]
        [DataRow(89, 1.72, "Obesidade Grau 1")]
        [DataRow(99, 1.68, "Obesidade Grau 2")]
        [DataRow(122, 1.74, "Obesidade Grau 3")]

        public void CalcularIMCLista (double kg, double altura, string c)
        {
            //Act
            var result = Calculadora.CalcularIMC(kg, altura);

            //Assert
            Assert.AreEqual(c, result);
        }

    }
}