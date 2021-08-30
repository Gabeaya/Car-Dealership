using System; //directs C# to provide specific code to run Console 
using System.Collections.Generic; //? I believe this directs our program to understand that we will be using an array,object, or list
using Dealership.Models;//here we call on our Car namespace, Models, in order to use our Car clas
namespace Dealership
{
  public class Program 
  {
    public static void Main()//below weve created four object instances of our class
    {
      /*Car volkswagen = new Car();//we denote new because they are each new instances of the Car class
      volkswagen.MakeModel = "1974 Volkswagen Thing"; //volkswagen.MakeModel is an object operator
      volkswagen.Price = 1100;// it tells the system to look in makeModel
      volkswagen.Miles = 368792;//then uses '=' as an assignement operator to set the value of the field for this instance 

      Car yugo = new Car();
      yugo.MakeModel = "1980 Yugo Koral";
      yugo.Price = 700;
      yugo.Miles = 56000;

      Car ford = new Car();
      ford.MakeModel = "1988 Ford Country Squire";
      ford.Price = 1400;
      ford.Miles = 239001;

      Car amc = new Car();
      amc.MakeModel = "1976 AMC Pacer";
      amc.Price = 400;
      amc.Miles = 198000;
      */
      //using our constructor to refactor(below is the same as above)
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);
      
      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc}; //This creates a list of the type, class, Car
    // the list above is intantiated with the new List syntax and it contains all the instances of our Car class inside
      
      //below we will use our setPrice method to change the ugo instance price
      yugo.SetPrice(500);
      Console.WriteLine("Enter maximum price: ");//user is informed to enter a price
      string stringMaxPrice = Console.ReadLine();//variable equal to user response
      int maxPrice = int.Parse(stringMaxPrice);//variable, same name as our Worthbuying argument, equal to the int parse of the user response

      List<Car> CarsMatchingSearch = new List<Car>(0);// this list will contain cars that meet the maxprice criteria

      foreach (Car automobile in Cars) 
      {
        if (automobile.WorthBuying(maxPrice))//loop calls on our worthbuying method which calls on our element, automobile, to check the max price
        {
          CarsMatchingSearch.Add(automobile); //if condition is met the autombile is added to the list on line 47
        }
      }
      //foreach(Car automobile in Cars)//this loops through our car list
      foreach(Car automobile in CarsMatchingSearch)//weve updated the loop to only include cars user can affod
      {
        //Console.WriteLine(automobile.MakeModel);//then it returns our MakeModel property for each
        //we will replace the "MakeModel" now that it is private
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());//these lines give all the automobile info to the user
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }

}
