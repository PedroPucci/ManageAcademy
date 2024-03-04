using System.ComponentModel;

namespace ManageAcademyWeb.Domain.Enums
{
    public enum ApplicationErrors
    {
        [Description("Ocorreu um erro, por favor, tente novamente.")]
        Application_Error_General,

        [Description("Informações inválidas para cadastro de permissão.")]
        Application_Error_PermissionInvalid,

        [Description("Permissão não foi encontrada.")]
        Application_Error_PermissionNotFound,

        [Description("O nome da permissão não pode ser nulo ou vazio.")]
        Application_Error_IsNullOrWhiteSpace,
    }
}