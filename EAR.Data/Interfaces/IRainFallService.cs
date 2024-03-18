using EAR.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAR.Data.Interfaces
{
    public interface IRainFallService
    {
        /// <summary>
        /// Get Rainfall reading by store id and limit
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public Task <List<RainFallReading>> GetRainFallReadingsByStoreId(string id, string limit);
    }
}
