// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/


//A code challenge

Random random = new Random();

int monsterHP = 10, heroHP = 10;
int count = 1;

do
{
    if (count%2 != 0) monsterHP = HeroAttack(monsterHP);
    else heroHP = MonsterAttack(heroHP);
    
    count++;

} while(monsterHP > 0 && heroHP > 0);

Console.WriteLine( monsterHP == 0 ? "Monster wins!" : "Hero wins!");


int HeroAttack(int monsterHP)
{
    int attack = random.Next(1, 10);
    monsterHP -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHP} health.");

    return monsterHP;
}

int MonsterAttack(int heroHP)
{
    int attack = random.Next(1, 10);
    heroHP -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health.");

    return heroHP;
}
