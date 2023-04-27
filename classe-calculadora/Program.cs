
using classe_calculadora;

Calculadora calc= new Calculadora();








Console.WriteLine($"Por favor, Digite o 1º numero:");
float numero1= float.Parse(Console.ReadLine());

Console.WriteLine($"Por favor, Digite o 2º numero:");
float numero2=float.Parse(Console.ReadLine());

float resultado = 0;
Console.WriteLine(@$"

--------------------------------
|          Programa            |
|        Calculadora!          |
|                              |
|     Escolha uma das opcoes!  |
|      1.Somar                 | 
|      2.susbtrair             |
|      3.Multiplicar           |
|      4.Dividir               |
|      0.sair                 | 
--------------------------------



");

string opcao = (Console.ReadLine());





switch (opcao)
{
       case "1":
        

  resultado = calc.Somar(numero1,numero2);
  Console.WriteLine($"o Valor da soma entre {numero1},e {numero2} e {resultado}");
        
        
        case "2":
        

  resultado = calc.Subtrair(numero1,numero2);
  Console.WriteLine($"o Valor da soma entre {numero1},e {numero2} e {resultado}");
        




        case "3":
        

  resultado = calc.Multiplicar(numero1,numero2);
  Console.WriteLine($"o Valor da soma entre {numero1},e {numero2} e {resultado}");
        
        case "4":
        

  resultado = calc.Dividir(numero1,numero2);
  Console.WriteLine($"o Valor da soma entre {numero1},e {numero2} e {resultado}");
        
        
        break;
    
        default:Console.WriteLine($"opcao invalida");
    
        
        break;
}














