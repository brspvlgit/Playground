namespace Lesson15.AIModelManager;
public static class ModelExtensions
{
    public static List<ModelLibrary.Model> GetModelsAboveAccuracy (this List<ModelLibrary.Model> models, double accuracyThreshold)
    {
        return [.. models.Where(m => m.Accuracy > accuracyThreshold)];
    }
}
