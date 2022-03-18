using JobForStudents;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    private ILoginService _loginService;

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate(LoginDTO model)
    {
        var response = _loginService.Authenticate(model);
        if (response == null)
            return BadRequest(new { message = "Kullanıcı Adı Yada Parola Hatalı Girildi" });
        return  Ok(response);
    }

    [Authorize]
    [HttpGet]
    public IActionResult GetAll()
    {
        return  Ok("Hoş Geldiniz");
    }
}
