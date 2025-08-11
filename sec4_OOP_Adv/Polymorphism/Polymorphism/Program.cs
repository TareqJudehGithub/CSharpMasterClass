// See https://aka.ms/new-console-template for more information
Console.WriteLine("Polymorphism\n");


Spaghetti spaghetti = new Spaghetti();
Pasta pasta = new Pasta();
Cheese cheese = new Cheese();
TomatoSauce tomatoSauce = new TomatoSauce();

spaghetti.AddIngredients(pasta);
spaghetti.AddIngredients(cheese);
spaghetti.AddIngredients(tomatoSauce);

spaghetti.Description();
class Spaghetti
{
    // List
    private List<Ingredient> _ingredients = new List<Ingredient>();

    // Add items to list
    public void AddIngredients(Ingredient ingredient) => _ingredients.Add(ingredient);

    public void Description()
    {
        string ingredient = string.Join("\n", _ingredients);
        Console.WriteLine($"Pasta ingredients list:\n{ingredient}");
    }
}

public class Ingredient
{

}
public class Pasta : Ingredient
{
    public string Name => "Pasta";
}
public class Cheese : Ingredient
{
    public string Name => "Cheese";
}
public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
}

