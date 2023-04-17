namespace GemsDev.GemsDev
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
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
        private static string Input = "";
        private static int CommandNum = 0;
    }
}

