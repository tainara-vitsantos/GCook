
using System.Runtime.CompilerServices;
using GCook.Data;
using GCook.Helpers;
using GCook.Models;
using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCook.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;
    private SignInManager<Usuario> _singInManager;
    private readonly UserManager<Usuario> _userMaganer;
    private readonly ILogger<UsuarioService> _logger;

    public UsuarioService(
        AppDbContext context,
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        ILogger<UsuarioService> logger

    )
    {
        _context = context;
        _singInManager = signInManager;
        _userMaganer = userManager;
        _logger = logger;
    }
    public async Task<SignInResult> LoginUsuario(LoginVM login)
    {
        string UserName = login.Email;
        if (Helper.IsValidEmail(login.Email))
        {
            var user = await _userMaganer.FindByEmailAsync(login.Email);
            if (user != null)
                UserName = user.UserName;
        }

        var result = await _singInManager.PasswordSignInAsync(
            UserName, login.Senha, login.Lembrar, lockoutOnFailure: true 
        );
    }

    public Task LogoutUsuario()
    {
        throw new NotImplementedException();
    }
}
