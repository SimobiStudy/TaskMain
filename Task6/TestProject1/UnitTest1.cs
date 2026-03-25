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
        var theme = ThemeXmlH.GetTest(Path.GetFullPath("../../../files.xml"));
        Assert.Pass();
    }
}