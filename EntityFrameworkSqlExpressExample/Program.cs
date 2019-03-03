using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlExpressExample
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new Model1())
            {
                // Create and save a new Students
                Console.WriteLine("Adding new students");

                var student = new anotherTable
                {
                    anotherage = "age",
                    anotherHeight = "height",
                };

                context.anotherTables.Add(student);

                context.SaveChanges();
            }


        }
    }
}
