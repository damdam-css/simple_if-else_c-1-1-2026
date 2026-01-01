Console.WriteLine("Haloo wir siapa nama anda?");
string userName = Console.ReadLine();
Console.WriteLine("Halo selamat datang di tebak angka, " + userName);

Random random = new Random();
int angkaRahasia = random.Next(1, 100);
Console.WriteLine(angkaRahasia);
int kesempatan = 7;

while (kesempatan > 0)
{
    Console.WriteLine("\nMasukkan angka 1–10:");
    string inputUser = Console.ReadLine();

    if (!int.TryParse(inputUser, out int angkaTebakan))
    {
        Console.WriteLine("bisanya masukin angka doang min");
        kesempatan--;
        Console.WriteLine($"Kesempatan tersisa: {kesempatan}");
        continue;
    }

    if (angkaTebakan > angkaRahasia)
    {
        Console.WriteLine("Kegedean angkanya min");
    }
    else if (angkaTebakan < angkaRahasia)
    {
        Console.WriteLine("Kekecilan angkanya min");
    }
    else
    {
        Console.WriteLine("mantap min tebakannya benar.");
        break;
    }

    kesempatan--;
    Console.WriteLine("Ini sisa kesempatan: " + kesempatan);
}

if (kesempatan == 0)
{
    Console.WriteLine("\nmin, kamu issue");
    Console.WriteLine("Jawaban yang benar adalah: " + angkaRahasia);
}