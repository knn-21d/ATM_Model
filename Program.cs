using ATM_Model.Primary_Classes;
using System.Runtime.InteropServices;

namespace ATM_Model
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        
        //static void Test(int accounts, int cards)
        //{
        //    Random rnd = new();
        //    for (int i = 0; i < accounts; i++)
        //    {
        //        new Account(rnd.Next(0, 200000), rnd.Next(0, 99));
        //    }

        //    for (int i = 0; i < cards; i++)
        //    {
        //        var card = new Card();
        //        card.Activate(rnd.Next(0, CentralDataStorage.GetAccounts.Count - 1));
        //    }
        //}
    }
}