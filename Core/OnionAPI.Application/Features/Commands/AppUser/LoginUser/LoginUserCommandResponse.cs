﻿using OnionAPI.Application.DTOs.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandResponse
    {
        
    }

    public class LoginUserSuccessResponse: LoginUserCommandResponse
    {
        public Token Token { get; set; }

    }
    public class LoginUserErrorResponse: LoginUserCommandResponse
    {
        public string Message { get; set; }
    }
}
