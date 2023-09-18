// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dog Class task\n");

Dog lucky = new Dog(name: "Lucky", breed: "german shepherd", weight: 40);
Dog tina = new Dog(name: "Tina", breed: "shar pei", weight: 25);
Dog poochi = new Dog(name: "Poochi", weight: 25);

Console.WriteLine(lucky.Describe());
Console.WriteLine(tina.Describe());
Console.WriteLine(poochi.Describe());
public class Dog
{
    // TODO
    #region fields
    private string _name;
    private string _breed = "mixed-breed";
    private int _weight;
    #endregion

    #region Constructors
    public Dog(string name, string breed, int weight)
    {
        this._name = name;
        this._breed = breed;
        this._weight = weight;
    }
    public Dog(string name, int weight)
    {
        this._name = name;
        this._weight = weight;
    }
    #endregion

    #region Methods
    public string Describe()
    {
        string sizeDescription;
        if (_weight < 5)
        {
            sizeDescription = "tiny";
        }
        else if (_weight >= 5 && _weight < 30)
        {
            sizeDescription = "medium";
        }
        else
        {
            sizeDescription = "large";
        }
        return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {sizeDescription} dog.";
    }
    #endregion
}
