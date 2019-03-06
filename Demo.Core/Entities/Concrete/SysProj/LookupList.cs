using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.SysProj
{
    public class LookupList : IEntity
    {
        [Key]
        public short Id { get; set; }
        public short? ParentId { get; set; }
        public byte LookupId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(250)]
        public string LongName { get; set; }
        public bool IsActive { get; set; }
        [StringLength(50)]
        public string Color { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [StringLength(300)]
        public string Value { get; set; }
    }
}
