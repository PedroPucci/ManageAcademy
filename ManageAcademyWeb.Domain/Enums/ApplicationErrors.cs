using System.ComponentModel;

namespace ManageAcademyWeb.Domain.Enums
{
    public enum ApplicationErrors
    {
        [Description("Ocorreu um erro, por favor, tente novamente.")]
        Application_Error_General,

        [Description("Informações inválidas para cadastro de permissão.")]
        Application_Error_PermissaoInvalid,
    }
}