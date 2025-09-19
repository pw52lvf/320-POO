namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            int tailleStore;

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Building> ground = new List<Building>();
            for (int i = 0; i < 1; i++)
            {
                Drone drone = new Drone(100, 100, "Joe");
                fleet.Add(drone);
            }

            for (int i = 0; i < 10; i++)
            {
                Building build = new Building(Helpers.GlobalHelpers.alea.Next(1, 1200), Helpers.GlobalHelpers.alea.Next(1, 600), Helpers.GlobalHelpers.alea.Next(20, 30),
                    Helpers.GlobalHelpers.alea.Next(20, 30), 80);
                ground.Add(build);
            }

            for (int i = 0; i < 2; i++)
            {
                Factory factory = new Factory(200, Helpers.GlobalHelpers.alea.Next(1, 1200), Helpers.GlobalHelpers.alea.Next(1, 600), Helpers.GlobalHelpers.alea.Next(50, 100),
                    Helpers.GlobalHelpers.alea.Next(50, 100), 80);
                ground.Add(factory);
            }

            for (int i = 0; i < 5; i++)
            {
                tailleStore = Helpers.GlobalHelpers.alea.Next(40, 60);
                Store store = new Store(new List<string> { "Lundi: 8h-18h", "Mardi: 8h-18h", "Mercredi: 8h-18h" }, Helpers.GlobalHelpers.alea.Next(1, 1200), Helpers.GlobalHelpers.alea.Next(1, 600),
                    tailleStore, tailleStore, 80);
                ground.Add(store);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, ground));
        }
    }
}