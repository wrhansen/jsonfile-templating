using DotLiquid;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace JsonTemplating.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var jsonString1 = System.IO.File.ReadAllText("Schemas/schema1.json");
        ViewData["jsonString1"] = jsonString1;

        var jsonString2 = System.IO.File.ReadAllText("Schemas/schema2.json");
        Template template = Template.Parse(jsonString2);
        ViewData["jsonString2"] = CleanUpJsonString(template.Render());

        var jsonString3 = System.IO.File.ReadAllText("Schemas/schema3.json");
        Template template2 = Template.Parse(jsonString3);
        ViewData["jsonString3"] = CleanUpJsonString(template2.Render());

        var jsonString4 = System.IO.File.ReadAllText("Schemas/schema4.json");
        Template template3 = Template.Parse(jsonString4);
        ViewData["jsonString4"] = CleanUpJsonString(template3.Render());

        return View("site/index.cshtml");
    }

    private string CleanUpJsonString(string jsonString)
    {
        return JsonSerializer.Serialize(
            JsonSerializer.Deserialize<dynamic>(jsonString),
            new JsonSerializerOptions() { WriteIndented = true }
        );
    }
}
