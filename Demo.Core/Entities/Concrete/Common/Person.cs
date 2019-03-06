using System;
using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Common
{
    public class Person : BaseEntity, IEntity
    {
        public int UnitId { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public short GenderTypeId { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal? Phone { get; set; }
        [StringLength(7)]
        public string Color { get; set; }
    }
}
