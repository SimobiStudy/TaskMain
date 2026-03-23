namespace DictClass;

public class WordDictionary
{
    private List<string> _words = new List<string>();
    private string _filename;
    private int _wordCount;

    public WordDictionary(string filename)
    {
        _filename = filename;
        OpenFile();
        _wordCount = _words.Count;
    }

    private void OpenFile()
    {
        foreach (var line in File.ReadLines(_filename))
        {
            _words.Add(line);
        }
    }

    public void AddWord(string word)
    {
        if (_words.Contains(word)) return;
        _words.Add(word);
        _wordCount++;
    }

    public void RemoveWord(string word)
    {
        if (!_words.Contains(word)) return;
        _words.Remove(word);
        _wordCount--;
    }

    private int GetLevensteinDistance(string word1, string word2)
    {
        var dist = Math.Abs(word1.Length - word2.Length);
        var wordArr1 = word1.ToCharArray();
        var wordArr2 = word2.ToCharArray();
        var wordProcess = word1.Length - dist;
        for (int i = 0; i < wordProcess; i++)
        {
            if (wordArr1[i] != wordArr2[i])
                dist++;
        }

        return dist;
    }

    public List<string> SearchLevensteinDistance(string word1, int maxDist = 3)
    {
        List<string> result = new List<string>();
        foreach (var word in _words)
        {
            if (GetLevensteinDistance(word1, word) > maxDist)
                continue;
            result.Add(word);
        }

        return result;
    }

    public List<string> SearchPalindromes()
    {
        var result = new List<string>();
        foreach (var word in _words)
        {
            var wordCharArray = word.ToCharArray();
            var isPalindrome = true;
            for (int i = 0; i < wordCharArray.Length / 2; i++)
            {
                if (wordCharArray[i] != wordCharArray[wordCharArray.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
                result.Add(word);
        }
        return result;
    }
}