namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What is your favorite subject in school?");

            string favoriteSubject = Console.ReadLine();

            
            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Thats a tough one!");
                    break;
                case "science":
                    Console.WriteLine("So interesting!");
                    break;
                case "language":
                    Console.WriteLine("Habla espanol?");
                    break;
                case "history":
                    Console.WriteLine("Is told by those who win.");
                    break;
                case "art":
                    Console.WriteLine("That's my favorite too!");
                    break;
                default:
                    Console.WriteLine("That's not a subject at any school I went to.");
                    break;
            }
        }
    }
}