namespace testaBuscaEu;
using buscaEu;

public class TestaBuscaEU
{
    public static List<Passageiro> Passageiros { get; set; } = new List<Passageiro>{
        new Passageiro(){
            Id = 1,
            Nome ="Rodrigo",
            Distancia = 32,
        },
        new Passageiro(){
            Id = 2,
            Nome = "Jose",
            Distancia = 56,
        },
        new Passageiro(){
            Id = 3,
            Nome = "Maria",
            Distancia = 106,
        }
    };

    [Test]
    public void Test1()
    {
        var passageiroEscolhido = buscaEu.buscaPassageiro(Passageiros);
        Assert.IsNotNull(passageiroEscolhido);
    }
}