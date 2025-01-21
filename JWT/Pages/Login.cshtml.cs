using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public IActionResult OnPost()
    {
        // Validate user credentials (for demo purposes, use hardcoded values)
        if (Username == "test" && Password == "password")
        {
            var token = JwtHelper.GenerateToken(Username);
            return new JsonResult(new { Token = token });
        }

        return Unauthorized();
    }
}
