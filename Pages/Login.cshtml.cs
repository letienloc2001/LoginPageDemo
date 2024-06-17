using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace LoginPageDemo.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> _logger;

    // [BindProperty]
    // public Credential Credential { get; set; }

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

// public class Credential
// {
//     [Required]
//     public string UserName { get; set; }

//     [Required]
//     [DataType(DataType.Password)]
//     public string Password { get; set; }
// }
