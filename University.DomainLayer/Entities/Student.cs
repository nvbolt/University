using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using University.DomainLayer.Entities.Enums;

namespace University.DomainLayer.Entities
{
    public class Student: BaseEntity<long>
    {
        [Required]
        public Gender Gender { get; set; }

        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(60)]
        public string Patronymic { get; set; }

        [MaxLength(16)]
        [MinLength(6)]
        public string Nickname { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
