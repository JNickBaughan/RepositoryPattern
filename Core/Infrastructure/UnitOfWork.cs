using Application.Interfaces;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IEntryReceiptRepository EntryReceiptRepository)
        {
            Receipts = EntryReceiptRepository;
        }

        public IEntryReceiptRepository Receipts { get; set; }

    }
}
