using System.Xml.Serialization;
using QuestionsXML.Types;

namespace QuestionsXML;

public static class ThemeXmlH
{
    /// <summary>
    /// Используйте этот метод для получения класса <see cref="Theme"/> из файла
    /// </summary>
    /// <param name="fileName">Путь к файлу</param>
    /// <returns>Класс <see cref="Theme"/></returns>
    public static Theme GetTheme(string fileName)
    {
        var serializer = new XmlSerializer(typeof(Theme));
        return (Theme)serializer.Deserialize(new StringReader(File.ReadAllText(fileName)));
    }

    /// <summary>
    /// Используйте этот метод для сериализации <see cref="Theme"/> в файл
    /// </summary>
    /// <param name="theme">Класс <see cref="Theme"/></param>
    /// <param name="fileName">Путь к файлу для сохранения</param>
    public static void SaveTheme(this Theme theme, string fileName)
    {
        var serializer = new XmlSerializer(typeof(Theme));
        serializer.Serialize(File.Create(fileName), theme);
    }
}