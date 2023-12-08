using DI.Models;
using System.Collections.Generic;

namespace DI.Repository
{
    public interface IStudent
    {
        //add the CRUD operations signature methods and implement it in the Repository
        List<Student> GetAll();
        List<Student> GetAllStudentsWithDepartmentData();
        Student GetById(int id);
        void Insert(Student item);
        void Edit(int id, Student item);
        void Delete(int id);
    }
}
