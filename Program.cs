//Griffin Parker
//October 18, 2022
//Mini Challenge 4 Remastered - Greater Than or Less Than
//Using if statements to compare two different numbers, my program will tell the user if their numbers are greater, lesser, or equal to each other
//Code Peer-reviewed by

bool end = true;
bool loop = true;
bool number1Checker = false;
bool number2Checker = false;
int num1 = 0;
int num2 = 0;
string repeat = "";

while (loop == true)
{
Console.Clear();
while (number1Checker == false || number2Checker == false)
{

Console.WriteLine("Please enter a number!");
string number1 = Console.ReadLine();
Console.WriteLine("Now please enter a second number! I will then let you know which one is greater, which one is lesser, or if they are equal to each other.");
string number2 = Console.ReadLine();
number1Checker = Int32.TryParse(number1, out num1);
number2Checker = Int32.TryParse(number2, out num2);
Console.Clear();
if (number1Checker == false || number2Checker == false) Console.WriteLine("Invalid response!");
}
Console.WriteLine("");

//Checking first number versus the second
if (num1 > num2){
Console.WriteLine(num1 + " is greater than "+ num2);
}
if (num1 < num2){
    Console.WriteLine(num1 + " is lesser than " + num2);
}
if (num1 == num2){
    Console.WriteLine(num1 + " is equal to " + num2);
}

//Checking second number versus the first
if (num2 < num1){
Console.WriteLine(num2 + " is lesser than "+ num1);
}
if (num2 > num1){
    Console.WriteLine(num2 + " is greater than " + num1);
}
end = true;
Console.WriteLine();
while (end == true)
{
Console.WriteLine("Would you like to compare numbers again? \"yes\" or \"no\"?");
repeat = Console.ReadLine();
repeat = repeat.ToLower();
if (repeat == "yes")
{
Console.WriteLine("TEST");
loop = true;
end = false;
number1Checker = false;
number2Checker = false;
}
if (repeat == "no")
{
loop = false;
end = false;
}
}

if (end == false)
{

} 
}
