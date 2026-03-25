using System.Xml.Serialization;

namespace QuestionsXML.Types;

[XmlType("Theme")]
public class Theme
{
    [XmlElement("Name")] public string? Name { get; set; }

    [XmlElement("difficulty")] public List<Difficulty>? Difficulty { get; set; }

    public override string ToString()
    {
        return Name ?? "Unknown";
    }
}