using DictClass;

namespace TestDictionary;

public class Tests
{
    WordDictionary wordDictionary;
    public const string DictionaryFileName = @"";
    public const string PalindromeDictionaryFileName = @"G:\Учеба\УП\Тема 1\WinForm\Тask5\TestDictionary\palindromeDictFile.txt";
    [OneTimeSetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TestPalindromeSearch()
    {
        var palindromeDictFileName = new WordDictionary(PalindromeDictionaryFileName);
        var expectedResult = new List<string>()
        {
            "ротатор",
            "потоп",
            "мадам",
            "наворован",
            "пуп",
            "дед",
            "топот",
        };
        var resultFile = palindromeDictFileName.SearchPalindromesToFile();
        Assert.That(File.ReadAllLines(resultFile), Is.EqualTo(expectedResult));
        Assert.Pass();
    }
    
}