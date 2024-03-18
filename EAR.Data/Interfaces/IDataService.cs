using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAR.Data.Interfaces
{
    public interface IDataService
    {
        public Task<string> GetDataAsync(string url);
    }
}
