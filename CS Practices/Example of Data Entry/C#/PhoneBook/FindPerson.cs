// Import the framework of the Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

// PhoneBook project
namespace PhoneBook
{
    // class FindPerson
    class FindPerson
    {
        // private field of type PhooneBookContext
        private PhoneBookContext ctxFind { get; set; }
        // private field of type bool
        private bool Find {get;set;}
        // private field of type string
        private string Charater { get; set; }
        // private field of type DataGridView
        private DataGridView Data { get; set; }
        // private field of type string
        private string TypeSearch { get; set; }

        // LinqToEntities using search function, which returns a DataGridView control containing the search results
        public DataGridView DetailPerson(PhoneBookContext ctx,bool Find,string charater,string search,DataGridView data)
        {
            // Enhance the private variables with the parameters of the function DetailPerson
            this.ctxFind = ctx;
            this.Find = Find;
            this.Charater = charater;
            this.Data = data;
            this.TypeSearch = search;

            // I declare a new instance of the class PhoneBookContext
            using (PhoneBookContext ctxFind = new PhoneBookContext())
            {
                // if the variable find and true charater and the variable is not empty or null
                if (this.Find.Equals(true) &&  ! string.IsNullOrEmpty(this.Charater))
                {
                    // if the value of the variable equal to TypeSearch NAME 
                    if (this.TypeSearch.Equals("NAME"))
                    {
                        // I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
                        var query = from c in ctx.Persons
                                    where c.NAME.StartsWith(this.Charater)
                                    select c;

                        // I make the iteration variable in the variable query person
                        foreach (var person in query)
                        {
                            // I post all the occurrences found in the variable of type DataGridView Date
                            this.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE);
                        }
                    }

                    // if the value of the variable equal to TypeSearch SURNAME 
                    if (this.TypeSearch.Equals("SURNAME"))
                    {
                        // I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
                        var query = from c in ctx.Persons
                                    where c.SURNAME.StartsWith(this.Charater)
                                    select c;

                        // I make the iteration variable in the variable query person
                        foreach (var person in query)
                        {
                            // I post all the occurrences found in the variable of type DataGridView Date
                            this.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE);
                        }
                    }

                    // if the value of the variable equal to TypeSearch TELEPHONENUMBER 
                    if (this.TypeSearch.Equals("TELEPHONENUMBER"))
                    {
                        // I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
                        var query = from c in ctx.Persons
                                    where c.TELEPHONENUMBER.StartsWith(this.Charater)
                                    select c;

                        // I make the iteration variable in the variable query person
                        foreach (var person in query)
                        {
                            // I post all the occurrences found in the variable of type DataGridView Date
                            this.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE);
                        }
                    }

                    // if the value of the variable equal to TypeSearch MOBILE
                    if (this.TypeSearch.Equals("MOBILE"))
                    {
                        // I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
                        var query = from c in ctx.Persons
                                    where c.MOBILE.StartsWith(this.Charater)
                                    select c;

                        // I make the iteration variable in the variable query person
                        foreach (var person in query)
                        {
                            // I post all the occurrences found in the variable of type DataGridView Date
                            this.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE);
                        }
                    }
                }

                // In case of missing parameters
                else
                {
                    // Display message to user
                    MessageBox.Show("Insert a Name,SurName,TelephoneNumber or Mobile for Person",Application.ProductName.ToString());
                }
            }

            // Returns the result of the function
            return this.Data;
        }
    }
}
