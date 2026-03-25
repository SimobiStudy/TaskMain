using System.Xml.Serialization;

namespace QuestionsXML.Types;

public class Answer
{
    [XmlAttribute("isTrue")]
    public bool IsTrue {get; set;}
    [XmlText]
    public string? Text {get; set;}
}