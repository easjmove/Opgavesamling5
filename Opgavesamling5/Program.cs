using Opgave5_2;
using Opgave5_3;
using Opgave5_4;
using Opgave5_5;

//Opgave 5.2
BlueBookPerson person = new BlueBookPerson(
                "Mette Hansen",
                new DateTime(2004, 5, 12),
                "Student / Programmør",
                "https://example.com/billeder/mette.jpg",
                "Det virker på min maskine!",
                "Softwarearkitekt hos en tech-gigant"
            );

Console.WriteLine(person.ToString());

//Opgave 5.3
//Trin 1: opret alle kort
string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

// Trin 2: Opret en List med 52 kort
List<Card> deck = new List<Card>();

foreach (var suit in suits)
{
    foreach (var value in values)
    {
        deck.Add(new Card(suit, value));
    }
}

// Trin 3: Udskriv kortstakken
Console.WriteLine("=== Oprindelig Kortbunke (52 kort) ===");
foreach (var card in deck)
{
    Console.WriteLine(card);
}

// Ekstra: Bland kortene
Card.Shuffle(deck);

// Ekstra: Træk et kort
Card drawnCard = Card.DrawCard(deck);
Console.WriteLine($"\nDu trak kortet: {drawnCard}\n");

// Ekstra: Fordel kortene til 4 spillere (12 eller 13 kort afhængigt af træk)
Card.DealCards(deck, 4);

//Opgave 5.4
CreditCard card1 = new CreditCard("1234-5678-9012-3456", "Visa");
CreditCard card2 = new CreditCard("9876-5432-1098-7654", "MasterCard", 25000m);
CreditCard card3 = new CreditCard("5555-4444-3333-2222", "Visa", 50000m, "Anders And");

Console.WriteLine(card1);
Console.WriteLine(card2);
Console.WriteLine(card3);

//Opgave 5.5
Console.WriteLine("Velkommen til Den gyldne måge!\n");

// 1. Spørg om drik
Console.Write("Hvilken sodavand ønsker du (f.eks. Cola, Fanta)? ");
string drinkName = Console.ReadLine();

Console.Write("Vælg størrelse på sodavand (1: Lille [13 kr], 2: Mellem [25 kr], 3: Stor [35 kr]): ");
DrinkSize drinkSize = Console.ReadLine() switch
{
    "1" => DrinkSize.Small,
    "3" => DrinkSize.Large,
    _ => DrinkSize.Medium
};
Drink drink = new Drink(drinkName, drinkSize);

// 2. Spørg om pomfritter
Console.Write("\nVælg størrelse på pomfritter (1: Mellem [24 kr], 2: Large [33 kr], 3: X-Large [50 kr]): ");
FriesSize friesSize = Console.ReadLine() switch
{
    "2" => FriesSize.Large,
    "3" => FriesSize.XLarge,
    _ => FriesSize.Medium
};
Fries fries = new Fries(friesSize);

// 3. Spørg om burger
Console.Write("\nHvilken burger ønsker du (f.eks. Big Mac, Cheeseburger)? ");
string burgerName = Console.ReadLine();

Console.Write("Indtast prisen på burgeren (f.eks. 45): ");
double.TryParse(Console.ReadLine(), out double burgerPrice);
Burger burger = new Burger(burgerName, burgerPrice);

// 4. Opret Menu og udskriv bestilling
Menu customerMenu = new Menu(drink, fries, burger);

Console.WriteLine("\n==================================");
Console.WriteLine($"Du har bestilt en menu med: {customerMenu}");
Console.WriteLine($"Totalpris: {customerMenu.GetTotalPrice()} kr.");
Console.WriteLine("==================================");