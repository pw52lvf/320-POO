namespace ex_parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed;
            int whichPara = 0;

            List<Para> para = new List<Para>();
            Plane plane = new Plane();

            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                foreach (Para parachutiste in para)
                {
                    parachutiste.update();
                }

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                foreach (Para parachutiste in para)
                {
                    parachutiste.draw();
                }

                // Temporiser
                Thread.Sleep(100);

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            whichPara++;
                            Para parachutiste = new Para("parachutiste" + whichPara, plane.x);
                            para.Add(parachutiste);
                            break;
                    }
                }
            }
        }
    }
}