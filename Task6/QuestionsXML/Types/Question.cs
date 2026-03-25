using System.Xml.Serialization;

namespace QuestionsXML.Types;

public class Question
{
    [XmlAttribute("img")] public string? ImagePath { get; set; }

    [XmlElement("title")] public string? Title { get; set; }
    
    [XmlAttribute("reward")]
    public int Reward { get; set; }

    [XmlArray("answers")]
    [XmlArrayItem("answer")]
    public List<Answer> Answers { get; set; }
}