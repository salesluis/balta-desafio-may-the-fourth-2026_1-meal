using balta_desafio_may_the_fourth_2026_1_meal.AI.Abstractions;
using Microsoft.Extensions.AI;

namespace balta_desafio_may_the_fourth_2026_1_meal.AI.Agents;

public class SuggestedRecipesAgent(string systemPrompt) : AgentCreator
{
    protected override string Uri => "http://localhost:11434";
    protected override string Model => "phi3:latest";
    protected override string SystemPrompt => systemPrompt;

    protected override AITool[] Tools => [];
}