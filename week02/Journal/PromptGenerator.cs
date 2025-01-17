using System;
class PromptGenerator
{
    string[] _questions = {"What is one thing you learned or realized today?", "What are you grateful for right now?", "How did you feel today and what influenced your emotions?","Who did you meet or see today?",
    "How was the school, job or free day?", "What challenges did I face today, and how did I overcome them?", "What made me smile or laugh today?", "Is there anything I regret doing or not doing today?", "What is something I want to improve or work on tomorrow?"};
    Random _ran = new Random();
    int i;
   

    public string Question(){
        i = _ran.Next(_questions.Length);
        
        return _questions[i];
    }
    
}