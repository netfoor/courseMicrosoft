/*
// Ejercicio de dados

Random dice = new Random(); 
int rollOne = dice.Next();
int rollTwo = dice.Next(101); 
int rollThree = dice.Next(50, 101);

Console.WriteLine($"First roll: {rollOne}");
Console.WriteLine($"Second roll: {rollTwo}"); 
Console.WriteLine($"Thrird roll: {rollThree}");

//El mayor de dos numeros


int fisrtValue = 500; 
int secondValue = 600; 
int largeValue = Math.Max(fisrtValue,secondValue);
Console.WriteLine(largeValue); 

// Método string.Contains

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("Hello"); 
Console.WriteLine(result); 

if (message.Contains("fox")){
    Console.WriteLine("What does the fox say?"); 
}

*/
// Lanzamiento de 3 dados

Random dice = new Random(); 
int rollOne = dice.Next(1,7);
int rollTwo = dice.Next(1,7);
int rollThree = dice.Next(1,7);
int total = rollOne + rollTwo + rollThree; 

Console.WriteLine($"Dice roll: {rollOne}, {rollTwo}, {rollThree} = {total}"); 

if (rollOne == rollTwo || rollOne == rollThree || rollTwo == rollThree){
    if (rollOne == rollTwo && rollTwo == rollThree){
    Console.WriteLine("You rolled triples!! +6 bonus to total");
    total += 6; 
    Console.WriteLine(total);  
} else {
    Console.WriteLine("You rolled doubles!! +2 bonus to total");
    total += 2;
    Console.WriteLine(total);   
}
}

if (total >= 15){
    Console.WriteLine("You win!!");
} else {
    Console.WriteLine("Sorry, you lose."); 
}

