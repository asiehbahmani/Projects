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

        public bool Add(string ControllerName, string ActionName,string username)
        {
            Log log = new Log()
            {
                ActionName = ActionName,
                ControllerName= ControllerName,
                username =username, 
                
              
            };
            context.Logs.Add(log);
            context.SaveChanges();
            return true;
        }
    }
}
