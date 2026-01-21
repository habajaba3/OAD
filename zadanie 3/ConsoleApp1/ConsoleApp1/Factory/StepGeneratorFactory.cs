using ConsoleApp1.StepGenerator;

namespace ConsoleApp1.Factory;

public static class StepsGeneratorFactory
{
    public static IStepsGenerator Create(string mode)
        => mode == "R" ? new RecursiveStepsGenerator()
            : new IterativeStepsGenerator();
}