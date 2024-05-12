// See https://aka.ms/new-console-template for more information

//dotnet library
Random dice = new Random();
int roll = dice.Next(1, 7); //Random.Nice method is stateful
Console.WriteLine(roll);
Console.WriteLine(dice.Next(1, 7));//this is stateless
//o call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.When calling a stateless method, you don't need to create a new instance of its class first.When calling a stateful method, you need to create an instance of the class, and access the method on the object.Use the new operator to create a new instance of a class.An instance of a class is called an object.

//Many methods in the .NET Class Library have overloaded method signatures. Among other things, this enables you to call the method with or without arguments specified in the calling statement.An overloaded method is defined with multiple method signatures. Overloaded methods provide different ways to call the method or provide different types of data.In some cases, overloaded versions of a method are used to define a parameter using different data types. For example, the Console.WriteLine() method has 19 different overloaded versions. Most of those overloads allow the method to accept different types and then write the specified information to the console. Consider the following code:
Random ludo = new Random(); //overloaded methods for Random means using Random ın dıfferent ways and form
int roll1 = ludo.Next(); //This will gıve a random ınt begınnıng from 0 to the hıghest ınteger 
int roll2 = ludo.Next(101); // stateful methodThis will give between 0 and 100
int roll3 = ludo.Next(50, 101); //This will be between 50 and 100;

Console.WriteLine($"First roll: {roll1}"); //this ıs also an overloaded method
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}"); //stateless methods

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
Random dices = new Random();
int randomNumber1 = dices.Next(1, 7);
int randomNumber2 = dices.Next(1, 7);
int randomNumber3 = dices.Next(1, 7);
int total = randomNumber1 + randomNumber2 + randomNumber3;
Console.WriteLine($"Dice roll: {randomNumber1} + {randomNumber2} + {randomNumber3} = {total}");
//The goal is to create an inner if-else construct where the two outcomes are related opposites, and then use the opposing outcomes (if/true and else/false) to award the bonus points for triples and doubles. To achieve this goal, you check for doubles in the outer if statement, and then for triples in the inner if statement. This pattern ensures that when the inner check for triples returns false, your else code block can award the points for doubles.
if ((randomNumber1 == randomNumber2) || (randomNumber2 == randomNumber3) || (randomNumber1 == randomNumber3)){
    if ((randomNumber1 == randomNumber2) &&  (randomNumber2 == randomNumber3)) {
    Console.WriteLine("You rolled a triple: +6 bonus to total!");
    total +=6;
} else {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
}

if (total >= 16)
{
    Console.WriteLine("You win a new car");
} //To make the game more fun, you can change the game from "win-or-lose" to awarding fictitious prizes for each score. You can offer four prizes. However, the player should win only one prize:If the player scores greater or equal to 16, they'll win a new car.If the player scores greater or equal to 10, they'll win a new laptop.If the player scores exactly 7, they'll win a trip.Otherwise, the player wins a kitten.
else if(total >= 10)
{
    Console.WriteLine("Sorry, you lose.");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two");
}
else {
    Console.WriteLine("You win a kitten!");
}
