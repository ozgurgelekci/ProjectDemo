using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Access
{
    public class UserRole : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public byte RoleId { get; set; }
    }
}
