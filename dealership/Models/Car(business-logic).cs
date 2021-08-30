using System; //directs C# to provide specific code to run functions in our application
// using System.Collections.Generic; //? I believe this directs our program to understand that we will be using an array,object, or list
//we comment out line 2 becuase Car.cs doesnt contain list objects

namespace Dealership.Models//name it by the folder it is in then we use models for the BL because it models the format of the objects
{
  public class Car // class declares Car as a class, Which is always in UpperCamelCase
  {//always format the curly braces under the class
    //public string MakeModel; //these variables are known as fields 
    //public int Price;//fields are any variable declared within a class
    //public int Miles;//fields are written in PascalCase
    // update our fieds to be privat
    private string _makeModel; //now that the variables are private
    private int _price;// we denote with camelCase and an underscore
    private int _miles;

    public Car(string makeModel, int price, int miles)// we should name our constructor the same as the class its called on. our constructor containes multiple parameters
    {// our parameters correspond to the Car fields and they include a preceding type
      _makeModel = makeModel; // we set the object fields equal to the parameters
      _price = price;//note the fields are PascalCase 
      _miles = miles;// note the parameters are lowerCamelCase
    }//this constructor will return a new instance of Car
    //The purpose of using a constructor is to refactor our Program class
    
    public void SetPrice(int newPrice) //this method will set discounted prices during sales for particluar cars
    {//we name is public so it can be publically accessed and denote void because it doesnt return a value
      _price = newPrice; //we set the argument as the new automobile price
    }
    public string GetMakeModel()//this allows to make the returned variable publicly available but prevents it from being exposed
    {
      return _makeModel;
    }
    //below we add more get methods for the remaining variables
    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public bool WorthBuying(int maxPrice)// firstly we define type, bool, then delcar it only takes one argument
    {//methods within the class can only be called on said class
      return (_price <= maxPrice); //our method returns whether true or false if the price is or isnt less/equal to the users maxprice
    }
  }//they are not properties but are exposed like properties with the public access modifier..this will change to private soon enough

  //This is all part of the UI and was trnasfered to the appropriate folder file
  // public class Program 
  // {
  //   public static void Main()//below weve created four object instances of our class
  //   {
  //     /*Car volkswagen = new Car();//we denote new because they are each new instances of the Car class
  //     volkswagen.MakeModel = "1974 Volkswagen Thing"; //volkswagen.MakeModel is an object operator
  //     volkswagen.Price = 1100;// it tells the system to look in makeModel
  //     volkswagen.Miles = 368792;//then uses '=' as an assignement operator to set the value of the field for this instance 

  //     Car yugo = new Car();
  //     yugo.MakeModel = "1980 Yugo Koral";
  //     yugo.Price = 700;
  //     yugo.Miles = 56000;

  //     Car ford = new Car();
  //     ford.MakeModel = "1988 Ford Country Squire";
  //     ford.Price = 1400;
  //     ford.Miles = 239001;

  //     Car amc = new Car();
  //     amc.MakeModel = "1976 AMC Pacer";
  //     amc.Price = 400;
  //     amc.Miles = 198000;
  //     */
  //     //using our constructor to refactor(below is the same as above)
  //     Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
  //     Car yugo = new Car("1980 Yugo Koral", 700, 56000);
  //     Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
  //     Car amc = new Car("1976 AMC Pacer", 400, 198000);
      
  //     List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc}; //This creates a list of the type, class, Car
  //   // the list above is intantiated with the new List syntax and it contains all the instances of our Car class inside
      
  //     Console.WriteLine("Enter maximum price: ");//user is informed to enter a price
  //     string stringMaxPrice = Console.ReadLine();//variable equal to user response
  //     int maxPrice = int.Parse(stringMaxPrice);//variable, same name as our Worthbuying argument, equal to the int parse of the user response

  //     List<Car> CarsMatchingSearch = new List<Car>(0);// this list will contain cars that meet the maxprice criteria

  //     foreach (Car automobile in Cars) 
  //     {
  //       if (automobile.WorthBuying(maxPrice))//loop calls on our worthbuying method which calls on our element, automobile, to check the max price
  //       {
  //         CarsMatchingSearch.Add(automobile); //if condition is met the autombile is added to the list on line 47
  //       }
  //     }
  //     //foreach(Car automobile in Cars)//this loops through our car list
  //     foreach(Car automobile in CarsMatchingSearch)//weve updated the loop to only include cars user can affod
  //     {
  //       Console.WriteLine(automobile.MakeModel);//then it returns our MakeModel property for each
  //     }
  //   }
  // }
}