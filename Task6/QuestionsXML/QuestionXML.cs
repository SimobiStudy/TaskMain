using System.Xml.Serialization;
using QuestionsXML.Types;

namespace QuestionsXML;

public static class ThemeXmlH
{
    public static Theme GetTheme(string fileName)
    {
        var serializer = new XmlSerializer(typeof(Theme));
        return (Theme)serializer.Deserialize(new StringReader(File.ReadAllText(fileName)));
    }

    public static void SaveTheme(this Theme theme, string fileName)
    {
        var serializer = new XmlSerializer(typeof(Theme));
        serializer.Serialize(File.Create(fileName), theme);
    }
}