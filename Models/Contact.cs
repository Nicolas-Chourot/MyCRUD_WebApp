using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCRUD_WebApp.Models
{
    public enum GenderType { Male, Female, other }
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderType Gender { get; set; }
    }
}