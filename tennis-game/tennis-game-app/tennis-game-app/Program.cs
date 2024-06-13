namespace tennis_game
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new MainTennisForm());   
            
        }
    }
}