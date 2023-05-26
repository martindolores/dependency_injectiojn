using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class StringDataProvider : IDataProvider
    {
        public string GetData()
        {
            return $"StringDataProvider: {Guid.NewGuid()}";
        }
    }
}
