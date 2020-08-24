﻿using System;
using Microsoft.AspNetCore.Identity;

namespace ExMessengerApi.Data.Models.Models
{
    public class ApplicationUser: IdentityUser, IEntity
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}