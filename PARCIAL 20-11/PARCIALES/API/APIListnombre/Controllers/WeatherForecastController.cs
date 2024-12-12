using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class NamesController : ControllerBase
{
    static List<string> names = new List<string>();

    [HttpGet]
    public List<string> Get()
    {
        return names;
    }

    [HttpPost]
    public void Post([FromBody] string name)
    {
        names.Add(name);
    }
}