namespace Lesson15.Static
{
    public static class ConfigurationManager
    {
        private static readonly Dictionary<string, string> _settings = new();
        private static readonly string _defaultEnvironment = "Production";
        private static bool _isInitialized;

        public static bool IsInitialized
        {
            get { return _isInitialized; }
        }

        public static string DefaultEnvironment
        {
            get { return _defaultEnvironment; }
        }

        public static int SettingsCount
        {
            get { return _settings.Count; }
        }

        static ConfigurationManager ()
        {
            InitializeDefaults();
            _isInitialized = true;
            Console.WriteLine("ConfigurationManager инициализирован.");
        }

        private static void InitializeDefaults ()
        {
            _settings["AppName"] = "MyApp";
            _settings["Version"] = "1.0";
            _settings["Environment"] = _defaultEnvironment;
        }

        public static string? GetSetting (string key)
        {
            if (_settings.TryGetValue(key, out var value))
                return value;

            return null;
        }

        public static void SetSetting (string key, string value)
        {
            if (string.IsNullOrWhiteSpace(key)) return;

            _settings[key] = value;
        }

        public static bool HasSetting (string key)
        {
            return _settings.ContainsKey(key);
        }

        public static void ClearAll ()
        {
            _settings.Clear();
            _isInitialized = false;
        }

        public static void PrintAll ()
        {
            Console.WriteLine("Настройки:");

            foreach (var kvp in _settings)
            {
                Console.WriteLine($"  {kvp.Key} = {kvp.Value}");
            }
        }
    }

    class ConfigHelper
    {
        public void Run ()
        {
            ConfigurationManager.PrintAll();

            ConfigurationManager.SetSetting("Theme", "Dark");
            Console.WriteLine($"Theme: {ConfigurationManager.GetSetting("Theme")}");

            Console.WriteLine($"Initialized: {ConfigurationManager.IsInitialized}");
            Console.WriteLine($"Всего настроек: {ConfigurationManager.SettingsCount}");

            ConfigurationManager.ClearAll();
            Console.WriteLine("После очистки:");
            ConfigurationManager.PrintAll();
        }
    }
}
