using Dapper.Contrib.Extensions;

namespace BaltaDapper.Models
{
    [Table("[Category]")]
    public class Caregory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Posts { get; set; }
    }
}
