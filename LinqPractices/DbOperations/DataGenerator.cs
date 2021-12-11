using LinqPractices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            var context = new LinqDbContext();
            if(context.Students.Any())
            {
                return;
            }
            else
            {
                context.Students.AddRange(
                new Student { Name="Ayşe",Surname="Yılmaz",ClassId=1 },
                new Student { Name = "Deniz", Surname = "Arda", ClassId = 1 },
                new Student { Name = "Umut", Surname = "Arda", ClassId = 2 },
                new Student { Name = "Merve", Surname = "Çalışkan", ClassId = 2 }

             );
                context.SaveChanges();
            }
        }
    }
}
