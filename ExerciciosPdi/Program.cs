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
                  "9 - Inverter numeros\n" +
                  "10 - Verificar quantidade de vogais\n" +
                  "11 - Caixa eletronico\n" +
                  "12 - Validar Cpf");

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
                //Calcular dois valores
                Exercicio3.Calculadora();
                break;
            case MenuOpcao.ContarCaracteres:
                //Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
                Exercicio4.Palavra();
                break;
            case MenuOpcao.ValidarPlaca:
                //Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018
                Exercicio5.PlacaVeiculo();
                break;
            case MenuOpcao.DataAtual:
                // Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos
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
            case MenuOpcao.VerificarVogais:
                Vogais.veificaVogais();
                break;
            case MenuOpcao.VerificarNotas:
                Caixa.caixaEletronico();
                break;
            case MenuOpcao.VerificarCpf:
                VerificarCpf.cpf();
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
    Inverternumeros = 9,
    VerificarVogais = 10,
    VerificarNotas = 11,
    VerificarCpf = 12,
}