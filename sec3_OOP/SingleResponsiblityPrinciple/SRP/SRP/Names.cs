class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NameValidator _nameValidator = new NameValidator();

    public void AddNames(List<string> stringsFromFile)
    {
        foreach (var name in stringsFromFile)
        {
            AddName(name);
        }
    }
    public void AddName(string name)
    {
        if (_nameValidator.IsValid(name))
            All.Add(name);
    }

}