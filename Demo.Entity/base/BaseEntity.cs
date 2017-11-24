using System.ComponentModel.DataAnnotations;

namespace Demo.Entity.@base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
