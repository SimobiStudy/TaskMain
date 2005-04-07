using System.Text;

namespace DictClass;

public class WordDictionary
{
    private List<string> _words = new List<string>();

    public List<string> Words
    {
        get => _words;
    }

    private string _filename;
    public int WordCount { get; private set; }

    /// <summary>
    /// Конструктор для создания словаря из текстового файла
    /// </summary>
    /// <param name="filename">Путь к файлу</param>
    /// <param name="encoding">Кодировка файла</param>
    public WordDictionary(string filename, Encoding encoding)
    {
        _filename = filename;
        OpenFile(encoding);
        WordCount = _words.Count;
    }

    public WordDictionary(string filename) : this(filename, Encoding.UTF8) { }
    
    public WordDictionary()
    {
        WordCount = 0;
    }

    private void OpenFile()
    {
        OpenFile(Encoding.UTF8);
    }
    private void OpenFile(Encoding encoding)
    {
        if (!File.Exists(_filename))
            throw new FileNotFoundException($"Файл по пути {_filename} не существует.");
        foreach (var line in File.ReadLines(_filename, encoding))
        {
            _words.Add(line.ToLower());
        }
    }

    /// <summary>
    /// Используйте этот метод для добавления слова в словарь
    /// </summary>
    /// <param name="word">Слово, которое надо добавить</param>
    public void AddWord(string word)
    {
        if (_words.Contains(word)) return;
        _words.Add(word);
        WordCount++;
        _words.Sort();
    }

    /// <summary>
    /// Используйте этот метод для удаления слова из словаря
    /// </summary>
    /// <param name="word">Слово, которое необходимо удалить</param>
    public void RemoveWord(string word)
    {
        if (!_words.Contains(word)) return;
        _words.Remove(word);
        WordCount--;
        _words.Sort();
    }

    /// <summary>
    /// Используйте этот метод для проверки нахождения слова в словаре
    /// </summary>
    /// <param name="word">Слово для проверки</param>
    /// <returns>True - если слово найдено, False - если нет</returns>
    public bool HasWord(string word)
    {
        return _words.Contains(word);
    }
    
    private int GetLevensteinDistance(string word1, string word2)
    {
        var dist = Math.Abs(word1.Length - word2.Length);
        var wordArr1 = word1.ToCharArray();
        var wordArr2 = word2.ToCharArray();
        var wordProcess = Math.Min(wordArr1.Length, wordArr2.Length);
        for (int i = 0; i < wordProcess; i++)
        {
            if (wordArr1[i] != wordArr2[i])
                dist++;
        }

        return dist;
    }

    /// <summary>
    /// Используйте этот метод для поиска всех слов с расстоянием Левенштейна не более maxDist для word1
    /// </summary>
    /// <param name="word1">Слово для определения расстояния</param>
    /// <param name="maxDist">Максимальное расстояние левенштейна</param>
    /// <returns>Список слов с расстоянием Левенштейна не более maxDist</returns>
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

    /// <summary>
    /// Используйте этот метод для поиска палиндромов в словаре
    /// </summary>
    /// <returns>Список палиндромов в словаре</returns>
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

    /// <summary>
    /// Используйте этот метод для поиска валиндрома и вывода их в отдельный текстовый файл
    /// </summary>
    /// <param name="fileName">Путь к файлу. Если равен null, то создастся временный текстовый файл</param>
    /// <returns>Путь к новому файлу</returns>
    public string SearchPalindromesToFile(string? fileName = null)
    {
        var resultPalindromes = SearchPalindromes();
        string filePath;
        if (fileName == null)
            filePath = Path.ChangeExtension(Path.GetTempFileName(), "txt");
        else
            filePath = (fileName.Clone() as string)!;
        File.WriteAllLines(filePath, resultPalindromes);
        return filePath;
    }
}