using BlazorMongoApp.Models;

namespace BlazorMongoApp.Interface
{
    public interface IOrder
    {
        public Task<List<Order>> GetAllOrders();
        public void AddOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(string orderId);
    }
}
