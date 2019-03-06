using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Access
{
    public class Permission : IEntity
    {
        [Key]
        public short Id { get; set; }
        public short ParentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Controller { get; set; }
        [StringLength(50)]
        public string Action { get; set; }
        [StringLength(150)]
        public string Raw { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        public short DisplayOrder { get; set; }
        public bool IsMenu { get; set; }
        public bool IsVisible { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
    }
}
