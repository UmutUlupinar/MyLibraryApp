﻿using Book.Data.Entities;
using Book.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Access.Seed;

public class UserSeed :IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(new User
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                UserType = UserType.Admin,
                CreatedDate = DateTime.Now,
                SignUpDate = DateTime.Now
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "umutulupinar",
                UserType = UserType.User,
                CreatedDate = DateTime.Now,
                SignUpDate = DateTime.Now
            }
        );
    }
}