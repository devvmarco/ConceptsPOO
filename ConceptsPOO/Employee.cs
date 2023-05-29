using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        private string _firstName;

        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public String LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, Birth: {BirthDate}, Hiring: {HiringDate}, Is active: {IsActive}";
                        
        }

    }
}