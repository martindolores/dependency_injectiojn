using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class DataService
    {
        private IDataProvider _dataProvider;

        public DataService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void ProcessData()
        {
            Console.WriteLine("Processing data:");
            Console.WriteLine(this._dataProvider.GetData());
        }

        public void ChangeProvider(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }
    }
}
