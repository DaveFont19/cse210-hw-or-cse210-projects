class Entry
{
    public string _entry, _prompt;
    public string _date;
    public void ShowEntry(){
        Console.WriteLine($"Date: {_date} - {_prompt} \n{_entry}");
    }
}