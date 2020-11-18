using BookingFactory;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        var stock = new PharmacyStock[]
        {
            new PharmacyStock
            {
                PharmacyId = 1,
                Stock = new []
                {
                    new ProductItem { ProductId = 1000, Quantity = 20, Price = 100 },
                    new ProductItem { ProductId = 2000, Quantity = 120, Price = 2 },
                    new ProductItem { ProductId = 3000, Quantity = 2, Price = 2500 },
                }
            },
            new PharmacyStock
            {
                PharmacyId = 2,
                Stock = new []
                {
                    new ProductItem { ProductId = 1000, Quantity = 3, Price = 80 },
                    new ProductItem { ProductId = 2000, Quantity = 12, Price = 1.7m }
                }
            },
            new PharmacyStock
            {
                PharmacyId = 3,
                Stock = new []
                {
                    new ProductItem { ProductId = 1000, Quantity = 20, Price = 120 },
                    new ProductItem { ProductId = 2000, Quantity = 120, Price = 5 },
                    new ProductItem { ProductId = 3000, Quantity = 5, Price = 2800 }
                }
            }
        };

        var booker = new BookingFactory.BookingFactory(new TestStockProvider(stock));


        var proposedBookings = await booker.Book(new[] { new ProductItem { ProductId = 1000, Quantity = 1, Price = 100 } });
    }
}
