using System.ComponentModel.DataAnnotations;

namespace G4.NetITIEFCoreDay02.Model
{
    public class Course
    {
        [Key]
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Houres { get; set; }
        /*---------------------------------------------------*/
        // Many To Many Rel
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        /*---------------------------------------------------*/
    }
}
