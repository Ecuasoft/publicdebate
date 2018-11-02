using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PublicDebate.Data
{
    public class UserDbEntity : IdentityUser<Guid>
    {
        public virtual List<DebateDbEntity> Debates { get; set; }
    }
}