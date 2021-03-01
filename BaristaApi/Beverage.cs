using System.Collections.Generic;


//INGREDIENTS
//ESPRESSO
//MILK
//MILK FOAM
//CHOCOLATE SYRUP
//WATER
public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}

class Espresso : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    //Espresso 4/4 (span?)
    public string CupType => throw new System.NotImplementedException();
    
}

class Latte : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    // Espresso 1/4, Milk 3/4
    public string CupType => throw new System.NotImplementedException();
}

class Cappucino : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    // Espresso 1/4, Milk 1/4, Milk Foam 2/4
    public string CupType => throw new System.NotImplementedException();
}

class Americano : IBeverages
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    //Espresso 2/4, Water 2/4 
    public string CupType => throw new System.NotImplementedException();
}

class Macchiato : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    // Espresso 1/4, Milk foam 3/4
    public string CupType => throw new System.NotImplementedException();
}

class Mocha : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    // Espresso 1/4, Chocholate syrup 1/4, Milk 2/4
    public string CupType => throw new System.NotImplementedException();
}