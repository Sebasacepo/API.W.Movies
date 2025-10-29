﻿using API.W.Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.W.Movies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        //Seccion para crear el dbset de las entidades o models
        public DbSet<Category> Categories { get; set; }

    }
}
