﻿using Microsoft.AspNetCore.Identity;

namespace ProductsApi.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string FullName { get; set; } = null!;
        public DateTime DateAdd { get; set; }
    }
}
