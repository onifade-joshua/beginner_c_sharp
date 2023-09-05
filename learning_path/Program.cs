namespace learning_path;

class Program
{
    static void Main(string[] args)
    {
        var Time = 1;
        var Rate = 50.4F; 
        var Money = 22000.0;

        var TotalAmount = (Time * Rate * Money) / 100;
        Console.WriteLine(TotalAmount);

        //Concatinating strings
        var fruitList = "Apples, Orange, Mango and Lemon";
        Console.WriteLine("There are " + fruitList + " in the fruits list of food.");
    }
}
