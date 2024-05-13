using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancingManager.Entities
{
    public class CostEntity
    {
        [Key]
        public int Id { get; set; }
        public double Cost { get; set; }

        public required string Name { get; set; }

        public required string Currency { get; set; }

        public required string CostType { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
