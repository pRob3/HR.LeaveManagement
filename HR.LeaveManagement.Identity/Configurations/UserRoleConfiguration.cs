using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    // Employee
                    RoleId = "d123696b-66b0-4b9f-b7ca-6a920e89938e",
                    UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
                },
                new IdentityUserRole<string>
                {
                    // Admin
                    RoleId = "ba4be6ef-e654-41c6-8f90-1fa79b58c98b",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );
        }
    }
}
