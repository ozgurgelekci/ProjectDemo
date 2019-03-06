using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Common
{
    public class Unit : BaseEntity, IEntity
    {
        public int ParentId { get; set; }
        public int UnitTypeId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        public bool IsActive { get; set; }
    }
}
