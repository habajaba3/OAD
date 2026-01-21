using ConsoleApp1.Model;

namespace ConsoleApp1.StepGenerator;

public class IterativeStepsGenerator : IStepsGenerator
{
    public IEnumerable<string> GenerateSteps(Quest quest)
    {
        for (int i = 1; i <= quest.Difficulty; i++)
            yield return $"  Krok {i}: {StepText(i, quest.Place)}";
    }

    private static string StepText(int stepNumber, string place)
        => stepNumber % 2 == 1 ? $"Idź {place} i rozejrzyj się."
            : "Zrób akcję: szukaj / walcz / zbierz.";
}