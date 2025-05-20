using System.Text.Json;

namespace Exam2
{
    public class Repository<T> : IRepository<T> where T : Model
    {
        private List<T> All { get; set; }
        private readonly string filePath;

        public Repository(string filePath)
        {
            this.filePath = filePath;
            
            All = new List<T>();
            EnsureFileExists();
        }

        public Repository<T> Load()
        {
            EnsureFileExists();
            string json = File.ReadAllText(filePath);
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    var list = JsonSerializer.Deserialize<List<T>>(json);
                    if (list != null)
                        All = list;
                }
                catch (JsonException)
                {
                    All = new List<T>(); // если файл повреждён
                }
            }
            else
            {
                All = new List<T>();
            }
            return this;
        }

        private void CallChanged()
        {
            EnsureFileExists();
            string json = JsonSerializer.Serialize(All, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, json);
        }
        
        public void Add(T item)
        {
            var entry = All.FirstOrDefault(x => x.Id == item.Id);
            if(entry != null)
                return;

            All.Add(item);
            CallChanged();
        }

        public void ReadAll()
        {
            foreach (var user in All)
            {
                Console.WriteLine(user.ToString());
            }
        }

        public void Modify(int id, T item)
        {
            var entry = All.FirstOrDefault(x => x.Id == id);
            if(entry == null)
                return;

            var index = All.IndexOf(entry);

            item.Id = id;

            All[index] = item;
            CallChanged();
        }

        public void Delete(int id)
        {
            var entry = All.FirstOrDefault(x => x.Id == id);
            if(entry == null)
                return;

            All.Remove(entry);
            CallChanged();
        }

        public void Load(IEnumerable<T> elements)
        {
            All = elements.ToList();
        }
        
        private void EnsureFileExists()
        {
            var dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(filePath))
            {
                using (var fs = File.Create(filePath))
                {
                    var empty = JsonSerializer.Serialize(new List<T>());
                    using (var sw = new StreamWriter(fs))
                        sw.Write(empty);
                }
            }
        }
    }
}