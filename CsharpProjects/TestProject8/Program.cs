Random random = new();

int value = random.Next(0, 2);

var result = value == 1 ? "head" : "tails";

Console.WriteLine(result);
