using ManageAcademyWeb.Domain.Dto;
using ManageAcademyWeb.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ManageAcademyWeb.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    public class PermissionController : Controller
    {
        private readonly IUnitOfWorkService _serviceUoW;

        public PermissionController(IUnitOfWorkService serviceUoW)
        {
            _serviceUoW = serviceUoW;
        }

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AddPermissionEntity([FromBody] PermissionDto permissionDto)
        {
            var result = await _serviceUoW.PermissionService.AddPermission(permissionDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}