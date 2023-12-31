﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DI.Models
{
    //to add student as a table in db run in package manager console
    //-> add-migration ,      -> update-database
    public class Student
    {
        public int Id { get; set; }
        // [DataType(DataType.EmailAddress)]
        [Display(Name = "Student Name")]
        [Required]
        [MaxLength(30, ErrorMessage = "Name must be less than 30 letter")]
        [MinLength(3, ErrorMessage = "NAme must be greater than 2 letter")]

       /** [Remote(action: "CheckName", controller: "Student"
            , AdditionalFields = "Address"
            , ErrorMessage = "Name Must Contai ITI")]
        **/
        public string Name { get; set; }

        [Required]
       // [RegularExpression(@"(Alex|Assiut)", ErrorMessage = "Address Must be Alex or Assiut")]
        public string Address { get; set; }

        [Display(Name = "Student Age")]
        [Required]
        [Range(maximum: 50, minimum: 20)]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"\w+\.(jpg|png)", ErrorMessage = "Image must be jpg or png")]
        public string Image { get; set; }

        [ForeignKey("Department")]
        [Display(Name = "Department Name")]
        public int Dept_Id { get; set; }
        //to add .Department in the student repo get student with department method
        // return context.Student.Include(s => s.Department).ToList();

        public virtual Department? Department { get; set; }// = new Department();
    }
}
