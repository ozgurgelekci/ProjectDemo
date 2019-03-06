using System;
using System.ComponentModel.DataAnnotations;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Log
{
    public class ExceptionLog : BaseEntity, IEntity
    {
        [Key]
        public Guid RequestId { get; set; }
        public int HResult { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
