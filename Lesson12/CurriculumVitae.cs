namespace Lesson12;

public class CurriculumVitae
{
    // Константа, например, максимальное количество символов в описании
    public const int MaxDescriptionLength = 1000;

    // Свойства
    public string FullName { get; set; }
    public string ContactInfo { get; set; }
    public string Summary { get; set; }
    public int YearsOfExperience { get; set; }
    public ConsoleColor TextColor { get; private set; }

    // Список навыков
    public List<string> Skills { get; set; }

    // Список предыдущих мест работы
    public List<string> WorkExperience { get; set; }

    // Конструктор по умолчанию
    public CurriculumVitae ()
    {
        // Инициализация значений по умолчанию
    }

    // Конструктор с параметрами
    public CurriculumVitae (string fullName, string contactInfo, int yearsOfExperience)
    {
        // Реализовать установку значений
    }

    // Метод вывода резюме на консоль
    public void PrintResume ()
    {
        // Реализовать вывод резюме в консоль
    }

    // Метод заполнения резюме
    public void FillResume (string summary)
    {
        // Реализовать логику заполнения резюме
    }

    // Метод подсчёта количества лет опыта
    public int CalculateExperience (int startYear)
    {
        // Реализовать вычисление количества лет опыта
        return 0;
    }

    // Метод изменения цвета текста резюме
    public void ChangeTextColor (ConsoleColor color)
    {
        // Реализовать смену цвета
    }

    // Метод добавления нового навыка
    public void AddSkill (string skill)
    {
        // Реализовать добавление нового навыка
    }

    // Метод добавления нового места работы
    public void AddWorkExperience (string job)
    {
        // Реализовать добавление нового места работы
    }

    // Метод удаления навыка
    public void RemoveSkill (string skill)
    {
        // Реализовать удаление навыка
    }

    // Метод удаления места работы
    public void RemoveWorkExperience (string job)
    {
        // Реализовать удаление места работы
    }

    // Метод очистки всех данных из резюме
    public void ClearResume ()
    {
        // Реализовать очистку всех данных
    }

    // Метод для обновления контактной информации
    public void UpdateContactInfo (string newContactInfo)
    {
        // Реализовать обновление контактной информации
    }
}