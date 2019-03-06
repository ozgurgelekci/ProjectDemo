using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.SysProj
{
    public class Resource : BaseEntity, IEntity
    {
        public byte LanguageId { get; set; }
        [StringLength(50)]
        public string Label { get; set; }
        [StringLength(500)]
        public string Title { get; set; }
    }
}
