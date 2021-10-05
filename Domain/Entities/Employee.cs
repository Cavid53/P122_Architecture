using Domain.Common;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
