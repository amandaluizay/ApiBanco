using Banco.ApiCore.Extensions;
using Banco.ApiCore.ViewModel;
using Business.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Banco.ApiCore.Controllers
{
    [Route("v1/contaFisica/api")]
    public class AuthenticationController : HomeController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppSettings _appSettings;

        public AuthenticationController(INotificador notificador,
                                        SignInManager<IdentityUser> signInManager,
                                        UserManager<IdentityUser> userManager,
                                        IOptions<AppSettings> appSettings) : base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }

        [HttpPost("entrar")]
        public async Task<ActionResult> Login(ContaBancariaViewModel loginUser)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var result = await _signInManager.PasswordSignInAsync(loginUser.CPF, loginUser.CPF, false, true);

            if (result.Succeeded)
            {
                return CustomResponse(loginUser);
            }
            if (result.IsLockedOut)
            {
                NotificarErro("Usuário temporariamente bloqueado por tentativas inválidas");
                return CustomResponse(loginUser);
            }

            NotificarErro("Usuário ou Senha incorretos");
            return CustomResponse(loginUser);
        }
    }
}
