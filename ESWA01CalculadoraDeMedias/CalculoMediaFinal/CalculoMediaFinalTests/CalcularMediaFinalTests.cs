using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESWA01CalculadoraDeMedias
{
    public class CalcularMediaFinalTests
    {
        // Calcula média semestral
        public static float CalcularMediaSem(float np1, float np2, float pim, float? ac = null)
        {
            float media = (4 * np1 + 4 * np2 + 2 * pim) / 10;

            if (ac.HasValue) // checkbox de atividade extra selecionada
            {
                media += ac.Value;
            }

            if (media > 10.0f)
            {
                media = 10.0f;
            }

            return (float)Math.Round(media, 1, MidpointRounding.AwayFromZero);
        }

        // Calcula média final
        public static float CalcularMediaFinal(float media, float exame)
        {
            float final = (media + exame) / 2;

            return (float)Math.Round(final, 1, MidpointRounding.AwayFromZero);
        }

        // Aprovação semestral
        public static bool AlunoAprovadoSem(float media)
        {
            return media >= 7;
        }

        // Aprovação final
        public static bool AlunoAprovadoFinal(float media)
        {
            return media >= 5;
        }
    }
}
