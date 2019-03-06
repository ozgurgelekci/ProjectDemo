using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Log
{
    public class RequestDetailLog : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public short? MessageTypeId { get; set; }
        public short? MessageContentTypeId { get; set; }
        [StringLength(150)]
        public string MessageParameters { get; set; }
        [StringLength(1000)]
        public string ActionParameters { get; set; }
    }
}
