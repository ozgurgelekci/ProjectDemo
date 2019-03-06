using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.SysProj
{
    public class Lookup : BaseEntity, IEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
