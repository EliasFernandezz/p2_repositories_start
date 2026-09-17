//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Repositories;

namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var carsDatabase = new Repository<Car>();
            carsDatabase.Add(new Car("Corolla", "Toyota", 2020));
            Car found = carsDatabase.Find(c => c.Maker == "Toyota");

            var moviesCatalog = new Repository<Movie>();
            moviesCatalog.Add(new Movie("Matrix", 1999));
            Movie foundMovie = moviesCatalog.Find(m => m.Year == 1999);
        }
    }
}