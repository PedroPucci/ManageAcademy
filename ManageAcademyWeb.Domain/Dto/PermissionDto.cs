using ManageAcademyWeb.Domain.Enums;

namespace ManageAcademyWeb.Domain.Dto
{
    public class PermissionDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public PermissionStatus Type { get; set; } = 0;
        public bool Status { get; set; } = false;
    }
}