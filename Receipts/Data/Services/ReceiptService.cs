using System.Threading.Tasks;
using Models;
using Receipts.Data.DataBase;
using System.Linq;
using System.Collections.Generic;
using Receipts.Data.Repositories.Interface;

namespace Receipts.Data.Services
{
    public class ReceiptService
    {
        private readonly DataContext _dataContext;
        private readonly IAsyncRepository<Receipt> _receiptRepository;

        public ReceiptService(DataContext dataContext, IAsyncRepository<Receipt> receiptRepository)
        {
            _dataContext = dataContext;
            _receiptRepository = receiptRepository;
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
        public async Task<List<Receipt>> ListAll()
        {
            var receipts = await _receiptRepository.GetAll();
            return receipts.ToList();
        }
    }
}