using System.Text.RegularExpressions;

class Reference
{
    private string _book, _words;
    private string[] _allText;
    private int _chapter, _verse, _endVerse;
    ReadFile _r = new ReadFile();

    public void GetAllText()
    {
        string _text = _r.ReadFiles();
        _allText = Regex.Split(_text, "&");

    }
    public void SetReference()
    {
        Random _ran = new Random();

        int num = _ran.Next(0, _allText.Length -1);
        string[] _scritpure = Regex.Split(_allText[num], "~");
        _book = _scritpure[0];
        _chapter = int.Parse(_scritpure[1]);
        _verse = int.Parse(_scritpure[2]);
        if (int.TryParse(_scritpure[3], out _endVerse))
        {
            _endVerse = int.Parse(_scritpure[3]);
            _words = _scritpure[4];

        }
        else
        {
            _words = _scritpure[3];
        }

    }
    public string GetReference()
    {
        return _endVerse > _verse
            ? $"{_book} {_chapter}:{_verse} - {_endVerse}"
            : $"{_book} {_chapter}:{_verse}";
    }

    public string GetText()
    {
        return _words;
    }
    public void SetText(string t){
        _words = t;
    }
}