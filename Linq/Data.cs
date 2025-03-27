using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Data
    {
        public static List<Person> GetEmployeeList() => new List<Person>()
        {
            new Person { Id = 1, FirstName = "Jan", LastName = "Kowalski", Age = 30, Country = "Polska" },
            new Person { Id = 2, FirstName = "Anna", LastName = "Nowak", Age = 25, Country = "Polska" },
            new Person { Id = 3, FirstName = "Marek", LastName = "Wiśniewski", Age = 40, Country = "Polska" },
            new Person { Id = 4, FirstName = "Piotr", LastName = "Wójcik", Age = 35, Country = "Niemcy" },
            new Person { Id = 5, FirstName = "Katarzyna", LastName = "Kamińska", Age = 28, Country = "Polska" },
            new Person { Id = 6, FirstName = "Tomasz", LastName = "Zieliński", Age = 45, Country = "Polska" },
            new Person { Id = 7, FirstName = "Agnieszka", LastName = "Dąbrowska", Age = 32, Country = "Polska" },
            new Person { Id = 8, FirstName = "Grzegorz", LastName = "Szymański", Age = 38, Country = "Polska" },
            new Person { Id = 9, FirstName = "Magdalena", LastName = "Lewandowska", Age = 29, Country = "Niemcy" },
            new Person { Id = 10, FirstName = "Robert", LastName = "Woźniak", Age = 50, Country = "Polska" },
            new Person { Id = 11, FirstName = "Paweł", LastName = "Kaczmarek", Age = 26, Country = "Polska" },
            new Person { Id = 12, FirstName = "Barbara", LastName = "Jankowska", Age = 34, Country = "Polska" },
            new Person { Id = 13, FirstName = "Marcin", LastName = "Mazur", Age = 37, Country = "Niemcy" },
            new Person { Id = 14, FirstName = "Ewa", LastName = "Krawczyk", Age = 42, Country = "Polska" },
            new Person { Id = 15, FirstName = "Krzysztof", LastName = "Piotrowski", Age = 31, Country = "Polska" },
            new Person { Id = 16, FirstName = "Natalia", LastName = "Grabowska", Age = 27, Country = "Polska" },
            new Person { Id = 17, FirstName = "Andrzej", LastName = "Nowicki", Age = 36, Country = "Hiszpania" },
            new Person { Id = 18, FirstName = "Joanna", LastName = "Adamczyk", Age = 33, Country = "Rosja" },
            new Person { Id = 19, FirstName = "Michał", LastName = "Dudek", Age = 44, Country = "Polska" },
            new Person { Id = 20, FirstName = "Sylwia", LastName = "Pawlak", Age = 39, Country = "Hiszpania" }
        };
    }
}


