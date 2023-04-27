using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personagem
{
    public class personagem
    {
        

        // declarar as propriedades
        // assinatura tipo nome = valor
        public string nome = "Tony Stark";

        public int idade = 35;

        public string armadura ="bleeding Edge";


        public string ia = "Jarvis";


//declarar os metodos

public void Atacar()
{

Console.WriteLine($"O personagem atacou!");



}


public string Defender()
{

return "O personagem atacou! ";


}



public void RestaurarArmadura()
{

Console.WriteLine($"O personagem restarou a armadura!");



}







    }
}