using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace TaskSignalR.Models
{
    public class ProductHub : Hub
    {
        public readonly Context _context;
        public ProductHub(Context context)
        {
            _context = context;
        }


        public void Buy(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            if (product != null && product.Quantity > 0)
            {
                product.Quantity--;
                _context.SaveChanges();
                Clients.All.SendAsync("ItemSold", product.Quantity, ProductId);
            }
        }
        public void MakeComment(int ProductId, string content, string user)
        {
            Comment comment = new Comment()
            {
                Content = content,
                UserName = user,
                ProductId = ProductId
            };
            var product = _context.Products.Find(ProductId);
            if (product != null && product.Quantity > 0)
            {
                _context.Add(comment);
                _context.SaveChanges();
                Clients.All.SendAsync("CommentAdded", ProductId, content, user);
            }

        }
    }
}
