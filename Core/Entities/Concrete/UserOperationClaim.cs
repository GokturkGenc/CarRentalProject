namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IDto
    {
        public int UserOperationClaimId { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }

}
