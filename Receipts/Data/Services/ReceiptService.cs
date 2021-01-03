using System.Threading.Tasks;
using Models;
using Receipts.Data.DataBase;
using System.Linq;
using System.Collections.Generic;
using Receipts.Data.Repositories.Interface;
using System;

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

        public async Task Create(string name,
        string description,
        List<StepRecipe> steps,
        List<IngredientRecipe> ingredients,
        string imageUrl = "" )
        {
            var receipt = new Receipt(ingredients, steps, name, description, imageUrl);
            
            await _dataContext.Receipts.AddAsync(receipt);
            await _dataContext.SaveChangesAsync();
        }

        //TODO: Move this to when repository is done
        public async Task<List<Receipt>> ListAll()
        {
            var receipts = await _receiptRepository.GetAll();
            var a = receipts.ToList();
            var ab = a.Where(x =>x.Steps.Count() != 0);
            return a;
        }

        public async Task DeleteReceipt(Guid receiptId)
        {
            var recipe = await _receiptRepository.FirstOrDefault(x => x.Id == receiptId);
            await _receiptRepository.Remove(recipe);
        }
    }
}