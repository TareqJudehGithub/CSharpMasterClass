// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n");

#region Objects
//Person john = new Person(name: "John", yearOfBirth: 1985);
#endregion

#region Object Initilizer
Person sarah = new Person
{
    Name = "Sarah",
    YearOfBirth = 1975
};
#endregion


class Person
{

    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    //public Person(string name, int yearOfBirth)
    //{

    //}
}

