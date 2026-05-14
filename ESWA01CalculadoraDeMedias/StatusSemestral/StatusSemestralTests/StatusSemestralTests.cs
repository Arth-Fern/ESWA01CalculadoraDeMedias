using Xunit;
using ESWA01CalculadoraDeMedias;

namespace ESWA01CalculadoraDeMedias.Tests
{
    public class StatusSemestralTests
    {
        // Aprovado semestral: média >= 7
        [Theory]
        [InlineData(7f, true)]   // exatamente no limite de aprovação
        [InlineData(7.1f, true)]   // acima do limite
        [InlineData(10f, true)]   // nota máxima
        public void AlunoAprovadoSem_MediaSuficiente_RetornaAprovado(float media, bool esperado)
        {
            bool resultado = CalcularMediaSemestralTests.AlunoAprovadoSem(media);
            Assert.Equal(esperado, resultado);
        }

        // Reprovado semestral: média < 7 (vai para exame)
        [Theory]
        [InlineData(6.9f, false)]  // logo abaixo do limite
        [InlineData(5f, false)]  // abaixo da média
        [InlineData(0f, false)]  // nota mínima
        public void AlunoAprovadoSem_MediaInsuficiente_RetornaReprovado(float media, bool esperado)
        {
            bool resultado = CalcularMediaSemestralTests.AlunoAprovadoSem(media);
            Assert.Equal(esperado, resultado);
        }

        // Limite exato: 7.0 aprovado, 6.9 reprovado
        [Fact]
        public void AlunoAprovadoSem_LimiteExato_EhAprovado()
        {
            Assert.True(CalcularMediaSemestralTests.AlunoAprovadoSem(7f));
            Assert.False(CalcularMediaSemestralTests.AlunoAprovadoSem(6.9f));
        }
    }
}