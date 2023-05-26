using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataProvider stringDataProvider = new StringDataProvider();
            IDataProvider intDataProvider = new IntDataProvider();

            DataService dataService = new DataService(stringDataProvider);

            dataService.ProcessData();
            Console.WriteLine();
            dataService.ChangeProvider(intDataProvider);
            dataService.ProcessData();
            Console.ReadLine();
        }
    }
}
