// Import the framework of the Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

// PhoneBook project
namespace PhoneBook
{
    // class PhoneBookContext
    class PhoneBookContext : DbContext
    {
        // private field of type DbSet<TEntity Person>
        // Represents a typed entity set that is used to perform create, read, update, and delete operations.
        public DbSet<Person> Persons { get; set; }
    }
}
