using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskSignalR.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public required string Content { get; set; }
        public required string UserName { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }


    }
}
