using Microsoft.AspNetCore.Mvc;

namespace TWTodolist.Controllers;

public class TestController : Controller{
    public IActionResult Index(){
        return View();
    }
}