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

//Student Grading

using System;

int examAssignments = 5;

int [] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int [] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int [] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89}; 
int [] loganScores = new int[] {90, 95, 87, 88, 96, 96};
int [] beckyScores = new int[] { 92, 91, 90, 91, 92, 92 ,92};
int [] chrisSocres = new int[] {84, 86, 88, 90, 92, 94, 96, 98};
int [] ericScores = new int[] {80, 90, 100, 80, 90, 100, 80, 90}; 
int [] gregorScores = new int[] {91, 91, 91, 91, 91, 91, 91};

string [] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"}; 

int [] studentScore = new int[10];

string currentStudentLetterGrade = ""; 

        
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScore = sophiaScores; 
    else if (currentStudent == "Andrew")
        studentScore = andrewScores; 
    else if (currentStudent == "Emma")
        studentScore = emmaScores;
    else if (currentStudent == "Logan")
        studentScore = loganScores;   
    else if (currentStudent == "Becky")
        studentScore = beckyScores; 
    else if  (currentStudent == "Chris")
        studentScore = chrisSocres; 
    else if (currentStudent == "Eric")
        studentScore = ericScores; 
    else if (currentStudent == "Gregor")
        studentScore = gregorScores; 
    else 
        continue; 
        
    int sumAssignmentScore = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0; 

    foreach (int score in studentScore)
    {
        gradedAssignments ++; 

        if (gradedAssignments <= examAssignments)
            sumAssignmentScore += score;
        else 

        sumAssignmentScore += score / 10; 
    }

    currentStudentGrade = (decimal)sumAssignmentScore / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-"; 

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-"; 
    
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-"; 
    
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-"; 
    
    else 
        currentStudentLetterGrade = "F"; 


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/
//Reto propuesto

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;
    decimal extraCredit = 0; 

    int gradedAssignments = 0;
    int extraAssignments = 0; 
    int sumAssignmentExtra = 0; 
    int sumOverallGrade = 0; 
    
    foreach (int score in studentScores)
    {
        gradedAssignments ++;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumOverallGrade += score / 10;
            sumAssignmentExtra += score; 
            extraAssignments ++;

    }
    extraCredit = sumAssignmentExtra / extraAssignments; 
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    decimal OverallGrade  = (decimal)(sumOverallGrade + sumAssignmentScores) / examAssignments;
    decimal subtraction = OverallGrade - currentStudentGrade; 

    if (OverallGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (OverallGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (OverallGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (OverallGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (OverallGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (OverallGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (OverallGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (OverallGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (OverallGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (OverallGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (OverallGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (OverallGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{OverallGrade}\t{currentStudentLetterGrade}\t{extraCredit} ({subtraction} pts)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

