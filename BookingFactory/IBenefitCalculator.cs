using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingFactory
{
    public interface IBenefitCalculator
    {
        Task<decimal> CaluclateBenefit(IEnumerable<Booking> bookings);
    }

    public class TestBenefitCalculator : IBenefitCalculator
    {
        Dictionary<int, decimal> pharmacyCommissions;

        public TestBenefitCalculator(Dictionary<int, decimal> pharmacyCommissions) => this.pharmacyCommissions = pharmacyCommissions;

        public Task<decimal> CaluclateBenefit(IEnumerable<Booking> bookings) => Task.FromResult(bookings.Sum(CalculateBeneift));

        decimal CalculateBeneift(Booking booking)
            => pharmacyCommissions.TryGetValue(booking.PharmacyId, out var commission)
            ? booking.Items.Sum(i => i.Price * i.Quantity * commission)
            : 0;
    }
}
