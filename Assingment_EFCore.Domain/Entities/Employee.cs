﻿using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<ProjectEmployee> ProjectEmployees { get; set; }
        public Salary Salary { get; set; }

        [Required]
        public DateTime JoinedDate { get; set; }
    }
}