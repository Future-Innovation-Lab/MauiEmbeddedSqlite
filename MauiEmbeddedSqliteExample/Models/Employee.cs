﻿using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiEmbeddedSqliteExample.Models
{
    public class Employees
    {
        [PrimaryKey, AutoIncrement]
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        [ForeignKey(typeof(Employees))]
        public int ReportsTo { get; set; }
    }
}
