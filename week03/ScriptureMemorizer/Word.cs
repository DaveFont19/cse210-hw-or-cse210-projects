class Word

{
    private string _text;
    public Word()
    {

    }

    public string Hide(string st)
    {
        string scripture = new string('_', st.Length);
        return scripture;
    }
    public bool IsHidden(string cWord){
        if (cWord.Contains("_")){
            return true;
        }
        else{
            return false;
        }
    }
}