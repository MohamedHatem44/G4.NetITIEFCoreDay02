using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G4.NetITIEFCoreDay02.Model
{
    public class Student
    {
        //[Key]
        public int StudentId { get; set; }
        [Required]
        //[StringLength(50)]
        [MinLength(3)]
        [MaxLength(25)]
        public string Name { get; set; }

        [MinLength(10)] // => for UI Request
        [MaxLength(50)]
        public string? Address { get; set; }
        /*---------------------------------------------------*/
        //Relation with Department 
        //Deapartment have many Std
        //Std Assiged to one Department

        //[ForeignKey("Department")]
        public int? DepartmentId {  get; set; }
        //[ForeignKey("DepartmentId")]

        // Navigation Prop
        public virtual Department Department { get; set; }
        /*---------------------------------------------------*/
        // Many To Many Rel
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        /*---------------------------------------------------*/
        //[Range(1.5)] // => for UI Request
        //[EmailAddress] // => for UI Request

        public override string ToString()
        {
            string departmentName = Department != null ? Department.DeptName : "No Department";
            return $"Student Id: {StudentId}, Student Name: {Name}, Student Address: {Address}, Department Id: {DepartmentId}, Department Name: {departmentName}";
        }
    }
}
