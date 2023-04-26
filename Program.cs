// The task of this program is to print symbols on the console using two threads.
// The first thread should only use the left side of the screen and the second
// task the right side of the screen.
// BUT something went wrong! Try it...
//
// Fix it!

int minX1 = 0;
int maxX1 = 40;

int minX2 = 41;
int maxX2 = 80;

int minY = 0;
int maxY = 29;

int amount = 1000;

Thread t1 = new Thread(() => PrintSymbols(minX1, maxX1, minY, maxY, 'L', amount));
Thread t2 = new Thread(() => PrintSymbols(minX2, maxX2, minY, maxY, 'R', amount));

Console.Clear();
Console.WriteLine($"### Threaded Console Printer ###");

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.SetCursorPosition(0, 29);
Console.Write("Press any key...");
Console.ReadKey();

void PrintSymbols(int minX, int maxX, int minY, int maxY, char symbol, int amount)
{
    for (int i = 0; i < amount; i++)
    {
        Random rnd = new Random();

        int x = rnd.Next(minX, maxX + 1);
        int y = rnd.Next(minY, maxY + 1);

        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
}