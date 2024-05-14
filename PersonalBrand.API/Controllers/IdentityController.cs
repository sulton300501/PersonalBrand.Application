﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBrand.Application.UseCases.IdentityCases.Commands;

namespace PersonalBrand.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IdentityController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
     public async Task<IActionResult> Register(CreateUserCommands createUserCommands)
        {
            var result = await _mediator.Send(createUserCommands);
            return Ok(result);
        }







    }
}
