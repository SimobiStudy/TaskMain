using System.Xml.Serialization;

namespace QuestionsXML.Types;

public class Difficulty
{
    [XmlAttribute("level")]
    public string? level;

    [XmlAttribute("questions")] 
    public int questionsAmount;
    
    [XmlArray("questions")]
    [XmlArrayItem("question")]
    public List<Question>? questions;
}

public enum DifficultyLevel
{
    [XmlEnum("easy")] Easy,
    [XmlEnum("normal")] Normal,
    [XmlEnum("hard")] Hard,   
}