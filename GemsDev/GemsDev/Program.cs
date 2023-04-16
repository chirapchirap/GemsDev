namespace GemsDev.GemsDev
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
            Menu.ShowMenu();
                if (!ConsoleInputValidation.InputValidation(Setters.SetConsoleInput(ref Input)))
                {
                    Input = "";
                    Console.Clear();
                    continue;
                }
                else 
                {
                    CommandNum = Convert.ToInt32(Input);
                }
                Menu.MoveThroughCommands(CommandNum);
            }
        }
        //public static string SetInput(ref string value)
        //{
        //    return value = Console.ReadLine();
        //}
        private static string Input = "";
        private static int CommandNum = 0;

    }
}

