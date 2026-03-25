using System.Xml.Serialization;

namespace QuestionsXML.Types;

public class Difficulty
{
    [XmlAttribute("level")] public string? level;
    [XmlAttribute("time")] public int TimeToComplete { get; set; } = -1; // в секундах

    [XmlArray("questions")] [XmlArrayItem("question")]
    public List<Question>? questions;

    [XmlAttribute("questions")] public int questionsAmount;

    [XmlAttribute("locked")] public bool IsLocked = true;
    public override string ToString()
    {
        return level ?? "Unknown";
    }
    
    public Difficulty(){}
    
    public Difficulty(string level, int timeToComplete = -1)
    {
        this.level = level;
        this.TimeToComplete = timeToComplete;
    }

    public Difficulty(string level, int questionsAmount, bool isLocked = true, int timeToComplete = -1) : this(level, timeToComplete)
    {
        this.questionsAmount = questionsAmount;
        this.IsLocked = isLocked;
    }
    
    public const string EasyDifficulty = "easy";
    public const string MediumDifficulty = "medium";
    public const string HardDifficulty = "hard";
}