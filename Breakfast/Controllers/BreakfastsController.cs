using Microsoft.AspNetCore.Mvc;
namespace Breakfast.Controller;
using Breakfast.Models;
using  Breakfast.Contract.BreakfastRequest;
using  Breakfast.Contract.BreakfastResponse;


[ApiController]
[Route("[controller]")]
public class BreakfastsController : ControllerBase {
[HttpPost()]
public IActionResult CreateBreakfast(CreateBreakfastRequest request){ 
    var breakfast= new Breakfast(Guid.NewGuid(),
    request.Name,
    request.Description,
    request.StartDateTime,
    request.EndDateTime,
    DateTime.UtcNow,
    request.Savory,
    request.Sweet
    );

    var response= new CreateBreakfastResponse(
    breakfast.Id,
    breakfast.Name,
    breakfast.Description,
    breakfast.StartDateTime,
    breakfast.EndDateTime,
    DateTime.UtcNow,
    breakfast.Savory,
    breakfast.Sweet
    );
    return Ok(request);
}
[HttpGet("{id:guid}")]
public IActionResult GetBreakfast(Guid id){ 
    return Ok(id);
}
[HttpPut("{id:guid}")]
public IActionResult UpsertBreakfast(Guid id, CreateBreakfastRequest request){ 
    return Ok(request);
}
[HttpDelete("{id:guid}")]
public IActionResult RemoveBreakfast(Guid id){ 
    return Ok(id);
}
}

