using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Sam", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee emp2 = new Employee(2, "Smith", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));            
            Employee emp3 = new Employee(3, "Harvey", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));            
            Employee emp4 = new Employee(4, "Specter", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));            
            Employee emp5 = new Employee(5, "Mike", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            
            Employee empOne = new DirectReport(emp1, "SPS200");
            Employee empTwo = new DirectReport(emp2, "SPS200");
            Employee empThree = new DirectReport(emp3, "SPS200");
            Employee empFour = new DirectReport(emp4, "SPS200");
            Employee empFive = new DirectReport(emp5, "SPS200");

            List<Employee> lstDirectReports = new List<Employee>();
            lstDirectReports.Add(empOne);
            lstDirectReports.Add(empTwo);
            lstDirectReports.Add(empThree);
            lstDirectReports.Add(empFour);
            lstDirectReports.Add(empFive);
            //Manager manEmp = new Manager(1001, "Fred", 10, DateTime.ParseExact("01-12-2001", "dd-MM-yyyy", CultureInfo.InvariantCulture), lstDirectReports, "SPS001");
            Manager manEmp = new Manager(lstDirectReports, "SPS001");
            var lst = manEmp.GetMyReports();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
           // Console.ReadKey();
        }
    }
}
