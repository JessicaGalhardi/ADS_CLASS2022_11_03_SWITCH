using System;

 class Program
{ 

    static void Main(string[] args)
    {
        try
        {

            Console.WriteLine("Please, enter with the name's car: ");
            string? car = Console.ReadLine();

            switch (car)
            {
                case "Ferrari":
                    Console.WriteLine("We have two Ferrari's available for rent!");
                    break;
                case "Porsche":
                    Console.WriteLine("We have five Porsche's available for rent!");
                    break;
                case "Corolla":
                    Console.WriteLine("We have one Corolla available for rent!");
                    break;


                default:
                    Console.WriteLine("Car not found!");
                    break;
         
            }

            Console.ReadKey();


        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while running the application" + ex);

        }
    }
}