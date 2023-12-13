﻿using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext(DbContextOptions options):base (options) { }

        public DbSet<Employee> Employees { get; set;}
    }
}
