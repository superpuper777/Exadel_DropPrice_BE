﻿using DAL.DataContext;
using DAL.Entities;

namespace DAL.DbInitializer
{
    public class PointOfSaleInitializer
    {
        private readonly ApplicationDbContext _context;

        public PointOfSaleInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InitializePointOfSales()
        {
            AddPointOfSales("Evos Lavash Center М.Юсуфа", "Мирзо-Улугбекский район ул.МУХАММАДА ЮСУФА, 1А", 41.324068, 69.326089);
            AddPointOfSales("Evos Lavash Center А.Дониша", "Юнусабадский район ул.АХМАДА ДОНИША, кв - л ЮНУСАБАД - 5, 11 / 1", 41.342615, 69.264924);
            AddPointOfSales("Evos Lavash Center Мукими", "Яккасарайский район ул.МУКИМИ", 41.280040, 69.241771);

            AddPointOfSales("Пицца темпо Громова", "ул. Громова 20, Минск", 53.8535645, 27.4444699);
            AddPointOfSales("Пицца темпо Бобруйская", "ул. Бобруйская 6, Минск", 53.8904302, 27.5539899);
            AddPointOfSales("Пицца темпо Мстиславца", "ул. Петра Мстиславца 11, Минск 220020", 53.9336182, 27.6521158);
        }

        public void AddPointOfSales(string name, string address, double latitude, double longitude)
        {
            _context.PointOfSales.Add(new PointOfSale()
            {
                Name = name,
                Address = address,
                Latitude = latitude,
                Longitude = longitude,
            });

            _context.SaveChanges();
        }
    }
}
