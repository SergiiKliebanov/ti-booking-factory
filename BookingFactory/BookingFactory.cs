using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingFactory
{
    public class BookingFactory : IDisposable
    {
        IStockProvider stockProvider;

        public BookingFactory(IStockProvider stockProvider) => this.stockProvider = stockProvider;

        public Task<IEnumerable<Booking>> Book(IEnumerable<ProductItem> demand)
        {
            //TODO: should return prosed bookings for incoming demand, resulting bookings should cover as much as possible of the demand and be as cheap as possible
            throw new NotImplementedException();
        }

        public void Dispose() => stockProvider.Dispose();
    }

    public struct Booking
    {
        public int PharmacyId { get; set; }
        public ProductItem[] Items { get; set; }
    }
}
