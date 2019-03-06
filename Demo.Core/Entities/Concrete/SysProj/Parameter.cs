using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.SysProj
{
    public class Parameter : IEntity
    {
        [Key]
        public short Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Value { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
    }
}
