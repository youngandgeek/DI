using DI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace DI.Repository
{
    //:IStudent implements the interface 
    public class StudentRepo : IStudent
    {
        //CRUD
        //DI
        //add the dbconclass 
        DbConnClass context;//= new ITIEntity();

        public StudentRepo(DbConnClass _context)
        {
            context = _context;
        }

        public List<Student> GetAll()
        {
            return context.Student.ToList();
        }
  public List<Student> GetAllStudentsWithDepartmentData()
        {
            return context.Student.Include(s => s.Department).ToList();
        }
        public Student GetById(int id)
        {
            return context.Student.FirstOrDefault(x => x.Id == id);
        }
        public void Insert(Student item)
        {
            context.Student.Add(item);
            context.SaveChanges();
        }
        public void Edit(int id, Student item)
        {
            Student oldStudent = GetById(id);
            oldStudent.Name = item.Name;
            oldStudent.Dept_Id = item.Dept_Id;
            oldStudent.Age = item.Age;
            oldStudent.Image = item.Image;
            oldStudent.Address = item.Address;

            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Student oldStudent = GetById(id);
            context.Student.Remove(oldStudent);
            context.SaveChanges();
        }


    }
}
