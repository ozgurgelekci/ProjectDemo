using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Access
{
    public class Role : IEntity
    {
        [Key]
        public byte Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
    }
}
