using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.DomainLayer.Entities
{
    public class Group : BaseEntity<long>
    {
        [MaxLength(25)]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
