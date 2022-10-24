using Assignment10_2_;
bool stillMore;
TimeSpan startLimit = new TimeSpan(7, 0, 0);
TimeSpan endLimit = new TimeSpan(22, 0, 0);
TimeSpan start, end;
double charges;
do
{

    Console.Write("Enter the starting time (HH:MM):");
    string received = Console.ReadLine();
    while (!TimeSpan.TryParse(received, out start) || start < startLimit || start >= endLimit)
    {
        Console.Write("Something went wrong, try again:");
        received = Console.ReadLine();
    }
    Console.Write("Enter the ending time (HH:MM):");
    received = Console.ReadLine();
    while (!TimeSpan.TryParse(received, out end) || end < start || end >= endLimit)
    {
        Console.Write("Something went wrong, try again:");
        received = Console.ReadLine();
    }


    Parking myParking = new Parking(start, end);
    TimeSpan numberofhours = myParking.HowLong();

    var total = myParking.Totalcharges(start, end);


    Console.WriteLine("Parking time is {0} hours and {1} minutes.", numberofhours.Hours,
    numberofhours.Minutes);
    Console.WriteLine("Total charges is {0} euros", total);

    Console.Write("More of this(Y/N):");
    string decison = Console.ReadLine().ToUpper();
    if (decison.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
}
while (stillMore);
