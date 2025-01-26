using System.Text.RegularExpressions;

class Scripture
{

    Word _word = new Word();
    public void DisplayText(string str)
    {
        Console.WriteLine(str);
    }

    public string HideRandomWords(string list)
    {
        Random _ran = new Random();
        string[] _scritpure = Regex.Split(list, " ");
        int num = _ran.Next(0, 4);

        for (int i = 0; i < num; i++)
        {
            Random _random = new Random();
            int randomNumber = _random.Next(0, _scritpure.Length -1);
            string wordToHide = _scritpure[randomNumber];
            if (_word.IsHidden(wordToHide) == false)
            {
                _scritpure[randomNumber]= _word.Hide(_scritpure[randomNumber]);
            }

        }

        string newArray = string.Join(" ", _scritpure);
        return newArray;

    }
}