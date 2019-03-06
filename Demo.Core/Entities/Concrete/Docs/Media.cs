using System;
using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Docs
{
    public class Media : BaseEntity, IEntity
    {
        public short MediaTypeId { get; set; }
        public byte[] BinaryData { get; set; }
        [StringLength(250)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        [StringLength(50)]
        public string LenghtShortName { get; set; }
        public bool IsPublic { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
