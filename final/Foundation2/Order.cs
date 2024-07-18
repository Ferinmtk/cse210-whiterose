
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalCost = 0;

            foreach (var product in products)
            {
                totalCost += product.GetTotalCost();
            }

            totalCost += customer.IsInUSA() ? 5 : 35;

            return totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();

            foreach (var product in products)
            {
                packingLabel.AppendLine($"Name: {product.GetName()}, Product ID: {product.GetProductId()}");
            }

            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }
}
