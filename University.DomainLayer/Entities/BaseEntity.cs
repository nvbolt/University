using System.ComponentModel.DataAnnotations;

namespace University.DomainLayer.Entities
{
    public abstract class BaseEntity
    {
    }

    public abstract class BaseEntity<TKey> : BaseEntity
    {
        [Key]
        public TKey Id { get; set; }
    }
}
