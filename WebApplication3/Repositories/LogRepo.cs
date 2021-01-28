using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public class LogRepo

    {
        public Context context = new Context();

        public bool Add(string ActionName,string credate,int userid,string entityname)
        {
            Log log = new Log()
            {
                ActionName = ActionName,
                credate=credate,
                userId=userid,
                EntityName= entityname 
              
            };
            context.Logs.Add(log);
            context.SaveChanges();
            return true;
        }
    }
}
