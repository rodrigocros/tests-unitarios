using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buscaEu
{   

    public static class buscaEu
    {
        public static bool CorridaAtiva { get; set; }
        
        // public static List<Passageiro> Passageiros { get; set; } = new List<Passageiro>{
        //     new Passageiro(){
        //         Id = 1,
        //         Nome ="Rodrigo",
        //         Distancia = 32,
        //     },
        //     new Passageiro(){
        //         Id = 2,
        //         Nome = "Jose",
        //         Distancia = 56,
        //     },
        //     new Passageiro(){
        //         Id = 3,
        //         Nome = "Maria",
        //         Distancia = 106,
        //     }
        // };
        
    
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

            return passageiroMaisperto;

        }
    
    }
}