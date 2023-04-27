using criando_celular;



celular novo = new celular();




/*Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
Só será possível executar tais métodos se o celular estiver ligado.
Envie o link do repositório como entrega desta atividade.*/

Console.WriteLine(@$"
-------------------------------
|           Programa          |
|                             |
|           Celular           |
|                             |
|    selecione uma da opcoes  | 
|      1.ligar                |
|      2.cor                  |
|      3.modelo               |
|      4.Tamanho             |
-------------------------------




");









Console.WriteLine($"gostaria de ligar o celular?");
char ligar = '0' ;



string cor= Console.ReadLine();


Console.WriteLine($"qual o modelo do celular?");

string modelo = Console.ReadLine();



string tamanho=Console.ReadLine();





switch (ligar)
{
    case '1':
          
       ligar=char.Parse(Console.ReadLine());

if (ligar == 1)
{
    







}







 break;

    case '2':
       
       Console.WriteLine($"qual a cor ?");
       
       cor=Console.ReadLine();
       

        break;
    
    case '3':
       
       Console.WriteLine($"qual o modelo?");
       
       modelo=Console.ReadLine();
       

        break;
    
 case '4':
       
       Console.WriteLine($"qual o tamanho?");
       
       tamanho=Console.ReadLine();
       

        break;
    






    default: Console.WriteLine($"digite  a opcao correta");
    
        break;
}









