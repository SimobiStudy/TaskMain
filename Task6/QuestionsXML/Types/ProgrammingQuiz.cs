using System.Xml.Serialization;

namespace QuestionsXML.Types;

[XmlType("Test")]
public class ProgrammingQuiz
{
    [XmlElement("Theme")] 
    public List<Theme>? Themes;
}