using Demo.Core.Entities.Abstract;

namespace Demo.Core.Entities.Concrete.Access
{
    public class RolePermission : BaseEntity, IEntity
    {

        public byte RoleId { get; set; }
        public short PermissionId { get; set; }
    }
}
