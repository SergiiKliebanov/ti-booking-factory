using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingFactory
{
    public class BookingFactory
    {
        IStockProvider stockProvider;

        public BookingFactory(IStockProvider stockProvider) => this.stockProvider = stockProvider;

        public Task<IEnumerable<Booking>> Book(IEnumerable<ProductItem> demand)
        {
            throw new NotImplementedException();
        }
    }

    public struct Booking
    {
        public int PharmacyId { get; set; }
        public ProductItem[] Items { get; set; }
    }
}
