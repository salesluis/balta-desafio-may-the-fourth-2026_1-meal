
using balta_desafio_may_the_fourth_2026_1_meal.AI;

Console.Clear();
Console.WriteLine("Bem vindo ao Receita Express");

while (true)
{
    Console.WriteLine("User > ");
    var prompt = Console.ReadLine();

    var agent = AgentFactory.GetAgent("suggested-recipes");
    
await foreach(var token in agent!.RunStreamingAsync(prompt!))
        Console.Write(token.Text);
}


