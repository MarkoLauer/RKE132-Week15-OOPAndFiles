
//string[] data = GetDataFromMyFile();

List<Gift> myGifts = new List<Gift>();
string[] giftsFromFile = GetDataFromMyFile();
foreach (string line in giftsFromFile)
{
    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
    Gift newGift = new Gift(tempArray[0],tempArray[1]);
    myGifts.Add(newGift);
}
foreach (Gift giftFromList in myGifts)
{
    Console.WriteLine($" {giftFromList.Name} wants {giftFromList.Present} for Christmas.");
}


static string[] GetDataFromMyFile()
{
    string filepath = @"C:\Users\Marko\frozen.txt";
    //string[] dataFromFile = File.ReadAllLines(filepath);

    return File.ReadAllLines(filepath);
}


static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Gift
{
    string name;
    string present;

    public Gift(string _name, string _present)
    {
        name = _name;
        present = _present;
    }
    public string Name
    {
        get { return name; }
    }
    public string Present
    {
        get { return present; }
    }
}