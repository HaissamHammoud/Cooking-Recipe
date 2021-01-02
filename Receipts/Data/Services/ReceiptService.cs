using System.Threading.Tasks;
using Models;
using Receipts.Data.DataBase;
using System.Linq;

namespace Receipts.Data.Services
{
    public class ReceiptService
    {
        private readonly DataContext _dataContext;
        public ReceiptService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Create(string name, string steps, string ingredients )
        {
            var receipt = new Receipt()
            {
                Name = name,
                Ingredients = ingredients,
                Steps = steps
            };
            await _dataContext.Receipts.AddAsync(receipt);
            await _dataContext.SaveChangesAsync();
        }

        //TODO: Move this to when repository is done
        // public async Receipt GetReceiptAsync()
        // {
        //     await _dataContext.
        // }
    }
}