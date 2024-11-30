using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReturnContant_MVC.Models;

namespace ReturnContant_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetContent()
    {

        // content bir view değildir!!

        // bu action'a gelindiğinde, ekranda sadece düz bir metin görünecektir!!

        // butona tıklanıldığında, view yerine bir yazı çıksın isterseniz returnContent'ı kullanabilirsiniz!!
        //return Content("http://www.google.com");

        //return Content("<h1>Ben 1'im </h1>");

        // return content geriye json veride dönebilir!!

        // Json veriye ne ihtiyacımız var, eğer mvcdeki bir action'u, javascript fetch metodu ile kullanacaksak,
        // fetch metodu json veriye göre cevap vermek için, return content içerisinde json veri verilebilir!!
        //return Content("{\"message\":\"ben bir jsonum\"}");



        return Json(new IndexViewModel()
        {
            Description = "Bu ürün piyasının en iyisi",
            Name = "Vestel Klima",
            Id = 5

        });

        //return Json();


    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
