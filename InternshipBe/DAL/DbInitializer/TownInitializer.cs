﻿using DAL.DataContext;
using DAL.Entities;

namespace DAL.DbInitializer
{
    public class TownInitializer
    {
        private readonly ApplicationDbContext _context;

        public TownInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InitializeTowns()
        {
            AddTown("Минск", 53.9005961, 27.5589895);
            AddTown("Гродно", 53.6688496, 23.8221359);
            AddTown("Ташкент", 41.2994958, 69.2400734);
        }

        public void AddTown(string name, double latitude, double longitude)
        {
            _context.Towns.Add(new Town()
            {
                Name = name,
                Latitude = latitude,
                Longitude = longitude,
            });

            _context.SaveChanges();
        }
    }
}