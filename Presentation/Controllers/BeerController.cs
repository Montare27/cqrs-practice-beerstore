using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

using Application.Beer.Commands.CreateBeer;
using Application.Beer.Commands.DeleteBeer;
using Application.Beer.Commands.UpdateBeet;
using Application.Beer.Queries.GetBeerDetails;
using Application.Beer.Queries.GetBeerList;
using MediatR;

[ApiController]
[Route("[controller]")]
public class BeerController : ControllerBase
{
    private readonly IMediator _mediator;

    public BeerController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("GetAll")]
    public async Task<ActionResult<List<GetBeerDto>>> GetAll()
    {
        var vm = await _mediator.Send(new GetBeerQuery());
        return Ok(vm);
    }

    [HttpGet("GetDetails/{id:Guid}")]
    public async Task<ActionResult<BeerDetailsDto>> GetDetails(Guid id)
    {
        var vm = await _mediator.Send(new GetBeerDetailsQuery{Id = id});
        return Ok(vm);
    }

    [HttpPost("CreateBeer")]
    public async Task<ActionResult<Guid>> CreateBeer([FromBody] CreateBeerCommand createBeerCommand)
    {
        var id = await _mediator.Send(createBeerCommand);
        return Ok(id);
    }

    [HttpPut("UpdateBeer/{id:Guid}")]
    public async Task<ActionResult> UpdateBeer([FromBody] UpdateBeerCommand updateBeerCommand)
    {
        await _mediator.Send(updateBeerCommand);
        return Ok();
    }

    [HttpDelete("DeleteBeer/{id:Guid}")]
    public async Task<ActionResult> DeleteBeer(Guid id)
    {
        await _mediator.Send(new DeleteBeerCommand{Id = id});
        return Ok();
    }

}
