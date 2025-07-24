using KTMVC.Models;

namespace KTMVC;

 
public class Person 
{
    [Key]
    public String? PersonId { get; set; }
    public int? Age { get; set; }
    public Double? FullName { get; set; }
}
