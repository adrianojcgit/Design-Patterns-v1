using patterns_gof_abstract_factory_v2.Domain.Enums;
using patterns_gof_abstract_factory_v2.Domain.Products;
using patterns_gof_abstract_factory_v2.Factory;

//Obtém as fábricas
var boloFactory = MassaAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
var pizzaFactory = MassaAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

//Cria os objetos com base no tipo : bolo
var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

//Cria os objetos com base no tipo : pizza
var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabreza);

//Exibe os detalhes
ExibeDetalhes(bolo1);
ExibeDetalhes(bolo2);
ExibeDetalhes(pizza1);
ExibeDetalhes(pizza2);

static void ExibeDetalhes(MassaBase massaBase)
{
    Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
    Console.WriteLine(massaBase.Nome);
    Console.WriteLine(massaBase?.Ingredientes[0]?.ToString());
    Console.WriteLine("\n");
}