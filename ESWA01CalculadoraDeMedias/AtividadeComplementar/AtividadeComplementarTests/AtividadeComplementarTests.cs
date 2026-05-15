using Xunit;
using ESWA01CalculadoraDeMedias;

namespace ESWA01CalculadoraDeMedias.Tests
{
    public class AtividadeComplementarTests
    {
        // Fórmula:
        // Média = ((4 * NP1 + 4 * NP2 + 2 * PIM) / 10) + AC
        // Média máxima = 10

        [Theory]
        [InlineData(8f, 8f, 8f, 1f, 9f)]      // soma AC corretamente
        [InlineData(10f, 10f, 10f, 2f, 10f)] // impede média maior que 10
        [InlineData(7f, 7f, 7f, 0f, 7f)]     // AC zero não altera média
        [InlineData(6f, 6f, 6f, 1f, 7f)]     // AC ajuda aprovação
        [InlineData(9f, 8f, 7f, 0.5f, 8.7f)]   // soma decimal corretamente
        [InlineData(5f, 5f, 5f, 2f, 7f)]     // AC aumenta média baixa
        [InlineData(9.5f, 9.5f, 9.5f, 1f, 10f)] // arredonda e limita em 10
        public void CalcularMediaSem_ComAC_RetornaMediaCorreta(
            float np1, float np2, float pim, float ac, float esperado)
        {
            // Act
            float resultado = CalcularMediaAtividadeComplementarTests.CalcularMediaSem(np1, np2, pim, ac);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}