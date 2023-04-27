using Personagem;

// instaciamos um objeto da classe personagem

    personagem tony = new personagem();

    // exibindo as informacoess dos objeto

    Console.WriteLine($"digite a idade do seu personagem:");
    tony.idade =int.Parse(Console.ReadLine());
    

    Console.WriteLine($" digite o nome do seu personagem");
    tony.nome = Console.ReadLine();
    

    Console.WriteLine($"informe a IA que o seu personagem utiliza: ");
    tony.ia =Console.ReadLine();
    

    Console.WriteLine(@$"
    
    
    {tony.nome},
    {tony.idade}
    {tony.aramadura}
    {tony.ia}
    
    
    
    
    ");
    

    tony.Atacar();
    tony.RestaurarArmadura();
    Console.WriteLine(tony.Defender());
    



