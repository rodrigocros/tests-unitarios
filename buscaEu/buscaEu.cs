using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buscaEu
{   

    public class buscaEu
    {

        public static Passageiro buscaPassageiro(List<Passageiro> Passageiros)
        {   
            Passageiro passageiroMaisperto = new();

            foreach (var passageiro in Passageiros)
            {
                if(passageiro.Distancia < passageiroMaisperto.Distancia){
                    passageiroMaisperto.Id = passageiro.Id; 
                    passageiroMaisperto.Nome = passageiro.Nome;
                    passageiroMaisperto.Distancia = passageiro.Distancia;
                };
            }
            System.Console.WriteLine(passageiroMaisperto);

            return passageiroMaisperto;

        }
    
    }
}