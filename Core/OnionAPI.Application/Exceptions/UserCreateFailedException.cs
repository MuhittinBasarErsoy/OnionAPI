﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Exceptions
{
    public class UserCreateFailedException :Exception
    {
        public UserCreateFailedException():base("Kullanıcı oluşturulurken beklenmedik bir hata alındı")
        {
            
        }

        public UserCreateFailedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserCreateFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
