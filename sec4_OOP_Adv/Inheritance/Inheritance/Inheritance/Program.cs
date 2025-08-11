// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inheritance\n");

Console.WriteLine("Press any key to continue");
Console.ReadKey();

// Objects
var pizza = new Pizza();
pizza.AddIngredients(new Cheddar());
pizza.AddIngredients(new TomatoSauce());
pizza.AddIngredients(new Mozzarella());


Console.WriteLine(pizza.Describe());
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredients(Ingredient ingredients) =>
        _ingredients.Add(ingredients);

    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}
public class Ingredient
{

}
public class Cheddar : Ingredient
{
    #region Properties
    public string Name => "Cheddar Cheese";
    public int AgedForMonths { get; }
    #endregion
}

public class TomatoSauce : Ingredient
{
    #region Properties
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
    #endregion
}

public class Mozzarella : Ingredient
{
    #region Properties
    public string Name => "Mozzarela";
    public bool isLight { get; }
    #endregion
}

