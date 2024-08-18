using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4.NetITIEFCoreDay02.Model
{
    public class Car
    {
        [Key]
        public int Car_Id { get; set; }
        [Required]
        public string Car_Name { get; set; }


        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
