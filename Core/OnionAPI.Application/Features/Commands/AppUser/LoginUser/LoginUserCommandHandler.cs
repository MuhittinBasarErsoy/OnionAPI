﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using OnionAPI.Application.Abstraction.Token;
using OnionAPI.Application.DTOs.Tokens;
using OnionAPI.Application.Exceptions;
using OnionAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
        readonly SignInManager<Domain.Entities.Identity.AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;

        public LoginUserCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userManager, SignInManager<Domain.Entities.Identity.AppUser> signInManager, ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
        }
        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.AppUser appUser = await _userManager.FindByNameAsync(request.UsernameOrPassword);
            if (appUser == null)
            {
                appUser = await _userManager.FindByEmailAsync(request.UsernameOrPassword);
            }
            if (appUser == null)
            {
                throw new NotFoundUserException();
            }

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, request.Password, false);
            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken();
                return new LoginUserSuccessResponse()
                {
                    Token = token
                };
            }
            //return new LoginUserErrorResponse()
            //{
            //    Message = "Kullanici veya sifre htalaı"
            //};
            throw new AuthenticationErrorException();
        }
    }
}
