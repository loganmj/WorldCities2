﻿using Microsoft.EntityFrameworkCore;
using WorldCities2.Server.Data.Models;

namespace WorldCities.Server.Data;

/// <summary>
/// Database context
/// </summary>
public class ApplicationDbContext : DbContext
{
    #region Constructors

    /// <summary>
    /// Parameterless constructor.
    /// </summary>
    public ApplicationDbContext() : base() { }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    /// <param name="options"></param>
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    #endregion

    #region Public Methods

    /// <summary>
    /// Accessor for a City object.
    /// </summary>
    public DbSet<City> Cities => Set<City>();

    /// <summary>
    /// Accessor for a Country object.
    /// </summary>
    public DbSet<Country> Countries => Set<Country>();

    #endregion
}