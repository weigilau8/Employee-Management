﻿using System;
namespace Employee_Management.Models
{
	public class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

	}
}

