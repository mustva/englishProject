﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace englishProject.Infrastructure.Users
{
    public class UserApp : IdentityUser
    {
        public string PicturePath { get; set; }
    }
}