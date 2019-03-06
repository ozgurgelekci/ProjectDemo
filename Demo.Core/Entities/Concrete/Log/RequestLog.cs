using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Log
{
    public class RequestLog : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public short PermissionId { get; set; }
        [StringLength(50)]
        public string BrowserName { get; set; }
        [StringLength(50)]
        public string MobileDeviceModel { get; set; }
        [StringLength(50)]
        public string IpAddress { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
