using Xunit;
using ESWA01CalculadoraDeMedias;

namespace ESWA01CalculadoraDeMedias.Tests
{
    public class CalculoMediaFinalTests
    {
        // Fórmula: (MediaSemestral + Exame) / 2

        [Theory]
        [InlineData(6f, 5f, 5.5f)] // caso típico de exame
        [InlineData(10f, 10f, 10f)]  // notas máximas
        [InlineData(0f, 0f, 0f)]   // notas mínimas
        [InlineData(6f, 8f, 7f)]   // exame bom recupera aluno
        [InlineData(6f, 4f, 5f)]   // exame no limite de aprovação
        [InlineData(6f, 3f, 4.5f)] // exame insuficiente
        public void CalcularMediaFinal_ValoresValidos_RetornaMediaCorreta(
            float mediaSem, float exame, float esperado)
        {
            float resultado = CalcularMediaFinalTests.CalcularMediaFinal(mediaSem, exame);
            Assert.Equal(esperado, resultado);
        }
    }
}