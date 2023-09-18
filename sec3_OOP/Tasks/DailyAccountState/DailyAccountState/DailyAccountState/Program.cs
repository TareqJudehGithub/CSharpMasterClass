// See https://aka.ms/new-console-template for more information

Console.WriteLine("DailyAccountState\n");


DateTime date = DateTime.Now;
static string Report() => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {SumOfOperations}";

public class DailyAccountState
{


    public int InitialState { get; }

    public int SumOfOperations { get; }

    public DailyAccountState(int initialState, int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    //your code goes here
    public int EndOfDayState => InitialState + SumOfOperations;

}
