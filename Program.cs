using System; 

    namespace textgame
    {
         class Program
    { 
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my role-playing text game");
            Console.WriteLine("The first room in this text playing game is to answer a math question, 2+2=what");
                String input = Console.readline();
            if (input.ToLower() == "Answer the question")
                {
                Console.WriteLine("You have solved the first question, and you unlocked level 2");
            }
            else
            {
                Console.WriteLine("Invalid Command.");
            }
        }
    }
}

