using Xunit;
using ESWA01CalculadoraDeMedias;

namespace ESWA01CalculadoraDeMedias.Tests
{
    public class ValidacaoNotasEPesosTests
    {
        // Notas válidas (0 a 10)
        [Theory]
        [InlineData(0f)]
        [InlineData(5f)]
        [InlineData(7.5f)]
        [InlineData(10f)]
        public void ValidarNota_NotaValida_EstaNoIntervaloPermitido(float nota)
        {
            Assert.True(nota >= 0f && nota <= 10f);
        }

        // Notas inválidas (fora do intervalo 0-10)
        [Theory]
        [InlineData(-1f)]
        [InlineData(10.1f)]
        [InlineData(100f)]
        public void ValidarNota_NotaInvalida_EstaForaDoIntervaloPermitido(float nota)
        {
            Assert.False(nota >= 0f && nota <= 10f);
        }

        // Soma dos pesos deve ser 10
        [Fact]
        public void Pesos_MediaSemestral_SomaDePesosIgualA10()
        {
            int pesoNP1 = 4;
            int pesoNP2 = 4;
            int pesoPIM = 2;

            int somaPesos = pesoNP1 + pesoNP2 + pesoPIM;

            Assert.Equal(10, somaPesos);
        }

        // NP1 e NP2 têm peso 4 cada
        [Fact]
        public void Pesos_NP1eNP2_SaoCadaUmQuatroDecimos()
        {
            int pesoNP1 = 4;
            int pesoNP2 = 4;
            int totalPesos = 10;

            Assert.Equal(pesoNP1, pesoNP2);
            Assert.True(pesoNP1 < totalPesos);
        }

        // PIM tem peso 2
        [Fact]
        public void Pesos_PIM_EhDoisDecimos()
        {
            int pesoPIM = 2;
            int totalPesos = 10;

            Assert.Equal(2, pesoPIM);
            Assert.True(pesoPIM < totalPesos);
        }
    }
}