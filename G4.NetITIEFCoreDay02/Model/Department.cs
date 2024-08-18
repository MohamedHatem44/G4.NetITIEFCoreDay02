using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4.NetITIEFCoreDay02.Model
{
    //[Table("ITI_Dept")]
    public class Department
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(25)]
        [Required]
        public string DeptName { get; set; }
        [MinLength(20)]
        [MaxLength(80)]
        public string? Description { get; set; }
        /*---------------------------------------------------*/
        //Relation with Std 
        //Deapartment have many Std
        //Std Assiged to one Department
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        /*---------------------------------------------------*/
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        /*---------------------------------------------------*/
        public override string ToString()
        {
            return $"Department Id: {Id}, Department Name: {DeptName}, Department Description: {Description}";
        }
    }
}
