namespace GemsDev.GemsDev
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
            Menu.ShowMenu();
                if (!Validation.InputValidation(SetInput(ref Input)))
                {
                    Input = "";
                    continue;
                }
                else 
                {
                    CommandNum = Convert.ToDouble(Input);
                }
                Menu.MoveThroughCommands(CommandNum);
            }
        }
        public static string SetInput(ref string value)
        {
            return value = Console.ReadLine();
        }
        private static string Input = "";
        private static double CommandNum = 0;

    }
}

