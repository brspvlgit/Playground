using Lesson15.AIModelManager;

namespace Lesson15;

internal class Program
{
    static void Main (string[] args)
    {
        var modelLibrary = new ModelLibrary();

        var model1 = new ModelLibrary.Model
        {
            Name = "Neural Network 1",
            Type = ModelType.NeuralNetwork,
            DateCreated = DateTime.Now.AddMonths(-2),
            Accuracy = 0.95
        };

        var model2 = new ModelLibrary.Model
        {
            Name = "Decision Tree 1",
            Type = ModelType.DecisionTree,
            DateCreated = DateTime.Now.AddMonths(-1),
            Accuracy = 0.85
        };

        var model3 = new ModelLibrary.Model
        {
            Name = "SVM 1",
            Type = ModelType.SVM,
            DateCreated = DateTime.Now.AddMonths(-3),
            Accuracy = 0.92
        };

        modelLibrary.AddModel(model1);
        modelLibrary.AddModel(model2);
        modelLibrary.AddModel(model3);

        var allModels = modelLibrary.GetModels();
        Console.WriteLine("All Models:");

        foreach (var model in allModels)
        {
            Console.WriteLine(model);
        }

        var highAccuracyModels = allModels.GetModelsAboveAccuracy(0.90);
        Console.WriteLine("\nModels with Accuracy > 90%:");

        foreach (var model in highAccuracyModels)
        {
            Console.WriteLine(model);
        }
    }
}
