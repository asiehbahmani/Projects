using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
   
    public class CourseRepo
    {
        public Context context= new Context();
       
        public course  Add(string courseName)
        {
            course cor = new course()
            {
                CourseName = courseName 
            };
            context.courses.Add(cor);
            context.SaveChanges();
            return cor;
        }

        public course Update(string courseName)
        {
            course cor = new course()
            {
                CourseName = courseName
            };
            //context.Users.Find(UserId);
            context.courses.Add(cor);
            context.SaveChanges();
            return cor;
        }




    }
}
