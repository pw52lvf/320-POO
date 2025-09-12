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

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Building> ground = new List<Building>();
            for (int i = 0; i < 100; i++)
            {
                Drone drone = new Drone(100, 100, "Joe");
                fleet.Add(drone);
            }

            for (int i = 0; i < 10; i++)
            {
                Building build = new Building(10, 50, 20, 20, 100, Color.Yellow);
                ground.Add(build);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, ground));
        }
    }
}