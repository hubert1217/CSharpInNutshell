// See https://aka.ms/new-console-template for more information
using Linq;

Console.WriteLine("Linq");


var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


var result = numbers.Where(x=>x%2==0).ToList();


var employeeList = Data.GetEmployeeList();

var ageBetween40and45 = (from employee in employeeList
                         where employee.Age >= 40 && employee.Age <= 45
                         select employee).ToList();


var _ageBetween40and45 = employeeList.Where(x => x.Age >= 40 && x.Age <= 45).ToList();


var fromSpain = employeeList.Where(x => x.Country.Contains("Hiszpania")).ToList();



var groupByCountry = employeeList.GroupBy(x => x.Country).Select(x => new { Country = x.Key, employee=x.ToList() }).ToList();






Console.WriteLine(string.Join(", ", result));

Console.ReadLine();