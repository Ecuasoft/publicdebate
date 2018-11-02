using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PublicDebate.Data
{
    public class RoleDbEntity : IdentityRole<Guid>
    {
    }
}