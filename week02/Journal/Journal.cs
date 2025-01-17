class Journal
{
    public List<Entry> _entries = new List<Entry>();
    DateTime _today = DateTime.Today;
    PromptGenerator _prompt = new PromptGenerator();
    public void ShowEntries()
    {
        foreach (Entry _e in _entries)
        {
            _e.ShowEntry();
        }
    }
    public void SaveJournal(string _fileName)
    {
        File.WriteAllText(_fileName, "Hello");
    }
    public void NewEntry()
    {
        Entry _entry1 = new Entry();
        string _p = _prompt.Question();
        Console.WriteLine(_p);
        _entry1._entry = Console.ReadLine();
        _entry1._prompt = _p;
        _entry1._date = _today.ToString("dd/MM/yyyy");
        _entries.Add(_entry1);
    }
}