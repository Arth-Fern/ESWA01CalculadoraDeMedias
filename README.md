# Calculadora de Médias Semestral e Final

Projeto desenvolvido para as disciplinas **Engenharia de Software Ágil Aplicada (ESWA)** e **Programação Orientada a Objetos (POO-C#)**.

Aplicativo Windows para cálculo de médias semestrais e finais de alunos, seguindo as regras de várias instituições de ensino.

------------------

## Sobre o Projeto

Este sistema permite o cálculo automatizado da **Média Semestral** e **Média Final** dos alunos, aplicando as regras padrão definidas pela instituição:

- **Média Semestral**: `(4×NP1 + 4×NP2 + 2×PIM) / 10`
- **Média Final**: `(Média Semestral + Exame) / 2`

O aplicativo também gerencia o status do aluno (Aprovado, Em Exame, Reprovado) e aplica arredondamento matemático conforme especificado.

------------------

## Funcionalidades

- Cálculo da Média Semestral
- Cálculo da Média Final
- Validação completa das notas (0,0 a 10)
- Sanitização e tratamento de entrada
- Status dinâmico com cores (Azul = Aprovado, Laranja = Em Exame, Vermelho = Reprovado)
- Botão "Limpar Tudo" para reset completo do formulário
- Interface amigável em Windows Forms

------------------

## Tecnologias Utilizadas

- **Linguagem**: C# 
- **Framework**: .NET Framework 4.7.2
- **Paradigma**: Programação Orientada a Objetos (POO)
- **Interface**: Windows Forms
- **Testes**: xUnit (em desenvolvimento)
- **Padrões**: SOLID, Código Limpo

------------------

## Estrutura do Projeto

- **`ESWAEECalculadoraDeMedias`** -> Biblioteca de Classes (Camada de Negócio)
- **`CalculadoraDeMediasEE`** -> Aplicação Executável (Windows Forms)

------------------

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/SEU_USUARIO/SEU_REPOSITORIO.git
