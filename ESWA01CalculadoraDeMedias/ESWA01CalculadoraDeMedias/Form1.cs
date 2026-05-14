using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ESWA01CalculadoraDeMedias
{
    public partial class Form1 : Form
    {
        private int pontosCarregamento;
        public Form1()
        {
            InitializeComponent();
            // Deixa o grupo de exibição do exame invísivel ao inicializar o programa
            grpExam.Visible = false;
            labelAC.Visible = false;
            textBoxAC.Visible = false;

        }



        private void txt_NP1_TextChanged_1(object sender, EventArgs e)
        {
            float nota;

            if (!ValidadorDeNotas.ValidarNota(txt_NP1, out nota))
                return;
        }

        private void txt_NP2_TextChanged_1(object sender, EventArgs e)
        {
            float nota;

            if (ValidadorDeNotas.ValidarNota(txt_NP2, out nota))
                return;
        }

        private void txt_PIM_TextChanged_1(object sender, EventArgs e)
        {
            float nota;

            if (ValidadorDeNotas.ValidarNota(txt_PIM, out nota))
                return;
        }

        // Botão que calcula a média semestral
        private void btn_Calc_Sem_Click_1(object sender, EventArgs e)
        {
            // Verifica se alguma textbox está vazia, se estiver retorna ao usuário
            if (txt_NP1.Text == "" || txt_NP2.Text == "" || txt_PIM.Text == "")
            {
                MessageBox.Show("Uma das caixas não está preenchida", "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float np1, np2, pim, ac = 0;

            if (!ValidadorDeNotas.ValidarNota(txt_NP1, out np1) || !ValidadorDeNotas.ValidarNota(txt_NP2, out np2) || !ValidadorDeNotas.ValidarNota(txt_PIM, out pim))
            {
                return;
            }

            //Valida AC apenas se o checkbox for selecionado
            if (checkBoxAC.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBoxAC.Text))
                {
                    MessageBox.Show("Preencha a nota da Atividade Complementar",
                                   "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxAC.Focus();
                    return;
                }

                if (!ValidadorDeNotas.ValidarNota(textBoxAC, out ac))
                {
                    return;
                }
            }

            float media = CalcularMedia.CalcularMediaSem(np1, np2, pim, ac);
            if (CalcularMedia.AlunoAprovadoSem(media))
            {
                status.Text = "Aprovado!!";
                status.ForeColor = Color.Blue;
                label_Calc_Sem.Text = media.ToString();
            }
            else
            {
                MessageBox.Show("Nota abaixo de 7! Por favor, insira sua nota no exame", "Retido para Exame");
                status.Text = "Aguardando nota do Exame...";
                status.ForeColor = Color.Orange;
                label_Calc_Sem.Text = media.ToString();

                // Define o grupo do exame como visível e trava as textboxes e botões anteriores
                grpExam.Visible = true;
                txt_NP1.ReadOnly = true;
                txt_NP2.ReadOnly = true;
                txt_PIM.ReadOnly = true;
                btn_Erase_Sem.Enabled = false;
                btn_Calc_Sem.Enabled = false;

                timer_waiting.Start();
            }
        }

        private void btn_Erase_Sem_Click_1(object sender, EventArgs e)
        {
            txt_NP1.Clear();
            txt_NP2.Clear();
            txt_PIM.Clear();
        }

        private void txt_Exam_TextChanged_1(object sender, EventArgs e)
        {
            float nota;

            if (ValidadorDeNotas.ValidarNota(txt_Exam, out nota))
            {
                return;
            }
        }

        private void btn_Erase_Exam_Click_1(object sender, EventArgs e)
        {
            txt_Exam.Clear();
        }

        // calcula a média final

        private void btn_Calc_Final_Click_1(object sender, EventArgs e)
        {
            timer_waiting.Stop();
            // Verifica se a caixa de exame não está preenchida, e retorna ao usuário
            float media_Semestral = float.Parse(label_Calc_Sem.Text);
            if (txt_Exam.Text == "")
            {
                MessageBox.Show("Uma das caixas não está preenchida", "erro 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float exam;

            if (!ValidadorDeNotas.ValidarNota(txt_Exam, out exam))
            {
                return;
            }

            float nota_final = CalcularMedia.CalcularMediaFinal(media_Semestral, exam);
            if (CalcularMedia.AlunoAprovadoFinal(nota_final))
            {
                status.Text = "Aprovado!!";
                status.ForeColor = Color.Blue;
                label_Calc_Final.Text = nota_final.ToString("F1");
            }
            else
            {
                status.Text = "Reprovado :(";
                status.ForeColor = Color.Red;
                label_Calc_Final.Text = nota_final.ToString();
            }


        }

        private void grpExam_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reseta o programa para o estado inicial

            txt_NP1.Clear();
            txt_NP2.Clear();
            txt_PIM.Clear();
            txt_Exam.Clear();
            label_Calc_Sem.Text = "0,0";
            label_Calc_Final.Text = "0,0";
            status.Text = "STATUS";
            status.ForeColor = Color.Black;
            grpExam.Visible = false;
            txt_NP1.ReadOnly = false;
            txt_NP2.ReadOnly = false;
            txt_PIM.ReadOnly = false;
            btn_Erase_Sem.Enabled = true;
            btn_Calc_Sem.Enabled = true;
            timer_waiting.Stop();

        }

        // configura o timer para os pontos no "Aguardando nota do Exame..."
        private void timer1_Tick(object sender, EventArgs e)
        {
            pontosCarregamento++;

            if (pontosCarregamento > 3)
            {
                pontosCarregamento = 0;
            }

            status.Text = "Aguardando nota do exame" + new string('.', pontosCarregamento);

        }

        private void checkBoxAC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAC.Checked)
            {
                labelAC.Visible = true;
                textBoxAC.Visible = true;
            }
            else
            {
                labelAC.Visible = false;
                textBoxAC.Visible = false;
            }
        }

        private void textBoxAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAC_Click(object sender, EventArgs e)
        {

        }
    }
}
