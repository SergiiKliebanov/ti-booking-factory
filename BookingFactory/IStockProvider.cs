using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingFactory
{
    public interface IStockProvider
    {
        public Task<IEnumerable<PharmacyStock>> GetStock(IEnumerable<int> productIds);
    }

    public struct PharmacyStock
    {
        public int PharmacyId { get; set; }
        public ProductItem[] Stock { get; set; }
    }
}
