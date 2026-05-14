using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESWA01CalculadoraDeMedias
{
    public class ValidadorDeNotas
    {
        public static bool ValidarNota(TextBox txt, out float nota)
        {
            if (!float.TryParse(txt.Text, out nota))
            {
                if (txt.Text != "")
                {
                    MessageBox.Show(
                        "Por favor, insira um número de 0 a 10 (separação decimal por vírgula)",
                        "Non Numeral Entry",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txt.Clear();
                    txt.Focus();

                    return false;
                }
            }

            if (nota < 0 || nota > 10)
            {
                if (txt.Text != "")
                {
                    MessageBox.Show(
                        "Por favor, insira um número de 0 a 10 (separação decimal por vírgula)",
                        "Out of Range Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txt.Clear();
                    txt.Focus();

                    return false;
                }

                return true;
            }

            return true;
        }
    }
}
