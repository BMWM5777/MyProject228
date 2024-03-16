using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    [HttpPost]
    public IActionResult Login([FromBody] LoginModel model)
    {
        // Проверка учетных данных и возврат результата
        if (IsValidCredentials(model.Email, model.Password))
        {
            return Ok(new { message = "Login successful" });
        }
        else
        {
            return BadRequest(new { message = "Invalid email or password" });
        }
    }

    private bool IsValidCredentials(string email, string password)
    {
        // Здесь должна быть ваша логика проверки учетных данных
        // Например, проверка в базе данных или другой системе хранения пользователей
        return (email == "user@example.com" && password == "password");
    }
}

public class LoginModel
{
    public string Email { get; set; }
    public string Password { get; set; }
}
