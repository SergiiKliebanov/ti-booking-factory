using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingFactory
{
    public interface IBenefitCalculator
    {
        Task<decimal> CaluclateBenefit(int pharmacyId, decimal productPrice);
    }

    public class TestBenefitCalculator : IBenefitCalculator
    {
        Dictionary<int, decimal> pharmacyCommissions;

        public TestBenefitCalculator(Dictionary<int, decimal> pharmacyCommissions) => this.pharmacyCommissions = pharmacyCommissions;

        public Task<decimal> CaluclateBenefit(int pharmacyId, decimal productPrice) => Task.FromResult(CalculateBeneift(pharmacyId, productPrice));

        decimal CalculateBeneift(int pharmacyId, decimal productPrice)
            => pharmacyCommissions.TryGetValue(pharmacyId, out var commission)
            ? productPrice * commission
            : 0;
    }
}
