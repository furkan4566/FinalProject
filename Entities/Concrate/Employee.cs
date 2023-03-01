using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        //public string Phone { get; set; }
        public string Notes { get; set; }


    }
}
