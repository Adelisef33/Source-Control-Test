Console.WriteLine("Why Hello World! How are you today?");

static void Main()
{
    HelloName();

    NumberGuesser();
}

//Method to greet the user by their name
static void HelloName()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();

    Console.WriteLine($"Hello {name}, I hope you are having an amazing day!");
}


// Going to implement a method that takes input from the user to guess a number


