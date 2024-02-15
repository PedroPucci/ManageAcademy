using ManageAcademyWeb.Domain.Enum;

namespace ManageAcademyWeb.Domain.Entity
{
    public class PermissionEntity : BaseEntity
    {
        public PermissionEntity(int id) : base(id)
        {
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public PermissionStatus Type { get; set; }
        public bool Status { get; set; }        
    }
}