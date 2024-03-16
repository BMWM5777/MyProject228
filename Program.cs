using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
var localOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(localOptions.Value);

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

public class btnLogin_Click
{
    // Код обработчика кнопки Login
    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        // Здесь может быть код для проверки логина и пароля

        // Перенаправляем пользователя на другую страницу или выполняем другие действия
    }

}

public class AccountController : Controller
{
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // Здесь вы можете добавить логику для аутентификации пользователя
        // Например, проверить логин и пароль в базе данных или в другом месте

        if (username == "admin" && password == "password")
        {
            // Если пользователь успешно аутентифицирован, выполните необходимые действия
            // Например, перенаправьте его на другую страницу или верните JSON-ответ

            return Ok(new { message = "Login successful" });
        }
        else
        {
            // Если аутентификация не удалась, верните соответствующий статус или сообщение об ошибке

            return Unauthorized(new { message = "Invalid username or password" });
        }
    }
}
