using System.Collections.Generic;
//INGREDIENTS
//ESPRESSO
//MILK
//MILK FOAM
//CHOCOLATE SYRUP
//WATER

//CUPTYPE,
//Small
//Medium
//Big

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}

class Espresso : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Water" };
    //Espresso 4/4 / Water? (span?)
    public string CupType => "Small";
    
}

class Latte : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Milk" };
    // Espresso 1/4, Milk 3/4
    public string CupType => "Large";
}

class Cappucino : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Milk" , "Milk Foam"};
    // Espresso 1/4, Milk 1/4, Milk Foam 2/4
    public string CupType => "Medium";
}

class Americano : IBeverages
{
    public List<string> Ingredients => new List<string> { "Beans", "Water" };
    //Espresso 2/4, Water 2/4 
    public string CupType => "Small";
}

class Macchiato : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Milk Foam" };
    // Espresso 1/4, Milk foam 3/4
    public string CupType => "Medium";
}

class Mocha : IBeverage
{
    public List<string> Ingredients => new List<string> { "Beans", "Chocolate Syrup", "Milk" };
    // Espresso 1/4, Chocholate syrup 1/4, Milk 2/4
    public string CupType => "Large";
}