public class Constructor
{
    public string name;
    public int number;
    public int startDate;
}

static void Main(string[] args)
{
    Constructor constructor = new Constructor();
    constructor.name = "The Constructor";
    constructor.number = 1;
    constructor.startDate = 2025;
    Console.WriteLine($"This is {constructor.name}, under the number {constructor.number}, having started on {constructor.startDate}");
}