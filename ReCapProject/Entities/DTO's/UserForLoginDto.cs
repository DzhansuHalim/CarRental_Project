﻿using Core.Entities.Abstract;

namespace Entities.DTO_s
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }


}
