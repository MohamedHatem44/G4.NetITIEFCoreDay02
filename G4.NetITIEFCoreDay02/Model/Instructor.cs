namespace G4.NetITIEFCoreDay02.Model
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        
        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();


        public virtual Car Car { get; set; }
    }
}
