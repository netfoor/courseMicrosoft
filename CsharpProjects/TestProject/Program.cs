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

if ( total >= 16 ){
    Console.WriteLine("You win a new car!"); 
} else if ( total >= 10 ){
    Console.WriteLine("You win a new laptop!"); 
} else if ( total == 7){
    Console.WriteLine("You win a trip for two"); 
} else {
    Console.WriteLine("You win a kitten"); 
}
*/

// Mejora de la tasa de renovación de las suscripciones

Random random = new Random(); 
//int dayUntilExpiration = random.Next(12);
int dayUntilExpiration = random.Next(12);
int discountPercentaje = 0; 

if (dayUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired."); 
} else if (dayUntilExpiration == 1){
    discountPercentaje += 20;
    Console.WriteLine($"Your subscription expires within a day\nRenew now and save {discountPercentaje}%!");
} else if (dayUntilExpiration <= 5){
    discountPercentaje += 10;
    Console.WriteLine($"Your subcription expires in {dayUntilExpiration} days. \nRenew now and save {discountPercentaje}%");
} else if (dayUntilExpiration <= 10){
    Console.WriteLine("Your subcription will expire soon. Renew now!");
} else {
    Console.WriteLine(); 
}

// Condiciones para verificar que se aplica correctamente los descuentos
if (dayUntilExpiration <= 5 && dayUntilExpiration > 1){
    Console.WriteLine("Se debe ofrecer un descuento de 10%"); 
} else if (dayUntilExpiration == 1){
    Console.WriteLine("Se debe ofrecer un descuento de 20%"); 
}