
using System.ComponentModel.DataAnnotations;

namespace Demo.Core.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
