using System.Xml.Serialization;

namespace QuestionsXML.Types;

public class Theme
{
    [XmlElement("Name")] public string? Name;
    [XmlElement("difficulty")] 
    public List<Difficulty>? Difficulty;
}