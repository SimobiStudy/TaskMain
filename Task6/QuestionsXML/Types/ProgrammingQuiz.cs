using System.Xml.Serialization;

namespace QuestionsXML.Types;

[XmlType("Test")]
public class ProgrammingQuiz
{
    [XmlElement("Theme")] 
    public List<Theme>? Themes { get; set; }

    [XmlIgnore] public string FilePath { get; private set; }

    public void AddTheme(Theme theme)
    {
        if (this.Themes == null)
            this.Themes = new List<Theme>();
        this.Themes.Add(theme);
        if (theme.Difficulties == null)
            theme.Difficulties = new List<Difficulty>();
        
    }

    /// <summary>
    /// Используйте этот метод для получения класса <see cref="ProgrammingQuiz" /> из файла
    /// </summary>
    /// <param name="fileName">Путь к файлу</param>
    /// <returns>Класс <see cref="ProgrammingQuiz" /></returns>
    public static ProgrammingQuiz GetTest(string fileName)
    {
        var serializer = new XmlSerializer(typeof(ProgrammingQuiz));
        ProgrammingQuiz result = null;
        try
        {
            result = (ProgrammingQuiz)serializer.Deserialize(new StringReader(File.ReadAllText(fileName)))!;
            result!.FilePath = fileName;
        }
        catch (FileNotFoundException ex)
        {
            throw new FileNotFoundException("Ошибка получения файла: Файл не найден", ex);
        }
        catch (InvalidOperationException ex)
        {
            throw new InvalidOperationException("Ошибка получения данных с XML", ex);
        }

        return result;
    }

    /// <summary>
    /// Используйте этот метод для сериализации <see cref="ProgrammingQuiz" /> в файл
    /// </summary>
    /// <param name="fileName">Путь к файлу для сохранения</param>
    public void Save(string fileName)
    {
        var serializer = new XmlSerializer(typeof(ProgrammingQuiz));
        serializer.Serialize(File.Create(fileName), this);
    }

    /// <summary>
    /// Используйте этот метод для сериализации <see cref="ProgrammingQuiz" /> в файл по пути filePath, который был установлен при загрузке
    /// </summary>
    public void Save()
    {
        Save(FilePath);
    }
}