//Griffin Parker
//October 19, 2022
//Mini Challenge 4 Remastered - Greater Than or Less Than
//Using if statements to compare two different numbers, my program will tell the user if their numbers are greater, lesser, or equal to each other
//Peer Review by: Jasmine Leek - program runs exactly as intended and did not break under all tested conditions.
//Great comments which clearly outline each step of the program. Nice!


//Initializing the variables that will be used in the program
bool end = true;
bool loop = true;
bool number1Checker = false;
bool number2Checker = false;
int num1 = 0;
int num2 = 0;
string repeat = "";

//This while loop contains the entirety of the program. If the user does not want to restart the program, loop is set to false
while (loop == true)
{
Console.Clear();

/*This while loop is designed to get both of the numbers from the user that the program will compare.
The loop checks to see if the first number OR the second number don't pass the TryParse test
and will continue to loop until both user inputs can be stored in an int variable  */
while (number1Checker == false || number2Checker == false)
{
Console.WriteLine("Please enter a number!");
//  \/ These lines of code get the user's first input and then test to see if their input can be stored in an int variable
string number1 = Console.ReadLine();
number1Checker = Int32.TryParse(  number1,        out num1);
//   /\ Bool variable             /\user's input  /\if the user's input is a number, it will be stored in the int variable num1

//If the first input can be stored in an int variable then this if statement will be ran
if (number1Checker == true)
{
//This if statment will repeat the same process used on the first user's input on their second input 
Console.WriteLine("Now please enter a second number! I will then let you know which one is greater, which one is lesser, or if they are equal to each other.");
string number2 = Console.ReadLine();
number2Checker = Int32.TryParse(number2, out num2);
}
Console.Clear();
//this if statement is ran if the user's first or second input are found to be false through the TryParse command
if (number1Checker == false || number2Checker == false) Console.WriteLine("Invalid response!");
}

//Checking first number versus the second
if (num1 > num2)  Console.WriteLine(num1 + " is greater than "+ num2);
if (num1 < num2)  Console.WriteLine(num1 + " is lesser than " + num2);
if (num1 == num2) Console.WriteLine(num1 + " is equal to " + num2);

//Checking second number versus the first
if (num2 < num1) Console.WriteLine(num2 + " is lesser than "+ num1);
if (num2 > num1) Console.WriteLine(num2 + " is greater than " + num1);

end = true;
Console.WriteLine();

//This while loop contains the part of the program that lets the user restart or end the program
//It will only end when the user types "yes" or "no"
while (end == true)
{
Console.WriteLine("Would you like to compare numbers again? \"yes\" or \"no\"?");
repeat = Console.ReadLine();
repeat = repeat.ToLower();
if (repeat == "yes")
{
//These variables are used to break out of the restart while loop, and reset the program's important variables to begin again
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
}
