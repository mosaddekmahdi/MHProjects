// Import the framework of the Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

// PhoneBook project
namespace PhoneBook
{
    // class Person
    class Person
    {
        // private field of type int
        public int ID { get; set; }
        // This attribute specifies the field below is required that can not be null or empty
        [Required]
        // private field of type string
        public string NAME { get; set; }
        // This attribute specifies the field below is required that can not be null or empty
        [Required]
        // private field of type string
        public string SURNAME { get; set; }
        // This attribute specifies the field below is required that can not be null or empty
        [Required]
        // private field of type string
        public string TELEPHONENUMBER { get; set; }
        // This attribute specifies the field below is required that can not be null or empty
        [Required]
        // private field of type string
        public string MOBILE { get; set; }
    }
}
