Random random = new();

int value = random.Next(0, 1);

if (value > 1)
    Console.WriteLine("head");
else
    Console.WriteLine("tails");