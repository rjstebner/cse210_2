public class Prompt
{
    public List<string> prompts;


    public Prompt()
    {
        prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What is something that I accomplished today?");
        prompts.Add("What is something that I am grateful for today?");
        prompts.Add("What is something that challenged me today?");
        prompts.Add("What is something that made me happy today?");
    }


    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);


        return prompts[index];
    }


}