using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab2.Entities
{
    /// <summary>
    /// Represents a Salaried Employee
    /// </summary>
    /// <remarks>Author: Kyle Castillo</remarks>
    /// <remarks>Date: Feb 05,2023</remarks>
    internal class Salaried : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for salaried employee.
        private double salary;

        public double Salary
        {
            get
            {
                return salary;
            }
        }

        public override double Pay
        {
            get
            {
                return salary;
            }
        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        public Salaried(string id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}
