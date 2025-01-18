using System;
using System.IO;
class Entry
{
    public string entry, prompt;
    public string date;
    Journal _journal = new Journal();
    public void ShowEntry(){
        Console.WriteLine($"Date: {date} - {prompt} \n{entry}");
    }
    public string SaveEntriesJournal(){
        string line = $"~{date}~{prompt}~{entry}";
        return line;
    }
    public void ConvertJournal(){
        string list = _journal.LoadJournal();
    }
}