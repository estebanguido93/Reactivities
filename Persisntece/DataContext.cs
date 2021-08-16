﻿using System;
using System.Diagnostics.CodeAnalysis;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persisntece
{
    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
