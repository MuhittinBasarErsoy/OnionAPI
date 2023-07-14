using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Abstraction.Token
{
    public interface ITokenHandler
    {
        DTOs.Tokens.Token CreateAccessToken(int minute=5);
    }
}
