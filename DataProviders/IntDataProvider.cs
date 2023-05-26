using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class IntDataProvider : IDataProvider
    {
        public string GetData()
        {
            Random rnd = new Random();
            return $"IntDataProvider: {rnd.Next()}";
        }
    }
}
