using Xunit;
using ESWA01CalculadoraDeMedias;

namespace ESWA01CalculadoraDeMedias.Tests
{
    public class CalculoMediaSemestralTests
    {
        // Fórmula: (4*NP1 + 4*NP2 + 2*PIM) / 10

        [Theory]
        [InlineData(10f, 10f, 10f, 10f)]  // notas máximas
        [InlineData(0f, 0f, 0f, 0f)]   // notas mínimas
        [InlineData(8f, 8f, 8f, 8f)]   // notas iguais
        [InlineData(6f, 8f, 5f, 6.6f)] // notas diferentes com pesos
        [InlineData(5f, 7f, 6f, 6f)]   // mistura de notas
        [InlineData(7f, 6f, 10f, 7.2f)]  // PIM alto influencia menos
        public void CalcularMediaSem_NotasValidas_RetornaMediaCorreta(
            float np1, float np2, float pim, float esperado)
        {
            float resultado = CalcularMediaTests.CalcularMediaSem(np1, np2, pim);
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void CalcularMediaSem_PIMTemMenorPeso_QuaNP1eNP2()
        {
            // PIM alto (10) com NP1 e NP2 baixas (5) deve resultar em média menor que 7
            float resultado = CalcularMediaTests.CalcularMediaSem(5f, 5f, 10f);
            Assert.True(resultado < 7f);
        }
    }
}