namespace Practic_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Barrier barrier = new Barrier();
            barrier.Event1 += Barrier_Event1;
            barrier.Event2 += Barrier_Event2;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Man man = new Man($"Человек {i + 1}");
                man.Event1 += Man_Event1;
                man.Event2 += Man_Event2;

                int randomNumber = random.Next(1, 3);
                barrier.TriggerRandomEvent(randomNumber, man.Name);
            }
        }

        static void Man_Event1(object sender, EventArgs e)
        {
            Man man = sender as Man;
            Console.WriteLine($"{man.Name}, иду.");
            man.Event1 -= Man_Event1;
            man.Event2 -= Man_Event2;
        }

        static void Man_Event2(object sender, EventArgs e)
        {
            Man man = sender as Man;
            Console.WriteLine($"{man.Name}, стою.");
        }

        static void Barrier_Event1(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Открыто ");
            Console.ResetColor();
        }

        static void Barrier_Event2(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Закрыто ");
            Console.ResetColor();
        }
    }
}