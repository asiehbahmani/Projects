using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Log
    {
        public  int logId { get; set; }

        public string EntityName { get; set; }

        public string ActionName { get; set; }

        public int userId { get; set; }

        public string credate { get; set; }
    }
}
