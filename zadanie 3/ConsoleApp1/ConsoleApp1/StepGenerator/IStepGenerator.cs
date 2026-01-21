using ConsoleApp1.Model;

namespace ConsoleApp1.StepGenerator;

public interface IStepsGenerator
{
    IEnumerable<string> GenerateSteps(Quest quest);
}