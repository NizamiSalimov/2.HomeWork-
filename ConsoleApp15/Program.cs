using System;

class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<string, double> exchangeRates = new Dictionary<string, double>();
        exchangeRates.Add("AZN", 1);
        exchangeRates.Add("TRY", 0.153);
        exchangeRates.Add("RUB", 0.011);

        
        Console.WriteLine("Mezenneni secin:");
        Console.WriteLine("1. AZN");
        Console.WriteLine("2. TRY");
        Console.WriteLine("3. RUB");

        
        Console.Write("Seciminizi daxil edin (1-3): ");
        
        int selection = int.Parse(Console.ReadLine());

      
        double exchangeRate;

        switch (selection)
        {
            case 1:
                exchangeRate = exchangeRates["AZN"];
                Console.WriteLine("AZN mezennesi: {0}", exchangeRate);
                break;
            case 2:
                exchangeRate = exchangeRates["TRY"];
                Console.WriteLine("TRY mezennesi: {0}", exchangeRate);
                break;
            case 3:
                exchangeRate = exchangeRates["RUB"];
                Console.WriteLine("RUB mezennesi: {0}", exchangeRate);
                break;
            default:
                Console.WriteLine("Secdiyiniz mezenne movcud deyil");
                break;

        }
    }
}
