using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Utility
{
    public class RandomGenerator
    {
        public static string GenerateRandomFileName(string extension)
        {
            return  Guid.NewGuid().ToString() + extension;
        }
    }
}
