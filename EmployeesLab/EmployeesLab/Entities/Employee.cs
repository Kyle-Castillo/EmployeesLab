using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab2.Entities
{
    /// <summary>
    /// Represents an Employee
    /// </summary>
    /// <remarks>Author: Kyle Castillo</remarks>
    /// <remarks>Date: Feb 05,2023</remarks>
    internal class Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for general employee.
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string birthdate;
        protected string department;

        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get => name;
        }

        public virtual double Pay
        {
            get
            {
                return 0;
            }
        }

        public string Address
        {
            get => address;
        }

        public string Phone
        {
            get => phone;
        }

        public long Sin
        {
            get => sin;
        }

        public string Birthdate
        {
            get => birthdate;
        }

        public string Department
        {
            get => department;
        }
        /// <summary>
        /// No-arg constructor
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /*public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
        }*/
    }
}