// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n");


public class Order
{
    //your code goes here    

    public string Item { get; }
    private DateTime _date;

    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {
            if (value.Year == DateTime.Now.Year)
            {
                _date = value;
            }

        }

    }

    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date;
    }
}
