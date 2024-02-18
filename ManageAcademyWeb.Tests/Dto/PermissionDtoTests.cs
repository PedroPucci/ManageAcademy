using ManageAcademyWeb.Domain.Dto;
using ManageAcademyWeb.Domain.Enums;

namespace ManageAcademyWeb.Tests.Dto
{
    public class PermissionDtoTests
    {
        [Fact(DisplayName = "Create PermissionDto with valid values")]
        public void CreatePermissionDto_WithValidValues()
        {
            // Arrange
            var name = "permissao 1";
            var description = "descrição 1";
            var status = true;
            var type = PermissionStatus.Active;

            // Act
            var permissionDto = new PermissionDto
            {
                Name = name,
                Description = description,
                Status = status,
                Type = type
            };

            // Assert
            Assert.NotNull(permissionDto);
            Assert.Equal(name, permissionDto.Name);
            Assert.Equal(description, permissionDto.Description);
            Assert.Equal(status, permissionDto.Status);
            Assert.Equal(type, permissionDto.Type);
        }
    }
}