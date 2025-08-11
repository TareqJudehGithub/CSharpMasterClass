
Console.WriteLine("Enums\n");


Season firstSeason = Season.Spring;
Console.WriteLine(firstSeason);

// Casting converting a Season type variable to int type
int firstSeasonNo = (int)Season.Spring;
Console.WriteLine(firstSeasonNo);
public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

// we Can override Enums values manually

public enum DaysOfWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

// or values of choice - like this http enum codes

public enum HttpCodes
{
    Ok = 200,
    NotFound = 404,
    InternalServerError = 500
}


