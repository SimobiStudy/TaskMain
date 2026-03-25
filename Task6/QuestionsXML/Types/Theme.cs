using System.Xml.Serialization;

namespace QuestionsXML.Types;

[XmlType("Theme")]
public class Theme
{
    [XmlElement("Name")] public string? Name { get; set; }

    [XmlElement("difficulty")] public List<Difficulty>? Difficulties { get; set; }

    public override string ToString()
    {
        return Name ?? "Unknown";
    }
    
    public Theme() {}

    public Theme(string name)
    {
        Name = name;
        Difficulties = new List<Difficulty>();
        Difficulties.Add(new Difficulty(Difficulty.EasyDifficulty,10,false,-1 ));
        Difficulties.Add(new Difficulty(Difficulty.MediumDifficulty,10,true,-1 ));
        Difficulties.Add(new Difficulty(Difficulty.HardDifficulty,10,true,-1 ));
    }
}