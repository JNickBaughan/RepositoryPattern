using Application.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceiptController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public ReceiptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "Receipts")]
        public IEnumerable<EntryReceipt> Get()
        {
            _unitOfWork.Receipts.AddAsync(new EntryReceipt
            {
                ID = new Guid(),
                TransactionName = "test transaction",
                Vendor = "starbucks"
            });

            return Enumerable.Range(1, 5).Select(index => new EntryReceipt
            {
                ID = new Guid(),
                TransactionName = "test transaction",
                Vendor = "starbucks"
            })
            .ToArray();
        }
    }
}