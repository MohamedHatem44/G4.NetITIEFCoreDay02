using G4.NetITIEFCoreDay02.Context;
using G4.NetITIEFCoreDay02.Model;
using Microsoft.EntityFrameworkCore;

namespace G4.NetITIEFCoreDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolContext db = new SchoolContext();

            #region Create Departments
            //Department d1 = new Department() { DeptName = "HR", Description = "HR_Department_Description" };
            //Department d2 = new Department() { DeptName = "SD", Description = "SD_Department_Description" };
            //Department d3 = new Department() { DeptName = "CS", Description = "CS_Department_Description" };
            //Department d4 = new Department() { DeptName = "UI", Description = "UI_Department_Description" };
            //Department d5 = new Department() { DeptName = "Mobile", Description = "Mobile_Department_Description" };

            //db.Departments.Add(d1);
            //db.AddRange(d2, d3, d4, d5);
            //db.SaveChanges();
            #endregion

            #region Create Students
            //Student s1 = new Student() { Name = "Mohamed", Address = "s", DepartmentId = 1 };
            //Student s2 = new Student() { Name = "Ahmed", Address = "Address", DepartmentId = 2 };
            //Student s3 = new Student() { Name = "Ali", Address = "Address", DepartmentId = 3 };
            //Student s4 = new Student() { Name = "Hala", Address = "Address", DepartmentId = 4 };
            //Student s5 = new Student() { Name = "Mai", Address = "Address", DepartmentId = 5 };
            //db.Add(s1);
            //db.Students.AddRange(s2, s3, s4, s5);
            //db.SaveChanges();
            #endregion

            #region Read All Departments
            //var departments = db.Departments.ToList();
            //foreach (var item in departments)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Read All Students
            //var students = db.Students.ToList();
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Read All Students With Department Name
            //var stdWithDeptName = db
            //    .Students
            //    .Include(std => std.Department)
            //    .ToList();

            //foreach (var item in stdWithDeptName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Single Student
            //var s1 = db.Students.First();
            //var s2 = db.Students.OrderBy(s=>s.StudentId).Last();
            //// Find take array => Com PK
            //var s3 = db.Students.Find();
            //Console.WriteLine(s3);
            #endregion

            #region Update
            // Catch To Update
            //var stdToUpdate = db.Students.Find(5);
            //if (stdToUpdate != null)
            //{
            //    stdToUpdate.Name = "Sara";
            //}
            //db.SaveChanges();
            //Console.WriteLine(stdToUpdate);


            //var stdToUpdate2 = new Student() { StudentId = 5, Name = "Omar", Address = "Address", DepartmentId = 1 };
            //db.Students.Update(stdToUpdate2);
            //db.SaveChanges();
            #endregion

            #region Delete
            //var stdToDelete = db.Students.Find(5);
            //if (stdToDelete != null)
            //{
            //    db.Students.Remove(stdToDelete);
            //    db.SaveChanges();
            //}
            #endregion
        }
    }
}
