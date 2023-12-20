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


// Lanzamiento de 3 dados y ejemplo de códico limpio según Microsoft

Random dice = new Random(); 

int rollOne = dice.Next(1, 7);
int rollTwo = dice.Next(1, 7);
int rollThree = dice.Next(1, 7);

int total = rollOne + rollTwo + rollThree;
Console.WriteLine($"Dice roll: {rollOne} + {rollTwo} + {rollThree} = {total}"); 

if ((rollOne == rollTwo) || (rollOne == rollThree) || (rollTwo == rollThree))
{
    if ((rollOne == rollTwo) && (rollTwo == rollThree))
    {
        Console.WriteLine("You rolled triples!! +6 bonus to total");
        total += 6; 
        Console.WriteLine(total);  
    } 
    else 
    {
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


// Haciendo uso de las matrices en c# 
string [] fraudelentOrderIDs = new string[3]; 
fraudelentOrderIDs[0] = "A123";
fraudelentOrderIDs[1] = "B456"; 
fraudelentOrderIDs[2] = "C789";  
//fraudelentOrderIDs[3] = "This is a test"; 



string [] fraudelentOrderIDs = {"A123", "B456", "C789"};
Console.WriteLine($"First: {fraudelentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudelentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudelentOrderIDs[2]}"); 

fraudelentOrderIDs[0] = "F000"; 

Console.WriteLine($"Reassign First: {fraudelentOrderIDs[0]}"); 
Console.WriteLine($"There are {fraudelentOrderIDs.Length} fraudalent orders to process.");

//Arrays 
string [] names = {"Carolina", "Fortino", "Daniela"}; 
foreach (string name in names){
    Console.WriteLine(name); 
}
//Desafío de pedido fraudulento
int [] inventory = {200, 450, 700, 175, 250};
int sum = 0; 
int biin = 0; 
foreach (int items in inventory){
    sum += items; 
    biin++; 
    Console.WriteLine($"Bin {biin} = {items} items (running total: {sum})");
}
Console.WriteLine($"Wew have {sum} items in inventory."); 
// Notificar los identificadores de pedido que necesitan una investigación más detallada

string [] inventory = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

int bin = 0; 
List<string> newList = new List<string>();

foreach (string fraudelentOrderIDs in inventory){
    
    if (fraudelentOrderIDs.StartsWith("B")){
        newList.Add(fraudelentOrderIDs); 
        bin ++;
    }
    
}
Console.WriteLine($"Usted necesita revisar los siguientes {bin} archivos: ");
foreach (string OtherList in newList){
    Console.WriteLine(OtherList); 
}


Random random = new Random(); 
string[] orderIDs = new string[5]; 

for (int i = 0; i < orderIDs.Length; i++){
    int prefixValue = random.Next(65, 70); 
    string prefix = Convert.ToChar(prefixValue).ToString(); 
    string suffix = random.Next(1, 1000).ToString();
    orderIDs[i] = prefix + suffix;
}

//Print out each orderID 
foreach ( var orderID in orderIDs ){
    Console.WriteLine(orderID); 
}

//Aplicación de directrices de estilo para mejorar la legibilidad
//El propósito de nivel superior de este código es invertir una cadena y contar el número de veces que aparece un carácter determinado.

string orderedMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = orderedMessage.ToCharArray();
Array.Reverse(message);

string newMessage = new String(message);

int presenceOfTheLetter = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { 
        presenceOfTheLetter++; 
    } 
}

Console.WriteLine(newMessage);
Console.WriteLine($"The letter 'o' appears {presenceOfTheLetter} times in the text.");
*/

//Student Grading

using System;

int currentAssignments = 5;

int [] sophiaScores = new int[] {90, 86, 87, 98, 100};
int [] andrewScores = new int[] {92, 89, 81, 96, 90};
int [] emmaScores = new int[] {90, 85, 87, 98, 68}; 
int [] loganScores = new int[] {90, 95, 87, 88, 96};

string [] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"}; 

foreach (string name in studentNames)
{
    if (name == "Sophia")
    {
    
        int sophiaSum = 0;
        decimal sophiaScore;

        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

    }
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
