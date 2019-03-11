using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.SysProj
{
    public class Language : IEntity
    {
        [Key]
        public byte Id { get; set; }
        [StringLength(10)]
        public string Culture { get; set; }
        [StringLength(10)]
        public byte UiCulture { get; set; }
        [StringLength(50)]
        public byte Name { get; set; }
    }
}
