using ManageAcademyWeb.Domain.Entity;
using ManageAcademyWeb.Domain.Enums;

namespace ManageAcademyWeb.Tests.Entity
{
    public class PermissionEntityTests
    {
        [Fact(DisplayName = "Create PermissionEntity with custom values")]
        public void CreatePermissionEntity_WithCustomValues()
        {
            // Arrange
            var name = "permissao 1";
            var description = "descrição 1";
            var status = true;
            var type = PermissionStatus.Active;

            // Act
            var permissionEntity = new PermissionEntity()
            {
                Name = name,
                Description = description,
                Status = status,
                Type = type
            };

            // Assert
            Assert.NotNull(permissionEntity);
            Assert.Equal(name, permissionEntity.Name);
            Assert.Equal(description, permissionEntity.Description);
            Assert.Equal(status, permissionEntity.Status);
            Assert.Equal(type, permissionEntity.Type);
        }
    }
}