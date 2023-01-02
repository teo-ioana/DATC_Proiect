using Microsoft.AspNetCore.Mvc;

namespace DATC_lab_1.Controllers;

[ApiController]
[Route("AmbrosiaAlert")]
public class PlantaController : ControllerBase
{
    PlantaRepo DataBase = new PlantaRepo(
        "ambrosiaalerttim",
        "B0Hm2+NZQwNwaAG3MwhzM/04cHeY4YhFW5wXKmvgG6g7ooUuemYQAoHP7i/5nCSszpfVw5RxfHe9+AStGh5edg==",
        "AmbrosiaAlertTim"
    );

    [HttpGet()]
    public IActionResult Get()
    {
        List<Planta> plantaList = new List<Planta>();
        Task.Run(async() => {plantaList = await DataBase.GetAllPlante();}).GetAwaiter().GetResult();
        return Ok(plantaList);
    }

    [HttpGet("{tipplantaalergena}")]
    public IActionResult Get(string tipplantaalergena)
    {
        List<Planta> plantaList = new List<Planta>();
        Task.Run(async() => {plantaList = await DataBase.GetAllPlante();}).GetAwaiter().GetResult();
        List<Planta> foundList = new List<Planta>();
        foreach (Planta x in plantaList)
        {
            if (x.TipPlantaAlergena == tipplantaalergena)
            {
                foundList.Add(x);
            }
        }

        if(foundList.Count==0)
              return Ok("This plant doesn't exist");

        return Ok(foundList);
    }

    [HttpPost("PostPlanta")]
    public async Task<string> Post(Planta planta)
    {
        await DataBase.InsertPlanta(planta);
        return "Post Succesful";
    }
}
