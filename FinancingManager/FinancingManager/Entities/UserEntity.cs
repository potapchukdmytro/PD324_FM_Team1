using System.ComponentModel.DataAnnotations;

namespace FinancingManager.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string LastName { get; set; }

        public required string UserName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }
        public virtual List<CostEntity> Costs { get; set; } = new();
    }
}
