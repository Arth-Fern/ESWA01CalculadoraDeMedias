using Xunit;
using ESWA01CalculadoraDeMedias;

namespace ESWA01CalculadoraDeMedias.Tests
{
    public class StatusExameTests
    {
        // Aprovado final: média >= 5
        [Theory]
        [InlineData(5f, true)]   // exatamente no limite
        [InlineData(5.1f, true)]   // acima do limite
        [InlineData(10f, true)]   // nota máxima
        public void AlunoAprovadoFinal_MediaSuficiente_RetornaAprovado(float media, bool esperado)
        {
            bool resultado = CalcularMediaExameTests.AlunoAprovadoFinal(media);
            Assert.Equal(esperado, resultado);
        }

        // Reprovado final: média < 5
        [Theory]
        [InlineData(4.9f, false)]  // logo abaixo do limite
        [InlineData(3f, false)]  // bem abaixo
        [InlineData(0f, false)]  // nota mínima
        public void AlunoAprovadoFinal_MediaInsuficiente_RetornaReprovado(float media, bool esperado)
        {
            bool resultado = CalcularMediaExameTests.AlunoAprovadoFinal(media);
            Assert.Equal(esperado, resultado);
        }

        // Limite exato: 5.0 aprovado, 4.9 reprovado
        [Fact]
        public void AlunoAprovadoFinal_LimiteExato_EhAprovado()
        {
            Assert.True(CalcularMediaExameTests.AlunoAprovadoFinal(5f));
            Assert.False(CalcularMediaExameTests.AlunoAprovadoFinal(4.9f));
        }
    }
}