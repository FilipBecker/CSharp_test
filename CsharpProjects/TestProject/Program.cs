Random random = new Random();
int monsterH = 10;
int heroH = 10;
int damege;

do {
    damege = random.Next(1, 11);
    monsterH -= damege;
    Console.WriteLine($"Monster({monsterH}) takes {damege} points of damege");
    if (monsterH > 0) {
        damege = random.Next(1, 11);
        heroH -= damege;
        Console.WriteLine($"Hero({heroH}) takes {damege} points of damege");
    }
} while ((heroH > 0) && (monsterH > 0));

if (monsterH <= 0) {
    Console.WriteLine("Hero won");
} else {
    Console.WriteLine("Monster won");
}