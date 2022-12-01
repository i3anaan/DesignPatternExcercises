using DesignPatterns.Exercises.Basic.FactoryMethod;
using DesignPatterns.Exercises.Basic.Observer;

namespace DesignPatterns.Exercises.Basic;

public static class Program
{
    public static void Main(string[] args)
    {
        // factory method exercise
        // new FactoryMethodClient().Run();
        
        // observer exercise
        new ObserverExerciseClient().Run();
    }
}