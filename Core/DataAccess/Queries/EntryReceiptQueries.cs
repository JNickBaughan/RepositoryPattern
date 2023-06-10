using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Queries
{
    public static class EntryReceiptQueries
    {
        public static string AddEntryReceipt =>
        @"INSERT INTO [EntryReceipt] ([TransactionName], [Vendor]) 
            VALUES (@TransactionName, @Vendor)";
    }
}
