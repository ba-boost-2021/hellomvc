using BilgeAdam.MVCStyla.Models;

namespace BilgeAdam.MVCStyla.Helpers
{
    public class ReceiptBuilder
    {
        private ReceiptViewModel model;
        public ReceiptBuilder CreateReceipt(string title, int id)
        {
            model = new ReceiptViewModel
            {
                Id = id,
                Title = title,
                Ingredients = new List<string>()
            };
            return this;
        }

        public ReceiptBuilder WithTariff(string tariff)
        {
            model.Tariff = tariff;
            return this;
        }

        public ReceiptBuilder WithImageCode(int code)
        {
            model.ImageCode = code;
            return this;
        }

        public ReceiptBuilder AddItem(string item)
        {
            model.Ingredients.Add(item);
            return this;
        }

        public ReceiptViewModel Build()
        {
            return model;
        }
    }
}
