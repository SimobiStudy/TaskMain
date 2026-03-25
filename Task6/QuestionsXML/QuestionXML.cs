using System.Xml;
using System.Xml.Serialization;
using QuestionsXML.Types;

namespace QuestionsXML;

#nullable disable
public static class ThemeXmlH
{
    /// <summary>
    ///     Используйте этот метод для получения класса <see cref="ProgrammingQuiz" /> из файла
    /// </summary>
    /// <param name="fileName">Путь к файлу</param>
    /// <returns>Класс <see cref="ProgrammingQuiz" /></returns>
    public static ProgrammingQuiz GetTest(string fileName)
    {
        var serializer = new XmlSerializer(typeof(ProgrammingQuiz));
        ProgrammingQuiz result = null;
        try
        {
            result = (ProgrammingQuiz)serializer.Deserialize(new StringReader(File.ReadAllText(fileName)));
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
    ///     Используйте этот метод для сериализации <see cref="ProgrammingQuiz" /> в файл
    /// </summary>
    /// <param name="quiz">Класс <see cref="ProgrammingQuiz"/></param>
    /// <param name="fileName">Путь к файлу для сохранения</param>
    public static void SaveTheme(this ProgrammingQuiz quiz, string fileName)
    {
        var serializer = new XmlSerializer(typeof(ProgrammingQuiz));
        serializer.Serialize(File.Create(fileName), quiz);
    }
}