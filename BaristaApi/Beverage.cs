using System.Collections.Generic;
//INGREDIENTS:
//ESPRESSO, MILK, MILK FOAM, CHOCOLATE SYRUP, WATER

//CUPTYPE:
//Small, Medium, Large

//COFFEE BEAN TYPES:
//Arabica: "Normal" coffee types
//Robusta: Strong coffee types

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }

    IBeverage GetBeverageType();
    //Add more Methods below like Ibeverage AddWater();
}

class Espresso : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Water" };
    //Espresso 4/4 / Water? (span?)
    public string CupType => "Small";

    public IBeverage GetBeverageType()
    {
        throw new System.NotImplementedException();
    }
}

class Latte : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Milk" };
    // Espresso 1/4, Milk 3/4
    public string CupType => "Large";

    public IBeverage GetBeverageType()
    {
        throw new System.NotImplementedException();
    }
}

class Cappucino : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Milk" , "Milk Foam"};
    // Espresso 1/4, Milk 1/4, Milk Foam 2/4
    public string CupType => "Large";

    public IBeverage GetBeverageType()
    {
        throw new System.NotImplementedException();
    }
}

class Americano : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Water" };
    //Espresso 2/4, Water 2/4 
    public string CupType => "Small";

    public IBeverage GetBeverageType()
    {
        throw new System.NotImplementedException();
    }
}

class Macchiato : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Milk Foam" };
    // Espresso 1/4, Milk foam 3/4
    public string CupType => "Medium";

    public IBeverage GetBeverageType()
    {
        throw new System.NotImplementedException();
    }
}

class Mocha : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Chocolate Syrup", "Milk" };
    // Espresso 1/4, Chocholate syrup 1/4, Milk 2/4
    public string CupType => "Large";

    public IBeverage GetBeverageType()
    {
        throw new System.NotImplementedException();
    }
}