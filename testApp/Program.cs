using OpenATV3;
namespace testApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // you can then define parts of the bag (name, etcetc) and it will auto populate
        Bag bagGeneration = new Bag();
        bagGeneration.GenerateBag("/Users/un/Downloads/bag.plist");
    }
}