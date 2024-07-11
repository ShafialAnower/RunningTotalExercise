//Write an application that prompts the user for integer values
//And keeps a running total.
//If the user enters a 'Q' then print the sum of all the values entered
//And end the program.

//Do we want the application to at least run once?


//Console.WriteLine("Running Total");
//Console.WriteLine("==============");


//int num;
//int total = 0;




//do
//{
//    Console.Write("Enter a number or (Q to quit): ");
//    num = int.Parse(Console.ReadLine());

//    if (Console.ReadLine().ToUpper().ToUpper() == "Q")
//    {
//        Console.WriteLine($"The sum of the number is: {(num + total)}");
//        break;
//    }
//} while (true);

//The solution above is not correct Store the user input in a variable after prompting for it.
// And to Check if the stored input is 'Q' to decide whether to end the loop or add the input to the total.



//Solution -> SkillFoundry Edition 

//Standard parse will crash the program if it encounters a -> Store user input in a string
//-> Check if the string is 'Q' ->If not then we can parse it 

//Declare variables for user input and total 
string input;
int total = 0; //It is possible a user can enter Q without entering any numbers 
//You cannnot use an uninitialized variable
//Print Title
Console.WriteLine("Running Total");
Console.WriteLine("==============");

//Loop unitil Q is entered 
do
{
    //Prompt user
    Console.Write("Enter a number or (Q to quit): ");
    input = Console.ReadLine().ToUpper();

    //if Q break loop
    if (input != "Q")
    {
        //Parse and add to total 
        total += int.Parse(input);  //The code total += int.Parse(input); is equivalent to total = total + int.Parse(input);.
        //This expression takes the integer value parsed from input and adds it to the current value of total. Then, it assigns the result back to total.
    }

    //If the user enter "Q" it is going to fall out of the loop because Q is not equal to Q

} while (input != "Q");

//Print result 

Console.WriteLine($"The sum of the numbers is: {total}");
