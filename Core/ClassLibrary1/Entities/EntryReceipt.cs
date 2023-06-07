using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class EntryReceipt
    {
        public Guid ID {  get; set; }

        public string TransactionName { get; set; }

        public string Vendor { get; set; }
    }
}
