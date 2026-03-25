using System.Xml.Serialization;

namespace QuestionsXML.Types;

public class Difficulty
{
    [XmlAttribute("level")] public string? level;
    [XmlAttribute("time")] public int TimeToComplete { get; set; } = int.MaxValue; // в секундах

    [XmlArray("questions")] [XmlArrayItem("question")]
    public List<Question>? questions;

    [XmlAttribute("questions")] public int questionsAmount;

    [XmlAttribute("locked")] public bool IsLocked = true;
    public override string ToString()
    {
        return level ?? "Unknown";
    }
}