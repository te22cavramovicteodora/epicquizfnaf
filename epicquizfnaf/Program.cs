
int points = 0;
Console.WriteLine("välkommen till fnafquiz fnaf extravaganza");

// -----------------------------------------------------------------------------

Console.WriteLine("1: vilken animatronic var responsible för bite of 87");
Console.WriteLine("a) ingen vet  b) toy chica probably c) mangle probably");
string answer1 = Console.ReadLine();
if (answer1 == "b")
{
  points++;
  Console.WriteLine("rätt, det är typ hon, jag tror det iallafall");
}
else
{
  Console.WriteLine("dålig opinion");
}

// -----------------------------------------------------------------------------

Console.WriteLine("2: vem e ourple guy");
Console.WriteLine("a) wiliam abbfton  b) michael afton  c) henry afton");
string answer2 = Console.ReadLine();
if (answer2 == "a")
{
  points++;
  Console.WriteLine("rätt ez gg");
}
else
{
  Console.WriteLine("fel du suger");
}

// -----------------------------------------------------------------------------

Console.WriteLine("3: vilken är den snyggaste animatronicen");
Console.WriteLine("a) ingen wtf  b) toy chica  c) funtime foxy");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("rätt, lite skumt att vara attraherad till en animerad leksak.");
}

if (answer3 == "b")
{
    Console.WriteLine("peddo");
}

if (answer3 == "c")
{
    Console.WriteLine("a person of culture i see...");
}


// -----------------------------------------------------------------------------

Console.WriteLine($"Du kan {points} % av loren, du har även {points} bitches .");
if (points == 0)
{
  Console.WriteLine("Du suger, game theory läxa nu");
}
else if (points < 3)
{
  Console.WriteLine("du är dålig");
}
else 
{
  Console.WriteLine("grattis du är bra på fnaf, men jag är bättre");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();