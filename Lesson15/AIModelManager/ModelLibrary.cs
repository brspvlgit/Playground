namespace Lesson15.AIModelManager;
public class ModelLibrary
{
    private List<Model> models = new List<Model>();

    public void AddModel (Model model)
    {
        models.Add(model);
    }

    public List<Model> GetModels ()
    {
        return models;
    }

    public List<Model> GetModelsByType (ModelType type)
    {
        return models.Where(m => m.Type == type).ToList();
    }

    public List<Model> SortModelsByDate ()
    {
        return models.OrderBy(m => m.DateCreated).ToList();
    }

    public class Model
    {
        public string Name { get; set; }
        public ModelType Type { get; set; }
        public DateTime DateCreated { get; set; }
        public double Accuracy { get; set; }

        public string GetModelInfo ()
        {
            return $"{Name} - {Type} - {Accuracy:P2} (Created: {DateCreated})";
        }

        public override string ToString ()
        {
            return $"{Name} ({Type}, {Accuracy:P2})";
        }
    }
}
