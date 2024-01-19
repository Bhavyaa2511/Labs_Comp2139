using System.ComponentModel.DataAnnotations;

namespace Mytuesdaylab1.Models
{
    public class Project
    {

        public int Projectid { get; set; }

        public required string Name { get; set; }


        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime Startdate { get; set; }

        [DataType(DataType.Date)]

        public DateTime Enddate { get; set; }

        public string? Status {  get; set; }
    }
}
