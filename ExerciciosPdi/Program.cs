using ExerciciosPdi.Exercicios;

namespace ExerciciosPdi.Exercicio1;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Escolha o exercício:\n" +
                  "1 - Nome do usuário\n" +
                  "2 - Concatenar nome completo\n" +
                  "3 - Calculadora\n" +
                  "4 - Contar caracteres de uma frase\n" +
                  "5 - Validar placa\n" +
                  "6 - Data atual\n" +
                  "7 - Verificar numero primo\n" +
                  "8 - Sequencia de fibonacci \n" +
                  "9 - Inverter numeros");

        int opcao = int.Parse(Console.ReadLine());

        MenuOpcao escolha = (MenuOpcao)opcao;
        
        switch (escolha)
        {
            case MenuOpcao.NomeUsuario:
                //Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
                Exercicio1.NomeUsuario();
                break;
            case MenuOpcao.NomeCompleto:
                //Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
                Exercicio2.NomeSobrenome();
                break;
            case MenuOpcao.Calculadora:
                /*1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.*/
                Exercicio3.Calculadora();
                break;
            case MenuOpcao.ContarCaracteres:
                //Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
                Exercicio4.Palavra();
                break;
            case MenuOpcao.ValidarPlaca:
                /*Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;

Ao final, o programa deve exibir*** Verdadeiro*** se a placa for válida e *** Falso*** caso contrário.*/
                Exercicio5.PlacaVeiculo();
                break;
            case MenuOpcao.DataAtual:
                /* Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.*/
                Exercicio6.DataAtual();
                break;
            case MenuOpcao.NumeroPrimo:
                // Crie um programa que verifique se um número é primo.
                Exercicio7.numeroPrimo();
                break;
            case MenuOpcao.SequenciaFibonacci:
                Fibonacci.numerosFibonacci();
                break;
            case MenuOpcao.Inverternumeros:
                InverterNumero.inverte();
                break;

            default:
                Console.WriteLine("Opção invalida");
                break;
        }


    }
}

public enum MenuOpcao
{
    NomeUsuario = 1,
    NomeCompleto = 2,
    Calculadora = 3,
    ContarCaracteres = 4,
    ValidarPlaca = 5,
    DataAtual = 6,
    NumeroPrimo = 7,
    SequenciaFibonacci = 8,
    Inverternumeros = 9
}