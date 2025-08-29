namespace ex_snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;
            int x = 0;
            int y = 10;


            while (isAlive)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("_@_ö");
                x++;
                Thread.Sleep(10);

                if (x  == 50)
                {
                    break;
                }
            }
            Console.Clear();
            Console.SetCursorPosition((int)x, (int)y);
            Console.WriteLine("____");
        }
    }
}
