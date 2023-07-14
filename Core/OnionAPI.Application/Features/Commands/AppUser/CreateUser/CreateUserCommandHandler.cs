using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using OnionAPI.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IMapper _mapper;
        readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;

        public CreateUserCommandHandler(IMapper mapper, UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.Entities.Identity.AppUser>(request);
            user.Id = Guid.NewGuid().ToString();
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, request.PasswordHash);
            IdentityResult result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                return new()
                {
                    Succeeded = true,
                    Message = "Kullanıcı başarıyla oluturulmuştur"
                };
            }
            else
            {
                throw new UserCreateFailedException();
            }
        }
    }
}
