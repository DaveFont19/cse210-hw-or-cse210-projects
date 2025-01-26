class ReadFile
{
    public string ReadFiles()
    {
        string link = "scriptures.txt";
        if (File.Exists(link))
        {
            string content = File.ReadAllText(link);
            return content;
        }
        else
        {
            return "nothing";
        }
    }
}