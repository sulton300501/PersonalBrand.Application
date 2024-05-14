using MediatR;
using Microsoft.AspNetCore.Identity;
using PersonalBrand.Application.UseCases.IdentityCases.Commands;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Application.UseCases.IdentityCases.Handlers.CommandHandlers
{
    public class CreateUserComandHandler : IRequestHandler<CreateUserCommands, ResponseModel>
    {
        private readonly UserManager<UserModel> _manager;

        public CreateUserComandHandler(UserManager<UserModel> userManager)
        {
            _manager = userManager;
        }

        public async Task<ResponseModel> Handle(CreateUserCommands request, CancellationToken cancellationToken)
        {
            var user = new UserModel
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
            };

            await _manager.CreateAsync(user , request.Password);
            return new ResponseModel
            {
                Message = "Yaratildi",
                IsSuccess = true,
                StatusCode = 201
            };

        }
    }
}
