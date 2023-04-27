
/*
Crie uma classe Aluno com as seguintes propriedades:

Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
Também teremos os métodos: 

VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

obs:
bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
outros casos a mensalidade será integral
Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
*/

Console.WriteLine(@$"

----------------------------------------
|                                      |
|                                      |
|      Programa Cadastro de Alunos     |
|                                      |
|                                      |
----------------------------------------                                      


");





Console.WriteLine($"Por Favor preencha as informacoes solicitadas!");


Console.WriteLine($"digite o nome do aluno:");
string nome = Console.ReadLine();

Console.WriteLine($"digite o curso do aluno:");
string curso = Console.ReadLine();


Console.WriteLine($"digite a idade do aluno:");
string idade = Console.ReadLine();

Console.WriteLine($"digite o Rg do aluno:");
int rg = int.Parse(Console.ReadLine());

Console.WriteLine($"E bolsista?:  digite 1 para sim e 2 para nao:");
int bolsista= int.Parse(Console.ReadLine());


Console.WriteLine($"digite o valor da mensalidade:");
float mensalidade =float.Parse(Console.ReadLine());

Console.WriteLine();


switch (bolsista )
{
    case 1 :
        
Console.WriteLine($"digite a media final:");
float mediaFinal=float.Parse(Console.ReadLine());


     


if (mediaFinal == 8 )
{
    
Console.WriteLine($"sera aplicado um desconto de 50% na mensalidade");



}
else
{
    
Console.WriteLine($"nao sera aplicado desconto!");


}



case 2 :
        
Console.WriteLine($"digite a media final:");
float mediaFinal=float.Parse(Console.ReadLine());


       break;
    default:

        break;



}