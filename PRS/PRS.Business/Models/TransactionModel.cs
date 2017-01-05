using PRS.Business.Managers.Interfaces;

namespace PRS.Business.Models
{
    public class TransactionModel : IModel
    {
        public int Id { get; set; }
        public UserModel User { get; set; }
        public ReservationModel Reservation { get; set; }
        public decimal Payment { get; set; }
    }
}
