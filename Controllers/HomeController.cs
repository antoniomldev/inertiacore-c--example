using InertiaCore;
using Microsoft.AspNetCore.Mvc;

namespace SystemLMS.Controllers;

[Route("/")]
public class HomeController : Controller
{

    [HttpGet]
    public Task<Response> Index()
    {

        return Task.FromResult(Inertia.Render("Index"));
    }

}