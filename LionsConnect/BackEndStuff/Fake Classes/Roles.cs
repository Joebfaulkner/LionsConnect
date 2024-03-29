﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LionsConnect.Fake_Classes
{
    internal static class Roles
    {
        public const string Customer = nameof(Customer);


        private static bool HasAnyRole(ClaimsPrincipal user, string target)
        {
            foreach(var role in target.Split(","))
            {
                if (user.IsInRole(role))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
