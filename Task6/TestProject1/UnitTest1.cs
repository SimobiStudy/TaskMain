using QuestionsXML;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var theme = ThemeXmlH.GetTheme(Path.GetFullPath("../../../files.xml"));
        Assert.Pass();
    }
}