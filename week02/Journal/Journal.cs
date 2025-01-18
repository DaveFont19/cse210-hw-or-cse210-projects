class Journal
{
    public List<Entry> _entries = new List<Entry>();
    DateTime _today = DateTime.Today;
    PromptGenerator _prompt = new PromptGenerator();
    public void ShowEntries()
    {
        foreach (Entry e in _entries)
        {
            e.ShowEntry();
        }
    }
    public void SaveJournal(string _fileName)
    {
        using (StreamWriter sw = File.CreateText(_fileName))
        { foreach (Entry e in _entries)
        {
            sw.WriteLine(e.SaveEntriesJournal());
        }
        }
    }
    public void NewEntry()
    {
        Entry _entry1 = new Entry();
        string p = _prompt.Question();
        Console.WriteLine(p);
        _entry1.entry = Console.ReadLine();
        _entry1.prompt = p;
        _entry1.date = _today.ToString("dd/MM/yyyy");
        _entries.Add(_entry1);
    }
    public string LoadJournal(){
        string loadJournal = "";
        return loadJournal;
    }
}