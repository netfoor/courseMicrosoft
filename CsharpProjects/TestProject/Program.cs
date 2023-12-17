// Ejercicio de dados
 
Random dice = new Random(); 
int rollOne = dice.Next();
int rollTwo = dice.Next(101); 
int rollThree = dice.Next(50, 101);

Console.WriteLine($"First roll: {rollOne}");
Console.WriteLine($"Second roll: {rollTwo}"); 
Console.WriteLine($"Thrird roll: {rollThree}");
